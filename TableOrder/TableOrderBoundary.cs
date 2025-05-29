using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.Domain;
using TableOrder.Controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TableOrder
{
    public partial class TableOrderBoundary : Form
    {
        private List<CartItem> cart = new List<CartItem>();
        private List<string> categoryList = new List<string>();
        private TableOrderMainController _controller;
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
                item.OnPlusClicked += MenuItemPlusClicked;
                flowLayoutPanelMenus.Controls.Add(item);
            }
        }
        private void MenuItemPlusClicked(object sender, MenuEntity menu)
        {
            cart.Add(menu);
            RefreshCart();
        }
        public class CartItem
        {
            public MenuEntity Menu { get; set; }
            public int Quantity { get; set; }
        }
        private void RefreshCart()
        {
            shoppingList.Items.Clear();
            foreach (var item in cart)
            {
                shoppingList.Items.Add($"{item.menuName} - {item.menuPrice}원");
            }
        }
        private void orderButton_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("장바구니가 비어 있습니다.");
                return;
            }

            _controller.OrderRequest(cart);
            MessageBox.Show("주문이 완료되었습니다!");
            cart.Clear();
            RefreshCart();
        }

        private void orderCheckButton_Click(object sender, EventArgs e)
        {
            var historyForm = new OrderViewBoundary();
            historyForm.ShowDialog();
        }
    }
    public class MenuItemControl : UserControl
    {
        public Label lblName;
        public Label lblPrice;
        public Button btnPlus;
        public Button btnMinus;
        public PictureBox picImage;

        public MenuEntity MenuData { get; private set; }

        // 델리게이트 정의
        public event EventHandler<MenuEntity> OnPlusClicked;

        public MenuItemControl(string name, int price, Image image)
        {
            this.Width = 140;
            this.Height = 180;

            MenuData = new MenuEntity
            {
                menuName = name,
                menuPrice = price
            };

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

            btnPlus.Click += (s, e) => OnPlusClicked?.Invoke(this, MenuData);

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
