using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ValheimCharacterEditor.Valheim;

namespace ValheimCharacterEditor.Forms
{
    public partial class FrmInventory : Form
    {
        // TODO: Replace this ugly thing with mathematical calculation
        private static readonly Dictionary<int, Tuple<int, int>> ItemCoordinates = new()
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
        private readonly string _characterName;
        private readonly string _imagesPath = Path.Combine(Application.StartupPath, "Images");

        public FrmInventory(List<Item> inventory, string characterName)
        {
            if (inventory == null) throw new ArgumentNullException(nameof(inventory));
            if (characterName == string.Empty) throw new ArgumentNullException(nameof(characterName));

            _inventory = inventory;
            _characterName = characterName;

            InitializeComponent();
        }

        private void FrmInventory_Load(object sender, EventArgs e)
        {
            Text = $"Editing character inventory: {_characterName}";
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

                Image itemImage = Image.FromFile(GetImagePath(item));
                pictureBox.Image = itemImage;
                pictureBox.Tag = item;
            }
        }

        private string GetImagePath(Item item)
        {
            string path;

            if (GameObjects.ItemProperties.ContainsKey(item.Name))
            {
                GameObjectProperties gameObject = GameObjects.ItemProperties[item.Name];

                if (gameObject.MaxVariants > 1 && item.Variant > 0)
                    path = Path.Combine(_imagesPath, $"{item.Name}{item.Variant}.png");
                else
                    path = Path.Combine(_imagesPath, $"{item.Name}.png");
            }
            else
                path = Path.Combine(_imagesPath, $"{item.Name}.png");

            return !File.Exists(path) ? Path.Combine(_imagesPath, "QuestionMark.png") : path;
        }

        private int GetItemSequentialId(int x, int y)
        {
            return ItemCoordinates.FirstOrDefault(v => v.Value.Item1 == y && v.Value.Item2 == x).Key;
        }

        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            Item item = (Item)pictureBox.Tag;

            if (item == null)
            {
                labelItemName.Text = "Empty slot";
                labelQuantity.Text = "-";
                return;
            }

            string name = GameObjects.ItemProperties[item.Name].DisplayName;
            labelItemName.Text = name;
            labelQuantity.Text = item.Stack.ToString();
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            labelItemName.Text = "-";
            labelQuantity.Text = "-";
        }
    }
}
