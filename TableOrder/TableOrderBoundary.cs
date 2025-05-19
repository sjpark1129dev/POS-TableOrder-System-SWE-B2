using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableOrder
{
    public partial class TableOrderBoundary : Form
    {
        public TableOrderBoundary()
        {
            InitializeComponent();
            LoadCategoryButtons();
            LoadMenuItems();
        }
        private void LoadCategoryButtons()
        {
            string[] categories = { "고기", "음료", "식사" };
            foreach (var cat in categories)
            {
                var btn = new Button()
                {
                    Text = cat,
                    Width = 130,
                    Height = 70
                };
                flowLayoutPanelCategory.Controls.Add(btn);
            }
        }

        private void LoadMenuItems()
        {
            flowLayoutPanelMenus.Controls.Clear();

            // 임시 이미지 생성
            Bitmap dummyImage = new Bitmap(100, 100);
            using (Graphics g = Graphics.FromImage(dummyImage))
            {
                g.Clear(Color.Gray);
                g.DrawString("Image", new Font("Arial", 10), Brushes.White, new PointF(10, 40));
            }

            var menus = new List<(string name, int price)>
            {
                ("삼겹살", 12000),
                ("콜라", 2000),
                ("된장찌개", 7000)
            };

            foreach (var menu in menus)
            {
                var item = new MenuItemControl(menu.name, menu.price, dummyImage);
                flowLayoutPanelMenus.Controls.Add(item);
            }
        }

    }
    public class MenuItemControl : UserControl
    {
        public Label lblName;
        public Label lblPrice;
        public Button btnPlus;
        public Button btnMinus;
        public PictureBox picImage;

        public MenuItemControl(string name, int price, Image image)
        {
            this.Width = 140;
            this.Height = 180;

            var layout = new TableLayoutPanel();
            layout.RowCount = 4;
            layout.ColumnCount = 1;
            layout.Dock = DockStyle.Fill;
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50)); // 이미지
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20)); // 메뉴명
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 25)); // 가격
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40)); // 버튼 영역

            // 이미지
            picImage = new PictureBox()
            {
                Image = image,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Dock = DockStyle.Fill
            };

            // 메뉴명
            lblName = new Label()
            {
                Text = name,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            // 가격
            lblPrice = new Label()
            {
                Text = price + "원",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            // 수량 버튼
            var btnPanel = new FlowLayoutPanel()
            {
                FlowDirection = FlowDirection.LeftToRight,
                Dock = DockStyle.Fill,
                AutoSize = true,
                WrapContents = false,
                Padding = new Padding(20, 0, 0, 0)
            };
            btnPlus = new Button() { Text = "+", Width = 30, Height = 30 };
            btnMinus = new Button() { Text = "-", Width = 30, Height = 30 };
            btnPanel.Controls.Add(btnPlus);
            btnPanel.Controls.Add(btnMinus);

            layout.Controls.Add(picImage, 0, 0);
            layout.Controls.Add(lblName, 0, 1);
            layout.Controls.Add(lblPrice, 0, 2);
            layout.Controls.Add(btnPanel, 0, 3);

            this.Controls.Add(layout);
        }
    }

}
