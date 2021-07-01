using System;
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
                    cbBeard.FindStringExact(
                        Constants.Beards[Constants.InternalBeards.IndexOf(_characterEntity.Data.Beard)]);
            }
            catch
            {
                cbBeard.SelectedIndex = 0;
            }

            try
            {
                cbHair.SelectedIndex =
                    cbHair.FindStringExact(
                        Constants.Hairs[Constants.InternalHairs.IndexOf(_characterEntity.Data.Hair)]);

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
        }

        private void btnEditInventory_Click(object sender, EventArgs e)
        {
            using FrmInventory frmInventory = new FrmInventory(_characterEntity.Data.Inventory, _characterEntity.Data.Name);
            frmInventory.ShowDialog(this);
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
        }

        private void numSetAll_ValueChanged(object sender, EventArgs e)
        {
            foreach (TrackBar trackbar in groupSkills.Controls.OfType<TrackBar>())
            {
                trackbar.Value = (int)numSetAll.Value;
                SkillTrackBar_Scroll(trackbar, new ScrollEventArgs(ScrollEventType.ThumbTrack, trackbar.Value));
            }
        }
    }
}
