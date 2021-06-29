using System.Collections.Generic;

namespace ValheimCharacterEditor.Valheim
{
    public class Character
    {
        public string Beard = "";
        public HashSet<Biomes> Biomes;
        public int Builds;
        public int Crafts;
        public int Deaths;
        public List<Food> Foods; // Foods currently being eaten by the character
        public string GuardianPower;
        public float GuardianPowerCooldown;
        public string Hair = "";
        public Vector3 HairColor;
        public float Hp;
        public long Id;
        public List<Item> Inventory;
        public bool IsFirstSpawn;
        public int Kills;
        public HashSet<string> KnownMaterials;
        public float MaxHp;
        public int Gender;  // 0 - Male, 1 - Female
        public string Name = "";
        public HashSet<string> Recipes;
        public HashSet<string> ShownTutorials;
        public List<Skill> Skills;
        public Vector3 SkinColor;
        public float Stamina;
        public string StartSeed = "";
        public Dictionary<string, int> Stations = new Dictionary<string, int>();
        public Dictionary<string, string> Texts = new Dictionary<string, string>();
        public float TimeSinceDeath;
        public HashSet<string> Trophies;
        public HashSet<string> Uniques;
        public Dictionary<long, World> WorldsData = new Dictionary<long, World>();
        public int DataVersion = 0;
        public int SkillsVersion;
        public int InventoryVersion;
        public int CharacterVersion;
    }
}
