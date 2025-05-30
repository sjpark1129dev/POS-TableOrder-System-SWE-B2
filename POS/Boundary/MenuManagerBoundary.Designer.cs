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
            panel1 = new Panel();
            menuCreateButton = new Button();
            menuEditButton = new Button();
            menuDeleteButton = new Button();
            panel2 = new Panel();
            kategorieManageButton = new Button();
            panel4 = new Panel();
            panel3 = new Panel();
            menuResetButton = new Button();
            menuIdTextBox = new TextBox();
            label7 = new Label();
            pictureAddButton = new Button();
            pictureBox = new PictureBox();
            KategorieComboBox = new ComboBox();
            menuPriceTextBox = new TextBox();
            menuNameTextBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            ImageAddButton = new Button();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridViewMenus = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            menuName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenus).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 1);
            tableLayoutPanel1.Controls.Add(dataGridViewMenus, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 64);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.4706812F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.52932F));
            tableLayoutPanel1.Size = new Size(677, 607);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(menuCreateButton);
            panel1.Controls.Add(menuEditButton);
            panel1.Controls.Add(menuDeleteButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 75);
            panel1.TabIndex = 0;
            // 
            // menuCreateButton
            // 
            menuCreateButton.Location = new Point(12, 9);
            menuCreateButton.Name = "menuCreateButton";
            menuCreateButton.Size = new Size(75, 23);
            menuCreateButton.TabIndex = 1;
            menuCreateButton.Text = "추가";
            menuCreateButton.UseVisualStyleBackColor = true;
            menuCreateButton.Click += menuCreateButton_Click;
            // 
            // menuEditButton
            // 
            menuEditButton.Location = new Point(235, 9);
            menuEditButton.Name = "menuEditButton";
            menuEditButton.Size = new Size(75, 23);
            menuEditButton.TabIndex = 1;
            menuEditButton.Text = "수정";
            menuEditButton.UseVisualStyleBackColor = true;
            menuEditButton.Click += menuEditButton_Click;
            // 
            // menuDeleteButton
            // 
            menuDeleteButton.Location = new Point(128, 9);
            menuDeleteButton.Name = "menuDeleteButton";
            menuDeleteButton.Size = new Size(75, 23);
            menuDeleteButton.TabIndex = 0;
            menuDeleteButton.Text = "삭제";
            menuDeleteButton.UseVisualStyleBackColor = true;
            menuDeleteButton.Click += menuDeleteButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(kategorieManageButton);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(341, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(333, 75);
            panel2.TabIndex = 1;
            // 
            // kategorieManageButton
            // 
            kategorieManageButton.Location = new Point(31, 9);
            kategorieManageButton.Name = "kategorieManageButton";
            kategorieManageButton.Size = new Size(113, 23);
            kategorieManageButton.TabIndex = 2;
            kategorieManageButton.Text = "카테고리 관리";
            kategorieManageButton.UseVisualStyleBackColor = true;
            kategorieManageButton.Click += kategorieManageButton_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(ImageAddButton);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(341, 84);
            panel4.Name = "panel4";
            panel4.Size = new Size(333, 520);
            panel4.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDark;
            panel3.Controls.Add(menuResetButton);
            panel3.Controls.Add(menuIdTextBox);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(pictureAddButton);
            panel3.Controls.Add(pictureBox);
            panel3.Controls.Add(KategorieComboBox);
            panel3.Controls.Add(menuPriceTextBox);
            panel3.Controls.Add(menuNameTextBox);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(333, 520);
            panel3.TabIndex = 8;
            // 
            // menuResetButton
            // 
            menuResetButton.Location = new Point(203, 6);
            menuResetButton.Name = "menuResetButton";
            menuResetButton.Size = new Size(65, 23);
            menuResetButton.TabIndex = 2;
            menuResetButton.Text = "초기화";
            menuResetButton.UseVisualStyleBackColor = true;
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
            // KategorieComboBox
            // 
            KategorieComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            KategorieComboBox.FormattingEnabled = true;
            KategorieComboBox.Location = new Point(110, 375);
            KategorieComboBox.Name = "KategorieComboBox";
            KategorieComboBox.Size = new Size(158, 23);
            KategorieComboBox.TabIndex = 5;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 378);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 2;
            label5.Text = "카테고리";
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
            // ImageAddButton
            // 
            ImageAddButton.Location = new Point(193, 261);
            ImageAddButton.Name = "ImageAddButton";
            ImageAddButton.Size = new Size(75, 23);
            ImageAddButton.TabIndex = 7;
            ImageAddButton.Text = "사진 추가";
            ImageAddButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(31, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 196);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(110, 387);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(158, 23);
            comboBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 346);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 303);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 390);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "카테고리";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 349);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "메뉴가격";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 306);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "메뉴명";
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
            dataGridViewMenus.Location = new Point(3, 84);
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
            dataGridViewMenus.Size = new Size(332, 520);
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
            // MenuManagerBoundary
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(683, 674);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MenuManagerBoundary";
            Text = "메뉴 관리";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Button menuCreateButton;
        private Button menuDeleteButton;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button kategorieManageButton;
        private PictureBox pictureBox1;
        private Button ImageAddButton;
        private DataGridView dataGridViewMenus;
        private Panel panel3;
        private TextBox menuIdTextBox;
        private Label label7;
        private Button pictureAddButton;
        private PictureBox pictureBox;
        private ComboBox KategorieComboBox;
        private TextBox menuPriceTextBox;
        private TextBox menuNameTextBox;
        private Label label5;
        private Label label6;
        private Label label4;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn menuName;
        private DataGridViewTextBoxColumn Price;
        private Button menuResetButton;
        private Button menuEditButton;
    }
}