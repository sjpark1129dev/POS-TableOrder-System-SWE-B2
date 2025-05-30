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
            categoryDeleteButton = new MaterialSkin.Controls.MaterialButton();
            categoryUpdateButton = new MaterialSkin.Controls.MaterialButton();
            categoryNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
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
            // 
            // categoryDeleteButton
            // 
            categoryDeleteButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            categoryDeleteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            categoryDeleteButton.Depth = 0;
            categoryDeleteButton.HighEmphasis = true;
            categoryDeleteButton.Icon = null;
            categoryDeleteButton.Location = new Point(238, 81);
            categoryDeleteButton.Margin = new Padding(4, 6, 4, 6);
            categoryDeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            categoryDeleteButton.Name = "categoryDeleteButton";
            categoryDeleteButton.NoAccentTextColor = Color.Empty;
            categoryDeleteButton.Size = new Size(121, 36);
            categoryDeleteButton.TabIndex = 5;
            categoryDeleteButton.Text = "카테고리 삭제";
            categoryDeleteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            categoryDeleteButton.UseAccentColor = false;
            categoryDeleteButton.UseVisualStyleBackColor = true;
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
            // 
            // categoryNameTextBox
            // 
            categoryNameTextBox.AnimateReadOnly = false;
            categoryNameTextBox.BorderStyle = BorderStyle.None;
            categoryNameTextBox.Depth = 0;
            categoryNameTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            categoryNameTextBox.LeadingIcon = null;
            categoryNameTextBox.Location = new Point(412, 136);
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
            materialLabel1.Location = new Point(351, 152);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(25, 19);
            materialLabel1.TabIndex = 8;
            materialLabel1.Text = "이름";
            // 
            // CategoryManagerBoundary
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(606, 459);
            Controls.Add(materialLabel1);
            Controls.Add(categoryNameTextBox);
            Controls.Add(categoryUpdateButton);
            Controls.Add(categoryDeleteButton);
            Controls.Add(categoryCreateButton);
            Controls.Add(materialListView1);
            Name = "CategoryManagerBoundary";
            Text = "카테고리 관리";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialListView materialListView1;
        private MaterialSkin.Controls.MaterialButton categoryCreateButton;
        private MaterialSkin.Controls.MaterialButton categoryDeleteButton;
        private MaterialSkin.Controls.MaterialButton categoryUpdateButton;
        private MaterialSkin.Controls.MaterialTextBox categoryNameTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}