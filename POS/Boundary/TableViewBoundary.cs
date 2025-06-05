using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using POS.Domain;

namespace POS.Boundary
{
    public partial class TableViewBoundary : MaterialForm
    {
        private AppDbContext _db = AppDbContext.Instance;
        private System.Windows.Forms.Timer _refreshTimer;
        private Dictionary<int, string> _lastTableSummaries = new();

        public TableViewBoundary()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            LoadTables(); // 최초 1회

            // 주기적 새로고침 타이머
            _refreshTimer = new System.Windows.Forms.Timer();
            _refreshTimer.Interval = 5000;
            _refreshTimer.Tick += (s, e) => LoadTables();
            _refreshTimer.Start();
        }

        public void LoadTables()
        {
            try
            {
                var tables = _db.Tables.OrderBy(t => t.Id).Take(10).ToList();

                // ✅ DB에서 실제 미결제 주문 + 아이템 포함 로드
                var unpaidOrders = _db.Orders
                    .Where(o => !o.IsPaid)
                    .Include(o => o.Items)
                    .ToList();

                // 🔁 삭제된 테이블 버튼 제거
                var tableIds = tables.Select(t => t.Id).ToHashSet();
                var buttonsToRemove = tableLayoutPanel1.Controls
                    .OfType<MaterialButton>()
                    .Where(b => !tableIds.Contains((int)b.Tag))
                    .ToList();

                foreach (var btn in buttonsToRemove)
                {
                    tableLayoutPanel1.Controls.Remove(btn);
                    btn.Dispose();
                    _lastTableSummaries.Remove((int)btn.Tag);
                }

                // ✅ 테이블 순서대로 버튼 생성 or 업데이트
                for (int i = 0; i < tables.Count; i++)
                {
                    var table = tables[i];
                    var order = unpaidOrders.FirstOrDefault(o => o.TableId == table.Id);
                    string summary = "";
                    string text = table.tableName;

                    if (order != null && order.Items != null && order.Items.Any())
                    {
                        var items = order.Items.ToList();
                        int totalPrice = items.Sum(item => item.TotalPrice);

                        string firstMenu = items[0].MenuName;
                        string summaryText = items.Count > 1
                            ? $"{firstMenu} 외 {items.Count - 1}"
                            : firstMenu;

                        summary = $"\n{summaryText}\n₩{totalPrice:N0}";
                    }

                    string fullText = text + summary;

                    if (_lastTableSummaries.TryGetValue(table.Id, out var prev) && prev == fullText)
                        continue;

                    _lastTableSummaries[table.Id] = fullText;

                    // ✅ 위치 계산 (2행 5열)
                    int col = i % 5;
                    int row = i / 5;

                    MaterialButton btn = tableLayoutPanel1.Controls
                        .OfType<MaterialButton>()
                        .FirstOrDefault(b => (int)b.Tag == table.Id);

                    if (btn != null)
                    {
                        btn.Text = fullText;
                    }
                    else
                    {
                        btn = new MaterialButton
                        {
                            Text = fullText,
                            Dock = DockStyle.Fill,
                            Tag = table.Id,
                            AutoSize = false
                        };
                        btn.Click += TableButton_Click;

                        tableLayoutPanel1.Controls.Add(btn, col, row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB 연결 실패: " + ex.Message, "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            if (sender is MaterialButton button && button.Tag is int tableId)
            {
                Form payAndOrderManagerBoundary = new OrderAndPayManagerBoundary(this, tableId);
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
}