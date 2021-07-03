namespace ValheimCharacterEditor.Models
{
    public class BackupResult
    {
        public bool Successful { get; set; }
        public string BackedFile { get; set; }
        public string BackupFile { get; set; }
        public string BackupMessage { get; set; }
    }
}
