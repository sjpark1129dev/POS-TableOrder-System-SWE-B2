using MaterialSkin.Controls;
using TableOrder.Repository;
using POS.Domain;


namespace TableOrder
{
    public partial class OrderViewBoundary : MaterialForm
    {
        private TableOrderHistoryRepository historyRepo;
        private int selectedTableId;
        // 생성자
        public OrderViewBoundary(int selectedTableId)
        {
            InitializeComponent();
            this.selectedTableId = selectedTableId;
            historyRepo = new TableOrderHistoryRepository();

            OrderDataView.AllowUserToAddRows = false;
        }
        private void LoadData()
        {
            foreach (DataGridViewColumn column in OrderDataView.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            var orders = historyRepo.GetUnpaidOrdersByTable(selectedTableId); // 변경

            if (orders == null || orders.Count == 0)
            {
                MessageBox.Show("해당 테이블의 미결제 주문이 없습니다.");
                this.DialogResult = DialogResult.Cancel; // 이유 전달
                this.Close();
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

            finalPrice.Text = $"총액: {totalPrice:N0}원";
        }

        private void OrderViewBoundary_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
