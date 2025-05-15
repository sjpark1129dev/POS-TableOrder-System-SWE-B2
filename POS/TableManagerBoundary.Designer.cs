namespace POS
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
            tableLayoutPanel2 = new TableLayoutPanel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            panel7 = new Panel();
            tableSaveButton = new Button();
            tableDeleteButton = new Button();
            tableCreateButton = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(panel6, 1, 2);
            tableLayoutPanel2.Controls.Add(panel5, 0, 2);
            tableLayoutPanel2.Controls.Add(panel4, 1, 1);
            tableLayoutPanel2.Controls.Add(panel3, 0, 1);
            tableLayoutPanel2.Controls.Add(panel2, 1, 0);
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(394, 444);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(200, 297);
            panel6.Name = "panel6";
            panel6.Size = new Size(191, 100);
            panel6.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(3, 297);
            panel5.Name = "panel5";
            panel5.Size = new Size(191, 100);
            panel5.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(200, 150);
            panel4.Name = "panel4";
            panel4.Size = new Size(191, 100);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(3, 150);
            panel3.Name = "panel3";
            panel3.Size = new Size(191, 100);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(200, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(191, 100);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(191, 100);
            panel1.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(tableSaveButton);
            panel7.Controls.Add(tableDeleteButton);
            panel7.Controls.Add(tableCreateButton);
            panel7.Controls.Add(label1);
            panel7.Controls.Add(textBox1);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(403, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(394, 444);
            panel7.TabIndex = 1;
            // 
            // tableSaveButton
            // 
            tableSaveButton.Location = new Point(72, 329);
            tableSaveButton.Name = "tableSaveButton";
            tableSaveButton.Size = new Size(269, 37);
            tableSaveButton.TabIndex = 6;
            tableSaveButton.Text = "테이블 저장";
            tableSaveButton.UseVisualStyleBackColor = true;
            tableSaveButton.Click += tableSaveButton_Click;
            // 
            // tableDeleteButton
            // 
            tableDeleteButton.Location = new Point(72, 274);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 35);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 0;
            // 
            // TableManagerBoundary
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "TableManagerBoundary";
            Text = "TableManagerBoundary";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Panel panel7;
        private Button tableSaveButton;
        private Button tableDeleteButton;
        private Button tableCreateButton;
        private Label label1;
        private TextBox textBox1;
    }
}