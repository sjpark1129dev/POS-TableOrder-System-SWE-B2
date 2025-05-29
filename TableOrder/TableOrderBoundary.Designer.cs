namespace TableOrder
{
    partial class TableOrderBoundary
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            flowLayoutPanelMenus = new FlowLayoutPanel();
            flowLayoutPanelCategory = new FlowLayoutPanel();
            orderCheckButton = new Button();
            orderButton = new Button();
            shoppingList = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanelMenus);
            panel1.Controls.Add(flowLayoutPanelCategory);
            panel1.Controls.Add(orderCheckButton);
            panel1.Controls.Add(orderButton);
            panel1.Controls.Add(shoppingList);
            panel1.Location = new Point(12, 15);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 532);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanelMenus
            // 
            flowLayoutPanelMenus.Location = new Point(149, 9);
            flowLayoutPanelMenus.Name = "flowLayoutPanelMenus";
            flowLayoutPanelMenus.Size = new Size(430, 456);
            flowLayoutPanelMenus.TabIndex = 52;
            // 
            // flowLayoutPanelCategory
            // 
            flowLayoutPanelCategory.AutoScroll = true;
            flowLayoutPanelCategory.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelCategory.Location = new Point(3, 3);
            flowLayoutPanelCategory.Name = "flowLayoutPanelCategory";
            flowLayoutPanelCategory.Size = new Size(136, 462);
            flowLayoutPanelCategory.TabIndex = 51;
            // 
            // orderCheckButton
            // 
            orderCheckButton.Location = new Point(3, 472);
            orderCheckButton.Margin = new Padding(3, 4, 3, 4);
            orderCheckButton.Name = "orderCheckButton";
            orderCheckButton.Size = new Size(174, 56);
            orderCheckButton.TabIndex = 8;
            orderCheckButton.Text = "주문내역조회";
            orderCheckButton.UseVisualStyleBackColor = true;
            orderCheckButton.Click += orderCheckButton_Click;
            // 
            // orderButton
            // 
            orderButton.Location = new Point(585, 472);
            orderButton.Margin = new Padding(3, 4, 3, 4);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(188, 56);
            orderButton.TabIndex = 7;
            orderButton.Text = "주문";
            orderButton.UseVisualStyleBackColor = true;
            orderButton.Click += orderButton_Click;
            // 
            // shoppingList
            // 
            shoppingList.FormattingEnabled = true;
            shoppingList.ItemHeight = 15;
            shoppingList.Location = new Point(585, 9);
            shoppingList.Margin = new Padding(3, 4, 3, 4);
            shoppingList.Name = "shoppingList";
            shoppingList.Size = new Size(188, 454);
            shoppingList.TabIndex = 6;
            shoppingList.Tag = "cart";
            // 
            // TableOrderBoundary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TableOrderBoundary";
            Text = "TableOrderBoundary";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button orderCheckButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.ListBox shoppingList;
        private FlowLayoutPanel flowLayoutPanelMenus;
        private FlowLayoutPanel flowLayoutPanelCategory;
    }
}

