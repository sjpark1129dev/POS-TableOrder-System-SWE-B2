using MaterialSkin;
using MaterialSkin.Controls;
using POS.Controller;
using POS.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Boundary
{
    public partial class MenuManagerBoundary : MaterialForm
    {
        private MenuCreateController menuCreateController = new MenuCreateController();
        private MenuEditController menuEditController = new MenuEditController();
        private MenuLoadController menuLoadController = new MenuLoadController();
        private MenuRemoveController menuRemoveController = new MenuRemoveController();
        private CategoryController categoryController = new CategoryController();
        private List<MenuEntity> menuList;
        private List<CategoryEntity> categoryList;
        private int? selectedMenuId = null;

        public MenuManagerBoundary()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridViewMenus.Columns.Clear(); // 기존 컬럼 제거
            dataGridViewMenus.AutoGenerateColumns = false;
            dataGridViewMenus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMenus.MultiSelect = false;
            dataGridViewMenus.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 메뉴 ID
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.HeaderText = "ID";
            idColumn.DataPropertyName = "Id";
            idColumn.Name = "Id";
            idColumn.Width = 50;
            dataGridViewMenus.Columns.Add(idColumn);

            // 메뉴명
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "메뉴명";
            nameColumn.DataPropertyName = "MenuName";
            nameColumn.Width = 150;
            dataGridViewMenus.Columns.Add(nameColumn);

            // 가격
            DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn();
            priceColumn.HeaderText = "가격";
            priceColumn.DataPropertyName = "MenuPrice";
            priceColumn.Width = 100;
            dataGridViewMenus.Columns.Add(priceColumn);

            LoadAllMenus(); // 초기 로딩
        }


        private void LoadAllMenus()
        {
            menuList = menuLoadController.MenuLoad();
            LoadAllCategories();
            RefreshMenuList();
        }

        private void LoadAllCategories()
        {
            categoryList = categoryController.GetAllCategory();
            comboBoxCategory.DisplayMember = "CategoryName"; // 보여줄 속성
            comboBoxCategory.ValueMember = "Id";             // 내부 값으로 쓸 속성
            comboBoxCategory.DataSource = categoryList;      // CategoryEntity 리스트
        }
        private void RefreshMenuList()
        {
            dataGridViewMenus.DataSource = null;
            dataGridViewMenus.DataSource = menuList;
        }

        private void menuCreateButton_Click(object sender, EventArgs e)
        {
            string name = menuNameTextBox.Text.Trim();
            string priceText = menuPriceTextBox.Text.Trim();

            // 유효성 검사
            if (string.IsNullOrWhiteSpace(name) || !int.TryParse(priceText, out int price))
            {
                MessageBox.Show("올바른 메뉴명과 가격을 입력하세요.");
                return;
            }

            // 중복 검사
            if (menuCreateController.Isduplicated(menuList, name))
            {
                MessageBox.Show("이미 존재하는 메뉴입니다.");
                return;
            }

            // ✅ 카테고리 선택 확인
            if (comboBoxCategory.SelectedValue == null)
            {
                MessageBox.Show("카테고리를 선택하세요.");
                return;
            }

            int categoryId = (int)comboBoxCategory.SelectedValue;

            // ✅ DB에 저장 (카테고리 ID 포함)
            menuCreateController.MenuCreate(name, price, categoryId);

            // 목록 다시 불러오기
            menuList = menuLoadController.MenuLoad();
            LoadAllMenus();
            MessageBox.Show("메뉴가 추가되었습니다.");
        }

        private void menuDeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenus.SelectedRows.Count == 0)
            {
                MessageBox.Show("삭제할 메뉴를 선택하세요.");
                return;
            }

            var value = dataGridViewMenus.SelectedRows[0].Cells["Id"].Value;

            if (value == null || !int.TryParse(value.ToString(), out int id))
            {
                MessageBox.Show("유효한 ID를 찾을 수 없습니다.");
                return;
            }

            var selectedMenu = menuList.FirstOrDefault(c => c.Id == id);
            if (selectedMenu == null)
            {
                MessageBox.Show("메뉴를 찾을 수 없습니다.");
                return;
            }

            menuRemoveController.MenuRemove(selectedMenu);
            selectedMenuId = null;
            LoadAllMenus();
        }

        private void menuEditButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenus.SelectedRows.Count == 0)
            {
                MessageBox.Show("수정할 메뉴를 선택하세요.");
                return;
            }

            var value = dataGridViewMenus.SelectedRows[0].Cells["Id"].Value;
            if (value == null || !int.TryParse(value.ToString(), out int id))
            {
                MessageBox.Show("유효한 ID를 찾을 수 없습니다.");
                return;
            }

            var selectedMenu = menuList.FirstOrDefault(c => c.Id == id);
            if (selectedMenu == null)
            {
                MessageBox.Show("메뉴를 찾을 수 없습니다.");
                return;
            }

            string newName = menuNameTextBox.Text.Trim();
            string newPriceText = menuPriceTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(newName) || !int.TryParse(newPriceText, out int newPrice))
            {
                MessageBox.Show("올바른 메뉴명과 가격을 입력하세요.");
                return;
            }

            if (comboBoxCategory.SelectedValue == null)
            {
                MessageBox.Show("카테고리를 선택하세요.");
                return;
            }

            int newCategoryId = (int)comboBoxCategory.SelectedValue;

            // 실제 수정
            selectedMenu.MenuName = newName;
            selectedMenu.MenuPrice = newPrice;
            selectedMenu.CategoryId = newCategoryId;

            // DB에 반영
            menuEditController.MenuEdit(selectedMenu);

            LoadAllMenus();
            MessageBox.Show("메뉴가 수정되었습니다.");
        }

        private void dataGridViewMenus_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewMenus.SelectedRows.Count == 0) return;

            var row = dataGridViewMenus.SelectedRows[0];
            selectedMenuId = (int)row.Cells["Id"].Value;

            var selectedMenu = menuList.FirstOrDefault(m => m.Id == selectedMenuId);
            if (selectedMenu != null)
            {
                menuNameTextBox.Text = selectedMenu.MenuName;
                menuPriceTextBox.Text = selectedMenu.MenuPrice.ToString();

                // ComboBox에서 해당 카테고리를 선택
                comboBoxCategory.SelectedValue = selectedMenu.CategoryId;
            }
        }

        private void CategoryManageButton_Click(object sender, EventArgs e)
        {
            MaterialForm categoryManagerForm = new CategoryManagerBoundary();
            categoryManagerForm.ShowDialog();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedValue != null)
            {
                int selectedCategoryId = (int)comboBoxCategory.SelectedValue;
                Console.WriteLine($"선택된 카테고리 ID: {selectedCategoryId}");

                // 필요하다면 CategoryEntity 객체도 얻기
                var selectedCategory = (CategoryEntity)comboBoxCategory.SelectedItem;
                string name = selectedCategory.CategoryName;
            }
        }

        private void menuResetButton_Click(object sender, EventArgs e)
        {
            menuNameTextBox.Text = string.Empty;
            menuPriceTextBox.Text = string.Empty;

            if (comboBoxCategory.Items.Count > 0)
            {
                comboBoxCategory.SelectedIndex = -1;
            }

            dataGridViewMenus.ClearSelection();
            selectedMenuId = null;
        }
    }
}
