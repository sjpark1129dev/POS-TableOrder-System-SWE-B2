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
                MessageBox.Show("��ȸ�� �����Ͱ� �����ϴ�.");
                finalsalesLabel.Text = "�Ѹ���: 0��";
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
            finalsalesLabel.Text = $"�Ѹ���: {totalSales:N0}��";
        }

        private void SalesManagerBoundary_Load(object sender, EventArgs e)
        {
            LoadSalesToGridView();
        }
    }
}
