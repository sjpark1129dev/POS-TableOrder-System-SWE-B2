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

        private void LoadTables()
        {
            try
            {
                var tables = _db.Tables.Take(10).ToList();
                var unpaidOrders = _db.Orders
                    .Where(o => !o.IsPaid)
                    .Include(o => o.Items)
                    .ToList();

                if (unpaidOrders.Count == 0)
                {
                    var dummyOrders = new List<OrderEntity>();
                    for (int i = 0; i < tables.Count; i++)
                    {
                        dummyOrders.Add(new OrderEntity
                        {
                            TableId = tables[i].Id,
                            IsPaid = false,
                            CreatedAt = DateTime.Now.AddMinutes(-i * 5),
                            Items = new List<OrderItemEntity>
                            {
                                new OrderItemEntity { MenuName = "김치찌개", Qty = 1, UnitPrice = 8000 },
                                new OrderItemEntity { MenuName = "계란말이", Qty = 1, UnitPrice = 3500 }
                            }
                        });
                    }
                    unpaidOrders = dummyOrders;
                }

                for (int i = 0; i < 10; i++)
                {
                    int col = i / 2;
                    int row = i % 2;

                    if (i >= tables.Count)
                    {
                        continue;
                    }

                    var table = tables[i];
                    string text = table.tableName;

                    var order = unpaidOrders.FirstOrDefault(o => o.TableId == table.Id);
                    string summary = "";

                    if (order != null && order.Items.Any())
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

                    // 이전 상태와 비교
                    if (_lastTableSummaries.TryGetValue(table.Id, out var prev) && prev == fullText)
                        continue;

                    _lastTableSummaries[table.Id] = fullText;

                    // 버튼이 이미 존재하는지 확인
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
                MessageBox.Show($"테이블 ID: {tableId} 클릭됨");
                Form payAndOrderManagerBoundary = new PayAndOrderManagerBoundary();
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
            Form tableManagerForm = new TableManagerBoundary();
            tableManagerForm.Show();
        }

        private void MenuManagerButton_Click(object sender, EventArgs e)
        {
            Form menuManagerBoundary = new MenuManagerBoundary();
            menuManagerBoundary.Show();
        }

        private void SalesManagerButton_Click(object sender, EventArgs e)
        {
            Form salesManagerBoundary = new SalesManagerBoundary();
            salesManagerBoundary.Show();
        }
    }
}