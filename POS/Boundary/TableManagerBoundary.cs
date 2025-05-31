using MaterialSkin.Controls;
using POS.Controller;
using POS.Domain;

namespace POS.Boundary
{
    public partial class TableManagerBoundary : MaterialForm
    {
        private TableController tableController = new TableController();
        private List<TableEntity> tableList;
        private int? selectedTableId = null;  // 선택된 테이블 ID 보관 (nullable int)
        public TableManagerBoundary()
        {
            InitializeComponent();
            tableList = tableController.GetAllTables();
            LoadTablesToPanel();
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
                btn.BackColor = Color.White; // ✅ 기본 배경 흰색

                btn.Click += TableButton_Click;

                tableLayoutPanelTables.Controls.Add(btn);
            }
        }

        private void tableCreateButton_Click(object sender, EventArgs e)
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

            var newTable = tableController.CreateTable(newName);
            tableList.Add(newTable);
            LoadTablesToPanel();
        }

        private void tableDeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedTableId == null)
            {
                MessageBox.Show("삭제할 테이블을 선택하세요.");
                return;
            }

            tableController.MarkDeleted(tableList, selectedTableId.Value);
            selectedTableId = null;
            LoadTablesToPanel();
        }

        private void tableSaveButton_Click(object sender, EventArgs e)
        {
            LoadTablesToPanel(); // UI 갱신
            MessageBox.Show("저장 완료");
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
            else
            {
                tableNameTextBox.Text = "선택 안됨";
                tableIdTextBox.Text = "선택 안됨";
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
            // 폼의 모든 컨트롤 순회해서 마우스다운 이벤트 연결
            AttachMouseDownHandlers(this);
        }
        private void AttachMouseDownHandlers(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                // 버튼은 제외
                if (ctrl is Button) continue;

                ctrl.MouseDown += NonButtonControl_MouseDown;

                // 컨테이너 안에 또 컨트롤이 있다면 재귀적으로 적용
                if (ctrl.HasChildren)
                    AttachMouseDownHandlers(ctrl);
            }
        }
        private void NonButtonControl_MouseDown(object sender, MouseEventArgs e)
        {
            ClearSelection();
        }

        private void textBoxResetButton_Click(object sender, EventArgs e)
        {

        }
    }
}
