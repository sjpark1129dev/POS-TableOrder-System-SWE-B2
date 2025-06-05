using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using POS.Domain;
using POS.Controller;

namespace POS.Boundary
{
    public partial class SalesManagerBoundary : MaterialForm
    {
        private List<SalesEntity> salesList;
        private SalesController salesController;
        private TableViewBoundary tableViewBoundary; // 테이블 뷰 바운더리 참조

        public SalesManagerBoundary(TableViewBoundary tableViewBoundary)
        {
            InitializeComponent();
            salesController = new SalesController();
            this.tableViewBoundary = tableViewBoundary; // 테이블 뷰 바운더리 참조 저장
            SalesDataView.AllowUserToAddRows = false;
        }

        private void salesSearchButton_Click(object sender, EventArgs e)
        {
            LoadSalesToGridView();
        }

        private void LoadSalesToGridView()
        {
            SalesDataView.Rows.Clear(); // ✅ 기존 행 제거

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

            foreach (var sale in salesList.OrderByDescending(s => s.SalesDate))
            {
                SalesDataView.Rows.Add(
                    sale.SalesDate.ToString("yyyy-MM-dd HH:mm:ss"),
                    sale.TableId,
                    sale.RecNum,
                    sale.MenuName,
                    sale.Qty,
                    sale.UnitPrice.ToString("N0"), // ✅ 콤마 추가
                    sale.Price.ToString("N0")      // ✅ 콤마 추가
                );
                totalSales += sale.Price;
            }

            finalsalesLabel.Text = $"총매출: {totalSales:N0}원";
        }

        private void SalesManagerBoundary_Load(object sender, EventArgs e)
        {
            LoadSalesToGridView();
        }

        private void SalesManagerBoundary_FormClosing(object sender, FormClosingEventArgs e)
        {
            tableViewBoundary.LoadTables(); // 테이블 뷰 바운더리의 테이블 목록 새로고침
        }
    }
}
