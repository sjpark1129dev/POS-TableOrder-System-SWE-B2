using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using POS.Controller;
using POS.Domain;

namespace POS.Boundary
{
    public partial class OrderAndPayManagerBoundary : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private TableViewBoundary tableViewBoundary;
        private OrderAndPayController orderAndPayController;
        private int tableId; // 테이블 ID 저장
        private string tableName; // 테이블 이름 저장

        public OrderAndPayManagerBoundary(TableViewBoundary tableViewBoundary, int tableId, string tableName)
        {
            InitializeComponent();
            this.tableViewBoundary = tableViewBoundary; // 테이블 뷰 바운더리 참조 저장
            this.orderAndPayController = new OrderAndPayController(); // 주문 및 결제 컨트롤러 인스턴스 생성
            this.tableId = tableId; // 테이블 ID 저장
            this.tableName = tableName; // 테이블 이름 저장
            this.Text = $"{tableName} 결제 및 주문 관리"; // 폼 제목 설정
        }

        private void PayManagerBoundary_Load(object sender, EventArgs e)
        {
            InitializeDataGridViewColumns(); // ← 여기 추가
            LoadUnpaidOrdersIntoGrid();
            UpdateTotalPrice();
        }

        private void InitializeDataGridViewColumns()
        {
            dataGridViewUnpaidOrders.Columns.Clear();
            dataGridViewUnpaidOrders.AutoGenerateColumns = false;
            dataGridViewUnpaidOrders.RowHeadersVisible = false;
            dataGridViewUnpaidOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 테이블 ID
            var colTableId = new DataGridViewTextBoxColumn
            {
                Name = "TableId",
                HeaderText = "테이블",
                DataPropertyName = "TableId",
                FillWeight = 100,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleLeft } // ← 명시적 정렬 해제
            };

            // 메뉴명
            var colMenuName = new DataGridViewTextBoxColumn
            {
                Name = "MenuName",
                HeaderText = "메뉴명",
                DataPropertyName = "MenuName",
                FillWeight = 100,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleLeft }
            };

            // 수량
            var colQty = new DataGridViewTextBoxColumn
            {
                Name = "Qty",
                HeaderText = "수량",
                DataPropertyName = "Qty",
                FillWeight = 100,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleLeft }
            };

            // 단가
            var colUnitPrice = new DataGridViewTextBoxColumn
            {
                Name = "UnitPrice",
                HeaderText = "단가",
                DataPropertyName = "UnitPrice",
                FillWeight = 100,
                DefaultCellStyle = {
                    Format = "N0", // 콤마 추가
                    Alignment = DataGridViewContentAlignment.MiddleLeft
                }
            };

            // 합계
            var colTotal = new DataGridViewTextBoxColumn
            {
                Name = "Total",
                HeaderText = "합계",
                DataPropertyName = "Total",
                FillWeight = 100,
                DefaultCellStyle = {
                    Format = "N0", // 콤마 추가
                    Alignment = DataGridViewContentAlignment.MiddleLeft
                }
            };

            // 주문시간
            var colOrderTime = new DataGridViewTextBoxColumn
            {
                Name = "OrderTime",
                HeaderText = "주문시간",
                DataPropertyName = "OrderTime",
                FillWeight = 200,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleLeft }
            };

            dataGridViewUnpaidOrders.Columns.Add(colTableId);
            dataGridViewUnpaidOrders.Columns.Add(colMenuName);
            dataGridViewUnpaidOrders.Columns.Add(colQty);
            dataGridViewUnpaidOrders.Columns.Add(colUnitPrice);
            dataGridViewUnpaidOrders.Columns.Add(colTotal);
            dataGridViewUnpaidOrders.Columns.Add(colOrderTime);
        }


        private void LoadUnpaidOrdersIntoGrid()
        {
            var unpaidItems = orderAndPayController.GetUnpaidOrderItemsByTable(tableId);
            dataGridViewUnpaidOrders.DataSource = unpaidItems;
        }

        private void UpdateTotalPrice()
        {
            int total = 0;

            foreach (DataGridViewRow row in dataGridViewUnpaidOrders.Rows)
            {
                if (row.IsNewRow)
                    continue;

                var cell = row.Cells["Total"];
                if (cell != null && cell.Value != null && int.TryParse(cell.Value.ToString(), out int price))
                {
                    total += price;
                }
            }

            Total.Text = $"총액 : {total:N0}원";
        }

        private void pay_Click(object sender, EventArgs e)
        {
            bool success = orderAndPayController.PayTable(tableId);

            if (success)
            {
                MessageBox.Show($"{tableName} 결제가 완료되었습니다.");
                tableViewBoundary.LoadTables(); // 테이블 뷰 갱신
                this.Close(); // 결제 완료 후 폼 닫기
            }
            else
            {
                MessageBox.Show("결제할 미결제 주문이 없습니다.");
                this.Close(); // 결제 완료 후 폼 닫기
            }
        }
    }
}