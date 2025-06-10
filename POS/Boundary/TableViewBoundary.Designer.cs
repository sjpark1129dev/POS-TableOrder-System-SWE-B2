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
            TableManagerButton = new MaterialSkin.Controls.MaterialButton();
            MenuManagerButton = new MaterialSkin.Controls.MaterialButton();
            SalesManagerButton = new MaterialSkin.Controls.MaterialButton();
            tableLayoutPanelRoot = new TableLayoutPanel();
            panelTop = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanelRoot.SuspendLayout();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // TableManagerButton
            // 
            TableManagerButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableManagerButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            TableManagerButton.Depth = 0;
            TableManagerButton.HighEmphasis = true;
            TableManagerButton.Icon = null;
            TableManagerButton.Location = new Point(80, 24);
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
            TableManagerButton.Click += TableManagerButton_Click;
            // 
            // MenuManagerButton
            // 
            MenuManagerButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MenuManagerButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            MenuManagerButton.Depth = 0;
            MenuManagerButton.HighEmphasis = true;
            MenuManagerButton.Icon = null;
            MenuManagerButton.Location = new Point(340, 24);
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
            MenuManagerButton.Click += MenuManagerButton_Click;
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
            SalesManagerButton.Location = new Point(623, 24);
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
            SalesManagerButton.Click += SalesManagerButton_Click;
            // 
            // tableLayoutPanelRoot
            // 
            tableLayoutPanelRoot.ColumnCount = 1;
            tableLayoutPanelRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelRoot.Controls.Add(panelTop, 0, 0);
            tableLayoutPanelRoot.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanelRoot.Dock = DockStyle.Fill;
            tableLayoutPanelRoot.Location = new Point(3, 64);
            tableLayoutPanelRoot.Name = "tableLayoutPanelRoot";
            tableLayoutPanelRoot.RowCount = 2;
            tableLayoutPanelRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 23.75979F));
            tableLayoutPanelRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 76.24021F));
            tableLayoutPanelRoot.Size = new Size(794, 383);
            tableLayoutPanelRoot.TabIndex = 10;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(SalesManagerButton);
            panelTop.Controls.Add(TableManagerButton);
            panelTop.Controls.Add(MenuManagerButton);
            panelTop.Dock = DockStyle.Fill;
            panelTop.Location = new Point(3, 3);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(788, 85);
            panelTop.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 94);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(788, 286);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // TableViewBoundary
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(255, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanelRoot);
            Name = "TableViewBoundary";
            Text = "POS";
            tableLayoutPanelRoot.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton TableManagerButton;
        private MaterialSkin.Controls.MaterialButton MenuManagerButton;
        private MaterialSkin.Controls.MaterialButton SalesManagerButton;
        private TableLayoutPanel tableLayoutPanelRoot;
        private Panel panelTop;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
