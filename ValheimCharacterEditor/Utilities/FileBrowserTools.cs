using System.Windows.Forms;

namespace ValheimCharacterEditor.Utilities
{
    public class FileBrowserTools
    {
        public static string GetFolderBrowserPath()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog()
            {
                Description = "Select the Valheim characters folder...",
                ShowNewFolderButton = false,
            };

            if (dialog.ShowDialog() != DialogResult.OK) return string.Empty;

            return dialog.SelectedPath;
        }
    }
}
