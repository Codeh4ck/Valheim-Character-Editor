using System.Collections.Generic;

namespace ValheimCharacterEditor.Utilities.Extensions
{
    public static class CollectionExtensions
    {
        public static int FindString(this string[] haystack, string needle)
        {
            for (int x = 0; x < haystack.Length; x++)
            {
                if (haystack[x].Equals(needle))
                    return x;
            }

            return -1;
        }
    }
}
