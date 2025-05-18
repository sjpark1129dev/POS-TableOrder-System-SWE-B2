namespace OrderView
{
    partial class OrderViewUI
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
            panel2 = new Panel();
            goBackBtn = new Button();
            panel3 = new Panel();
            finalPrice = new Label();
            OrderDataView = new DataGridView();
            menuName = new DataGridViewTextBoxColumn();
            qty = new DataGridViewTextBoxColumn();
            totalPrice = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrderDataView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 67);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 20F);
            label1.Location = new Point(303, 2);
            label1.Name = "label1";
            label1.Size = new Size(183, 54);
            label1.TabIndex = 1;
            label1.Text = "주문조회";
            // 
            // panel2
            // 
            panel2.Controls.Add(goBackBtn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 364);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 86);
            panel2.TabIndex = 3;
            // 
            // goBackBtn
            // 
            goBackBtn.Location = new Point(346, 20);
            goBackBtn.Name = "goBackBtn";
            goBackBtn.Size = new Size(140, 45);
            goBackBtn.TabIndex = 0;
            goBackBtn.Text = "돌아가기";
            goBackBtn.UseVisualStyleBackColor = true;
            goBackBtn.Click += goBackBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(finalPrice);
            panel3.Controls.Add(OrderDataView);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 297);
            panel3.TabIndex = 4;
            // 
            // finalPrice
            // 
            finalPrice.AutoSize = true;
            finalPrice.Location = new Point(684, 256);
            finalPrice.Name = "finalPrice";
            finalPrice.Size = new Size(40, 25);
            finalPrice.TabIndex = 3;
            finalPrice.Text = "0원";
            // 
            // OrderDataView
            // 
            OrderDataView.Anchor = AnchorStyles.None;
            OrderDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrderDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderDataView.Columns.AddRange(new DataGridViewColumn[] { menuName, qty, totalPrice });
            OrderDataView.Location = new Point(85, 0);
            OrderDataView.Name = "OrderDataView";
            OrderDataView.RowHeadersWidth = 62;
            OrderDataView.Size = new Size(639, 238);
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
            // OrderViewUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "OrderViewUI";
            Text = "주문조회";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrderDataView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView OrderDataView;
        private DataGridViewTextBoxColumn menuName;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn totalPrice;
        private Button goBackBtn;
        private Label finalPrice;
    }
}
