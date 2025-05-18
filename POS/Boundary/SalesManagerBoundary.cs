namespace SalesManagement
{
    public partial class SalesManagerBoundary : Form
    {
        public SalesManagerBoundary()
        {
            InitializeComponent();
            startDate.Value = DateTime.Now.AddDays(-7);
            LoadData();
        }
        private void LoadData()
        {

            foreach (DataGridViewColumn column in SalesDataView.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            SalesDataView.Rows.Add("2024-05-01", "R001", "����", 3, 9000);
            SalesDataView.Rows.Add("2024-05-01", "R001", "���", 2, 10000);
            SalesDataView.Rows.Add("2024-05-01", "R001", "������", 4, 12000);
        }

        private void menutxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
