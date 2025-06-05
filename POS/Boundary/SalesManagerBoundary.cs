using MaterialSkin.Controls;
using POS.Domain;
using POS.Controller;

namespace POS.Boundary
{
    public partial class SalesManagerBoundary : MaterialForm
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

            salesList = salesController.SearchSales(selectedStartDate, selectedEndDate, menuName, recnum);

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
                    sale.SalesDate.ToString("yyyy-MM-dd"),
                    sale.TableId,
                    sale.RecNum,
                    sale.MenuName,
                    sale.Qty,
                    sale.UnitPrice,
                    sale.Price
                );
                totalSales += sale.Price;
            }
            ;
            finalsalesLabel.Text = $"총매출: {totalSales:N0}원";
        }

        private void SalesManagerBoundary_Load(object sender, EventArgs e)
        {
            LoadSalesToGridView();
        }
    }
}
