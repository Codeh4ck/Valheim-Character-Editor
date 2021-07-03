using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ValheimCharacterEditor.Valheim;

namespace ValheimCharacterEditor.Utilities
{
    public class CharacterLoader
    {
        public static List<CharacterEntity> Characters { get; private set; }
        public static List<CharacterEntity> CharactersUnmodified { get; private set; }

        static CharacterLoader()
        {
            Characters = new List<CharacterEntity>();
            CharactersUnmodified = new List<CharacterEntity>();
        }

        public static void LoadCharacters()
        {
            if (Characters.Count > 0) 
                Characters = new List<CharacterEntity>();

            if (CharactersUnmodified.Count > 0)
                CharactersUnmodified = new List<CharacterEntity>();

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
                CharacterEntity character = CharacterParser.ReadCharacterFile(file);
                Characters.Add(character);

                /*
                    The reason we re-read the files is to create a deep copy of each character,
                    in order to use later as references to compare character changes.

                    While we can use MemberwiseClone() to perform copies,
                    this approach is more tidy in exchange for some performance impact 
                */

                CharacterEntity characterCopy = CharacterParser.ReadCharacterFile(file);
                CharactersUnmodified.Add(characterCopy);
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
