using System.Collections.Generic;

namespace ValheimCharacterEditor.Valheim
{
    public class Constants
    {
        public static List<string> Beards = new List<string>
        {
            "No beard",
            "Braided 1",
            "Braided 2",
            "Braided 3",
            "Braided 4",
            "Long 1",
            "Long 2",
            "Short 1",
            "Short 2",
            "Short 3",
            "Thick 1"
        };

        public static List<string> InternalBeards = new List<string>
        {
            "BeardNone",
            "Beard5",
            "Beard6",
            "Beard9",
            "Beard10",
            "Beard1",
            "Beard2",
            "Beard3",
            "Beard4",
            "Beard7",
            "Beard8"
        };

        public static readonly List<string> Hairs = new List<string>
        {
            "No hair",
            "Braided 1",
            "Braided 2",
            "Braided 3",
            "Braided 4",
            "Long 1",
            "Ponytail 1",
            "Ponytail 2",
            "Ponytail 3",
            "Ponytail 4",
            "Short 1",
            "Short 2",
            "Side Swept 1",
            "Side Swept 2",
            "Side Swept 3"
        };

        public static readonly List<string> InternalHairs = new List<string>
        {
            "HairNone",
            "Hair3",
            "Hair11",
            "Hair12",
            "Hair13",
            "Hair6",
            "Hair1",
            "Hair2",
            "Hair4",
            "Hair7",
            "Hair5",
            "Hair8",
            "Hair9",
            "Hair10",
            "Hair14"
        };

        public static readonly List<string> Genders = new List<string>
        {
            "Male",
            "Female"
        };

        public static readonly List<string> Skills = new List<string>
        {
            "Swords",
            "Knives",
            "Clubs",
            "Polearms",
            "Spears",
            "Blocking",
            "Axes",
            "Bows",
            "Unarmed",
            "Pickaxes",
            "WoodCutting",
            "Jump",
            "Sneak",
            "Run",
            "Swim"
        };



        public const string NameDisallowedCharacters = "0123456789,;.:-_´¨{}][+*`^¡¿'?=)(/&¬%$·#@!|ª\\º\"'";
    }
}
