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
            Table1 = new Panel();
            tableNumber = new Label();
            totalAmount = new Label();
            exampleMenu = new Label();
            menuCount = new Label();
            Table2 = new Panel();
            menuCount2 = new Label();
            exampleMenu2 = new Label();
            totalAmount2 = new Label();
            tableNumber2 = new Label();
            Table3 = new Panel();
            Table4 = new Panel();
            menuCount4 = new Label();
            exampleMenu4 = new Label();
            totalAmount4 = new Label();
            tableNumber4 = new Label();
            Table5 = new Panel();
            menuCount5 = new Label();
            exampleMenu5 = new Label();
            totalAmount5 = new Label();
            tableNumber5 = new Label();
            Table6 = new Panel();
            menuCount6 = new Label();
            exampleMenu6 = new Label();
            totalAmount6 = new Label();
            tableNumber6 = new Label();
            listBox1 = new ListBox();
            totalAmount3 = new Label();
            tableNumber3 = new Label();
            Table1.SuspendLayout();
            Table2.SuspendLayout();
            Table3.SuspendLayout();
            Table4.SuspendLayout();
            Table5.SuspendLayout();
            Table6.SuspendLayout();
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
            MenuManagerButton.Click += MenuManagerButton_Click;
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
            // Table1
            // 
            Table1.Controls.Add(menuCount);
            Table1.Controls.Add(exampleMenu);
            Table1.Controls.Add(totalAmount);
            Table1.Controls.Add(tableNumber);
            Table1.Location = new Point(38, 108);
            Table1.Name = "Table1";
            Table1.Size = new Size(197, 139);
            Table1.TabIndex = 4;
            // 
            // tableNumber
            // 
            tableNumber.AutoSize = true;
            tableNumber.Location = new Point(12, 12);
            tableNumber.Name = "tableNumber";
            tableNumber.Size = new Size(66, 15);
            tableNumber.TabIndex = 0;
            tableNumber.Text = "1번 테이블";
            tableNumber.Click += label1_Click;
            // 
            // totalAmount
            // 
            totalAmount.AutoSize = true;
            totalAmount.Location = new Point(124, 112);
            totalAmount.Name = "totalAmount";
            totalAmount.Size = new Size(70, 15);
            totalAmount.TabIndex = 1;
            totalAmount.Text = "총액:@@원";
            // 
            // exampleMenu
            // 
            exampleMenu.AutoSize = true;
            exampleMenu.Location = new Point(12, 41);
            exampleMenu.Name = "exampleMenu";
            exampleMenu.Size = new Size(43, 15);
            exampleMenu.TabIndex = 2;
            exampleMenu.Text = "삼겹살";
            // 
            // menuCount
            // 
            menuCount.AutoSize = true;
            menuCount.Location = new Point(59, 41);
            menuCount.Name = "menuCount";
            menuCount.Size = new Size(19, 15);
            menuCount.TabIndex = 3;
            menuCount.Text = "*2";
            // 
            // Table2
            // 
            Table2.Controls.Add(menuCount2);
            Table2.Controls.Add(exampleMenu2);
            Table2.Controls.Add(totalAmount2);
            Table2.Controls.Add(tableNumber2);
            Table2.Location = new Point(282, 108);
            Table2.Name = "Table2";
            Table2.Size = new Size(197, 139);
            Table2.TabIndex = 5;
            // 
            // menuCount2
            // 
            menuCount2.AutoSize = true;
            menuCount2.Location = new Point(59, 41);
            menuCount2.Name = "menuCount2";
            menuCount2.Size = new Size(19, 15);
            menuCount2.TabIndex = 3;
            menuCount2.Text = "*5";
            // 
            // exampleMenu2
            // 
            exampleMenu2.AutoSize = true;
            exampleMenu2.Location = new Point(12, 41);
            exampleMenu2.Name = "exampleMenu2";
            exampleMenu2.Size = new Size(31, 15);
            exampleMenu2.TabIndex = 2;
            exampleMenu2.Text = "목살";
            // 
            // totalAmount2
            // 
            totalAmount2.AutoSize = true;
            totalAmount2.Location = new Point(124, 112);
            totalAmount2.Name = "totalAmount2";
            totalAmount2.Size = new Size(70, 15);
            totalAmount2.TabIndex = 1;
            totalAmount2.Text = "총액:@@원";
            // 
            // tableNumber2
            // 
            tableNumber2.AutoSize = true;
            tableNumber2.Location = new Point(12, 12);
            tableNumber2.Name = "tableNumber2";
            tableNumber2.Size = new Size(66, 15);
            tableNumber2.TabIndex = 0;
            tableNumber2.Text = "2번 테이블";
            // 
            // Table3
            // 
            Table3.Controls.Add(tableNumber3);
            Table3.Controls.Add(totalAmount3);
            Table3.Controls.Add(listBox1);
            Table3.Location = new Point(547, 108);
            Table3.Name = "Table3";
            Table3.Size = new Size(197, 139);
            Table3.TabIndex = 6;
            // 
            // Table4
            // 
            Table4.Controls.Add(menuCount4);
            Table4.Controls.Add(exampleMenu4);
            Table4.Controls.Add(totalAmount4);
            Table4.Controls.Add(tableNumber4);
            Table4.Location = new Point(38, 275);
            Table4.Name = "Table4";
            Table4.Size = new Size(197, 139);
            Table4.TabIndex = 5;
            // 
            // menuCount4
            // 
            menuCount4.AutoSize = true;
            menuCount4.Location = new Point(59, 41);
            menuCount4.Name = "menuCount4";
            menuCount4.Size = new Size(19, 15);
            menuCount4.TabIndex = 3;
            menuCount4.Text = "*2";
            // 
            // exampleMenu4
            // 
            exampleMenu4.AutoSize = true;
            exampleMenu4.Location = new Point(12, 41);
            exampleMenu4.Name = "exampleMenu4";
            exampleMenu4.Size = new Size(43, 15);
            exampleMenu4.TabIndex = 2;
            exampleMenu4.Text = "삼겹살";
            // 
            // totalAmount4
            // 
            totalAmount4.AutoSize = true;
            totalAmount4.Location = new Point(124, 112);
            totalAmount4.Name = "totalAmount4";
            totalAmount4.Size = new Size(70, 15);
            totalAmount4.TabIndex = 1;
            totalAmount4.Text = "총액:@@원";
            // 
            // tableNumber4
            // 
            tableNumber4.AutoSize = true;
            tableNumber4.Location = new Point(12, 12);
            tableNumber4.Name = "tableNumber4";
            tableNumber4.Size = new Size(66, 15);
            tableNumber4.TabIndex = 0;
            tableNumber4.Text = "4번 테이블";
            // 
            // Table5
            // 
            Table5.Controls.Add(menuCount5);
            Table5.Controls.Add(exampleMenu5);
            Table5.Controls.Add(totalAmount5);
            Table5.Controls.Add(tableNumber5);
            Table5.Location = new Point(282, 275);
            Table5.Name = "Table5";
            Table5.Size = new Size(197, 139);
            Table5.TabIndex = 5;
            // 
            // menuCount5
            // 
            menuCount5.AutoSize = true;
            menuCount5.Location = new Point(59, 41);
            menuCount5.Name = "menuCount5";
            menuCount5.Size = new Size(19, 15);
            menuCount5.TabIndex = 3;
            menuCount5.Text = "*2";
            // 
            // exampleMenu5
            // 
            exampleMenu5.AutoSize = true;
            exampleMenu5.Location = new Point(12, 41);
            exampleMenu5.Name = "exampleMenu5";
            exampleMenu5.Size = new Size(43, 15);
            exampleMenu5.TabIndex = 2;
            exampleMenu5.Text = "삼겹살";
            // 
            // totalAmount5
            // 
            totalAmount5.AutoSize = true;
            totalAmount5.Location = new Point(124, 112);
            totalAmount5.Name = "totalAmount5";
            totalAmount5.Size = new Size(70, 15);
            totalAmount5.TabIndex = 1;
            totalAmount5.Text = "총액:@@원";
            // 
            // tableNumber5
            // 
            tableNumber5.AutoSize = true;
            tableNumber5.Location = new Point(12, 12);
            tableNumber5.Name = "tableNumber5";
            tableNumber5.Size = new Size(66, 15);
            tableNumber5.TabIndex = 0;
            tableNumber5.Text = "5번 테이블";
            // 
            // Table6
            // 
            Table6.Controls.Add(menuCount6);
            Table6.Controls.Add(exampleMenu6);
            Table6.Controls.Add(totalAmount6);
            Table6.Controls.Add(tableNumber6);
            Table6.Location = new Point(547, 275);
            Table6.Name = "Table6";
            Table6.Size = new Size(197, 139);
            Table6.TabIndex = 5;
            // 
            // menuCount6
            // 
            menuCount6.AutoSize = true;
            menuCount6.Location = new Point(59, 41);
            menuCount6.Name = "menuCount6";
            menuCount6.Size = new Size(19, 15);
            menuCount6.TabIndex = 3;
            menuCount6.Text = "*2";
            // 
            // exampleMenu6
            // 
            exampleMenu6.AutoSize = true;
            exampleMenu6.Location = new Point(12, 41);
            exampleMenu6.Name = "exampleMenu6";
            exampleMenu6.Size = new Size(43, 15);
            exampleMenu6.TabIndex = 2;
            exampleMenu6.Text = "삼겹살";
            // 
            // totalAmount6
            // 
            totalAmount6.AutoSize = true;
            totalAmount6.Location = new Point(124, 112);
            totalAmount6.Name = "totalAmount6";
            totalAmount6.Size = new Size(70, 15);
            totalAmount6.TabIndex = 1;
            totalAmount6.Text = "총액:@@원";
            // 
            // tableNumber6
            // 
            tableNumber6.AutoSize = true;
            tableNumber6.Location = new Point(12, 12);
            tableNumber6.Name = "tableNumber6";
            tableNumber6.Size = new Size(66, 15);
            tableNumber6.TabIndex = 0;
            tableNumber6.Text = "6번 테이블";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 30);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(163, 79);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // totalAmount3
            // 
            totalAmount3.AutoSize = true;
            totalAmount3.Location = new Point(124, 112);
            totalAmount3.Name = "totalAmount3";
            totalAmount3.Size = new Size(70, 15);
            totalAmount3.TabIndex = 7;
            totalAmount3.Text = "총액:@@원";
            // 
            // tableNumber3
            // 
            tableNumber3.AutoSize = true;
            tableNumber3.Location = new Point(12, 12);
            tableNumber3.Name = "tableNumber3";
            tableNumber3.Size = new Size(66, 15);
            tableNumber3.TabIndex = 4;
            tableNumber3.Text = "3번 테이블";
            // 
            // TableViewBoundary
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(Table6);
            Controls.Add(Table5);
            Controls.Add(Table4);
            Controls.Add(Table3);
            Controls.Add(Table2);
            Controls.Add(Table1);
            Controls.Add(LunchTimeButton);
            Controls.Add(SalesManagerButton);
            Controls.Add(MenuManagerButton);
            Controls.Add(TableManagerButton);
            Name = "TableViewBoundary";
            Text = "TableViewBoundary";
            Table1.ResumeLayout(false);
            Table1.PerformLayout();
            Table2.ResumeLayout(false);
            Table2.PerformLayout();
            Table3.ResumeLayout(false);
            Table3.PerformLayout();
            Table4.ResumeLayout(false);
            Table4.PerformLayout();
            Table5.ResumeLayout(false);
            Table5.PerformLayout();
            Table6.ResumeLayout(false);
            Table6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button TableManagerButton;
        private Button MenuManagerButton;
        private Button SalesManagerButton;
        private Button LunchTimeButton;
        private Panel Table1;
        private Label tableNumber;
        private Label exampleMenu;
        private Label totalAmount;
        private Label menuCount;
        private Panel Table2;
        private Label menuCount2;
        private Label exampleMenu2;
        private Label totalAmount2;
        private Label tableNumber2;
        private Panel Table3;
        private Panel Table4;
        private Label menuCount4;
        private Label exampleMenu4;
        private Label totalAmount4;
        private Label tableNumber4;
        private Panel Table5;
        private Label menuCount5;
        private Label exampleMenu5;
        private Label totalAmount5;
        private Label tableNumber5;
        private Panel Table6;
        private Label menuCount6;
        private Label exampleMenu6;
        private Label totalAmount6;
        private Label tableNumber6;
        private ListBox listBox1;
        private Label tableNumber3;
        private Label totalAmount3;
    }
}
