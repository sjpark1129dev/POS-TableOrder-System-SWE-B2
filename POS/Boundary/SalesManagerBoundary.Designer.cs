namespace POS.Boundary
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
            recnumTxt = new TextBox();
            menuTxt = new TextBox();
            salesSearchBtn = new MaterialSkin.Controls.MaterialButton();
            label4 = new Label();
            label3 = new Label();
            startDate = new DateTimePicker();
            label2 = new Label();
            endDate = new DateTimePicker();
            panel2 = new Panel();
            finalsalesLabel = new MaterialSkin.Controls.MaterialLabel();
            SalesDataView = new DataGridView();
            dateTime = new DataGridViewTextBoxColumn();
            TableId = new DataGridViewTextBoxColumn();
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
            label1.Location = new Point(72, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "날짜:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.Controls.Add(recnumTxt);
            panel1.Controls.Add(menuTxt);
            panel1.Controls.Add(salesSearchBtn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(startDate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(endDate);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 64);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(909, 53);
            panel1.TabIndex = 1;
            // 
            // recnumTxt
            // 
            recnumTxt.Location = new Point(587, 17);
            recnumTxt.Name = "recnumTxt";
            recnumTxt.Size = new Size(100, 23);
            recnumTxt.TabIndex = 9;
            // 
            // menuTxt
            // 
            menuTxt.Location = new Point(403, 17);
            menuTxt.Name = "menuTxt";
            menuTxt.Size = new Size(100, 23);
            menuTxt.TabIndex = 8;
            // 
            // salesSearchBtn
            // 
            salesSearchBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            salesSearchBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            salesSearchBtn.Depth = 0;
            salesSearchBtn.HighEmphasis = true;
            salesSearchBtn.Icon = null;
            salesSearchBtn.Location = new Point(782, 9);
            salesSearchBtn.Margin = new Padding(4, 6, 4, 6);
            salesSearchBtn.MouseState = MaterialSkin.MouseState.HOVER;
            salesSearchBtn.Name = "salesSearchBtn";
            salesSearchBtn.NoAccentTextColor = Color.Empty;
            salesSearchBtn.Size = new Size(64, 36);
            salesSearchBtn.TabIndex = 0;
            salesSearchBtn.Text = "조회";
            salesSearchBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            salesSearchBtn.UseAccentColor = false;
            salesSearchBtn.UseVisualStyleBackColor = true;
            salesSearchBtn.Click += salesSearchButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(508, 20);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 6;
            label4.Text = "계산서 번호:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 20);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 4;
            label3.Text = "메뉴명:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // startDate
            // 
            startDate.CustomFormat = "yyyy-MM-dd";
            startDate.Format = DateTimePickerFormat.Custom;
            startDate.Location = new Point(110, 17);
            startDate.Margin = new Padding(2);
            startDate.Name = "startDate";
            startDate.Size = new Size(107, 23);
            startDate.TabIndex = 3;
            startDate.Value = new DateTime(2025, 5, 18, 2, 19, 19, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 18);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 2;
            label2.Text = "~";
            // 
            // endDate
            // 
            endDate.CustomFormat = "yyyy-MM-dd";
            endDate.Format = DateTimePickerFormat.Custom;
            endDate.Location = new Point(241, 17);
            endDate.Margin = new Padding(2);
            endDate.Name = "endDate";
            endDate.Size = new Size(107, 23);
            endDate.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(finalsalesLabel);
            panel2.Controls.Add(SalesDataView);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 117);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(909, 357);
            panel2.TabIndex = 3;
            // 
            // finalsalesLabel
            // 
            finalsalesLabel.AutoSize = true;
            finalsalesLabel.Depth = 0;
            finalsalesLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            finalsalesLabel.Location = new Point(740, 315);
            finalsalesLabel.MouseState = MaterialSkin.MouseState.HOVER;
            finalsalesLabel.Name = "finalsalesLabel";
            finalsalesLabel.Size = new Size(66, 19);
            finalsalesLabel.TabIndex = 4;
            finalsalesLabel.Text = "총매출: 0원";
            // 
            // SalesDataView
            // 
            SalesDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SalesDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SalesDataView.Columns.AddRange(new DataGridViewColumn[] { dateTime, TableId, recnum, menuName, qty, unitPrice, totalPrice });
            SalesDataView.Dock = DockStyle.Top;
            SalesDataView.Location = new Point(63, 0);
            SalesDataView.Margin = new Padding(2);
            SalesDataView.Name = "SalesDataView";
            SalesDataView.RowHeadersVisible = false;
            SalesDataView.RowHeadersWidth = 62;
            SalesDataView.Size = new Size(783, 305);
            SalesDataView.TabIndex = 2;
            // 
            // dateTime
            // 
            dateTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dateTime.HeaderText = "날짜";
            dateTime.MinimumWidth = 8;
            dateTime.Name = "dateTime";
            dateTime.Width = 200;
            // 
            // TableId
            // 
            TableId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            TableId.FillWeight = 12.6815863F;
            TableId.HeaderText = "테이블ID";
            TableId.Name = "TableId";
            TableId.Width = 70;
            // 
            // recnum
            // 
            recnum.FillWeight = 12.6815863F;
            recnum.HeaderText = "계산서번호";
            recnum.MinimumWidth = 8;
            recnum.Name = "recnum";
            // 
            // menuName
            // 
            menuName.FillWeight = 12.6815863F;
            menuName.HeaderText = "메뉴명";
            menuName.MinimumWidth = 8;
            menuName.Name = "menuName";
            // 
            // qty
            // 
            qty.FillWeight = 12.6815863F;
            qty.HeaderText = "수량";
            qty.MinimumWidth = 8;
            qty.Name = "qty";
            // 
            // unitPrice
            // 
            unitPrice.FillWeight = 12.6815863F;
            unitPrice.HeaderText = "단가";
            unitPrice.MinimumWidth = 8;
            unitPrice.Name = "unitPrice";
            // 
            // totalPrice
            // 
            totalPrice.FillWeight = 12.6815863F;
            totalPrice.HeaderText = "합계";
            totalPrice.MinimumWidth = 8;
            totalPrice.Name = "totalPrice";
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(846, 0);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(63, 357);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(63, 357);
            panel3.TabIndex = 0;
            // 
            // SalesManagerBoundary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 477);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "SalesManagerBoundary";
            Text = "결제내역관리";
            FormClosing += SalesManagerBoundary_FormClosing;
            Load += SalesManagerBoundary_Load;
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
        private DateTimePicker startDate;
        private Label label2;
        private DateTimePicker endDate;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private DataGridView SalesDataView;
        private Panel panel4;
        private Panel panel3;
        private MaterialSkin.Controls.MaterialButton salesSearchBtn;
        private MaterialSkin.Controls.MaterialLabel finalsalesLabel;
        private TextBox recnumTxt;
        private TextBox menuTxt;
        private DataGridViewTextBoxColumn dateTime;
        private DataGridViewTextBoxColumn TableId;
        private DataGridViewTextBoxColumn recnum;
        private DataGridViewTextBoxColumn menuName;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn unitPrice;
        private DataGridViewTextBoxColumn totalPrice;
    }
}
