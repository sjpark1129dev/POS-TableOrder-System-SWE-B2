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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridViewMenus = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            menuName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            pictureBoxPreview = new PictureBox();
            materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            menuPriceTextBox = new MaterialSkin.Controls.MaterialTextBox();
            menuNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            addImageButton = new MaterialSkin.Controls.MaterialButton();
            priceLabel = new MaterialSkin.Controls.MaterialLabel();
            menuNameLabel = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            menuResetButton = new MaterialSkin.Controls.MaterialButton();
            comboBoxCategory = new MaterialSkin.Controls.MaterialComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            CategoryManageButton = new MaterialSkin.Controls.MaterialButton();
            menuEditButton = new MaterialSkin.Controls.MaterialButton();
            menuDeleteButton = new MaterialSkin.Controls.MaterialButton();
            menuCreateButton = new MaterialSkin.Controls.MaterialButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenus).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
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
            tableLayoutPanel1.Size = new Size(717, 785);
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
            tableLayoutPanel2.Location = new Point(3, 108);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(711, 674);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // dataGridViewMenus
            // 
            dataGridViewMenus.AllowUserToAddRows = false;
            dataGridViewMenus.AllowUserToDeleteRows = false;
            dataGridViewMenus.AllowUserToResizeColumns = false;
            dataGridViewMenus.AllowUserToResizeRows = false;
            dataGridViewMenus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("맑은 고딕", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewMenus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMenus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMenus.Columns.AddRange(new DataGridViewColumn[] { Id, menuName, Price });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("맑은 고딕", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewMenus.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewMenus.Dock = DockStyle.Fill;
            dataGridViewMenus.Location = new Point(3, 3);
            dataGridViewMenus.MultiSelect = false;
            dataGridViewMenus.Name = "dataGridViewMenus";
            dataGridViewMenus.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("맑은 고딕", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewMenus.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewMenus.RowHeadersVisible = false;
            dataGridViewMenus.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewMenus.RowTemplate.ReadOnly = true;
            dataGridViewMenus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMenus.Size = new Size(349, 668);
            dataGridViewMenus.TabIndex = 4;
            dataGridViewMenus.SelectionChanged += dataGridViewMenus_SelectionChanged;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Id.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            menuName.DefaultCellStyle = dataGridViewCellStyle3;
            menuName.FillWeight = 60F;
            menuName.HeaderText = "메뉴명";
            menuName.Name = "menuName";
            menuName.ReadOnly = true;
            menuName.Resizable = DataGridViewTriState.False;
            // 
            // Price
            // 
            Price.DataPropertyName = "menuPrice";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            Price.DefaultCellStyle = dataGridViewCellStyle4;
            Price.FillWeight = 30F;
            Price.HeaderText = "가격";
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Resizable = DataGridViewTriState.False;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(pictureBoxPreview);
            panel3.Controls.Add(materialTextBox3);
            panel3.Controls.Add(materialLabel2);
            panel3.Controls.Add(menuPriceTextBox);
            panel3.Controls.Add(menuNameTextBox);
            panel3.Controls.Add(addImageButton);
            panel3.Controls.Add(priceLabel);
            panel3.Controls.Add(menuNameLabel);
            panel3.Controls.Add(materialLabel1);
            panel3.Controls.Add(menuResetButton);
            panel3.Controls.Add(comboBoxCategory);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(358, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 668);
            panel3.TabIndex = 8;
            // 
            // pictureBoxPreview
            // 
            pictureBoxPreview.BackColor = Color.White;
            pictureBoxPreview.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxPreview.Location = new Point(53, 88);
            pictureBoxPreview.Name = "pictureBoxPreview";
            pictureBoxPreview.Size = new Size(262, 216);
            pictureBoxPreview.TabIndex = 6;
            pictureBoxPreview.TabStop = false;
            // 
            // materialTextBox3
            // 
            materialTextBox3.AnimateReadOnly = false;
            materialTextBox3.BorderStyle = BorderStyle.None;
            materialTextBox3.Depth = 0;
            materialTextBox3.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox3.LeadingIcon = null;
            materialTextBox3.Location = new Point(99, 20);
            materialTextBox3.MaxLength = 50;
            materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox3.Multiline = false;
            materialTextBox3.Name = "materialTextBox3";
            materialTextBox3.Size = new Size(115, 50);
            materialTextBox3.TabIndex = 20;
            materialTextBox3.Text = "";
            materialTextBox3.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(53, 33);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(40, 19);
            materialLabel2.TabIndex = 19;
            materialLabel2.Text = "메뉴ID";
            // 
            // menuPriceTextBox
            // 
            menuPriceTextBox.AnimateReadOnly = false;
            menuPriceTextBox.BorderStyle = BorderStyle.None;
            menuPriceTextBox.Depth = 0;
            menuPriceTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            menuPriceTextBox.LeadingIcon = null;
            menuPriceTextBox.Location = new Point(139, 440);
            menuPriceTextBox.MaxLength = 50;
            menuPriceTextBox.MouseState = MaterialSkin.MouseState.OUT;
            menuPriceTextBox.Multiline = false;
            menuPriceTextBox.Name = "menuPriceTextBox";
            menuPriceTextBox.Size = new Size(158, 50);
            menuPriceTextBox.TabIndex = 18;
            menuPriceTextBox.Text = "";
            menuPriceTextBox.TrailingIcon = null;
            // 
            // menuNameTextBox
            // 
            menuNameTextBox.AnimateReadOnly = false;
            menuNameTextBox.BorderStyle = BorderStyle.None;
            menuNameTextBox.Depth = 0;
            menuNameTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            menuNameTextBox.LeadingIcon = null;
            menuNameTextBox.Location = new Point(139, 374);
            menuNameTextBox.MaxLength = 50;
            menuNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            menuNameTextBox.Multiline = false;
            menuNameTextBox.Name = "menuNameTextBox";
            menuNameTextBox.Size = new Size(158, 50);
            menuNameTextBox.TabIndex = 17;
            menuNameTextBox.Text = "";
            menuNameTextBox.TrailingIcon = null;
            // 
            // addImageButton
            // 
            addImageButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addImageButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addImageButton.Depth = 0;
            addImageButton.HighEmphasis = true;
            addImageButton.Icon = null;
            addImageButton.Location = new Point(226, 313);
            addImageButton.Margin = new Padding(4, 6, 4, 6);
            addImageButton.MouseState = MaterialSkin.MouseState.HOVER;
            addImageButton.Name = "addImageButton";
            addImageButton.NoAccentTextColor = Color.Empty;
            addImageButton.Size = new Size(89, 36);
            addImageButton.TabIndex = 16;
            addImageButton.Text = "사진 추가";
            addImageButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            addImageButton.UseAccentColor = false;
            addImageButton.UseVisualStyleBackColor = true;
            addImageButton.Click += addImageButton_Click;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Depth = 0;
            priceLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            priceLabel.Location = new Point(84, 457);
            priceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(25, 19);
            priceLabel.TabIndex = 15;
            priceLabel.Text = "가격";
            // 
            // menuNameLabel
            // 
            menuNameLabel.AutoSize = true;
            menuNameLabel.Depth = 0;
            menuNameLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            menuNameLabel.Location = new Point(79, 389);
            menuNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            menuNameLabel.Name = "menuNameLabel";
            menuNameLabel.Size = new Size(37, 19);
            menuNameLabel.TabIndex = 14;
            menuNameLabel.Text = "메뉴명";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(67, 526);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(49, 19);
            materialLabel1.TabIndex = 13;
            materialLabel1.Text = "카테고리";
            // 
            // menuResetButton
            // 
            menuResetButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            menuResetButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            menuResetButton.Depth = 0;
            menuResetButton.HighEmphasis = true;
            menuResetButton.Icon = null;
            menuResetButton.Location = new Point(246, 23);
            menuResetButton.Margin = new Padding(4, 6, 4, 6);
            menuResetButton.MouseState = MaterialSkin.MouseState.HOVER;
            menuResetButton.Name = "menuResetButton";
            menuResetButton.NoAccentTextColor = Color.Empty;
            menuResetButton.Size = new Size(69, 36);
            menuResetButton.TabIndex = 12;
            menuResetButton.Text = "초기화";
            menuResetButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            menuResetButton.UseAccentColor = false;
            menuResetButton.UseVisualStyleBackColor = true;
            menuResetButton.Click += menuResetButton_Click;
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
            comboBoxCategory.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboBoxCategory.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.IntegralHeight = false;
            comboBoxCategory.ItemHeight = 43;
            comboBoxCategory.Location = new Point(139, 512);
            comboBoxCategory.MaxDropDownItems = 4;
            comboBoxCategory.MouseState = MaterialSkin.MouseState.OUT;
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(158, 49);
            comboBoxCategory.StartIndex = 0;
            comboBoxCategory.TabIndex = 10;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
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
            tableLayoutPanel3.Size = new Size(711, 99);
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
            CategoryManageButton.Location = new Point(560, 31);
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
            menuEditButton.Location = new Point(410, 31);
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
            menuDeleteButton.Location = new Point(233, 31);
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
            menuCreateButton.Location = new Point(56, 31);
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
            ClientSize = new Size(723, 852);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MenuManagerBoundary";
            Text = "메뉴 관리";
            FormClosing += MenuManagerBoundary_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenus).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).EndInit();
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
        private PictureBox pictureBoxPreview;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialButton menuDeleteButton;
        private MaterialSkin.Controls.MaterialButton CategoryManageButton;
        private MaterialSkin.Controls.MaterialButton menuEditButton;
        private MaterialSkin.Controls.MaterialComboBox comboBoxCategory;
        private MaterialSkin.Controls.MaterialLabel priceLabel;
        private MaterialSkin.Controls.MaterialLabel menuNameLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton menuResetButton;
        private MaterialSkin.Controls.MaterialTextBox menuPriceTextBox;
        private MaterialSkin.Controls.MaterialTextBox menuNameTextBox;
        private MaterialSkin.Controls.MaterialButton addImageButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
    }
}