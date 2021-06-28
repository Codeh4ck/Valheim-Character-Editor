using System;

namespace ValheimCharacterEditor.Valheim
{
    public class Item
    {
        public long CrafterId;
        public string CrafterName;
        public float Durability;
        public bool Equipped;
        public string Name;
        public Tuple<int, int> Position;
        public int Quality;
        public int Stack;
        public int Variant;
    }
}
