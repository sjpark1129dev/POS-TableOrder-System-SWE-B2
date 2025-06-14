﻿using MaterialSkin.Controls;
using POS.Controller;
using POS.Domain;

namespace POS.Boundary
{
    public partial class TableManagerBoundary : MaterialForm
    {
        private TableController tableController = new TableController();
        private List<TableEntity> tableList;
        private int? selectedTableId = null;  // 선택된 테이블 ID 보관 (nullable int)
        private TableViewBoundary tableViewBoundary; // 테이블 뷰 바운더리 참조
        public TableManagerBoundary(TableViewBoundary tableViewBoundary)
        {
            InitializeComponent();
            tableList = tableController.GetAllTables();
            LoadTablesToPanel();
            this.tableViewBoundary = tableViewBoundary; // 테이블 뷰 바운더리 참조 저장
        }

        private void LoadTablesToPanel()
        {
            tableLayoutPanelTables.Controls.Clear(); // 기존 버튼 제거

            foreach (var table in tableList)
            {
                var btn = new Button();
                btn.Text = $"테이블: {table.tableName}";
                btn.Tag = table.Id;
                btn.Dock = DockStyle.Fill;
                btn.Margin = new Padding(10);
                btn.BackColor = Color.White; // 기본 배경 흰색

                btn.Click += TableButton_Click;

                tableLayoutPanelTables.Controls.Add(btn);
            }
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            selectedTableId = (int)btn.Tag;

            // 선택 강조 초기화
            foreach (Button b in tableLayoutPanelTables.Controls)
                b.BackColor = Color.White;

            btn.BackColor = Color.LightGreen;

            // 버튼에 저장된 ID로 테이블 정보 찾기
            var selectedTable = tableList.FirstOrDefault(t => t.Id == selectedTableId);

            if (selectedTable != null)
            {
                tableNameTextBox.Text = selectedTable.tableName;
                tableIdTextBox.Text = selectedTable.Id.ToString();
            }
        }
        private void textBoxResetButton_Click(object sender, EventArgs e)
        {
            selectedTableId = null;
            foreach (Button b in tableLayoutPanelTables.Controls)
                b.BackColor = Color.White;
            tableIdTextBox.Text = "";
            tableNameTextBox.Text = "";
        }

        private void tableCreateButton_Click(object sender, EventArgs e)
        {
            string newName = tableNameTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("테이블 이름을 입력하세요.");
                return;
            }

            if (tableList.Count >= 10)
            {
                MessageBox.Show("테이블은 최대 10개까지만 생성할 수 있습니다.");
                return;
            }

            if (tableController.IsDuplicateName(tableList, newName))
            {
                MessageBox.Show("이미 존재하는 테이블 이름입니다.");
                return;
            }

            tableController.CreateTable(newName);
            tableList = tableController.GetAllTables();
            tableIdTextBox.Text = "";
            tableNameTextBox.Text = "";
            LoadTablesToPanel();
        }

        private void tableDeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedTableId == null)
            {
                MessageBox.Show("삭제할 테이블을 선택하세요.");
                return;
            }
            
            tableController.RemoveTable((int)selectedTableId);
            tableList = tableController.GetAllTables();
            selectedTableId = null;
            tableIdTextBox.Text = "";
            tableNameTextBox.Text = "";
            LoadTablesToPanel();
        }
        private void tableEditSaveButton_Click(object sender, EventArgs e)
        {
            if (selectedTableId == null)
            {
                MessageBox.Show("수정할 테이블을 선택하세요.");
                return;
            }

            string newName = tableNameTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("테이블 이름을 입력하세요.");
                return;
            }

            // 이름이 중복되면 수정 금지 (단, 현재 선택된 테이블은 예외)
            if (tableList.Any(t => t.tableName.Equals(newName, StringComparison.OrdinalIgnoreCase) && t.Id != selectedTableId))
            {
                MessageBox.Show("이미 존재하는 테이블 이름입니다.");
                return;
            }

            var table = tableList.FirstOrDefault(t => t.Id == selectedTableId);
            table.tableName = newName;
            tableController.UpdateTable(table);
            tableList = tableController.GetAllTables();
            tableIdTextBox.Text = "";
            tableNameTextBox.Text = "";
            LoadTablesToPanel();
        }

        private void TableManagerBoundary_FormClosing(object sender, FormClosingEventArgs e)
        {
            tableViewBoundary.LoadTables();
        }
    }
}
