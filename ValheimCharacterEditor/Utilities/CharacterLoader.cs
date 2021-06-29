using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ValheimCharacterEditor.Models;
using ValheimCharacterEditor.Valheim;

namespace ValheimCharacterEditor.Utilities
{
    public class CharacterLoader
    {
        public static List<CharacterEntity> Characters { get; set; }

        static CharacterLoader()
        {
            Characters = new List<CharacterEntity>();
        }

        public static void LoadCharacters()
        {
            string charactersDirectory = Path.Combine(Constants.ValheimBasePath, "characters");

            while (!Directory.Exists(charactersDirectory))
            {
                MessageBox.Show(
                    "The default character directory does not exist. If you have installed Valheim on a different folder, please select the correct characters folder.\n\nThe characters folder must contain all .FCH character files.",
                    "Characters folder does not exist!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                string selectedFolder = FileBrowserTools.GetFolderBrowserPath();
                if (string.IsNullOrEmpty(selectedFolder)) return;

                charactersDirectory = selectedFolder;
            }

            string[] fchFiles = Directory.GetFiles(charactersDirectory, "*.fch");

            if (fchFiles.Length == 0)
            {
                MessageBox.Show("You have not created a Valheim character yet.", "No characters found!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Environment.Exit(1);
            }

            foreach (string file in fchFiles)
            {
                CharacterParser parser = new CharacterParser(file);
                parser.ReadCharacterData();

                Characters.Add(parser.Character);
            }
        }

        public static List<string> GetCharacterNames()
        {
            List<string> characterNames = new List<string>(Characters.Count);

            foreach (CharacterEntity entity in Characters)
                characterNames.Add(entity.Data.Name);

            return characterNames;
        }
    }
}
