using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ValheimCharacterEditor.Utilities.Extensions;
using ValheimCharacterEditor.Valheim;

namespace ValheimCharacterEditor.Forms
{
    public partial class FrmItemEditor : Form
    {
        private Item _item;
        private readonly CharacterEntity _character;
        private bool _initializedFirstItem;

        private FrmItemEditor(Item item, CharacterEntity character)
        {
            if (character == null) throw new ArgumentNullException(nameof(character));
            
            _item = item;
            _character = character;

            InitializeComponent();
        }

        public static Item GetItemModification(Form parent, Item item, CharacterEntity character)
        {
            using FrmItemEditor itemEditor = new FrmItemEditor(item, character);
            
            if (itemEditor.ShowDialog(parent) != DialogResult.OK)
                return null;

            return itemEditor._item;
        }

        private void FrmItemEditor_Load(object sender, EventArgs e)
        {
            // All non-items generally contain an underscore
            // Any item that contains a digit is usually some character appearance customization

            cbItems.DataSource = GameObjects.ItemProperties.Values
                .Select(x => x.DisplayName)
                .Where(x => !x.Contains("_") && !x.Any(char.IsDigit))
                .OrderBy(x => x)
                .ToList();

            if (_item != null)
            {
                LoadItem(_item);

                GameObjectProperties itemProperties = GameObjects.ItemProperties[_item.Name];
                cbItems.SelectedIndex = cbItems.FindStringExact(itemProperties.DisplayName);

                _initializedFirstItem = true;
            }
            else
            {
                cbItems.SelectedIndex = 0;
            }
        }

        private void cbItems_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string selectedItem = cbItems.SelectedItem.ToString();

            if (string.IsNullOrEmpty(selectedItem)) return;

            KeyValuePair<string ,GameObjectProperties> gameObject =
                GameObjects.ItemProperties.FirstOrDefault(x => x.Value.DisplayName == selectedItem);

            if (_item == null || _initializedFirstItem)
            {
                Item item = new Item
                {
                    Name = gameObject.Key,
                    Quality = gameObject.Value.MaxQuality,
                    Variant = 0,
                    Stack = 1,
                    CrafterId = _character.Data.Id,
                    CrafterName = _character.Data.Name,
                };


                item.Durability = item.GetMaxDurability(gameObject.Value.MaxQuality);

                _item = item;
            }

            LoadItem(_item);

            Image image = Image.FromFile(_item.GetImagePath());
            pbItemImage.Image = image;
        }

        private void LoadItem(Item item)
        {
            if (!GameObjects.ItemProperties.ContainsKey(item.Name))
            {
                numQuality.Value = 1;
                numQuality.Enabled = false;
                numQuantity.Value = 1;
                numQuantity.Enabled = false;
                numVariant.Value = 0;
                numVariant.Enabled = false;

                return;
            }

            GameObjectProperties itemProperties = GameObjects.ItemProperties[item.Name];

            if (itemProperties.MaxQuality > 1)
            {
                numQuality.Enabled = true;
                numQuality.Maximum = itemProperties.MaxQuality;
                numQuality.Value = item.Quality == 0 ? 1 : item.Quality;
            }
            else
            {
                numQuality.Enabled = false;
                numQuality.Value = _item.Quality;
            }

            if (itemProperties.MaxStackSize > 1)
            {
                numQuantity.Enabled = true;
                numQuantity.Maximum = itemProperties.MaxStackSize;
                numQuantity.Value = item.Stack == 0 ? 1 : item.Stack; ;
            }
            else
            {
                numQuantity.Enabled = false;
                numQuantity.Value = _item.Stack;
            }

            if (itemProperties.MaxVariants > 0)
            {
                numVariant.Enabled = true;
                numVariant.Maximum = itemProperties.MaxVariants - 1;
                numVariant.Value = item.Variant;
            }
            else
            {
                numVariant.Enabled = false;
                numVariant.Value = item.Variant;
            }
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (_item != null)
                _item.Stack = Convert.ToInt32(numQuantity.Value);
        }

        private void numQuality_ValueChanged(object sender, EventArgs e)
        {
            if (_item != null)
            {
                _item.Quality = Convert.ToInt32(numQuality.Value);
                _item.Durability = _item.GetMaxDurability();
            }
        }

        private void numVariant_ValueChanged(object sender, EventArgs e)
        {
            if (_item != null)
            {
                _item.Variant = Convert.ToInt32(numVariant.Value);
                UpdateImage();
            }
        }

        private void UpdateImage()
        {
            Image image = Image.FromFile(_item.GetImagePath());
            pbItemImage.Image = image;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
