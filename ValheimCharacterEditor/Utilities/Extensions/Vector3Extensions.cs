using System.Drawing;
using ValheimCharacterEditor.Valheim;

namespace ValheimCharacterEditor.Utilities.Extensions
{
    public static class Vector3Extensions
    {
        public static Color ToColor(this Vector3 vector)
        {
            return Color.FromArgb(255, 
                (int)(vector.X * 255), (int)(vector.Y * 255), (int)(vector.Z * 255));
        }

        public static Vector3 FromColor(this Vector3 vector, Color color)
        {
            vector.X = color.R / 255.0F;
            vector.Y = color.G / 255.0F;
            vector.Z = color.B / 255.0F;

            return vector;
        }


        public static string ToColorString(this Vector3 vector)
        {
            Color color = vector.ToColor();
            return $"R: {color.R}, G: {color.G}, B: {color.B}";
        }
    }
}
