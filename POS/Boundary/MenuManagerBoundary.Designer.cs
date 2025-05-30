namespace POS.Boundary
{
    partial class MenuManagerBoundary
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridViewMenus = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            menuName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            lblCategorySelect = new MaterialSkin.Controls.MaterialLabel();
            comboBoxCategory = new MaterialSkin.Controls.MaterialComboBox();
            menuResetButton = new Button();
            menuIdTextBox = new TextBox();
            label7 = new Label();
            pictureAddButton = new Button();
            pictureBox = new PictureBox();
            menuPriceTextBox = new TextBox();
            menuNameTextBox = new TextBox();
            label6 = new Label();
            label4 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            CategoryManageButton = new MaterialSkin.Controls.MaterialButton();
            menuEditButton = new MaterialSkin.Controls.MaterialButton();
            menuDeleteButton = new MaterialSkin.Controls.MaterialButton();
            menuCreateButton = new MaterialSkin.Controls.MaterialButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenus).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 64);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.4706812F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.52932F));
            tableLayoutPanel1.Size = new Size(705, 687);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(dataGridViewMenus, 0, 0);
            tableLayoutPanel2.Controls.Add(panel3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 95);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(699, 589);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // dataGridViewMenus
            // 
            dataGridViewMenus.AllowUserToAddRows = false;
            dataGridViewMenus.AllowUserToDeleteRows = false;
            dataGridViewMenus.AllowUserToResizeColumns = false;
            dataGridViewMenus.AllowUserToResizeRows = false;
            dataGridViewMenus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("맑은 고딕", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewMenus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewMenus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMenus.Columns.AddRange(new DataGridViewColumn[] { Id, menuName, Price });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("맑은 고딕", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridViewMenus.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewMenus.Dock = DockStyle.Fill;
            dataGridViewMenus.Location = new Point(3, 3);
            dataGridViewMenus.MultiSelect = false;
            dataGridViewMenus.Name = "dataGridViewMenus";
            dataGridViewMenus.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("맑은 고딕", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridViewMenus.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewMenus.RowHeadersVisible = false;
            dataGridViewMenus.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewMenus.RowTemplate.ReadOnly = true;
            dataGridViewMenus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMenus.Size = new Size(343, 583);
            dataGridViewMenus.TabIndex = 4;
            dataGridViewMenus.SelectionChanged += dataGridViewMenus_SelectionChanged;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            Id.DefaultCellStyle = dataGridViewCellStyle8;
            Id.FillWeight = 10F;
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Resizable = DataGridViewTriState.False;
            // 
            // menuName
            // 
            menuName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            menuName.DataPropertyName = "menuName";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            menuName.DefaultCellStyle = dataGridViewCellStyle9;
            menuName.FillWeight = 60F;
            menuName.HeaderText = "메뉴명";
            menuName.Name = "menuName";
            menuName.ReadOnly = true;
            menuName.Resizable = DataGridViewTriState.False;
            // 
            // Price
            // 
            Price.DataPropertyName = "menuPrice";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = null;
            Price.DefaultCellStyle = dataGridViewCellStyle10;
            Price.FillWeight = 30F;
            Price.HeaderText = "가격";
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Resizable = DataGridViewTriState.False;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(lblCategorySelect);
            panel3.Controls.Add(comboBoxCategory);
            panel3.Controls.Add(menuResetButton);
            panel3.Controls.Add(menuIdTextBox);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(pictureAddButton);
            panel3.Controls.Add(pictureBox);
            panel3.Controls.Add(menuPriceTextBox);
            panel3.Controls.Add(menuNameTextBox);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(352, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(344, 583);
            panel3.TabIndex = 8;
            // 
            // lblCategorySelect
            // 
            lblCategorySelect.AutoSize = true;
            lblCategorySelect.Depth = 0;
            lblCategorySelect.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCategorySelect.Location = new Point(37, 396);
            lblCategorySelect.MouseState = MaterialSkin.MouseState.HOVER;
            lblCategorySelect.Name = "lblCategorySelect";
            lblCategorySelect.Size = new Size(49, 19);
            lblCategorySelect.TabIndex = 11;
            lblCategorySelect.Text = "카테고리";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.AutoResize = false;
            comboBoxCategory.BackColor = Color.FromArgb(255, 255, 255);
            comboBoxCategory.Depth = 0;
            comboBoxCategory.DrawMode = DrawMode.OwnerDrawVariable;
            comboBoxCategory.DropDownHeight = 174;
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.DropDownWidth = 121;
            comboBoxCategory.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboBoxCategory.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.IntegralHeight = false;
            comboBoxCategory.ItemHeight = 43;
            comboBoxCategory.Location = new Point(110, 378);
            comboBoxCategory.MaxDropDownItems = 4;
            comboBoxCategory.MouseState = MaterialSkin.MouseState.OUT;
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(158, 49);
            comboBoxCategory.StartIndex = 0;
            comboBoxCategory.TabIndex = 10;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // menuResetButton
            // 
            menuResetButton.Location = new Point(203, 6);
            menuResetButton.Name = "menuResetButton";
            menuResetButton.Size = new Size(65, 23);
            menuResetButton.TabIndex = 2;
            menuResetButton.Text = "초기화";
            menuResetButton.UseVisualStyleBackColor = true;
            menuResetButton.Click += menuResetButton_Click;
            // 
            // menuIdTextBox
            // 
            menuIdTextBox.Enabled = false;
            menuIdTextBox.Location = new Point(91, 7);
            menuIdTextBox.Name = "menuIdTextBox";
            menuIdTextBox.Size = new Size(106, 23);
            menuIdTextBox.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 10);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 8;
            label7.Text = "메뉴ID";
            // 
            // pictureAddButton
            // 
            pictureAddButton.Location = new Point(193, 249);
            pictureAddButton.Name = "pictureAddButton";
            pictureAddButton.Size = new Size(75, 23);
            pictureAddButton.TabIndex = 7;
            pictureAddButton.Text = "사진 추가";
            pictureAddButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.White;
            pictureBox.Location = new Point(31, 36);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(237, 196);
            pictureBox.TabIndex = 6;
            pictureBox.TabStop = false;
            // 
            // menuPriceTextBox
            // 
            menuPriceTextBox.Location = new Point(110, 334);
            menuPriceTextBox.Name = "menuPriceTextBox";
            menuPriceTextBox.Size = new Size(158, 23);
            menuPriceTextBox.TabIndex = 4;
            // 
            // menuNameTextBox
            // 
            menuNameTextBox.Location = new Point(110, 291);
            menuNameTextBox.Name = "menuNameTextBox";
            menuNameTextBox.Size = new Size(158, 23);
            menuNameTextBox.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 337);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 1;
            label6.Text = "메뉴가격";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 294);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 0;
            label4.Text = "메뉴명";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(CategoryManageButton, 3, 0);
            tableLayoutPanel3.Controls.Add(menuEditButton, 2, 0);
            tableLayoutPanel3.Controls.Add(menuDeleteButton, 1, 0);
            tableLayoutPanel3.Controls.Add(menuCreateButton, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(699, 86);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // CategoryManageButton
            // 
            CategoryManageButton.Anchor = AnchorStyles.None;
            CategoryManageButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CategoryManageButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            CategoryManageButton.Depth = 0;
            CategoryManageButton.HighEmphasis = true;
            CategoryManageButton.Icon = null;
            CategoryManageButton.Location = new Point(550, 25);
            CategoryManageButton.Margin = new Padding(4, 6, 4, 6);
            CategoryManageButton.MouseState = MaterialSkin.MouseState.HOVER;
            CategoryManageButton.Name = "CategoryManageButton";
            CategoryManageButton.NoAccentTextColor = Color.Empty;
            CategoryManageButton.Size = new Size(121, 36);
            CategoryManageButton.TabIndex = 10;
            CategoryManageButton.Text = "카테고리 관리";
            CategoryManageButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            CategoryManageButton.UseAccentColor = false;
            CategoryManageButton.UseVisualStyleBackColor = true;
            CategoryManageButton.Click += CategoryManageButton_Click;
            // 
            // menuEditButton
            // 
            menuEditButton.Anchor = AnchorStyles.None;
            menuEditButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            menuEditButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            menuEditButton.Depth = 0;
            menuEditButton.HighEmphasis = true;
            menuEditButton.Icon = null;
            menuEditButton.Location = new Point(403, 25);
            menuEditButton.Margin = new Padding(4, 6, 4, 6);
            menuEditButton.MouseState = MaterialSkin.MouseState.HOVER;
            menuEditButton.Name = "menuEditButton";
            menuEditButton.NoAccentTextColor = Color.Empty;
            menuEditButton.Size = new Size(64, 36);
            menuEditButton.TabIndex = 11;
            menuEditButton.Text = "수정";
            menuEditButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            menuEditButton.UseAccentColor = false;
            menuEditButton.UseVisualStyleBackColor = true;
            menuEditButton.Click += menuEditButton_Click;
            // 
            // menuDeleteButton
            // 
            menuDeleteButton.Anchor = AnchorStyles.None;
            menuDeleteButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            menuDeleteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            menuDeleteButton.Depth = 0;
            menuDeleteButton.HighEmphasis = true;
            menuDeleteButton.Icon = null;
            menuDeleteButton.Location = new Point(229, 25);
            menuDeleteButton.Margin = new Padding(4, 6, 4, 6);
            menuDeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            menuDeleteButton.Name = "menuDeleteButton";
            menuDeleteButton.NoAccentTextColor = Color.Empty;
            menuDeleteButton.Size = new Size(64, 36);
            menuDeleteButton.TabIndex = 10;
            menuDeleteButton.Text = "삭제";
            menuDeleteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            menuDeleteButton.UseAccentColor = false;
            menuDeleteButton.UseVisualStyleBackColor = true;
            menuDeleteButton.Click += menuDeleteButton_Click;
            // 
            // menuCreateButton
            // 
            menuCreateButton.Anchor = AnchorStyles.None;
            menuCreateButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            menuCreateButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            menuCreateButton.Depth = 0;
            menuCreateButton.HighEmphasis = true;
            menuCreateButton.Icon = null;
            menuCreateButton.Location = new Point(55, 25);
            menuCreateButton.Margin = new Padding(4, 6, 4, 6);
            menuCreateButton.MouseState = MaterialSkin.MouseState.HOVER;
            menuCreateButton.Name = "menuCreateButton";
            menuCreateButton.NoAccentTextColor = Color.Empty;
            menuCreateButton.Size = new Size(64, 36);
            menuCreateButton.TabIndex = 2;
            menuCreateButton.Text = "추가";
            menuCreateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            menuCreateButton.UseAccentColor = false;
            menuCreateButton.UseVisualStyleBackColor = true;
            menuCreateButton.Click += menuCreateButton_Click;
            // 
            // MenuManagerBoundary
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(711, 754);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MenuManagerBoundary";
            Text = "메뉴 관리";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenus).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridViewMenus;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn menuName;
        private DataGridViewTextBoxColumn Price;
        private MaterialSkin.Controls.MaterialButton menuCreateButton;
        private Panel panel3;
        private Button menuResetButton;
        private TextBox menuIdTextBox;
        private Label label7;
        private Button pictureAddButton;
        private PictureBox pictureBox;
        private TextBox menuPriceTextBox;
        private TextBox menuNameTextBox;
        private Label label6;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialButton menuDeleteButton;
        private MaterialSkin.Controls.MaterialButton CategoryManageButton;
        private MaterialSkin.Controls.MaterialButton menuEditButton;
        private MaterialSkin.Controls.MaterialLabel lblCategorySelect;
        private MaterialSkin.Controls.MaterialComboBox comboBoxCategory;
    }
}