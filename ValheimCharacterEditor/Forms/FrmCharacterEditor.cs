using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ValheimCharacterEditor.Utilities.Extensions;
using ValheimCharacterEditor.Valheim;

namespace ValheimCharacterEditor.Forms
{
    public partial class FrmCharacterEditor : Form
    {
        private readonly CharacterEntity _characterEntity;
        public FrmCharacterEditor(CharacterEntity characterEntity)
        {
            _characterEntity = characterEntity ?? throw new ArgumentNullException(nameof(characterEntity));
            InitializeComponent();
        }

        private void FrmCharacterEditor_Load(object sender, EventArgs e)
        {
            Text = $"Editing character: {_characterEntity.Data.Name}";
            PopulateFields();


            // We're hooking these events after loading the character to prevent any unintentional modification
            cbGender.SelectedIndexChanged += cbGender_SelectedIndexChanged;
            cbBeard.SelectedIndexChanged += cbBeard_SelectedIndexChanged;
            cbHair.SelectedIndexChanged += cbHair_SelectedIndexChanged;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            // First, verify that the name is valid
            if (!(txtName.Text.Length is >= 3 and <= 15))
            {
                MessageBox.Show("Character name must be 3 to 15 characters long.", "Invalid character name!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            foreach (char c in txtName.Text)
            {
                if (Constants.NameDisallowedCharacters.Contains(c))
                {
                    MessageBox.Show($"Your character name contains invalid characters.\n\nInvalid character: {c}",
                        "Invalid character name!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return;
                }
            }

            _characterEntity.Data.Name = txtName.Text;

            bool result = FrmSaveCharacter.SaveCharacter(this, _characterEntity);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            Close();
        }

        private void PopulateFields()
        {
            txtName.Text = _characterEntity.Data.Name;
            cbBeard.DataSource = Constants.Beards;
            cbHair.DataSource = Constants.Hairs;
            cbGender.DataSource = Constants.Genders;

            try
            {
                cbBeard.SelectedIndex =
                    cbBeard.FindStringExact(Constants.GetBeardName(_characterEntity.Data.Beard));
            }
            catch
            {
                cbBeard.SelectedIndex = 0;
            }

            try
            {
                cbHair.SelectedIndex =
                    cbHair.FindStringExact(Constants.GetHairName(_characterEntity.Data.Hair));

            }
            catch
            {
                cbHair.SelectedIndex = 0;
            }

            cbGender.SelectedIndex = cbGender.FindStringExact(Constants.GetGenderName(_characterEntity.Data.Gender));

            panelSkinTone.BackColor = _characterEntity.Data.SkinColor.ToColor();
            panelHairColor.BackColor = _characterEntity.Data.HairColor.ToColor();

            foreach (Skill skill in _characterEntity.Data.Skills)
            {
                var tuple = GetSkillControls(skill);

                tuple.Item1.Value = (int)skill.Level;
                tuple.Item2.Text = ((int)skill.Level).ToString(CultureInfo.CurrentCulture);
            }
        }

        private void btnEditSkinTone_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog()
            {
                AllowFullOpen = true,
                FullOpen = true
            };

            if (colorDialog.ShowDialog(this) != DialogResult.OK) return;
            panelSkinTone.BackColor = colorDialog.Color;

            _characterEntity.Data.SkinColor = new Vector3().FromColor(colorDialog.Color);
        }

        private void btnEditHairColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog()
            {
                AllowFullOpen = true,
                FullOpen = true
            };


            if (colorDialog.ShowDialog(this) != DialogResult.OK) return;
            panelHairColor.BackColor = colorDialog.Color;

            _characterEntity.Data.HairColor = new Vector3().FromColor(colorDialog.Color);
        }

        private void btnEditInventory_Click(object sender, EventArgs e)
        {
            List<Item> inventory = FrmInventory.GetInventoryModification(this, _characterEntity);

            if (inventory == null) return;

            _characterEntity.Data.Inventory = inventory;
        }

        private Tuple<TrackBar, Label> GetSkillControls(Skill skill)
        {
            string skillName = skill.SkillName.ToString("F").ToLower();

            TrackBar trackbarControl = null;
            Label labelControl = null;

            foreach (TrackBar c in groupSkills.Controls.OfType<TrackBar>())
            {
                if (c.Name.ToLower().Replace("trackbar", "") == skillName)
                {
                    trackbarControl = c;
                    break;
                }
            }

            foreach (Label c in groupSkills.Controls.OfType<Label>())
            {
                if (c.Name.ToLower().Replace("label", "") == skillName)
                {
                    labelControl = c;
                    break;
                }
            }

            return new Tuple<TrackBar, Label>(trackbarControl, labelControl);
        }

        private void SkillTrackBar_Scroll(object sender, EventArgs e)
        {
            TrackBar trackbar = (TrackBar)sender;
            string skillName = trackbar.Name.ToLower().Replace("trackbar", "");

            foreach (Label c in groupSkills.Controls.OfType<Label>())
            {
                if (c.Name.ToLower().Replace("label", "") == skillName)
                    c.Text = trackbar.Value.ToString();
            }

            foreach (Skill skill in _characterEntity.Data.Skills)
            {
                if (skill.SkillName.ToString("F").ToLower() == skillName)
                    skill.Level = trackbar.Value;
            }
        }

        private void numSetAll_ValueChanged(object sender, EventArgs e)
        {
            foreach (TrackBar trackbar in groupSkills.Controls.OfType<TrackBar>())
            {
                trackbar.Value = (int)numSetAll.Value;
                SkillTrackBar_Scroll(trackbar, new ScrollEventArgs(ScrollEventType.ThumbTrack, trackbar.Value));
            }
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            _characterEntity.Data.Gender = Constants.GetInternalGender(cbGender.SelectedItem.ToString());
        }

        private void cbBeard_SelectedIndexChanged(object sender, EventArgs e)
        {
            _characterEntity.Data.Beard =
                Constants.InternalBeards[Constants.Beards.IndexOf(cbBeard.SelectedItem.ToString())];
        }

        private void cbHair_SelectedIndexChanged(object sender, EventArgs e)
        {
            _characterEntity.Data.Hair =
                Constants.InternalHairs[Constants.Hairs.IndexOf(cbHair.SelectedItem.ToString())];
        }
    }
}
