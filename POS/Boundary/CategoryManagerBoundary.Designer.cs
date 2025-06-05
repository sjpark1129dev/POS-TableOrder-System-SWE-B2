namespace POS.Boundary
{
    partial class CategoryManagerBoundary
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
            materialListView1 = new MaterialSkin.Controls.MaterialListView();
            categoryCreateButton = new MaterialSkin.Controls.MaterialButton();
            categoryRemoveButton = new MaterialSkin.Controls.MaterialButton();
            categoryUpdateButton = new MaterialSkin.Controls.MaterialButton();
            categoryNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            categoryIDtxt = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            selectResetButton = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // materialListView1
            // 
            materialListView1.AutoSizeTable = false;
            materialListView1.BackColor = Color.FromArgb(255, 255, 255);
            materialListView1.BorderStyle = BorderStyle.None;
            materialListView1.Depth = 0;
            materialListView1.FullRowSelect = true;
            materialListView1.Location = new Point(52, 138);
            materialListView1.MinimumSize = new Size(200, 100);
            materialListView1.MouseLocation = new Point(-1, -1);
            materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            materialListView1.Name = "materialListView1";
            materialListView1.OwnerDraw = true;
            materialListView1.Size = new Size(270, 297);
            materialListView1.TabIndex = 3;
            materialListView1.UseCompatibleStateImageBehavior = false;
            materialListView1.View = View.Details;
            materialListView1.SelectedIndexChanged += materialListView1_SelectedIndexChanged;
            // 
            // categoryCreateButton
            // 
            categoryCreateButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            categoryCreateButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            categoryCreateButton.Depth = 0;
            categoryCreateButton.HighEmphasis = true;
            categoryCreateButton.Icon = null;
            categoryCreateButton.Location = new Point(52, 81);
            categoryCreateButton.Margin = new Padding(4, 6, 4, 6);
            categoryCreateButton.MouseState = MaterialSkin.MouseState.HOVER;
            categoryCreateButton.Name = "categoryCreateButton";
            categoryCreateButton.NoAccentTextColor = Color.Empty;
            categoryCreateButton.Size = new Size(121, 36);
            categoryCreateButton.TabIndex = 4;
            categoryCreateButton.Text = "카테고리 생성";
            categoryCreateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            categoryCreateButton.UseAccentColor = false;
            categoryCreateButton.UseVisualStyleBackColor = true;
            categoryCreateButton.Click += categoryCreateButton_Click;
            // 
            // categoryRemoveButton
            // 
            categoryRemoveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            categoryRemoveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            categoryRemoveButton.Depth = 0;
            categoryRemoveButton.HighEmphasis = true;
            categoryRemoveButton.Icon = null;
            categoryRemoveButton.Location = new Point(238, 81);
            categoryRemoveButton.Margin = new Padding(4, 6, 4, 6);
            categoryRemoveButton.MouseState = MaterialSkin.MouseState.HOVER;
            categoryRemoveButton.Name = "categoryRemoveButton";
            categoryRemoveButton.NoAccentTextColor = Color.Empty;
            categoryRemoveButton.Size = new Size(121, 36);
            categoryRemoveButton.TabIndex = 5;
            categoryRemoveButton.Text = "카테고리 삭제";
            categoryRemoveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            categoryRemoveButton.UseAccentColor = false;
            categoryRemoveButton.UseVisualStyleBackColor = true;
            categoryRemoveButton.Click += categoryRemoveButton_Click;
            // 
            // categoryUpdateButton
            // 
            categoryUpdateButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            categoryUpdateButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            categoryUpdateButton.Depth = 0;
            categoryUpdateButton.HighEmphasis = true;
            categoryUpdateButton.Icon = null;
            categoryUpdateButton.Location = new Point(429, 81);
            categoryUpdateButton.Margin = new Padding(4, 6, 4, 6);
            categoryUpdateButton.MouseState = MaterialSkin.MouseState.HOVER;
            categoryUpdateButton.Name = "categoryUpdateButton";
            categoryUpdateButton.NoAccentTextColor = Color.Empty;
            categoryUpdateButton.Size = new Size(121, 36);
            categoryUpdateButton.TabIndex = 6;
            categoryUpdateButton.Text = "카테고리 수정";
            categoryUpdateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            categoryUpdateButton.UseAccentColor = false;
            categoryUpdateButton.UseVisualStyleBackColor = true;
            categoryUpdateButton.Click += categoryUpdateButton_Click;
            // 
            // categoryNameTextBox
            // 
            categoryNameTextBox.AnimateReadOnly = false;
            categoryNameTextBox.BorderStyle = BorderStyle.None;
            categoryNameTextBox.Depth = 0;
            categoryNameTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            categoryNameTextBox.LeadingIcon = null;
            categoryNameTextBox.Location = new Point(410, 203);
            categoryNameTextBox.MaxLength = 50;
            categoryNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            categoryNameTextBox.Multiline = false;
            categoryNameTextBox.Name = "categoryNameTextBox";
            categoryNameTextBox.Size = new Size(153, 50);
            categoryNameTextBox.TabIndex = 7;
            categoryNameTextBox.Text = "";
            categoryNameTextBox.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(357, 221);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(25, 19);
            materialLabel1.TabIndex = 8;
            materialLabel1.Text = "이름";
            // 
            // categoryIDtxt
            // 
            categoryIDtxt.AnimateReadOnly = false;
            categoryIDtxt.BorderStyle = BorderStyle.None;
            categoryIDtxt.Depth = 0;
            categoryIDtxt.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            categoryIDtxt.LeadingIcon = null;
            categoryIDtxt.Location = new Point(410, 138);
            categoryIDtxt.MaxLength = 50;
            categoryIDtxt.MouseState = MaterialSkin.MouseState.OUT;
            categoryIDtxt.Multiline = false;
            categoryIDtxt.Name = "categoryIDtxt";
            categoryIDtxt.ReadOnly = true;
            categoryIDtxt.Size = new Size(75, 50);
            categoryIDtxt.TabIndex = 9;
            categoryIDtxt.Text = "";
            categoryIDtxt.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(357, 157);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(16, 19);
            materialLabel2.TabIndex = 10;
            materialLabel2.Text = "ID";
            // 
            // selectResetButton
            // 
            selectResetButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            selectResetButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            selectResetButton.Depth = 0;
            selectResetButton.HighEmphasis = true;
            selectResetButton.Icon = null;
            selectResetButton.Location = new Point(492, 147);
            selectResetButton.Margin = new Padding(4, 6, 4, 6);
            selectResetButton.MouseState = MaterialSkin.MouseState.HOVER;
            selectResetButton.Name = "selectResetButton";
            selectResetButton.NoAccentTextColor = Color.Empty;
            selectResetButton.Size = new Size(69, 36);
            selectResetButton.TabIndex = 11;
            selectResetButton.Text = "초기화";
            selectResetButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            selectResetButton.UseAccentColor = false;
            selectResetButton.UseVisualStyleBackColor = true;
            selectResetButton.Click += selectResetButton_Click;
            // 
            // CategoryManagerBoundary
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(606, 459);
            Controls.Add(selectResetButton);
            Controls.Add(materialLabel2);
            Controls.Add(categoryIDtxt);
            Controls.Add(materialLabel1);
            Controls.Add(categoryNameTextBox);
            Controls.Add(categoryUpdateButton);
            Controls.Add(categoryRemoveButton);
            Controls.Add(categoryCreateButton);
            Controls.Add(materialListView1);
            Name = "CategoryManagerBoundary";
            Text = "카테고리 관리";
            Load += CategoryManagerBoundary_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialListView materialListView1;
        private MaterialSkin.Controls.MaterialButton categoryCreateButton;
        private MaterialSkin.Controls.MaterialButton categoryRemoveButton;
        private MaterialSkin.Controls.MaterialButton categoryUpdateButton;
        private MaterialSkin.Controls.MaterialTextBox categoryNameTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox categoryIDtxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton selectResetButton;
    }
}