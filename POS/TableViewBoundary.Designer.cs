namespace POS
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
            TableManagerButton = new Button();
            MenuManagerButton = new Button();
            SalesManagerButton = new Button();
            LunchTimeButton = new Button();
            SuspendLayout();
            // 
            // TableManagerButton
            // 
            TableManagerButton.Location = new Point(37, 30);
            TableManagerButton.Name = "TableManagerButton";
            TableManagerButton.Size = new Size(111, 40);
            TableManagerButton.TabIndex = 0;
            TableManagerButton.Text = "테이블 관리";
            TableManagerButton.UseVisualStyleBackColor = true;
            TableManagerButton.Click += TableManagerButton_Click;
            // 
            // MenuManagerButton
            // 
            MenuManagerButton.Location = new Point(229, 30);
            MenuManagerButton.Name = "MenuManagerButton";
            MenuManagerButton.Size = new Size(111, 40);
            MenuManagerButton.TabIndex = 1;
            MenuManagerButton.Text = "메뉴 관리";
            MenuManagerButton.UseVisualStyleBackColor = true;
            // 
            // SalesManagerButton
            // 
            SalesManagerButton.Location = new Point(431, 30);
            SalesManagerButton.Name = "SalesManagerButton";
            SalesManagerButton.Size = new Size(111, 40);
            SalesManagerButton.TabIndex = 2;
            SalesManagerButton.Text = "매출 관리";
            SalesManagerButton.UseVisualStyleBackColor = true;
            // 
            // LunchTimeButton
            // 
            LunchTimeButton.Location = new Point(633, 30);
            LunchTimeButton.Name = "LunchTimeButton";
            LunchTimeButton.Size = new Size(111, 40);
            LunchTimeButton.TabIndex = 3;
            LunchTimeButton.Text = "특선 전환";
            LunchTimeButton.UseVisualStyleBackColor = true;
            // 
            // TableViewBoundary
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(800, 450);
            Controls.Add(LunchTimeButton);
            Controls.Add(SalesManagerButton);
            Controls.Add(MenuManagerButton);
            Controls.Add(TableManagerButton);
            Name = "TableViewBoundary";
            Text = "TableViewBoundary";
            ResumeLayout(false);
        }

        #endregion

        private Button TableManagerButton;
        private Button MenuManagerButton;
        private Button SalesManagerButton;
        private Button LunchTimeButton;
    }
}
