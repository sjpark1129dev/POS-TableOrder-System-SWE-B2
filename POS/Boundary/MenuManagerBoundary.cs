using POS.Controller;
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

namespace POS.Boundary
{
    public partial class MenuManagerBoundary : Form
    {
        private MenuCreateController menuCreateController = new MenuCreateController();
        private MenuEditController menuEditController = new MenuEditController();
        private MenuLoadController menuLoadController = new MenuLoadController();
        private MenuRemoveController menuRemoveController = new MenuRemoveController();
        private List<MenuEntity> menuList;
        private int? selectedMenuId = null;

        public MenuManagerBoundary()
        {
            InitializeComponent();
            LoadAllMenus();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridViewMenus.AutoGenerateColumns = false;
            dataGridViewMenus.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            LoadAllMenus();
        }

        private void LoadAllMenus()
        {
            menuList = menuLoadController.MenuLoad();
            RefreshMenuList();
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

            if (string.IsNullOrWhiteSpace(name) || !int.TryParse(priceText, out int price))
            {
                MessageBox.Show("올바른 메뉴명과 가격을 입력하세요.");
                return;
            }

            if (menuCreateController.Isduplicated(menuList, name))
            {
                MessageBox.Show("이미 존재하는 메뉴입니다.");
                return;
            }

            // 바로 DB에 저장
            menuCreateController.MenuCreate(name, price);

            // 다시 전체 목록 로드해서 ID 포함된 상태로 반영
            menuList = menuLoadController.MenuLoad();
            RefreshMenuList();
            MessageBox.Show("메뉴가 추가되었습니다.");
        }
        
        private void menuDeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenus.SelectedRows.Count == 0)
            {
                MessageBox.Show("삭제할 메뉴를 선택하세요.");
                return;
            }

            var id = (int)dataGridViewMenus.SelectedRows[0].Cells["Id"].Value;

            selectedMenuId = null;
            RefreshMenuList();
        }
        
        private void menuSaveButton_Click(object sender, EventArgs e)
        {
            RefreshMenuList();
            MessageBox.Show("저장 완료");
        }

        private void dataGridViewMenus_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewMenus.SelectedRows.Count == 0) return;

            var row = dataGridViewMenus.SelectedRows[0];
            selectedMenuId = (int)row.Cells["Id"].Value;

            var selectedMenu = menuList.FirstOrDefault(m => m.Id == selectedMenuId);
            if (selectedMenu != null)
            {
                menuNameTextBox.Text = selectedMenu.menuName;
                menuPriceTextBox.Text = selectedMenu.menuPrice.ToString("N0");
            }
        }
    }
}
