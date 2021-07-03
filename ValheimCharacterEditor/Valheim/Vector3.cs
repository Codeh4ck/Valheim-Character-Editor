using System;

namespace ValheimCharacterEditor.Valheim
{
#pragma warning disable CS0659
    public class Vector3
#pragma warning restore CS0659
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public override bool Equals(object other)
        {
            if (other == null) return false;
            if (GetType() != other.GetType()) return false;
            if (ReferenceEquals(this, other)) return true;

            return CompareProperties((Vector3) other);
        }

        private bool CompareProperties(Vector3 other)
        {
            if (Math.Abs(X - other.X) >= float.Epsilon) return false;
            if (Math.Abs(Y - other.Y) >= float.Epsilon) return false;
            if (Math.Abs(Z - other.Z) >= float.Epsilon) return false;

            return true;
        }
    }
}
