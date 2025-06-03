namespace POS.Boundary
{
    partial class PayAndOrderManagerBoundary
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            Total = new MaterialSkin.Controls.MaterialLabel();
            dataGridView1 = new DataGridView();
            pay = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Depth = 0;
            Total.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Total.Location = new Point(537, 291);
            Total.MouseState = MaterialSkin.MouseState.HOVER;
            Total.Name = "Total";
            Total.Size = new Size(58, 19);
            Total.TabIndex = 1;
            Total.Text = "총액 : 0원";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(647, 155);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pay
            // 
            pay.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pay.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            pay.Depth = 0;
            pay.HighEmphasis = true;
            pay.Icon = null;
            pay.Location = new Point(284, 331);
            pay.Margin = new Padding(4, 6, 4, 6);
            pay.MouseState = MaterialSkin.MouseState.HOVER;
            pay.Name = "pay";
            pay.NoAccentTextColor = Color.Empty;
            pay.Size = new Size(85, 36);
            pay.TabIndex = 8;
            pay.Text = "결제하기";
            pay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            pay.UseAccentColor = false;
            pay.UseVisualStyleBackColor = true;
            pay.Click += pay_Click;
            // 
            // PayAndOrderManagerBoundary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 450);
            Controls.Add(Total);
            Controls.Add(pay);
            Controls.Add(dataGridView1);
            Name = "PayAndOrderManagerBoundary";
            Text = "결제 관리";
            Load += PayManagerBoundary_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // 멤버 변수
        private MaterialSkin.Controls.MaterialLabel Total;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton pay;

        // 주문 리스트 로드 및 총액 계산
        private void LoadOrdersToListView()
        {
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("MenuName", "메뉴");
                dataGridView1.Columns.Add("Quantity", "수량");
                dataGridView1.Columns.Add("Price", "가격");
            }

            dataGridView1.Rows.Clear();

            // 테스트용 예시 데이터
            dataGridView1.Rows.Add("삼겹살", 2, 12000);
            dataGridView1.Rows.Add("목살", 1, 13000);
            dataGridView1.Rows.Add("된장찌개", 2, 5000);

            CalculateTotalPrice();
        }

        private void CalculateTotalPrice()
        {
            int total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Quantity"].Value != null && row.Cells["Price"].Value != null)
                {
                    if (int.TryParse(row.Cells["Quantity"].Value.ToString(), out int qty) &&
                        int.TryParse(row.Cells["Price"].Value.ToString(), out int price))
                    {
                        total += qty * price;
                    }
                }
            }

            Total.Text = $"총액 : {total:N0}원";
        }
    }
}