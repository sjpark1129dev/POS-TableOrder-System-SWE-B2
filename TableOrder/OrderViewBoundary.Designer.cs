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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            finalPrice = new Label();
            OrderDataView = new DataGridView();
            menuName = new DataGridViewTextBoxColumn();
            qty = new DataGridViewTextBoxColumn();
            totalPrice = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrderDataView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 40);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 20F);
            label1.Location = new Point(212, 1);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 37);
            label1.TabIndex = 1;
            label1.Text = "주문조회";
            // 
            // panel3
            // 
            panel3.Controls.Add(finalPrice);
            panel3.Controls.Add(OrderDataView);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 40);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(560, 230);
            panel3.TabIndex = 4;
            // 
            // finalPrice
            // 
            finalPrice.AutoSize = true;
            finalPrice.Location = new Point(479, 154);
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
            OrderDataView.Columns.AddRange(new DataGridViewColumn[] { menuName, qty, totalPrice });
            OrderDataView.Location = new Point(60, 26);
            OrderDataView.Margin = new Padding(2, 2, 2, 2);
            OrderDataView.Name = "OrderDataView";
            OrderDataView.RowHeadersWidth = 62;
            OrderDataView.Size = new Size(447, 143);
            OrderDataView.TabIndex = 2;
            // 
            // menuName
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            menuName.DefaultCellStyle = dataGridViewCellStyle4;
            menuName.HeaderText = "메뉴명";
            menuName.MinimumWidth = 8;
            menuName.Name = "menuName";
            // 
            // qty
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            qty.DefaultCellStyle = dataGridViewCellStyle5;
            qty.HeaderText = "수량";
            qty.MinimumWidth = 8;
            qty.Name = "qty";
            // 
            // totalPrice
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            totalPrice.DefaultCellStyle = dataGridViewCellStyle6;
            totalPrice.HeaderText = "금액";
            totalPrice.MinimumWidth = 8;
            totalPrice.Name = "totalPrice";
            // 
            // OrderViewBoundary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "OrderViewBoundary";
            Text = "주문조회";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrderDataView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private DataGridView OrderDataView;
        private DataGridViewTextBoxColumn menuName;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn totalPrice;
        private Label finalPrice;
    }
}
