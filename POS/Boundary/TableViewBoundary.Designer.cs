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
            Table4 = new Panel();
            orderList4 = new ListBox();
            totalAmount4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            TableManagerButton = new MaterialSkin.Controls.MaterialButton();
            MenuManagerButton = new MaterialSkin.Controls.MaterialButton();
            SalesManagerButton = new MaterialSkin.Controls.MaterialButton();
            Table4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            // TableManagerButton
            // 
            TableManagerButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableManagerButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            TableManagerButton.Depth = 0;
            TableManagerButton.HighEmphasis = true;
            TableManagerButton.Icon = null;
            TableManagerButton.Location = new Point(202, 79);
            TableManagerButton.Margin = new Padding(4, 6, 4, 6);
            TableManagerButton.MouseState = MaterialSkin.MouseState.HOVER;
            TableManagerButton.Name = "TableManagerButton";
            TableManagerButton.NoAccentTextColor = Color.Empty;
            TableManagerButton.Size = new Size(105, 36);
            TableManagerButton.TabIndex = 7;
            TableManagerButton.Text = "테이블 관리";
            TableManagerButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            TableManagerButton.UseAccentColor = false;
            TableManagerButton.UseVisualStyleBackColor = true;
            TableManagerButton.Click += TableManagerButton2_Click;
            // 
            // MenuManagerButton
            // 
            MenuManagerButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MenuManagerButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            MenuManagerButton.Depth = 0;
            MenuManagerButton.HighEmphasis = true;
            MenuManagerButton.Icon = null;
            MenuManagerButton.Location = new Point(354, 79);
            MenuManagerButton.Margin = new Padding(4, 6, 4, 6);
            MenuManagerButton.MouseState = MaterialSkin.MouseState.HOVER;
            MenuManagerButton.Name = "MenuManagerButton";
            MenuManagerButton.NoAccentTextColor = Color.Empty;
            MenuManagerButton.Size = new Size(89, 36);
            MenuManagerButton.TabIndex = 8;
            MenuManagerButton.Text = "메뉴 관리";
            MenuManagerButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            MenuManagerButton.UseAccentColor = false;
            MenuManagerButton.UseVisualStyleBackColor = true;
            MenuManagerButton.Click += MenuManagerButton2_Click;
            // 
            // SalesManagerButton
            // 
            SalesManagerButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SalesManagerButton.BackColor = Color.White;
            SalesManagerButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            SalesManagerButton.Depth = 0;
            SalesManagerButton.ForeColor = SystemColors.ControlText;
            SalesManagerButton.HighEmphasis = true;
            SalesManagerButton.Icon = null;
            SalesManagerButton.Location = new Point(494, 79);
            SalesManagerButton.Margin = new Padding(4, 6, 4, 6);
            SalesManagerButton.MouseState = MaterialSkin.MouseState.HOVER;
            SalesManagerButton.Name = "SalesManagerButton";
            SalesManagerButton.NoAccentTextColor = Color.Empty;
            SalesManagerButton.Size = new Size(89, 36);
            SalesManagerButton.TabIndex = 9;
            SalesManagerButton.Text = "매출 관리";
            SalesManagerButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            SalesManagerButton.UseAccentColor = false;
            SalesManagerButton.UseVisualStyleBackColor = false;
            SalesManagerButton.Click += SalesManagerButton2_Click;
            // 
            // TableViewBoundary
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(255, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(SalesManagerButton);
            Controls.Add(MenuManagerButton);
            Controls.Add(TableManagerButton);
            Controls.Add(tableLayoutPanel1);
            Name = "TableViewBoundary";
            Text = "TableViewBoundary";
            Table4.ResumeLayout(false);
            Table4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel Table4;
        private Label totalAmount4;
        private ListBox orderList4;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton TableManagerButton;
        private MaterialSkin.Controls.MaterialButton MenuManagerButton;
        private MaterialSkin.Controls.MaterialButton SalesManagerButton;
    }
}
