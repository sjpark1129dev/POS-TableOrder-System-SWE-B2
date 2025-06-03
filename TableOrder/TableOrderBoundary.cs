using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using POS.Domain;
using TableOrder.Controller;
using POS.Controller;
using POS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace TableOrder
{
   

    public partial class TableOrderBoundary : MaterialForm
    {
        private List<CartItem> cart = new List<CartItem>();
        private List<string> categoryList = new List<string>();
        private TableOrderMainController _controller;
        private MenuLoadController menuController;
        private List<MenuEntity> allMenus;
        private List<CategoryEntity> allCategories;
        private MaterialComboBox comboBoxTableSelector;
        private TableController tableController;
        private int selectedTableId = -1;
        private Label labelSelectedTable;



        public TableOrderBoundary()
        {
            InitializeComponent();
            tableController = new TableController();
            comboBoxTableSelector = new MaterialComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Width = 200,
                Location = new Point(200, 480), // 위치 조정
                Font = new Font("맑은 고딕", 10),
                Hint = "테이블 선택"
            };

            // 테이블 목록 불러오기
            var tableList = tableController.GetAllTables();
            comboBoxTableSelector.DataSource = tableList;
            comboBoxTableSelector.DisplayMember = "tableName";
            comboBoxTableSelector.ValueMember = "Id";

            // 선택 변경 이벤트
            comboBoxTableSelector.SelectedIndexChanged += ComboBoxTableSelector_SelectedIndexChanged;
            
            // 폼에 추가
            this.Controls.Add(comboBoxTableSelector);
            comboBoxTableSelector.BringToFront(); // 다른 컨트롤에 가리지 않게

            labelSelectedTable = new Label
            {
                Text = "선택된 테이블: 없음",
                Location = new Point(420, 480),  // comboBox 오른쪽 위치 추천
                AutoSize = true,
                Font = new Font("맑은 고딕", 10, FontStyle.Bold)
            };
            this.Controls.Add(labelSelectedTable);
            labelSelectedTable.BringToFront(); // 다른 컨트롤에 가리지 않게

            _controller = new TableOrderMainController();
            categoryController = new CategoryController();
            menuController = new MenuLoadController();
            allMenus = menuController.MenuLoad();   // DB에서 전체 메뉴 로드
            allCategories = categoryController.GetAllCategory(); // 전체 카테고리도 로드
            LoadCategoryButtons();   // DB에서 불러온 카테고리로 버튼 생성
            LoadMenuItems(-1);
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Font = new Font("맑은 고딕", 10, FontStyle.Bold);
            labelTotalPrice.Text = "총 가격: 0원";
            labelTotalPrice.BringToFront();
           


            
        }
       
        private void ComboBoxTableSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTableSelector.SelectedItem is TableEntity selectedTable)
            {
                selectedTableId = selectedTable.Id;
                labelSelectedTable.Text = $"선택된 테이블: {selectedTable.tableName}";
                
            }
        }

        private CategoryController categoryController;
        private void LoadCategoryButtons()
        {
            flowLayoutPanelCategory.Controls.Clear();

            var categories = categoryController.GetAllCategory(); // DB에서 카테고리 목록 불러오기

            foreach (var cat in categories)
            {
                var btn = new MaterialButton()
                {
                    Text = cat.CategoryName,
                    Width = 130,
                    Height = 70,
                    MinimumSize = new Size(130, 70), // 최소 크기 보장
                    Tag = cat.Id, // 나중에 클릭 시 어떤 카테고리인지 알 수 있음
                    AutoSize = false,
                    HighEmphasis = true,
                    Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
                };

                // 클릭 이벤트에 연결 (추후 메뉴 필터링에 사용)
                btn.Click += CategoryButton_Click;
               
                flowLayoutPanelCategory.Controls.Add(btn);
            }
        }
       
        private void LoadMenuItems(int categoryId)
        {
            flowLayoutPanelMenus.Controls.Clear();

            Bitmap dummyImage = new Bitmap(100, 100);
            using (Graphics g = Graphics.FromImage(dummyImage))
            {
                g.Clear(Color.Gray);
                g.DrawString("Image", new Font("Arial", 10), Brushes.White, new PointF(10, 40));
            }

            List<MenuEntity> filteredMenus = (categoryId == -1)
                ? allMenus
                : allMenus.Where(m => m.CategoryId == categoryId).ToList();

            foreach (var menu in filteredMenus)
            {
                
                var item = new MenuItemControl(menu.MenuName, menu.MenuPrice, dummyImage)
                {
                    MenuData = menu
                };
                item.OnPlusClicked += MenuItemPlusClicked;
                item.OnMinusClicked += MenuItemMinusClicked;
                flowLayoutPanelMenus.Controls.Add(item);
            }
        }
        private void CategoryButton_Click(object sender, EventArgs e)
        {
            if (sender is MaterialButton btn && btn.Tag is int categoryId)
            {
                LoadMenuItems(categoryId);
            }
        }



        
        private void MenuItemPlusClicked(object sender, MenuEntity menu)
        {
            var existingItem = cart.FirstOrDefault(c => c.Menu.MenuName == menu.MenuName);
            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                cart.Add(new CartItem(menu));
            }

            RefreshCart();
        }
        private void MenuItemMinusClicked(object sender, MenuEntity menu)
        {
            var existing = cart.FirstOrDefault(c => c.Menu.MenuName == menu.MenuName);

            if (existing != null)
            {
                existing.Quantity--;

                if (existing.Quantity <= 0)
                {
                    cart.Remove(existing);
                }

                RefreshCart();
            }
        }
        public class CartItem
        {
            public MenuEntity Menu { get; set; }
            public int Quantity { get; set; }

            public CartItem(MenuEntity menu)
            {
                Menu = menu;
                Quantity = 1;
            }
        }

        private void RefreshCart()
        {
            shoppingList.Items.Clear();

            int total = 0;
            foreach (var item in cart)
            {
                int lineTotal = item.Menu.MenuPrice * item.Quantity;
                shoppingList.Items.Add($"{item.Menu.MenuName}  {item.Quantity}개 {lineTotal}원");
                total += lineTotal;
            }

            labelTotalPrice.Text = $"총 가격: {total:N0}원";

            
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            
            if (cart.Count == 0)
            {
                MessageBox.Show("장바구니가 비어 있습니다.");
                return;
            }

            var orderList = cart.SelectMany(c => Enumerable.Repeat(c.Menu, c.Quantity)).ToList();
            _controller.OrderRequest(selectedTableId, orderList);
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

        public MenuEntity MenuData { get;  set; }

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
            btnPlus = new MaterialButton() { Text = "+", Width = 30, Height = 30,
                Type = MaterialButton.MaterialButtonType.Contained,
                HighEmphasis = true,
               
                AutoSize = false,
                Density = MaterialButton.MaterialButtonDensity.Default
            };
            btnMinus = new MaterialButton() { Text = "-", Width = 30, Height = 30,
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
