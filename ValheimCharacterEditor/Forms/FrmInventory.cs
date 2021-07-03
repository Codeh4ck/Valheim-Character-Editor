using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ValheimCharacterEditor.Utilities.Extensions;
using ValheimCharacterEditor.Valheim;

namespace ValheimCharacterEditor.Forms
{
    public partial class FrmInventory : Form
    {
        // TODO: Replace this ugly thing with mathematical calculation
        private static readonly Dictionary<int, Tuple<int, int>> InventoryPositions = new()
        {
            { 1, new Tuple<int, int>(0, 0) },
            { 2, new Tuple<int, int>(0, 1) },
            { 3, new Tuple<int, int>(0, 2) },
            { 4, new Tuple<int, int>(0, 3) },
            { 5, new Tuple<int, int>(0, 4) },
            { 6, new Tuple<int, int>(0, 5) },
            { 7, new Tuple<int, int>(0, 6) },
            { 8, new Tuple<int, int>(0, 7) },

            { 9, new Tuple<int, int>(1, 0) },
            { 10, new Tuple<int, int>(1, 1) },
            { 11, new Tuple<int, int>(1, 2) },
            { 12, new Tuple<int, int>(1, 3) },
            { 13, new Tuple<int, int>(1, 4) },
            { 14, new Tuple<int, int>(1, 5) },
            { 15, new Tuple<int, int>(1, 6) },
            { 16, new Tuple<int, int>(1, 7) },

            { 17, new Tuple<int, int>(2, 0) },
            { 18, new Tuple<int, int>(2, 1) },
            { 19, new Tuple<int, int>(2, 2) },
            { 20, new Tuple<int, int>(2, 3) },
            { 21, new Tuple<int, int>(2, 4) },
            { 22, new Tuple<int, int>(2, 5) },
            { 23, new Tuple<int, int>(2, 6) },
            { 24, new Tuple<int, int>(2, 7) },

            { 25, new Tuple<int, int>(3, 0) },
            { 26, new Tuple<int, int>(3, 1) },
            { 27, new Tuple<int, int>(3, 2) },
            { 28, new Tuple<int, int>(3, 3) },
            { 29, new Tuple<int, int>(3, 4) },
            { 30, new Tuple<int, int>(3, 5) },
            { 31, new Tuple<int, int>(3, 6) },
            { 32, new Tuple<int, int>(3, 7) }
        };

        private readonly List<Item> _inventory;
        private readonly CharacterEntity _character;

        private FrmInventory(CharacterEntity character)
        {
            if (character == null) throw new ArgumentNullException(nameof(character));

            _character = character;
            _inventory = character.Data.Inventory;

            InitializeComponent();
        }

        public static List<Item> GetInventoryModification(Form parent, CharacterEntity character)
        {
            using FrmInventory frmInventory = new FrmInventory(character);
            if (frmInventory.ShowDialog(parent) != DialogResult.OK) return null;

            return frmInventory._inventory;
        }

        private void FrmInventory_Load(object sender, EventArgs e)
        {
            Text = $"Editing character inventory: {_character.Data.Name}";
            PopulateInventory();
        }

        private void PopulateInventory()
        {
            foreach (Item item in _inventory)
            {
                int x = item.Position.Item1;
                int y = item.Position.Item2;

                int linear = GetItemSequentialId(x, y);

                PictureBox pictureBox =
                    Controls.Find($"pbSlot{linear}", false).FirstOrDefault() as PictureBox;

                if (pictureBox == null) continue;

                Image itemImage = Image.FromFile(item.GetImagePath());
                pictureBox.Image = itemImage;
                pictureBox.Tag = item;
            }
        }

        private int GetItemSequentialId(int x, int y)
        {
            return InventoryPositions.FirstOrDefault(v => v.Value.Item1 == y && v.Value.Item2 == x).Key;
        }

        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            Item item = (Item)pictureBox.Tag;

            if (item == null)
            {
                labelItemName.Text = "Empty slot";
                labelQuantity.Text = "-";
                labelDurability.Text = "-";
                labelVariant.Text = "-";
                return;
            }

            string name = GameObjects.ItemProperties[item.Name].DisplayName;

            labelItemName.Text = name;
            labelQuantity.Text = item.Stack.ToString();
            labelDurability.Text = item.GetMaxDurability().ToString(CultureInfo.CurrentCulture);
            labelVariant.Text = item.Variant.ToString();
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            labelItemName.Text = "-";
            labelQuantity.Text = "-";
        }

        private void PictureBox_DoubleClick(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox) sender;
            Item item = (Item) pictureBox.Tag;

            Item modified = ModifyItem(item, GetInventoryPosition(pictureBox));

            if (modified == null) return;

            pictureBox.Tag = modified;
            pictureBox.Image = Image.FromFile(modified.GetImagePath());
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl;
            Item item = (Item)pictureBox.Tag;

            Item modified = ModifyItem(item, GetInventoryPosition(pictureBox));

            if (modified == null) return;

            pictureBox.Tag = modified;
            pictureBox.Image = Image.FromFile(modified.GetImagePath());
        }

        private Item ModifyItem(Item item, Tuple<int, int> position)
        {
            Item modified = FrmItemEditor.GetItemModification(this, item, _character);
            if (modified == null) return null;

            // Inventory coordinates are reversed in Valheim for some weird reason
            // Therefore x is y and y is x
            modified.Position ??= new Tuple<int, int>(position.Item2, position.Item1);

            _inventory.Remove(item);
            _inventory.Add(modified);

            return modified;
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox) ((ContextMenuStrip) ((ToolStripMenuItem) sender).Owner).SourceControl;
            Item item = (Item)pictureBox.Tag;

            _inventory.Remove(item);

            pictureBox.Image = null;
            pictureBox.Tag = null;
        }

        private Tuple<int, int> GetInventoryPosition(PictureBox pictureBox)
        {
            bool result = int.TryParse(pictureBox.Name.Replace("pbSlot", ""), out int index);
            if (!result) return null;

            return InventoryPositions[index];
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
