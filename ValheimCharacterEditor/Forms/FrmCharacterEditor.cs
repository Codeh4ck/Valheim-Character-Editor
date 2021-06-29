using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using ValheimCharacterEditor.Models;
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
            PopulateFields();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private Tuple<Guna2TrackBar, Guna2HtmlLabel> GetSkillControls(Skill skill)
        {
            string skillName = skill.SkillName.ToString("F").ToLower();

            Guna2TrackBar trackbarControl = null;
            Guna2HtmlLabel labelControl = null;

            foreach (Guna2TrackBar c in groupSkills.Controls.OfType<Guna2TrackBar>())
            {
                if (c.Name.ToLower().Replace("trackbar", "") == skillName)
                {
                    trackbarControl = c;
                    break;
                }
            }

            foreach (Guna2HtmlLabel c in groupSkills.Controls.OfType<Guna2HtmlLabel>())
            {
                if (c.Name.ToLower().Replace("label", "") == skillName)
                {
                    labelControl = c;
                    break;
                }
            }

            return new Tuple<Guna2TrackBar, Guna2HtmlLabel>(trackbarControl, labelControl);
        }
    }
}
