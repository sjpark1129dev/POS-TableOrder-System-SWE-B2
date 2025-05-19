using POS.Controller;
using POS.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Boundary
{
    public partial class MenuManagerBoundary : Form
    {
        private readonly MenuController menuController = new MenuController();
        private List<MenuDto> menuList = new();
        private int? selectedMenuId = null;

        public MenuManagerBoundary()
        {
            InitializeComponent();
            LoadMenusAsync();
            InitializeDataGridView();
        }

        private async Task LoadMenusAsync()
        {
            menuList = await menuController.GetAllMenusAsync();
            RefreshMenuList();
        }

        private void InitializeDataGridView()
        {
            dataGridViewMenus.AutoGenerateColumns = false;
            dataGridViewMenus.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void RefreshMenuList()
        {
            dataGridViewMenus.DataSource = null;
            dataGridViewMenus.DataSource = menuList;
        }

        private async void menuCreateButton_Click(object sender, EventArgs e)
        {
            string name = menuNameTextBox.Text.Trim();
            string priceText = menuPriceTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || !int.TryParse(priceText, out int price))
            {
                MessageBox.Show("올바른 메뉴명과 가격을 입력하세요.");
                return;
            }

            if (menuController.IsDuplicateName(menuList, name))
            {
                MessageBox.Show("이미 존재하는 메뉴입니다.");
                return;
            }

            var success = await menuController.CreateMenuAsync(name, price);
            if (success)
            {
                await ReloadAndNotify("메뉴가 추가되었습니다.");
            }
            else
            {
                MessageBox.Show("추가 실패");
            }
        }

        private async void menuDeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenus.SelectedRows.Count == 0)
            {
                MessageBox.Show("삭제할 메뉴를 선택하세요.");
                return;
            }

            var id = (int)dataGridViewMenus.SelectedRows[0].Cells["Id"].Value;

            var success = await menuController.DeleteMenuAsync(id);
            if (success)
            {
                await ReloadAndNotify("삭제 완료");
            }
            else
            {
                MessageBox.Show("삭제 실패");
            }
        }

        private async void menuSaveButton_Click(object sender, EventArgs e)
        {
            if (selectedMenuId == null)
            {
                MessageBox.Show("수정할 메뉴를 선택하세요.");
                return;
            }

            string newName = menuNameTextBox.Text.Trim();
            string newPriceText = menuPriceTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(newName) || !int.TryParse(newPriceText, out int newPrice))
            {
                MessageBox.Show("올바른 입력을 확인하세요.");
                return;
            }

            var menu = menuList.FirstOrDefault(m => m.Id == selectedMenuId);
            if (menu == null) return;

            menu.Name = newName;
            menu.Price = newPrice;

            var success = await menuController.UpdateMenuAsync(menu);
            if (success)
            {
                await ReloadAndNotify("수정 완료");
            }
            else
            {
                MessageBox.Show("수정 실패");
            }
        }

        private async Task ReloadAndNotify(string message)
        {
            await LoadMenusAsync();
            MessageBox.Show(message);
            ClearSelection();
        }

        private void ClearSelection()
        {
            selectedMenuId = null;
            menuNameTextBox.Text = string.Empty;
            menuPriceTextBox.Text = string.Empty;
        }

        private void dataGridViewMenus_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewMenus.SelectedRows.Count == 0) return;

            var row = dataGridViewMenus.SelectedRows[0];
            selectedMenuId = (int)row.Cells["Id"].Value;

            var selectedMenu = menuList.FirstOrDefault(m => m.Id == selectedMenuId);
            if (selectedMenu != null)
            {
                menuNameTextBox.Text = selectedMenu.Name;
                menuPriceTextBox.Text = selectedMenu.Price.ToString("N0");
            }
        }
    }
}
