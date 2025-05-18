using POS.Controller;
using POS.Entity;
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
    public partial class MenuManagerBoundary : Form
    {
        private MenuController menuController = AppControllers.Instance.MenuController;
        private List<MenuEntity> menuList;
        private int? selectedMenuId = null;

        public MenuManagerBoundary()
        {
            InitializeComponent();
            menuList = menuController.GetAllMenus();
            InitializeDataGridView();
        }
        
        private void InitializeDataGridView()
        {
            dataGridViewMenus.AutoGenerateColumns = false;
            dataGridViewMenus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMenus.MultiSelect = false;
            dataGridViewMenus.DataSource = null;

            dataGridViewMenus.Columns.Clear();

            dataGridViewMenus.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 50,
                ReadOnly = true
            });
            dataGridViewMenus.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "메뉴명",
                DataPropertyName = "Name",
                Width = 150
            });
            dataGridViewMenus.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "가격",
                DataPropertyName = "Price",
                Width = 100
            });

            RefreshMenuList();
        }
        
        private void RefreshMenuList()
        {
            dataGridViewMenus.DataSource = null;
            dataGridViewMenus.DataSource = menuList.Where(m => m.State != EntityState.Deleted).ToList();
        }
        
        private void menuCreateButton_Click(object sender, EventArgs e)
        {
            string name = menuNameTextBox.Text.Trim();
            string priceText = menuPriceTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || !decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("올바른 메뉴명과 가격을 입력하세요.");
                return;
            }

            if (menuController.IsDuplicateName(menuList, name))
            {
                MessageBox.Show("이미 존재하는 메뉴입니다.");
                return;
            }

            // 바로 DB에 저장
            var newMenu = menuController.CreateMenu(name, price);
            menuController.SaveAllMenus(new List<MenuEntity> { newMenu });

            // 다시 전체 목록 로드해서 ID 포함된 상태로 반영
            menuList = menuController.GetAllMenus();
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
            menuController.MarkDeleted(menuList, id);
            selectedMenuId = null;
            RefreshMenuList();
        }
        
        private void menuSaveButton_Click(object sender, EventArgs e)
        {
            menuController.SaveAllMenus(menuList);

            foreach (var menu in menuList.ToList())
            {
                if (menu.State == EntityState.Deleted)
                    menuList.Remove(menu);
                else
                    menu.State = EntityState.Unchanged;
            }

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
                menuNameTextBox.Text = selectedMenu.Name;
                menuPriceTextBox.Text = selectedMenu.Price.ToString("N0");
            }
        }
    }
}
