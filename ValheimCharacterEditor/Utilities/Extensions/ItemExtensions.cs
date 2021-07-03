using System;
using System.IO;
using System.Windows.Forms;
using ValheimCharacterEditor.Valheim;

namespace ValheimCharacterEditor.Utilities.Extensions
{
    public static class ItemExtensions
    {
        private static readonly string ImagesPath = Path.Combine(Application.StartupPath, "Images");

        public static string GetImagePath(this Item item)
        {
            string path;

            if (GameObjects.ItemProperties.ContainsKey(item.Name))
            {
                GameObjectProperties gameObject = GameObjects.ItemProperties[item.Name];

                if (gameObject.MaxVariants > 1 && item.Variant > 0)
                    path = Path.Combine(ImagesPath, $"{item.Name}{item.Variant}.png");
                else
                    path = Path.Combine(ImagesPath, $"{item.Name}.png");
            }
            else
                path = Path.Combine(ImagesPath, $"{item.Name}.png");

            return !File.Exists(path) ? Path.Combine(ImagesPath, "QuestionMark.png") : path;
        }

        public static float GetMaxDurability(this Item item)
        {
            return GetMaxDurability(item, item.Quality);
        }

        public static float GetMaxDurability(this Item item, int quality)
        {
            return GameObjects.ItemProperties[item.Name].MaxDurability +
                   (float)Math.Max(0, quality - 1) *
                   GameObjects.ItemProperties[item.Name].DurabilityPerLevel;
        }

        public static string GetDisplayName(this Item item)
        {
            GameObjectProperties itemProperties = item.GetItemProperties();
            if (itemProperties == null) return "Unknown";

            return itemProperties.DisplayName;
        }

        public static GameObjectProperties GetItemProperties(this Item item)
        {
            try
            {
                return GameObjects.ItemProperties[item.Name];
            }
            catch
            {
                return null;
            }
        }
    }
}
