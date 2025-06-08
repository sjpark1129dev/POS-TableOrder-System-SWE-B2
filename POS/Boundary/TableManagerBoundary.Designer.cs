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
            tableEditSaveButton = new MaterialSkin.Controls.MaterialButton();
            tableDeleteButton = new MaterialSkin.Controls.MaterialButton();
            tableCreateButton2 = new MaterialSkin.Controls.MaterialButton();
            textBoxResetButton = new Button();
            tableIdTextBox = new TextBox();
            tableIdLabel = new Label();
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
            tableLayoutPanel1.Location = new Point(3, 64);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54.9295769F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45.0704231F));
            tableLayoutPanel1.Size = new Size(794, 383);
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
            tableLayoutPanelTables.Size = new Size(391, 377);
            tableLayoutPanelTables.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.LightSteelBlue;
            panel7.Controls.Add(tableEditSaveButton);
            panel7.Controls.Add(tableDeleteButton);
            panel7.Controls.Add(tableCreateButton2);
            panel7.Controls.Add(textBoxResetButton);
            panel7.Controls.Add(tableIdTextBox);
            panel7.Controls.Add(tableIdLabel);
            panel7.Controls.Add(tableNameLabel);
            panel7.Controls.Add(tableNameTextBox);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(400, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(391, 377);
            panel7.TabIndex = 1;
            // 
            // tableEditSaveButton
            // 
            tableEditSaveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableEditSaveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            tableEditSaveButton.Depth = 0;
            tableEditSaveButton.HighEmphasis = true;
            tableEditSaveButton.Icon = null;
            tableEditSaveButton.Location = new Point(219, 264);
            tableEditSaveButton.Margin = new Padding(4, 6, 4, 6);
            tableEditSaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            tableEditSaveButton.Name = "tableEditSaveButton";
            tableEditSaveButton.NoAccentTextColor = Color.Empty;
            tableEditSaveButton.Size = new Size(105, 36);
            tableEditSaveButton.TabIndex = 13;
            tableEditSaveButton.Text = "테이블 수정";
            tableEditSaveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            tableEditSaveButton.UseAccentColor = false;
            tableEditSaveButton.UseVisualStyleBackColor = true;
            tableEditSaveButton.Click += tableEditSaveButton_Click;
            // 
            // tableDeleteButton
            // 
            tableDeleteButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableDeleteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            tableDeleteButton.Depth = 0;
            tableDeleteButton.HighEmphasis = true;
            tableDeleteButton.Icon = null;
            tableDeleteButton.Location = new Point(219, 216);
            tableDeleteButton.Margin = new Padding(4, 6, 4, 6);
            tableDeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            tableDeleteButton.Name = "tableDeleteButton";
            tableDeleteButton.NoAccentTextColor = Color.Empty;
            tableDeleteButton.Size = new Size(105, 36);
            tableDeleteButton.TabIndex = 12;
            tableDeleteButton.Text = "테이블 삭제";
            tableDeleteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            tableDeleteButton.UseAccentColor = false;
            tableDeleteButton.UseVisualStyleBackColor = true;
            tableDeleteButton.Click += tableDeleteButton_Click;
            // 
            // tableCreateButton2
            // 
            tableCreateButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableCreateButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            tableCreateButton2.Depth = 0;
            tableCreateButton2.HighEmphasis = true;
            tableCreateButton2.Icon = null;
            tableCreateButton2.Location = new Point(219, 168);
            tableCreateButton2.Margin = new Padding(4, 6, 4, 6);
            tableCreateButton2.MouseState = MaterialSkin.MouseState.HOVER;
            tableCreateButton2.Name = "tableCreateButton2";
            tableCreateButton2.NoAccentTextColor = Color.Empty;
            tableCreateButton2.Size = new Size(105, 36);
            tableCreateButton2.TabIndex = 11;
            tableCreateButton2.Text = "테이블 생성";
            tableCreateButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            tableCreateButton2.UseAccentColor = false;
            tableCreateButton2.UseVisualStyleBackColor = true;
            tableCreateButton2.Click += tableCreateButton_Click;
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
            Text = "테이블 관리";
            FormClosing += TableManagerBoundary_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanelTables;
        private Panel panel7;
        private Label tableNameLabel;
        private TextBox tableNameTextBox;
        private TextBox tableIdTextBox;
        private Label tableIdLabel;
        private Button textBoxResetButton;
        private MaterialSkin.Controls.MaterialButton tableCreateButton2;
        private MaterialSkin.Controls.MaterialButton tableEditSaveButton;
        private MaterialSkin.Controls.MaterialButton tableDeleteButton;
    }
}