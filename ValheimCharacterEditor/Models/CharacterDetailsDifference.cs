using System.Collections.Generic;

namespace ValheimCharacterEditor.Models
{
    public class CharacterDetailsDifference
    {
        public StringDifference NameDifference { get; set; }
        public StringDifference GenderDifference { get; set; }
        public StringDifference BeardDifference { get; set; }
        public StringDifference HairDifference { get; set; }
        public Vector3Difference SkinToneDifference { get; set; }
        public Vector3Difference HairColorDifference { get; set; }
        public List<SkillDifference> SkillDifferences { get; set; }
        public List<InventoryDifference> InventoryDifferences { get; set; }

        public CharacterDetailsDifference()
        {
            SkillDifferences = new List<SkillDifference>();
            InventoryDifferences = new List<InventoryDifference>();
        }
    }
}
