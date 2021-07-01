using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using ValheimCharacterEditor.Valheim;

namespace ValheimCharacterEditor.Utilities
{
    public class CharacterParser
    {
        public CharacterEntity Character { get; private set; }
        
        private readonly string _characterFile;

        public CharacterParser(string characterFile)
        {
            if (string.IsNullOrEmpty(characterFile)) throw new ArgumentNullException(nameof(characterFile));
            _characterFile = characterFile;
        }

        private BinaryStream LoadBinaryFile(string path)
        {
            using FileStream fileStream = File.OpenRead(path);

            BinaryReader reader = new BinaryReader(fileStream);

            int dataLength = reader.ReadInt32();
            byte[] data = reader.ReadBytes(dataLength);

            return new BinaryStream(data);
        }

        public Character ReadCharacterData()
        {
            Character character = new Character();

            Character = new CharacterEntity()
            {
                Data = character,
                File = _characterFile
            };

            using BinaryStream binaryStream = LoadBinaryFile(_characterFile);

            if (binaryStream.Length == 0)
            {
                MessageBox.Show($"Could not read file:\n\n{_characterFile}", "File read error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return null;
            }

            character.CharacterVersion = binaryStream.ReadInt32();
            character.Kills = binaryStream.ReadInt32();
            character.Deaths = binaryStream.ReadInt32();
            character.Crafts = binaryStream.ReadInt32();
            character.Builds = binaryStream.ReadInt32();

            int numberOfWorlds = binaryStream.ReadInt32();

            for (int i = 0; i < numberOfWorlds; i++)
            {
                long worldId = binaryStream.ReadInt64();

                World world = new World
                {
                    HasCustomSpawnPoint = binaryStream.ReadBoolean(),
                    SpawnPoint = binaryStream.ReadVector3(),
                    HasLogoutPoint = binaryStream.ReadBoolean(),
                    LogoutPoint = binaryStream.ReadVector3(),
                    HasDeathPoint = binaryStream.ReadBoolean(),
                    DeathPoint = binaryStream.ReadVector3(),
                    HomePoint = binaryStream.ReadVector3(),
                };

                if (binaryStream.ReadBoolean())
                    world.MapData = binaryStream.ReadBytes();

                character.WorldsData.Add(worldId, world);
            }

            character.Name = binaryStream.ReadString();
            character.Id = binaryStream.ReadInt64();
            character.StartSeed = binaryStream.ReadString();

            if (!binaryStream.ReadBoolean()) return character;

            int dataLength = binaryStream.ReadInt32();
            character.DataVersion = binaryStream.ReadInt32();

            character.MaxHp = binaryStream.ReadSingle();
            character.Hp = binaryStream.ReadSingle();
            character.Stamina = binaryStream.ReadSingle();
            character.IsFirstSpawn = binaryStream.ReadBoolean();
            character.TimeSinceDeath = binaryStream.ReadSingle();
            character.GuardianPower = binaryStream.ReadString();
            character.GuardianPowerCooldown = binaryStream.ReadSingle();
            character.Inventory = new List<Item>();
            character.InventoryVersion = binaryStream.ReadInt32();

            int numberOfItems = binaryStream.ReadInt32();

            for (int i = 0; i < numberOfItems; i++)
            {
                Item item = new Item
                {
                    Name = binaryStream.ReadString(),
                    Stack = binaryStream.ReadInt32(),
                    Durability = binaryStream.ReadSingle(),
                    Position = new Tuple<int, int>(binaryStream.ReadInt32(), binaryStream.ReadInt32()),
                    Equipped = binaryStream.ReadBoolean(),
                    Quality = binaryStream.ReadInt32(),
                    Variant = binaryStream.ReadInt32(),
                    CrafterId = binaryStream.ReadInt64(),
                    CrafterName = binaryStream.ReadString()
                };

                if (item.Name != "")
                    character.Inventory.Add(item);
            }

            character.Recipes = new HashSet<string>();
            character.KnownMaterials = new HashSet<string>();
            character.ShownTutorials = new HashSet<string>();
            character.Uniques = new HashSet<string>();
            character.Trophies = new HashSet<string>();
            character.Biomes = new HashSet<Biomes>();

            int numberOfRecipes = binaryStream.ReadInt32();

            for (int i = 0; i < numberOfRecipes; i++)
                character.Recipes.Add(binaryStream.ReadString());

            int numberOfStations = binaryStream.ReadInt32();

            for (int i = 0; i < numberOfStations; i++)
                character.Stations.Add(binaryStream.ReadString(), binaryStream.ReadInt32());

            int numberOfKnownMaterials = binaryStream.ReadInt32();

            for (int i = 0; i < numberOfKnownMaterials; i++)
                character.KnownMaterials.Add(binaryStream.ReadString());

            int numberOfShownTutorials = binaryStream.ReadInt32();

            for (int i = 0; i < numberOfShownTutorials; i++)
                character.ShownTutorials.Add(binaryStream.ReadString());

            int numberOfUniques = binaryStream.ReadInt32();

            for (int i = 0; i < numberOfUniques; i++)
                character.Uniques.Add(binaryStream.ReadString());

            int numberOfTrophies = binaryStream.ReadInt32();

            for (int i = 0; i < numberOfTrophies; i++)
                character.Trophies.Add(binaryStream.ReadString());

            int numberOfBiomes = binaryStream.ReadInt32();

            for (int i = 0; i < numberOfBiomes; i++)
                character.Biomes.Add((Biomes) binaryStream.ReadInt32());

            int numberOfTexts = binaryStream.ReadInt32();

            for (int i = 0; i < numberOfTexts; i++)
                character.Texts.Add(binaryStream.ReadString(), binaryStream.ReadString());

            character.Beard = binaryStream.ReadString();
            character.Hair = binaryStream.ReadString();
            character.SkinColor = binaryStream.ReadVector3();
            character.HairColor = binaryStream.ReadVector3();
            character.Gender = binaryStream.ReadInt32();

            int numberOfConsumedFood = binaryStream.ReadInt32();
            character.Foods = new List<Food>();

            for (int i = 0; i < numberOfConsumedFood; i++)
            {
                Food food = new Food
                {
                    Name = binaryStream.ReadString(),
                    HpLeft = binaryStream.ReadSingle(),
                    StaminaLeft = binaryStream.ReadSingle()
                };

                character.Foods.Add(food);
            }

            character.SkillsVersion = binaryStream.ReadInt32();

            int numberOfSkills = binaryStream.ReadInt32();
            character.Skills = new List<Skill>();

            for (int i = 0; i < numberOfSkills; i++)
            {
                Skill skill = new Skill
                {
                    SkillName = (SkillNames) binaryStream.ReadInt32(),
                    Level = binaryStream.ReadSingle(),
                    NextLevelPercentage = binaryStream.ReadSingle()
                };

                character.Skills.Add(skill);
            }

            return character;
        }

        public byte[] WriteCharacterData(Character character)
        {
            using BinaryStream binaryStream = new BinaryStream();

            binaryStream.Write(character.CharacterVersion);
            binaryStream.Write(character.Kills);
            binaryStream.Write(character.Deaths);
            binaryStream.Write(character.Crafts);
            binaryStream.Write(character.Builds);
            binaryStream.Write(character.WorldsData.Count);

            foreach (KeyValuePair<long, World> world in character.WorldsData)
            {
                binaryStream.Write(world.Key);
                binaryStream.Write(world.Value.HasCustomSpawnPoint);
                binaryStream.Write(world.Value.SpawnPoint);
                binaryStream.Write(world.Value.HasLogoutPoint);
                binaryStream.Write(world.Value.LogoutPoint);
                binaryStream.Write(world.Value.HasDeathPoint);
                binaryStream.Write(world.Value.DeathPoint);
                binaryStream.Write(world.Value.HomePoint);
                binaryStream.Write(world.Value.MapData != null);

                if (world.Value.MapData != null)
                    binaryStream.Write(world.Value.MapData);
            }

            binaryStream.Write(character.Name);
            binaryStream.Write(character.Id);
            binaryStream.Write(character.StartSeed);
            binaryStream.Write(character.DataVersion != 0); 

            using BinaryStream binaryStream2 = new BinaryStream();

            if (character.MaxHp != 0)
            {
                binaryStream2.Write(character.DataVersion);
                binaryStream2.Write(character.MaxHp);
                binaryStream2.Write(character.Hp);
                binaryStream2.Write(character.Stamina);
                binaryStream2.Write(character.IsFirstSpawn);
                binaryStream2.Write(character.TimeSinceDeath);
                binaryStream2.Write(character.GuardianPower);
                binaryStream2.Write(character.GuardianPowerCooldown);
                binaryStream2.Write(character.InventoryVersion);
                binaryStream2.Write(character.Inventory.Count);

                foreach (Item item in character.Inventory)
                {
                    binaryStream2.Write(item.Name);
                    binaryStream2.Write(item.Stack);
                    binaryStream2.Write(item.Durability);
                    binaryStream2.Write(item.Position.Item1);
                    binaryStream2.Write(item.Position.Item2);
                    binaryStream2.Write(item.Equipped);
                    binaryStream2.Write(item.Quality);
                    binaryStream2.Write(item.Variant);
                    binaryStream2.Write(item.CrafterId);
                    binaryStream2.Write(item.CrafterName);
                }

                binaryStream2.Write(character.Recipes.Count);

                foreach (string recipe in character.Recipes)
                    binaryStream2.Write(recipe);

                binaryStream2.Write(character.Stations.Count);

                foreach (KeyValuePair<string, int> station in character.Stations)
                {
                    binaryStream2.Write(station.Key);
                    binaryStream2.Write(station.Value);
                }

                binaryStream2.Write(character.KnownMaterials.Count);

                foreach (string material in character.KnownMaterials)
                    binaryStream2.Write(material);

                binaryStream2.Write(character.ShownTutorials.Count);

                foreach (string tutorial in character.ShownTutorials)
                    binaryStream2.Write(tutorial);

                binaryStream2.Write(character.Uniques.Count);

                foreach (string unique in character.Uniques)
                    binaryStream2.Write(unique);

                binaryStream2.Write(character.Trophies.Count);

                foreach (string trophy in character.Trophies)
                    binaryStream2.Write(trophy);

                binaryStream2.Write(character.Biomes.Count);

                foreach (Biomes biome in character.Biomes)
                    binaryStream2.Write((int)biome);

                binaryStream2.Write(character.Texts.Count);

                foreach (KeyValuePair<string, string> text in character.Texts)
                {
                    binaryStream2.Write(text.Key);
                    binaryStream2.Write(text.Value);
                }

                binaryStream2.Write(character.Beard);
                binaryStream2.Write(character.Hair);
                binaryStream2.Write(character.SkinColor);
                binaryStream2.Write(character.HairColor);
                binaryStream2.Write(character.Gender);
                binaryStream2.Write(character.Foods.Count);

                foreach (Food food in character.Foods)
                {
                    binaryStream2.Write(food.Name);
                    binaryStream2.Write(food.HpLeft);
                    binaryStream2.Write(food.StaminaLeft);
                }

                binaryStream2.Write(character.SkillsVersion);
                binaryStream2.Write(character.Skills.Count);

                foreach (Skill skill in character.Skills)
                {
                    binaryStream2.Write((int)skill.SkillName);
                    binaryStream2.Write(skill.Level);
                    binaryStream2.Write(skill.NextLevelPercentage);
                }
            }

            byte[] playerData = binaryStream2.ToArray();

            binaryStream.Write(playerData.Length);

            byte[] data = binaryStream.ToArray();
            byte[] final = data.Concat(playerData).ToArray();
            byte[] length = BitConverter.GetBytes(final.Length);
            byte[] hashLength = BitConverter.GetBytes(64);
            byte[] hash = SHA512.Create().ComputeHash(final);

            binaryStream.Clear();
            binaryStream2.Clear();

            return length.Concat(final).ToArray().Concat(hashLength).ToArray().Concat(hash).ToArray();
        }

        public string StripInvalidCharacters(string fileName)
        {
            List<char> invalidCharacters = Path.GetInvalidFileNameChars().ToList();
            StringBuilder fileNameBuilder = new StringBuilder();

            foreach (char character in fileName)
            {
                if (invalidCharacters.Contains(character))
                    continue;

                fileNameBuilder.Append(character);
            }

            return fileNameBuilder.ToString();
        }

        public bool SaveCharacterFile(string fileName)
        {
            if (Character?.Data == null || string.IsNullOrEmpty(Character?.File))
            {
                MessageBox.Show("You have not processed a character.", "No character to write!", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return false;
            }

            if (ValheimInstanceTools.IsValheimRunning())
            {
                DialogResult closeValheim = 
                    MessageBox.Show(
                        "Valheim is running. Any operation on critical files might corrupt the data.\n\n" +
                        "Would you like to close Valheim?", 
                        "Valheim is running!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation);

                if (closeValheim == DialogResult.No) return false;
            }

            string newFileName = StripInvalidCharacters(Character.Data.Name) + ".fch";
            Character.File = Path.Combine(Path.GetDirectoryName(Character.File), newFileName);

            File.WriteAllBytes(Character.File, WriteCharacterData(Character.Data));

            return true;
        }
    }
}
