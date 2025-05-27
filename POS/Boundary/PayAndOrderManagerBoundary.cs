using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Boundary
{
    public partial class PayAndOrderManagerBoundary : Form
    {
        public PayAndOrderManagerBoundary()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PayManagerBoundary_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;

            // 컬럼 추가
            listView1.Columns.Add("메뉴명", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("단가", 70, HorizontalAlignment.Right);
            listView1.Columns.Add("수량", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("가격", 90, HorizontalAlignment.Right);

            // 예시 데이터 추가
            AddMenuItem("불고기", 12000, 2);
            AddMenuItem("김치찌개", 8000, 1);

            UpdateTotalPrice(); // 총액 초기 계산 및 표시
        }

        private void AddMenuItem(string name, int unitPrice, int quantity)
        {
            int totalPrice = unitPrice * quantity;

            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(unitPrice.ToString("N0"));
            item.SubItems.Add(quantity.ToString());
            item.SubItems.Add(totalPrice.ToString("N0"));

            listView1.Items.Add(item);

            UpdateTotalPrice(); // 아이템 추가 시마다 총액 갱신
        }

        private void UpdateTotalPrice()
        {
            int total = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                string priceText = item.SubItems[3].Text;

                if (int.TryParse(priceText.Replace(",", ""), out int price))
                {
                    total += price;
                }
            }

            Total.Text = "총액 : " + total.ToString("N0") + "원"; // 이렇게 바꾸면 됨
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

