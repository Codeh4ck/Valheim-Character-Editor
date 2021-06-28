namespace ValheimCharacterEditor.Valheim
{
    public class GameObjectItemProperties
    {
        public int MaxStackSize { get; set; }
        public int MaxDurability { get; set; }
        public int DurabilityPerLevel { get; set; }
        public int MaxQuality { get; set; }
        public int MaxVariants { get; set; }
        public bool Craftable { get; set; }
        public string DisplayName { get; set; }

        public GameObjectItemProperties() { }

        public GameObjectItemProperties(
            int maxStackSize,
            int maxDurability,
            int durabilityPerLevel,
            int maxQuality,
            int maxVariants,
            bool craftable,
            string displayName)
        {

            MaxStackSize = maxStackSize;
            MaxDurability = maxDurability;
            DurabilityPerLevel = durabilityPerLevel;
            MaxQuality = maxQuality;
            MaxVariants = maxVariants;
            Craftable = craftable;
            DisplayName = displayName;
        }
    }
}
