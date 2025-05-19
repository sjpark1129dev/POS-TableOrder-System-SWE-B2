using POS.Controller;
using POS.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Boundary
{
    public partial class TableManagerBoundary : Form
    {
        private readonly TableController tableController = new TableController();
        private List<TableDto> tableList = new();
        private int? selectedTableId = null;

        public TableManagerBoundary()
        {
            InitializeComponent();
            _ = LoadTablesAsync(); // async 호출
        }
        private async Task LoadTablesAsync()
        {
            tableList = await tableController.GetAllTablesAsync();
            LoadTablesToPanel();
        }

        private void LoadTablesToPanel()
        {
            tableLayoutPanelTables.Controls.Clear();

            foreach (var table in tableList)
            {
                var btn = new Button
                {
                    Text = $"테이블: {table.Name}",
                    Tag = table.Id,
                    Dock = DockStyle.Fill,
                    Margin = new Padding(10),
                    BackColor = Color.White
                };

                btn.Click += TableButton_Click;

                tableLayoutPanelTables.Controls.Add(btn);
            }
        }

        private async void tableCreateButton_Click(object sender, EventArgs e)
        {
            string newName = tableNameTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("테이블 이름을 입력하세요.");
                return;
            }

            if (tableController.IsDuplicateName(tableList, newName))
            {
                MessageBox.Show("이미 존재하는 테이블 이름입니다.");
                return;
            }

            var success = await tableController.CreateTableAsync(newName);
            if (success)
            {
                await ReloadAndNotify("테이블이 추가되었습니다.");
            }
            else
            {
                MessageBox.Show("추가 실패");
            }
        }

        private async void tableDeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedTableId == null)
            {
                MessageBox.Show("삭제할 테이블을 선택하세요.");
                return;
            }

            var success = await tableController.DeleteTableAsync(selectedTableId.Value);
            if (success)
            {
                await ReloadAndNotify("삭제 완료");
            }
            else
            {
                MessageBox.Show("삭제 실패");
            }
        }

        private async void tableSaveButton_Click(object sender, EventArgs e)
        {
            if (selectedTableId == null)
            {
                MessageBox.Show("수정할 테이블을 선택하세요.");
                return;
            }

            var table = tableList.FirstOrDefault(t => t.Id == selectedTableId);
            if (table == null) return;

            string newName = tableNameTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("수정할 이름을 입력하세요.");
                return;
            }

            table.Name = newName;
            var success = await tableController.UpdateTableAsync(table);

            if (success)
            {
                await ReloadAndNotify("수정 완료");
            }
            else
            {
                MessageBox.Show("수정 실패");
            }
        }

        private async Task ReloadAndNotify(string msg)
        {
            await LoadTablesAsync();
            MessageBox.Show(msg);
            ClearSelection();
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            selectedTableId = (int)btn.Tag;

            foreach (Button b in tableLayoutPanelTables.Controls)
                b.BackColor = Color.White;

            btn.BackColor = Color.LightGreen;

            var selectedTable = tableList.FirstOrDefault(t => t.Id == selectedTableId);
            if (selectedTable != null)
            {
                tableNameTextBox.Text = selectedTable.Name;
                tableIdTextBox.Text = selectedTable.Id.ToString();
            }
        }

        private void ClearSelection()
        {
            selectedTableId = null;
            foreach (Button b in tableLayoutPanelTables.Controls)
                b.BackColor = Color.White;

            tableNameTextBox.Text = "선택 안됨";
            tableIdTextBox.Text = "선택 안됨";
        }

        private void TableManagerBoundary_Load(object sender, EventArgs e)
        {
            AttachMouseDownHandlers(this);
        }

        private void AttachMouseDownHandlers(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is Button) continue;
                ctrl.MouseDown += NonButtonControl_MouseDown;
                if (ctrl.HasChildren)
                    AttachMouseDownHandlers(ctrl);
            }
        }

        private void NonButtonControl_MouseDown(object sender, MouseEventArgs e)
        {
            ClearSelection();
        }
    }
}
