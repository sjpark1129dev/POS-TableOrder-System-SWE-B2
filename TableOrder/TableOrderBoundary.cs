using MaterialSkin.Controls;
using POS.Domain;
using TableOrder.Controller;
using POS.Controller;
using TableOrder.Controls;
using TableOrder.Entity;

namespace TableOrder
{
    public partial class TableOrderBoundary : MaterialForm
    {
        private System.Windows.Forms.Timer refreshTimer;
        private List<CartItem> cart = new List<CartItem>();
        private TableOrderMainController tableOrderMainController;
        private List<MenuEntity> allMenus;
        private List<CategoryEntity> allCategories;
        private int selectedTableId;

        public TableOrderBoundary()
        {
            InitializeComponent();
            tableOrderMainController = new TableOrderMainController();

            InitializeTableSelector();

            allMenus = tableOrderMainController.LoadMenus();
            allCategories = tableOrderMainController.LoadCategories();

            LoadCategoryButtons();
            LoadMenuItems(-1);

            // 가격 라벨 설정
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Font = new Font("맑은 고딕", 10, FontStyle.Bold);
            labelTotalPrice.Text = "총 가격: 0원";
            labelTotalPrice.BringToFront();

            // ✅ 주기적 갱신 타이머
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 5000; // 5초마다 확인
            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Start();
        }
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            var newMenus = tableOrderMainController.LoadMenus();
            var newCategories = tableOrderMainController.LoadCategories();

            bool menusChanged = !MenusEqual(allMenus, newMenus);
            bool categoriesChanged = !CategoriesEqual(allCategories, newCategories);

            if (menusChanged)
            {
                allMenus = newMenus;
                LoadMenuItems(-1); // 전체 메뉴 갱신
            }

            if (categoriesChanged)
            {
                allCategories = newCategories;
                LoadCategoryButtons(); // 카테고리 버튼 재로딩
            }
        }
        private bool MenusEqual(List<MenuEntity> oldList, List<MenuEntity> newList)
        {
            if (oldList.Count != newList.Count)
                return false;

            return oldList.OrderBy(m => m.Id).Zip(newList.OrderBy(m => m.Id), (old, newer) =>
                old.Id == newer.Id &&
                old.MenuName == newer.MenuName &&
                old.MenuPrice == newer.MenuPrice &&
                old.CategoryId == newer.CategoryId &&
                (old.MenuImage == null && newer.MenuImage == null ||
                 old.MenuImage != null && newer.MenuImage != null && old.MenuImage.SequenceEqual(newer.MenuImage))
            ).All(equal => equal);
        }

        private bool CategoriesEqual(List<CategoryEntity> oldList, List<CategoryEntity> newList)
        {
            if (oldList.Count != newList.Count)
                return false;

            return oldList.OrderBy(c => c.Id).Zip(newList.OrderBy(c => c.Id), (a, b) =>
                a.Id == b.Id && a.CategoryName == b.CategoryName
            ).All(equal => equal);
        }
        private void InitializeTableSelector()
        {
            var tableList = tableOrderMainController.GetAllTables();
            comboBoxTableSelector.DataSource = tableList;
            selectedTableId = tableList[0].Id;
            comboBoxTableSelector.DisplayMember = "tableName";
            comboBoxTableSelector.ValueMember = "Id";

            comboBoxTableSelector.SelectedIndexChanged += ComboBoxTableSelector_SelectedIndexChanged;
        }
        private void ComboBoxTableSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTableSelector.SelectedItem is TableEntity selectedTable)
            {
                selectedTableId = selectedTable.Id;
            }
        }
        private void LoadCategoryButtons()
        {
            flowLayoutPanelCategory.Controls.Clear();


            foreach (var cat in allCategories)
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
        private void CategoryButton_Click(object sender, EventArgs e)
        {
            if (sender is MaterialButton button && button.Tag is int categoryId)
            {
                LoadMenuItems(categoryId);
            }
        }
        private void LoadMenuItems(int categoryId)
        {
            flowLayoutPanelMenus.WrapContents = true;
            flowLayoutPanelMenus.Controls.Clear();
            flowLayoutPanelMenus.AutoScroll = true;
            List<MenuEntity> filteredMenus = (categoryId == -1)
                ? allMenus
                : allMenus.Where(m => m.CategoryId == categoryId).ToList();

            foreach (var menu in filteredMenus)
            {
                // 이미지 데이터 → Bitmap 변환
                Bitmap imageToShow;
                if (menu.MenuImage != null)
                {
                    using var ms = new MemoryStream(menu.MenuImage);
                    imageToShow = new Bitmap(ms);
                }
                else
                {
                    // 대체 이미지
                    imageToShow = new Bitmap(100, 100);
                    using (Graphics g = Graphics.FromImage(imageToShow))
                    {
                        g.Clear(Color.Gray);
                        g.DrawString("No Image", new Font("Arial", 10), Brushes.White, new PointF(10, 40));
                    }
                }

                var item = new MenuItemControl(menu.MenuName, menu.MenuPrice, imageToShow)
                {
                    MenuData = menu,
                    Width = 120,
                    Height = 190
                };

                item.OnPlusClicked += MenuItemPlusClicked;
                item.OnMinusClicked += MenuItemMinusClicked;
                flowLayoutPanelMenus.Controls.Add(item);
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
            else
            {
                MessageBox.Show("장바구니에 해당 메뉴가 없습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            tableOrderMainController.OrderRequest(selectedTableId, orderList);
            MessageBox.Show("주문이 완료되었습니다!");
            cart.Clear();
            RefreshCart();
        }

        private void orderCheckButton_Click(object sender, EventArgs e)
        {
            var historyForm = new OrderViewBoundary(selectedTableId);
            historyForm.ShowDialog();
        }
    }

}
