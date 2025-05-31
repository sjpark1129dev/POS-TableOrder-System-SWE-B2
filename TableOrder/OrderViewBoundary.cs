using MaterialSkin.Controls;

namespace TableOrder
{
    public partial class OrderViewBoundary : MaterialForm
    {
        public OrderViewBoundary()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {

            foreach (DataGridViewColumn column in OrderDataView.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            OrderDataView.Rows.Add("»ï°ã»ì", 3, 9000);
            OrderDataView.Rows.Add("¸ñ»ì", 2, 10000);
            OrderDataView.Rows.Add("Ç×Á¤»ì", 4, 12000);
            finalPrice.Text = "31,000¿ø";
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
