using MaterialSkin;
using MaterialSkin.Controls;
using POS.Controller; // ✅ 컨트롤러 추가
using POS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;

namespace POS.Boundary
{
    public partial class TableViewBoundary : MaterialForm
    {
        private TableController _tableController;
        private OrderAndPayController _orderController;
        private System.Windows.Forms.Timer _refreshTimer;
        private Dictionary<int, string> _lastTableSummaries = new();

        public TableViewBoundary()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            _tableController = new TableController();
            _orderController = new OrderAndPayController();

            LoadTables();
            　
            _refreshTimer = new System.Windows.Forms.Timer();
            _refreshTimer.Interval = 60000;
            _refreshTimer.Tick += (s, e) => LoadTables();
            _refreshTimer.Start();
        }

        public void LoadTables()
        {
            try
            {
                var tables = _tableController.GetAllTables();

                if (!IsTableStateChanged(tables, out var currentSummaries))
                    return; // 변경 없음 → UI 갱신 안 함

                // 변경 감지됨 → 전체 다시 그리기
                tableLayoutPanel1.Controls.Clear();
                _lastTableSummaries = currentSummaries;

                for (int i = 0; i < tables.Count; i++)
                {
                    var table = tables[i];
                    string fullText = currentSummaries[table.Id];
                    int col = i % 5;
                    int row = i / 5;

                    var btn = new MaterialButton
                    {
                        Text = fullText,
                        Dock = DockStyle.Fill,
                        Tag = new TableInfo { TableId = table.Id, TableName = table.tableName },
                        AutoSize = false
                    };
                    btn.Click += TableButton_Click;
                    tableLayoutPanel1.Controls.Add(btn, col, row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB 연결 실패: " + ex.Message, "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsTableStateChanged(List<TableEntity> newTableList, out Dictionary<int, string> newSummaries)
        {
            newSummaries = new Dictionary<int, string>();
            bool changed = false;

            foreach (var table in newTableList)
            {
                var items = _orderController.GetUnpaidOrderItemsByTable(table.Id);

                string summary = "";
                string text = table.tableName;

                if (items != null && items.Count > 0)
                {
                    string firstMenu = items[0]?.MenuName ?? "메뉴없음";
                    int totalPrice = items.Sum(item => Convert.ToInt32(item.Total));
                    string summaryText = items.Count > 1 ? $"{firstMenu} 외 {items.Count - 1}" : firstMenu;
                    summary = $"\n{summaryText}\n\u20A9{totalPrice:N0}";
                }

                string fullText = text + summary;
                newSummaries[table.Id] = fullText;

                if (!_lastTableSummaries.TryGetValue(table.Id, out var prevText) || prevText != fullText)
                    changed = true;
            }

            // 테이블 삭제 여부 확인
            var deletedTableIds = _lastTableSummaries.Keys.Except(newSummaries.Keys);
            if (deletedTableIds.Any())
                changed = true;

            return changed;
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            if (sender is MaterialButton button && button.Tag is TableInfo info)
            {
                Form payAndOrderManagerBoundary = new OrderAndPayManagerBoundary(this, info.TableId, info.TableName);
                payAndOrderManagerBoundary.ShowDialog();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _refreshTimer?.Stop();
            _refreshTimer?.Dispose();
            base.OnFormClosing(e);
        }

        private void TableManagerButton_Click(object sender, EventArgs e)
        {
            Form tableManagerForm = new TableManagerBoundary(this);
            tableManagerForm.ShowDialog();
        }

        private void MenuManagerButton_Click(object sender, EventArgs e)
        {
            Form menuManagerBoundary = new MenuManagerBoundary(this);
            menuManagerBoundary.ShowDialog();
        }

        private void SalesManagerButton_Click(object sender, EventArgs e)
        {
            Form salesManagerBoundary = new SalesManagerBoundary(this);
            salesManagerBoundary.ShowDialog();
        }
    }
    public class TableInfo
    {
        public int TableId { get; set; }
        public string TableName { get; set; }
    }
}
