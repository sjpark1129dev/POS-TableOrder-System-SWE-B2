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
            categoryCreateButton = new Button();
            categoryRemoveButton = new Button();
            categoryUpdateButton = new Button();
            CategoryListView = new ListView();
            SuspendLayout();
            // 
            // categoryCreateButton
            // 
            categoryCreateButton.Location = new Point(101, 57);
            categoryCreateButton.Name = "categoryCreateButton";
            categoryCreateButton.Size = new Size(116, 42);
            categoryCreateButton.TabIndex = 0;
            categoryCreateButton.Text = "카테고리 생성";
            categoryCreateButton.UseVisualStyleBackColor = true;
            categoryCreateButton.Click += categoryCreateButton_Click;
            // 
            // categoryRemoveButton
            // 
            categoryRemoveButton.Location = new Point(249, 57);
            categoryRemoveButton.Name = "categoryRemoveButton";
            categoryRemoveButton.Size = new Size(106, 42);
            categoryRemoveButton.TabIndex = 1;
            categoryRemoveButton.Text = "카테고리 삭제";
            categoryRemoveButton.UseVisualStyleBackColor = true;
            categoryRemoveButton.Click += categoryRemoveButton_Click;
            // 
            // categoryUpdateButton
            // 
            categoryUpdateButton.Location = new Point(377, 57);
            categoryUpdateButton.Name = "categoryUpdateButton";
            categoryUpdateButton.Size = new Size(110, 42);
            categoryUpdateButton.TabIndex = 2;
            categoryUpdateButton.Text = "카테고리 저장";
            categoryUpdateButton.UseVisualStyleBackColor = true;
            categoryUpdateButton.Click += categoryUpdateButton_Click;
            // 
            // CategoryListView
            // 
            CategoryListView.Location = new Point(98, 125);
            CategoryListView.Name = "CategoryListView";
            CategoryListView.Size = new Size(391, 236);
            CategoryListView.TabIndex = 3;
            CategoryListView.UseCompatibleStateImageBehavior = false;
            // 
            // CategoryManagerBoundary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 459);
            Controls.Add(CategoryListView);
            Controls.Add(categoryUpdateButton);
            Controls.Add(categoryRemoveButton);
            Controls.Add(categoryCreateButton);
            Name = "CategoryManagerBoundary";
            Text = "CategoryManagerBoundary";
            ResumeLayout(false);
        }

        #endregion

        private Button categoryCreateButton;
        private Button categoryRemoveButton;
        private Button categoryUpdateButton;
        private ListView CategoryListView;
    }
}