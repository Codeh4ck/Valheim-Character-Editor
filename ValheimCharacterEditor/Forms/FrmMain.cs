using System;
using System.Windows.Forms;
using ValheimCharacterEditor.Models;
using ValheimCharacterEditor.Utilities;

namespace ValheimCharacterEditor.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (ValheimInstanceTools.IsValheimRunning())
            {
                MessageBox.Show(
                    "Valheim is running. You must close Valheim before editing a character otherwise data corruption may occur.",
                    "Valheim is running!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            CharacterLoader.LoadCharacters();

            cbCharacters.DataSource = CharacterLoader.GetCharacterNames();
        }

        private void btnEditCharacter_Click(object sender, EventArgs e)
        {
            CharacterEntity characterEntity = CharacterLoader.Characters[cbCharacters.SelectedIndex];

            FrmCharacterEditor characterEditor = new FrmCharacterEditor(characterEntity);
            characterEditor.Show();

            Close();
        }
    }
}
