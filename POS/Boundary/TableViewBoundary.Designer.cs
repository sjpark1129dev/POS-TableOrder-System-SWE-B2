namespace POS
{
    partial class TableViewBoundary
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
            TableManagerButton = new Button();
            MenuManagerButton = new Button();
            SalesManagerButton = new Button();
            LunchTimeButton = new Button();
            Table1 = new Panel();
            totalAmount = new Label();
            Table2 = new Panel();
            totalAmount2 = new Label();
            Table3 = new Panel();
            totalAmount3 = new Label();
            orderList1 = new ListBox();
            Table4 = new Panel();
            totalAmount4 = new Label();
            Table5 = new Panel();
            totalAmount5 = new Label();
            Table6 = new Panel();
            totalAmount6 = new Label();
            orderList2 = new ListBox();
            orderList3 = new ListBox();
            orderList4 = new ListBox();
            orderList5 = new ListBox();
            orderList6 = new ListBox();
            Table1.SuspendLayout();
            Table2.SuspendLayout();
            Table3.SuspendLayout();
            Table4.SuspendLayout();
            Table5.SuspendLayout();
            Table6.SuspendLayout();
            SuspendLayout();
            // 
            // TableManagerButton
            // 
            TableManagerButton.Location = new Point(37, 30);
            TableManagerButton.Name = "TableManagerButton";
            TableManagerButton.Size = new Size(111, 40);
            TableManagerButton.TabIndex = 0;
            TableManagerButton.Text = "테이블 관리";
            TableManagerButton.UseVisualStyleBackColor = true;
            TableManagerButton.Click += TableManagerButton_Click;
            // 
            // MenuManagerButton
            // 
            MenuManagerButton.Location = new Point(226, 30);
            MenuManagerButton.Name = "MenuManagerButton";
            MenuManagerButton.Size = new Size(111, 40);
            MenuManagerButton.TabIndex = 1;
            MenuManagerButton.Text = "메뉴 관리";
            MenuManagerButton.UseVisualStyleBackColor = true;
            MenuManagerButton.Click += MenuManagerButton_Click;
            // 
            // SalesManagerButton
            // 
            SalesManagerButton.Location = new Point(431, 30);
            SalesManagerButton.Name = "SalesManagerButton";
            SalesManagerButton.Size = new Size(111, 40);
            SalesManagerButton.TabIndex = 2;
            SalesManagerButton.Text = "매출 관리";
            SalesManagerButton.UseVisualStyleBackColor = true;
            // 
            // LunchTimeButton
            // 
            LunchTimeButton.Location = new Point(633, 30);
            LunchTimeButton.Name = "LunchTimeButton";
            LunchTimeButton.Size = new Size(111, 40);
            LunchTimeButton.TabIndex = 3;
            LunchTimeButton.Text = "특선 전환";
            LunchTimeButton.UseVisualStyleBackColor = true;
            // 
            // Table1
            // 
            Table1.Controls.Add(totalAmount);
            Table1.Controls.Add(orderList1);
            Table1.Location = new Point(38, 108);
            Table1.Name = "Table1";
            Table1.Size = new Size(197, 139);
            Table1.TabIndex = 4;
            // 
            // totalAmount
            // 
            totalAmount.AutoSize = true;
            totalAmount.Location = new Point(124, 112);
            totalAmount.Name = "totalAmount";
            totalAmount.Size = new Size(70, 15);
            totalAmount.TabIndex = 1;
            totalAmount.Text = "총액:@@원";
            // 
            // Table2
            // 
            Table2.Controls.Add(orderList2);
            Table2.Controls.Add(totalAmount2);
            Table2.Location = new Point(282, 108);
            Table2.Name = "Table2";
            Table2.Size = new Size(197, 139);
            Table2.TabIndex = 5;
            // 
            // totalAmount2
            // 
            totalAmount2.AutoSize = true;
            totalAmount2.Location = new Point(124, 112);
            totalAmount2.Name = "totalAmount2";
            totalAmount2.Size = new Size(70, 15);
            totalAmount2.TabIndex = 1;
            totalAmount2.Text = "총액:@@원";
            // 
            // Table3
            // 
            Table3.Controls.Add(orderList3);
            Table3.Controls.Add(totalAmount3);
            Table3.Location = new Point(547, 108);
            Table3.Name = "Table3";
            Table3.Size = new Size(197, 139);
            Table3.TabIndex = 6;
            // 
            // totalAmount3
            // 
            totalAmount3.AutoSize = true;
            totalAmount3.Location = new Point(124, 112);
            totalAmount3.Name = "totalAmount3";
            totalAmount3.Size = new Size(70, 15);
            totalAmount3.TabIndex = 7;
            totalAmount3.Text = "총액:@@원";
            // 
            // orderList1
            // 
            orderList1.FormattingEnabled = true;
            orderList1.ItemHeight = 15;
            orderList1.Location = new Point(12, 13);
            orderList1.Name = "orderList1";
            orderList1.Size = new Size(163, 79);
            orderList1.TabIndex = 4;
            orderList1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Table4
            // 
            Table4.Controls.Add(orderList4);
            Table4.Controls.Add(totalAmount4);
            Table4.Location = new Point(38, 275);
            Table4.Name = "Table4";
            Table4.Size = new Size(197, 139);
            Table4.TabIndex = 5;
            // 
            // totalAmount4
            // 
            totalAmount4.AutoSize = true;
            totalAmount4.Location = new Point(124, 112);
            totalAmount4.Name = "totalAmount4";
            totalAmount4.Size = new Size(70, 15);
            totalAmount4.TabIndex = 1;
            totalAmount4.Text = "총액:@@원";
            // 
            // Table5
            // 
            Table5.Controls.Add(orderList5);
            Table5.Controls.Add(totalAmount5);
            Table5.Location = new Point(282, 275);
            Table5.Name = "Table5";
            Table5.Size = new Size(197, 139);
            Table5.TabIndex = 5;
            // 
            // totalAmount5
            // 
            totalAmount5.AutoSize = true;
            totalAmount5.Location = new Point(124, 112);
            totalAmount5.Name = "totalAmount5";
            totalAmount5.Size = new Size(70, 15);
            totalAmount5.TabIndex = 1;
            totalAmount5.Text = "총액:@@원";
            // 
            // Table6
            // 
            Table6.Controls.Add(orderList6);
            Table6.Controls.Add(totalAmount6);
            Table6.Location = new Point(547, 275);
            Table6.Name = "Table6";
            Table6.Size = new Size(197, 139);
            Table6.TabIndex = 5;
            // 
            // totalAmount6
            // 
            totalAmount6.AutoSize = true;
            totalAmount6.Location = new Point(124, 112);
            totalAmount6.Name = "totalAmount6";
            totalAmount6.Size = new Size(70, 15);
            totalAmount6.TabIndex = 1;
            totalAmount6.Text = "총액:@@원";
            // 
            // orderList2
            // 
            orderList2.FormattingEnabled = true;
            orderList2.ItemHeight = 15;
            orderList2.Location = new Point(15, 13);
            orderList2.Name = "orderList2";
            orderList2.Size = new Size(163, 79);
            orderList2.TabIndex = 5;
            // 
            // orderList3
            // 
            orderList3.FormattingEnabled = true;
            orderList3.ItemHeight = 15;
            orderList3.Location = new Point(15, 13);
            orderList3.Name = "orderList3";
            orderList3.Size = new Size(163, 79);
            orderList3.TabIndex = 6;
            // 
            // orderList4
            // 
            orderList4.FormattingEnabled = true;
            orderList4.ItemHeight = 15;
            orderList4.Location = new Point(12, 15);
            orderList4.Name = "orderList4";
            orderList4.Size = new Size(163, 79);
            orderList4.TabIndex = 8;
            // 
            // orderList5
            // 
            orderList5.FormattingEnabled = true;
            orderList5.ItemHeight = 15;
            orderList5.Location = new Point(15, 15);
            orderList5.Name = "orderList5";
            orderList5.Size = new Size(163, 79);
            orderList5.TabIndex = 9;
            // 
            // orderList6
            // 
            orderList6.FormattingEnabled = true;
            orderList6.ItemHeight = 15;
            orderList6.Location = new Point(15, 15);
            orderList6.Name = "orderList6";
            orderList6.Size = new Size(163, 79);
            orderList6.TabIndex = 9;
            // 
            // TableViewBoundary
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(Table6);
            Controls.Add(Table5);
            Controls.Add(Table4);
            Controls.Add(Table3);
            Controls.Add(Table2);
            Controls.Add(Table1);
            Controls.Add(LunchTimeButton);
            Controls.Add(SalesManagerButton);
            Controls.Add(MenuManagerButton);
            Controls.Add(TableManagerButton);
            Name = "TableViewBoundary";
            Text = "TableViewBoundary";
            Table1.ResumeLayout(false);
            Table1.PerformLayout();
            Table2.ResumeLayout(false);
            Table2.PerformLayout();
            Table3.ResumeLayout(false);
            Table3.PerformLayout();
            Table4.ResumeLayout(false);
            Table4.PerformLayout();
            Table5.ResumeLayout(false);
            Table5.PerformLayout();
            Table6.ResumeLayout(false);
            Table6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button TableManagerButton;
        private Button MenuManagerButton;
        private Button SalesManagerButton;
        private Button LunchTimeButton;
        private Panel Table1;
        private Label totalAmount;
        private Panel Table2;
        private Label totalAmount2;
        private Panel Table3;
        private Panel Table4;
        private Label totalAmount4;
        private Panel Table5;
        private Label totalAmount5;
        private Panel Table6;
        private Label totalAmount6;
        private ListBox orderList1;
        private Label totalAmount3;
        private ListBox orderList2;
        private ListBox orderList3;
        private ListBox orderList4;
        private ListBox orderList5;
        private ListBox orderList6;
    }
}
