namespace ValheimCharacterEditor.Valheim
{
    public class World
    {
        public Vector3 DeathPoint = new Vector3();
        public bool HasCustomSpawnPoint;
        public bool HasDeathPoint;
        public bool HasLogoutPoint;
        public Vector3 HomePoint = new Vector3();
        public Vector3 LogoutPoint = new Vector3();
        public byte[] MapData;
        public Vector3 SpawnPoint = new Vector3();
    }
}
