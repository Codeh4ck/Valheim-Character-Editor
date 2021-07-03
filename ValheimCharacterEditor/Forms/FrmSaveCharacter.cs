using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ValheimCharacterEditor.Models;
using ValheimCharacterEditor.Utilities;
using ValheimCharacterEditor.Utilities.Extensions;
using ValheimCharacterEditor.Valheim;

namespace ValheimCharacterEditor.Forms
{
    public partial class FrmSaveCharacter : Form
    {
        private readonly CharacterEntity _character;

        public FrmSaveCharacter(CharacterEntity character)
        {
            if (character == null) throw new ArgumentNullException(nameof(character));
            _character = character;

            InitializeComponent();
        }

        public static bool SaveCharacter(Form parent, CharacterEntity character)
        {
            using FrmSaveCharacter saveCharacter = new FrmSaveCharacter(character);
            if (saveCharacter.ShowDialog(parent) != DialogResult.OK) return false;

            return true;
        }

        private void FrmSaveCharacter_Load(object sender, EventArgs e)
        {
            Text = $"{Text} {_character.Data.Name}";
            GetDifferences();
        }

        private void GetDifferences()
        {
            CharacterEntity original =
                CharacterLoader.CharactersUnmodified.FirstOrDefault(x => x.Data.Id == _character.Data.Id);

            if (original == null)
            {
                txtChanges.Text = "New character. No differences";
                return;
            }

            labelCharacterName.Text = original.Data.Name;

            DifferenceReader reader = new DifferenceReader(original.Data, _character.Data);
            CharacterDetailsDifference differences = reader.GetCharacterDetailsChanges();

            if (differences.NameDifference != null)
            {
                txtChanges.AppendText(differences.NameDifference.Name + "\r\n");
                txtChanges.AppendText($"{differences.NameDifference.PreviousValue} -> {differences.NameDifference.NewValue}\r\n\r\n");
            }

            if (differences.GenderDifference != null)
            {
                txtChanges.AppendText(differences.GenderDifference.Name + "\r\n");
                txtChanges.AppendText($"{differences.GenderDifference.PreviousValue} -> {differences.GenderDifference.NewValue}\r\n\r\n");
            }

            if (differences.BeardDifference != null)
            {
                txtChanges.AppendText(differences.BeardDifference.Name + "\r\n");
                txtChanges.AppendText($"{differences.BeardDifference.PreviousValue} -> {differences.BeardDifference.NewValue}\r\n\r\n");
            }

            if (differences.HairDifference != null)
            {
                txtChanges.AppendText(differences.HairDifference.Name + "\r\n");
                txtChanges.AppendText($"{differences.HairDifference.PreviousValue} -> {differences.HairDifference.NewValue}\r\n\r\n");
            }

            if (differences.SkinToneDifference != null)
            {
                txtChanges.AppendText(differences.SkinToneDifference.Name + "\r\n");
                txtChanges.AppendText($"{differences.SkinToneDifference.PreviousValue.ToColorString()} -> {differences.SkinToneDifference.NewValue.ToColorString()}\r\n\r\n");
            }

            if (differences.HairColorDifference != null)
            {
                txtChanges.AppendText(differences.HairColorDifference.Name + "\r\n");
                txtChanges.AppendText($"{differences.HairColorDifference.PreviousValue.ToColorString()} -> {differences.HairColorDifference.NewValue.ToColorString()}\r\n\r\n");
            }

            foreach (SkillDifference skillDifference in differences.SkillDifferences)
            {
                txtChanges.AppendText($"{skillDifference.SkillName:F}\r\n");
                txtChanges.AppendText($"{Convert.ToInt32(skillDifference.PreviousValue)} -> {Convert.ToInt32(skillDifference.NewValue)}\r\n\r\n");
            }

            foreach (InventoryDifference inventoryDifference in differences.InventoryDifferences)
            {
                txtChanges.AppendText($"{inventoryDifference.Name}\r\n");
                if (!string.IsNullOrEmpty(inventoryDifference.PreviousValue))
                {
                    txtChanges.AppendText("-> Previous item:\r\n");
                    txtChanges.AppendText($"{inventoryDifference.PreviousValue}\r\n");
                    txtChanges.AppendText("-> New item:\r\n");
                    txtChanges.AppendText($"{inventoryDifference.NewValue}\r\n");
                }
                else
                    txtChanges.AppendText($"{inventoryDifference.NewValue}\r\n\r\n");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string oldFile = _character.File;

            BackupResult backupResult = null;

            if (chkBackup.Checked)
            {
                if (string.IsNullOrEmpty(oldFile) || !File.Exists(oldFile))
                {
                    DialogResult dialogResult = MessageBox.Show(
                        "The old character file has been deleted. Backup will be skipped.\n\nWould you like to proceed?",
                        "Old character file missing!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (dialogResult == DialogResult.No) return;
                }
                else
                {
                    backupResult = BackupCharacter(oldFile);
                }
            }

            bool saveResult = CharacterParser.SaveCharacterFile(oldFile, _character);

            StringBuilder builder = new StringBuilder();

            builder.Append(
                $"Your character modifications {(saveResult ? "have been saved successfully!" : "could not be saved.")}");

            if (saveResult && backupResult != null)
            {
                builder.AppendLine(
                    backupResult.Successful
                        ? $"\n\nYour character has been backed up successfully!\n\nYou can find the backup at:\n{backupResult.BackupFile}"
                        : $"\n\nCould not backup your character.\nError message:\n\n{backupResult.BackupMessage}");
            }

            MessageBox.Show(builder.ToString(),
                saveResult ? 
                    "Character saved successfully!" :
                    "Could not save character!",
                MessageBoxButtons.OK,
                saveResult ? 
                    MessageBoxIcon.Information :
                    MessageBoxIcon.Exclamation);
            
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private BackupResult BackupCharacter(string oldFile)
        {
            string oldFileDirectory = Path.GetDirectoryName(oldFile);
            string backupFilename = $"{Path.GetFileNameWithoutExtension(oldFile)}-BAK.fch";

            string backupFullPath;

            if (!string.IsNullOrEmpty(oldFileDirectory))
                backupFullPath = Path.Combine(oldFileDirectory, backupFilename);
            else
            {
                FolderBrowserDialog folderBrowser = new FolderBrowserDialog()
                {
                    Description = "Select a folder to save your character backup...",
                    ShowNewFolderButton = true
                };

                if (folderBrowser.ShowDialog(this) != DialogResult.OK)
                {
                    return new BackupResult()
                    {
                        BackedFile = oldFile,
                        BackupFile = string.Empty,
                        Successful = false,
                        BackupMessage = "User did not select a backup folder."
                    };
                };

                backupFullPath = Path.Combine(folderBrowser.SelectedPath, backupFilename);
            }

            try
            {
                File.Copy(oldFile, backupFullPath);

                return new BackupResult()
                {
                    BackupMessage = $"Backup has been completed successfully!",
                    BackedFile = oldFile,
                    BackupFile = backupFullPath,
                    Successful = true
                };
            }
            catch (Exception ex)
            {
                return new BackupResult()
                {
                    BackupMessage = $"Could not backup file. Error: {ex.Message}",
                    BackedFile = oldFile,
                    BackupFile = backupFullPath,
                    Successful = false
                };
            }
        }
    }
}
