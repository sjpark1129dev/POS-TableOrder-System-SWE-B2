using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using POS.Domain;
using System.Linq;
using System.Windows.Forms;

namespace POS.Boundary
{
    public partial class TableViewBoundary : MaterialForm
    {
        private AppDbContext _db = AppDbContext.Instance;

        public TableViewBoundary()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            LoadTables();
        }
        private void LoadTables()
        {
            var tables = _db.Tables.Take(10).ToList();

            // 미결제 주문 (Items 포함)
            var unpaidOrders = _db.Orders
                .Where(o => !o.IsPaid)
                .Include(o => o.Items) // 중요!
                .OrderByDescending(o => o.CreatedAt)
                .ToList();

            // ✅ 더미 데이터 삽입 (만약 주문이 없으면)
            if (unpaidOrders.Count == 0)
            {
                var dummyOrders = new List<OrderEntity>();

                for (int i = 0; i < tables.Count; i++)
                {
                    var dummy = new OrderEntity
                    {
                        TableId = tables[i].Id,
                        IsPaid = false,
                        CreatedAt = DateTime.Now.AddMinutes(-i * 5),
                        Items = new List<OrderItemEntity>
                {
                    new OrderItemEntity { MenuName = "김치찌개", Qty = 1, UnitPrice = 8000 },
                    new OrderItemEntity { MenuName = "계란말이", Qty = 1, UnitPrice = 3500 }
                }
                    };
                    dummyOrders.Add(dummy);
                }

                unpaidOrders = dummyOrders;
            }

            tableLayoutPanel1.Controls.Clear();

            for (int i = 0; i < 10; i++)
            {
                int col = i / 2;
                int row = i % 2;

                if (i < tables.Count)
                {
                    var table = tables[i];
                    string text = table.tableName;

                    var order = unpaidOrders.FirstOrDefault(o => o.TableId == table.Id);

                    if (order != null && order.Items.Any())
                    {
                        var items = order.Items.ToList();
                        int totalPrice = items.Sum(item => item.TotalPrice);

                        string firstMenu = items[0].MenuName;
                        string summaryText = items.Count > 1
                            ? $"{firstMenu} 외 {items.Count - 1}"
                            : firstMenu;

                        text += $"\n{summaryText}\n₩{totalPrice:N0}";
                    }

                    var btn = new MaterialButton
                    {
                        Text = text,
                        Dock = DockStyle.Fill,
                        Tag = table.Id,
                        AutoSize = false
                    };
                    btn.Click += TableButton_Click;

                    tableLayoutPanel1.Controls.Add(btn, col, row);
                }
                else
                {
                    var placeholder = new Panel { Dock = DockStyle.Fill };
                    tableLayoutPanel1.Controls.Add(placeholder, col, row);
                }
            }
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            var button = sender as MaterialButton;
            int tableId = (int)button.Tag;
            MessageBox.Show($"테이블 ID: {tableId} 클릭됨");
            Form payAndOrderManagerBoundary = new PayAndOrderManagerBoundary();
            payAndOrderManagerBoundary.ShowDialog();
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