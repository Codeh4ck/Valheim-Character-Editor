using System.Windows.Forms;
using ValheimCharacterEditor.Utilities;
using ValheimCharacterEditor.Valheim;

namespace ValheimCharacterEditor.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, System.EventArgs e)
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

        private void btnEditCharacter_Click(object sender, System.EventArgs e)
        {
            CharacterEntity characterEntity = CharacterLoader.Characters[cbCharacters.SelectedIndex];

            FrmCharacterEditor characterEditor = new FrmCharacterEditor(characterEntity);
            characterEditor.Show();

            Close();
        }
    }
}
