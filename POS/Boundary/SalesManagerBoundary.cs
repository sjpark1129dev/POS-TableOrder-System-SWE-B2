using POS.Entity;
using POS.Controller;

namespace SalesManagement
{
    public partial class SalesManagerBoundary : Form
    {
        private List<SalesEntity> salesList;
        private SalesController salesController;

        public SalesManagerBoundary()
        {
            InitializeComponent();
            salesController = new SalesController();
        }
        private void salesSearchButton_Click(object sender, EventArgs e)
        {
            LoadSalesToGridView();
        }

        private void LoadSalesToGridView()
        {
            DateTime selectedEndDate = endDate.Value.Date;
            DateTime selectedStartDate = startDate.Value.Date;
            string menuName = menuTxt.Text.Trim();
            string recnum = recnumTxt.Text.Trim();

            salesList = salesController.SearchSales(menuName, selectedStartDate, selectedEndDate, recnum);

            if (salesList.Count == 0)
            {
                MessageBox.Show("조회된 데이터가 없습니다.");
                finalsalesLabel.Text = "총매출: 0원";
                return;
            }

            int totalSales = 0;

            foreach (var sale in salesList)
            {
                SalesDataView.Rows.Add(
                    sale.salesDate.ToString("yyyy-MM-dd"),
                    sale.recnum,
                    sale.menuName,
                    sale.qty,
                    sale.unitPrice,
                    sale.price
                );
                totalSales += sale.price; 
            }
            finalsalesLabel.Text = $"총매출: {totalSales:N0}원";
        }
    }
}
