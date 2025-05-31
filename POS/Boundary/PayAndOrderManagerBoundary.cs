using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using POS.Domain;

namespace POS.Boundary
{
    public partial class PayAndOrderManagerBoundary : MaterialForm
    {
        public PayAndOrderManagerBoundary()
        {
            InitializeComponent();
        }

        private void PayManagerBoundary_Load(object sender, EventArgs e)
        {
            // DataGridView 설정
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // 컬럼 정의
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "메뉴명",
                Name = "MenuName",
                Width = 150
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "단가",
                Name = "UnitPrice",
                Width = 70,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "N0" }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "수량",
                Name = "Quantity",
                Width = 50,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "가격",
                Name = "TotalPrice",
                Width = 90,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "N0" }
            });

            // 예시 데이터 추가
            AddMenuItem("불고기", 12000, 2);
            AddMenuItem("김치찌개", 8000, 1);

            UpdateTotalPrice();
        }

        private void AddMenuItem(string name, int unitPrice, int quantity)
        {
            int totalPrice = unitPrice * quantity;

            dataGridView1.Rows.Add(name, unitPrice, quantity, totalPrice);

            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            int total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["TotalPrice"].Value != null &&
                    int.TryParse(row.Cells["TotalPrice"].Value.ToString(), out int price))
                {
                    total += price;
                }
            }

            Total.Text = "총액 : " + total.ToString("N0") + "원";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // 선택 이벤트 처리용 (필요 시)
        }
    }
}
