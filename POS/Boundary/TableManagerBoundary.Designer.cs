namespace POS.Boundary
{
    partial class TableManagerBoundary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanelTables = new TableLayoutPanel();
            panel7 = new Panel();
            tableSaveButton = new Button();
            textBoxResetButton = new Button();
            tableIdTextBox = new TextBox();
            tableIdLabel = new Label();
            tableDeleteButton = new Button();
            tableCreateButton = new Button();
            tableNameLabel = new Label();
            tableNameTextBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanelTables, 0, 0);
            tableLayoutPanel1.Controls.Add(panel7, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54.9295769F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45.0704231F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanelTables
            // 
            tableLayoutPanelTables.ColumnCount = 2;
            tableLayoutPanelTables.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTables.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTables.Dock = DockStyle.Fill;
            tableLayoutPanelTables.Location = new Point(3, 3);
            tableLayoutPanelTables.Name = "tableLayoutPanelTables";
            tableLayoutPanelTables.RowCount = 5;
            tableLayoutPanelTables.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelTables.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelTables.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelTables.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelTables.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelTables.Size = new Size(394, 444);
            tableLayoutPanelTables.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.LightSteelBlue;
            panel7.Controls.Add(tableSaveButton);
            panel7.Controls.Add(textBoxResetButton);
            panel7.Controls.Add(tableIdTextBox);
            panel7.Controls.Add(tableIdLabel);
            panel7.Controls.Add(tableDeleteButton);
            panel7.Controls.Add(tableCreateButton);
            panel7.Controls.Add(tableNameLabel);
            panel7.Controls.Add(tableNameTextBox);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(403, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(394, 444);
            panel7.TabIndex = 1;
            // 
            // tableSaveButton
            // 
            tableSaveButton.Location = new Point(72, 308);
            tableSaveButton.Name = "tableSaveButton";
            tableSaveButton.Size = new Size(269, 37);
            tableSaveButton.TabIndex = 10;
            tableSaveButton.Text = "테이블 저장";
            tableSaveButton.UseVisualStyleBackColor = true;
            // 
            // textBoxResetButton
            // 
            textBoxResetButton.Location = new Point(239, 87);
            textBoxResetButton.Name = "textBoxResetButton";
            textBoxResetButton.Size = new Size(85, 26);
            textBoxResetButton.TabIndex = 9;
            textBoxResetButton.Text = "초기화";
            textBoxResetButton.UseVisualStyleBackColor = true;
            textBoxResetButton.Click += textBoxResetButton_Click;
            // 
            // tableIdTextBox
            // 
            tableIdTextBox.Enabled = false;
            tableIdTextBox.Location = new Point(139, 29);
            tableIdTextBox.Name = "tableIdTextBox";
            tableIdTextBox.Size = new Size(185, 23);
            tableIdTextBox.TabIndex = 8;
            // 
            // tableIdLabel
            // 
            tableIdLabel.AutoSize = true;
            tableIdLabel.Location = new Point(50, 32);
            tableIdLabel.Name = "tableIdLabel";
            tableIdLabel.Size = new Size(83, 15);
            tableIdLabel.TabIndex = 7;
            tableIdLabel.Text = "테이블 고유ID";
            // 
            // tableDeleteButton
            // 
            tableDeleteButton.Location = new Point(72, 265);
            tableDeleteButton.Name = "tableDeleteButton";
            tableDeleteButton.Size = new Size(269, 37);
            tableDeleteButton.TabIndex = 5;
            tableDeleteButton.Text = "테이블 삭제";
            tableDeleteButton.UseVisualStyleBackColor = true;
            tableDeleteButton.Click += tableDeleteButton_Click;
            // 
            // tableCreateButton
            // 
            tableCreateButton.Location = new Point(72, 222);
            tableCreateButton.Name = "tableCreateButton";
            tableCreateButton.Size = new Size(269, 37);
            tableCreateButton.TabIndex = 2;
            tableCreateButton.Text = "테이블 생성";
            tableCreateButton.UseVisualStyleBackColor = true;
            tableCreateButton.Click += tableCreateButton_Click;
            // 
            // tableNameLabel
            // 
            tableNameLabel.AutoSize = true;
            tableNameLabel.Location = new Point(62, 60);
            tableNameLabel.Name = "tableNameLabel";
            tableNameLabel.Size = new Size(71, 15);
            tableNameLabel.TabIndex = 1;
            tableNameLabel.Text = "테이블 이름";
            // 
            // tableNameTextBox
            // 
            tableNameTextBox.Location = new Point(139, 58);
            tableNameTextBox.Name = "tableNameTextBox";
            tableNameTextBox.Size = new Size(185, 23);
            tableNameTextBox.TabIndex = 0;
            // 
            // TableManagerBoundary
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "TableManagerBoundary";
            Text = "TableManagerBoundary";
            Load += TableManagerBoundary_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanelTables;
        private Panel panel7;
        private Button tableDeleteButton;
        private Button tableCreateButton;
        private Label tableNameLabel;
        private TextBox tableNameTextBox;
        private TextBox tableIdTextBox;
        private Label tableIdLabel;
        private Button textBoxResetButton;
        private Button tableSaveButton;
    }
}