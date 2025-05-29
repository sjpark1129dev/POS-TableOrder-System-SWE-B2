namespace POS.Boundary
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
            Table4 = new Panel();
            orderList4 = new ListBox();
            totalAmount4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            Table4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TableManagerButton
            // 
            TableManagerButton.Location = new Point(75, 75);
            TableManagerButton.Name = "TableManagerButton";
            TableManagerButton.Size = new Size(111, 40);
            TableManagerButton.TabIndex = 0;
            TableManagerButton.Text = "테이블 관리";
            TableManagerButton.UseVisualStyleBackColor = true;
            TableManagerButton.Click += TableManagerButton_Click;
            // 
            // MenuManagerButton
            // 
            MenuManagerButton.Location = new Point(361, 75);
            MenuManagerButton.Name = "MenuManagerButton";
            MenuManagerButton.Size = new Size(111, 40);
            MenuManagerButton.TabIndex = 1;
            MenuManagerButton.Text = "메뉴 관리";
            MenuManagerButton.UseVisualStyleBackColor = true;
            MenuManagerButton.Click += MenuManagerButton_Click;
            // 
            // SalesManagerButton
            // 
            SalesManagerButton.Location = new Point(603, 75);
            SalesManagerButton.Name = "SalesManagerButton";
            SalesManagerButton.Size = new Size(111, 40);
            SalesManagerButton.TabIndex = 2;
            SalesManagerButton.Text = "매출 관리";
            SalesManagerButton.UseVisualStyleBackColor = true;
            // 
            // Table4
            // 
            Table4.Controls.Add(orderList4);
            Table4.Controls.Add(totalAmount4);
            Table4.Location = new Point(3, 3);
            Table4.Name = "Table4";
            Table4.Size = new Size(149, 123);
            Table4.TabIndex = 5;
            // 
            // orderList4
            // 
            orderList4.FormattingEnabled = true;
            orderList4.ItemHeight = 15;
            orderList4.Location = new Point(3, 12);
            orderList4.Name = "orderList4";
            orderList4.Size = new Size(143, 79);
            orderList4.TabIndex = 8;
            // 
            // totalAmount4
            // 
            totalAmount4.AutoSize = true;
            totalAmount4.Location = new Point(76, 94);
            totalAmount4.Name = "totalAmount4";
            totalAmount4.Size = new Size(70, 15);
            totalAmount4.TabIndex = 1;
            totalAmount4.Text = "총액:@@원";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(Table4, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 180);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(776, 258);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // TableViewBoundary
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(255, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(SalesManagerButton);
            Controls.Add(MenuManagerButton);
            Controls.Add(TableManagerButton);
            Name = "TableViewBoundary";
            Text = "TableViewBoundary";
            Table4.ResumeLayout(false);
            Table4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button TableManagerButton;
        private Button MenuManagerButton;
        private Button SalesManagerButton;
        private Panel Table4;
        private Label totalAmount4;
        private ListBox orderList4;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
