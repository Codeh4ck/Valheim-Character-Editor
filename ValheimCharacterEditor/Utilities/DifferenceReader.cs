using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ValheimCharacterEditor.Models;
using ValheimCharacterEditor.Utilities.Extensions;
using ValheimCharacterEditor.Valheim;

namespace ValheimCharacterEditor.Utilities
{
    public class DifferenceReader
    {
        private readonly Character _oldCharacter;
        private readonly Character _newCharacter;

        public DifferenceReader(Character oldCharacter, Character newCharacter)
        {
            if (oldCharacter == null) throw new ArgumentNullException(nameof(oldCharacter));
            if (newCharacter == null) throw new ArgumentNullException(nameof(newCharacter));

            _oldCharacter = oldCharacter;
            _newCharacter = newCharacter;
        }

        public CharacterDetailsDifference GetCharacterDetailsChanges()
        {
            CharacterDetailsDifference differences = new CharacterDetailsDifference();

            if (string.Compare(_oldCharacter.Name, _newCharacter.Name, StringComparison.Ordinal) != 0)
            {
                differences.NameDifference = new StringDifference
                {
                    Name = "Character Name", NewValue = _newCharacter.Name, PreviousValue = _oldCharacter.Name
                };
            }

            if (_oldCharacter.Gender != _newCharacter.Gender)
            {
                differences.GenderDifference = new StringDifference()
                {
                    Name = "Gender",
                    NewValue = Constants.GetGenderName(_newCharacter.Gender),
                    PreviousValue = Constants.GetGenderName(_oldCharacter.Gender)
                };
            }

            if (string.Compare(_oldCharacter.Beard, _newCharacter.Beard, StringComparison.Ordinal) != 0)
            {
                differences.BeardDifference = new StringDifference()
                {
                    Name = "Beard",
                    NewValue = Constants.GetBeardName(_newCharacter.Beard),
                    PreviousValue = Constants.GetBeardName(_oldCharacter.Beard)
                };
            }

            if (string.Compare(_oldCharacter.Hair, _newCharacter.Hair, StringComparison.Ordinal) != 0)
            {
                differences.HairDifference = new StringDifference()
                {
                    Name = "Hair",
                    NewValue = Constants.GetHairName(_newCharacter.Hair),
                    PreviousValue = Constants.GetHairName(_oldCharacter.Hair)
                };
            }

            if (!_oldCharacter.SkinColor.Equals(_newCharacter.SkinColor))
            {
                differences.SkinToneDifference = new Vector3Difference()
                {
                    Name = "Skin Color",
                    NewValue = _newCharacter.SkinColor,
                    PreviousValue = _oldCharacter.SkinColor
                };
            }

            if (!_oldCharacter.HairColor.Equals(_newCharacter.HairColor))
            {
                differences.HairColorDifference = new Vector3Difference()
                {
                    Name = "Hair Color",
                    NewValue = _newCharacter.HairColor,
                    PreviousValue = _oldCharacter.HairColor
                };
            }

            differences.SkillDifferences = GetSkillDifferences();
            differences.InventoryDifferences = GetInventoryDifferences();

            return differences;
        }

        private List<SkillDifference> GetSkillDifferences()
        {
            List<SkillDifference> skillDifferences = new List<SkillDifference>();

            foreach (Skill skill in _oldCharacter.Skills)
            {
                Skill newSkill = _newCharacter.Skills.FirstOrDefault(x => x.SkillName == skill.SkillName);
                if (newSkill == null) continue;

                if (Math.Abs(skill.Level - newSkill.Level) > float.Epsilon)
                {
                    skillDifferences.Add(new SkillDifference()
                    {
                        SkillName = skill.SkillName,
                        NewValue = newSkill.Level,
                        PreviousValue = skill.Level
                    });
                }
            }

            return skillDifferences;
        }

        private List<InventoryDifference> GetInventoryDifferences()
        {
            List<InventoryDifference> inventoryDifferences = new List<InventoryDifference>();
            
            // Detect new items
            foreach (Item item in _newCharacter.Inventory)
            {
                if (_oldCharacter.Inventory.FirstOrDefault(x => x.Name == item.Name) != null) continue;

                GameObjectProperties itemProperties = item.GetItemProperties();

                InventoryDifference difference = new InventoryDifference
                {
                    Name = $"New item: {itemProperties.DisplayName}",
                    NewValue = BuildItemDescription(item, itemProperties),
                    PreviousValue = string.Empty
                };

                inventoryDifferences.Add(difference);
            }

            // Detect removed items
            foreach (Item item in _oldCharacter.Inventory)
            {
                if (_newCharacter.Inventory.FirstOrDefault(x => x.Name == item.Name) == null)
                {
                    GameObjectProperties itemProperties = item.GetItemProperties();

                    InventoryDifference difference = new InventoryDifference()
                    {
                        Name = $"Removed item: {itemProperties.DisplayName}",
                        NewValue = BuildItemDescription(item, itemProperties),
                        PreviousValue = string.Empty
                    };

                    inventoryDifferences.Add(difference);
                }
            }

            // Detect changed items

            foreach (Item item in _newCharacter.Inventory)
            {
                Item oldItem = _oldCharacter.Inventory.FirstOrDefault(x => x.Position.Equals(item.Position));
                if (oldItem == null) continue;

                if (item.Name != oldItem.Name || 
                    item.Quality != oldItem.Quality ||
                    item.Stack != oldItem.Stack ||
                    item.Variant != oldItem.Variant)
                {

                    GameObjectProperties oldItemProperties = oldItem.GetItemProperties();
                    GameObjectProperties newItemProperties = item.GetItemProperties();

                    InventoryDifference difference = new InventoryDifference()
                    {
                        Name = $"Changed item: {oldItem.Name}",
                        NewValue = BuildItemDescription(item, newItemProperties),
                        PreviousValue = BuildItemDescription(oldItem, oldItemProperties)
                    };

                    inventoryDifferences.Add(difference);
                }
            }

            return inventoryDifferences;
        }

        private string BuildItemDescription(Item item, GameObjectProperties properties)
        {
            StringBuilder itemDetails = new StringBuilder();

            if (properties.MaxStackSize > 1)
                itemDetails.AppendLine($"\tQuantity: {item.Stack}");

            if (properties.MaxQuality > 1)
                itemDetails.AppendLine($"\tQuality: {item.Quality}");

            if (properties.Craftable)
            {
                itemDetails.AppendLine($"\tDurability: {Convert.ToInt32(item.GetMaxDurability())}");
                itemDetails.AppendLine($"\tCrafter Id: {item.CrafterId}");
                itemDetails.AppendLine($"\tCrafter Name: {item.CrafterName}");
            }

            if (properties.MaxVariants > 0)
                itemDetails.AppendLine($"\tVariant: {item.Variant}");

            return itemDetails.ToString();
        }
    }

}
