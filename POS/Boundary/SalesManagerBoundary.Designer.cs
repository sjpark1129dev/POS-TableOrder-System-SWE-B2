namespace SalesManagement
{
    partial class SalesManagerBoundary
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
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            recnumtxt = new TextBox();
            label4 = new Label();
            menutxt = new TextBox();
            label3 = new Label();
            endDate = new DateTimePicker();
            label2 = new Label();
            startDate = new DateTimePicker();
            panel2 = new Panel();
            label5 = new Label();
            SalesDataView = new DataGridView();
            dateTime = new DataGridViewTextBoxColumn();
            recnum = new DataGridViewTextBoxColumn();
            menuName = new DataGridViewTextBoxColumn();
            qty = new DataGridViewTextBoxColumn();
            unitPrice = new DataGridViewTextBoxColumn();
            totalPrice = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SalesDataView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 19);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 0;
            label1.Text = "날짜:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(recnumtxt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(menutxt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(endDate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(startDate);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1307, 63);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(1143, 16);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "조회";
            button1.UseVisualStyleBackColor = true;
            // 
            // recnumtxt
            // 
            recnumtxt.Location = new Point(884, 14);
            recnumtxt.Name = "recnumtxt";
            recnumtxt.Size = new Size(210, 31);
            recnumtxt.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(766, 18);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 6;
            label4.Text = "계산서 번호:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // menutxt
            // 
            menutxt.Location = new Point(538, 16);
            menutxt.Name = "menutxt";
            menutxt.Size = new Size(210, 31);
            menutxt.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(462, 18);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 4;
            label3.Text = "메뉴명:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // endDate
            // 
            endDate.CustomFormat = "yyyy-MM-dd";
            endDate.Format = DateTimePickerFormat.Custom;
            endDate.Location = new Point(270, 13);
            endDate.Name = "endDate";
            endDate.Size = new Size(151, 31);
            endDate.TabIndex = 3;
            endDate.Value = new DateTime(2025, 5, 18, 2, 19, 19, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 14);
            label2.Name = "label2";
            label2.Size = new Size(25, 25);
            label2.TabIndex = 2;
            label2.Text = "~";
            // 
            // startDate
            // 
            startDate.CustomFormat = "yyyy-MM-dd";
            startDate.Format = DateTimePickerFormat.Custom;
            startDate.Location = new Point(82, 14);
            startDate.Name = "startDate";
            startDate.Size = new Size(151, 31);
            startDate.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(SalesDataView);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(1307, 570);
            panel2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1063, 527);
            label5.Name = "label5";
            label5.Size = new Size(148, 25);
            label5.TabIndex = 3;
            label5.Text = "총매출: 31,000원";
            // 
            // SalesDataView
            // 
            SalesDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SalesDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SalesDataView.Columns.AddRange(new DataGridViewColumn[] { dateTime, recnum, menuName, qty, unitPrice, totalPrice });
            SalesDataView.Dock = DockStyle.Top;
            SalesDataView.Location = new Point(90, 0);
            SalesDataView.Name = "SalesDataView";
            SalesDataView.RowHeadersWidth = 62;
            SalesDataView.Size = new Size(1127, 509);
            SalesDataView.TabIndex = 2;
            // 
            // dateTime
            // 
            dateTime.HeaderText = "날짜";
            dateTime.MinimumWidth = 8;
            dateTime.Name = "dateTime";
            // 
            // recnum
            // 
            recnum.HeaderText = "계산서번호";
            recnum.MinimumWidth = 8;
            recnum.Name = "recnum";
            // 
            // menuName
            // 
            menuName.HeaderText = "메뉴명";
            menuName.MinimumWidth = 8;
            menuName.Name = "menuName";
            // 
            // qty
            // 
            qty.HeaderText = "수량";
            qty.MinimumWidth = 8;
            qty.Name = "qty";
            // 
            // unitPrice
            // 
            unitPrice.HeaderText = "단가";
            unitPrice.MinimumWidth = 8;
            unitPrice.Name = "unitPrice";
            // 
            // totalPrice
            // 
            totalPrice.HeaderText = "합계";
            totalPrice.MinimumWidth = 8;
            totalPrice.Name = "totalPrice";
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1217, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(90, 570);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(90, 570);
            panel3.TabIndex = 0;
            // 
            // SalesManagerBoundary
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 633);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SalesManagerBoundary";
            Text = "SalesManagerBoundary";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SalesDataView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DateTimePicker endDate;
        private Label label2;
        private DateTimePicker startDate;
        private Button button1;
        private TextBox recnumtxt;
        private Label label4;
        private TextBox menutxt;
        private Label label3;
        private Panel panel2;
        private DataGridView SalesDataView;
        private DataGridViewTextBoxColumn dateTime;
        private DataGridViewTextBoxColumn recnum;
        private DataGridViewTextBoxColumn menuName;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn unitPrice;
        private DataGridViewTextBoxColumn totalPrice;
        private Panel panel4;
        private Panel panel3;
        private Label label5;
    }
}
