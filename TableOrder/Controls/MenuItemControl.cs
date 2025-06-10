using System;
using System.Drawing;
using System.Windows.Forms;
using POS.Domain;
using MaterialSkin.Controls;

namespace TableOrder.Controls
{
    public class MenuItemControl : UserControl
    {
        public Label lblName;
        public Label lblPrice;
        public Button btnPlus;
        public Button btnMinus;
        public PictureBox picImage;

        public MenuEntity MenuData { get; set; }

        // 델리게이트 정의
        public event EventHandler<MenuEntity> OnPlusClicked;
        public event EventHandler<MenuEntity> OnMinusClicked;
        public MenuItemControl(string name, int price, Image image)
        {
            this.Width = 140;
            this.Height = 180;

            MenuData = new MenuEntity
            {
                MenuName = name,
                MenuPrice = price
            };

            var layout = new TableLayoutPanel();
            layout.RowCount = 4;
            layout.ColumnCount = 1;
            layout.Dock = DockStyle.Fill;
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50)); // 이미지
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20)); // 메뉴명
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 25)); // 가격
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50)); // 버튼 영역

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
                Padding = new Padding(20, 0, 0, 0),
                Margin = new Padding(0, -5, 0, 0)
            };
            btnPlus = new MaterialButton()
            {
                Text = "+",
                Width = 30,
                Height = 30,
                Type = MaterialButton.MaterialButtonType.Contained,
                HighEmphasis = true,

                AutoSize = false,
                Density = MaterialButton.MaterialButtonDensity.Default
            };
            btnMinus = new MaterialButton()
            {
                Text = "-",
                Width = 30,
                Height = 30,
                Type = MaterialButton.MaterialButtonType.Contained,
                HighEmphasis = true,

                AutoSize = false,
                Density = MaterialButton.MaterialButtonDensity.Default
            };

            btnPlus.Click += (s, e) => OnPlusClicked?.Invoke(this, MenuData);
            btnMinus.Click += (s, e) => OnMinusClicked?.Invoke(this, MenuData);

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