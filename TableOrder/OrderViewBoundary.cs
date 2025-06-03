using MaterialSkin.Controls;
using TableOrder.Repository;
using POS.Domain;


namespace TableOrder
{
    public partial class OrderViewBoundary : MaterialForm
    {
        private TableOrderHistoryRepository historyRepo;
        public OrderViewBoundary()
        {
            InitializeComponent();
            historyRepo = new TableOrderHistoryRepository();
            LoadData();
        }
        private void LoadData()
        {

            foreach (DataGridViewColumn column in OrderDataView.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            var orders = historyRepo.GetAllOrder();

            if (orders == null || orders.Count == 0)
            {
                MessageBox.Show("주문 내역이 없습니다.");
                return;
            }

            OrderDataView.Rows.Clear();

            int totalPrice = 0;

            foreach (var order in orders)
            {
                foreach (var item in order.Items)
                {
                    OrderDataView.Rows.Add(item.MenuName, item.Qty, item.TotalPrice);
                    totalPrice += item.TotalPrice;

                    
                }
            }
            int totalRowIndex = OrderDataView.Rows.Add(); // 새 행 추가
            var totalRow = OrderDataView.Rows[totalRowIndex];
            totalRow.Cells["총금액"].Value = $" {totalPrice:N0}원";
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
