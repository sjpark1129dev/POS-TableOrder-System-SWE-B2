namespace TableOrder
{
    partial class OrderViewBoundary
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel3 = new Panel();
            finalPrice = new Label();
            OrderDataView = new DataGridView();
            menuName = new DataGridViewTextBoxColumn();
            qty = new DataGridViewTextBoxColumn();
            totalPrice = new DataGridViewTextBoxColumn();
            총금액 = new DataGridViewTextBoxColumn();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrderDataView).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(finalPrice);
            panel3.Controls.Add(OrderDataView);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 64);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(554, 203);
            panel3.TabIndex = 4;
            // 
            // finalPrice
            // 
            finalPrice.AutoSize = true;
            finalPrice.Location = new Point(481, 171);
            finalPrice.Margin = new Padding(2, 0, 2, 0);
            finalPrice.Name = "finalPrice";
            finalPrice.Size = new Size(26, 15);
            finalPrice.TabIndex = 3;
            finalPrice.Text = "0원";
            // 
            // OrderDataView
            // 
            OrderDataView.Anchor = AnchorStyles.None;
            OrderDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrderDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderDataView.Columns.AddRange(new DataGridViewColumn[] { menuName, qty, totalPrice, 총금액 });
            OrderDataView.Location = new Point(57, 12);
            OrderDataView.Margin = new Padding(2);
            OrderDataView.Name = "OrderDataView";
            OrderDataView.RowHeadersWidth = 62;
            OrderDataView.Size = new Size(447, 143);
            OrderDataView.TabIndex = 2;
            // 
            // menuName
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            menuName.DefaultCellStyle = dataGridViewCellStyle1;
            menuName.HeaderText = "메뉴명";
            menuName.MinimumWidth = 8;
            menuName.Name = "menuName";
            // 
            // qty
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            qty.DefaultCellStyle = dataGridViewCellStyle2;
            qty.HeaderText = "수량";
            qty.MinimumWidth = 8;
            qty.Name = "qty";
            // 
            // totalPrice
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            totalPrice.DefaultCellStyle = dataGridViewCellStyle3;
            totalPrice.HeaderText = "금액";
            totalPrice.MinimumWidth = 8;
            totalPrice.Name = "totalPrice";
            // 
            // 총금액
            // 
            총금액.HeaderText = "총금액";
            총금액.Name = "총금액";
            // 
            // OrderViewBoundary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(panel3);
            Margin = new Padding(2);
            Name = "OrderViewBoundary";
            Text = "주문조회";
            Load += OrderViewBoundary_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrderDataView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private DataGridView OrderDataView;
        private Label finalPrice;
        private DataGridViewTextBoxColumn menuName;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn totalPrice;
        private DataGridViewTextBoxColumn 총금액;
    }
}
