using MaterialSkin.Controls;

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
            comboBoxTableSelector = new MaterialComboBox();
            labelTotalPrice = new MaterialLabel();
            flowLayoutPanelCategory = new FlowLayoutPanel();
            orderCheckButton = new MaterialButton();
            orderButton = new MaterialButton();
            shoppingList = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanelMenus);
            panel1.Controls.Add(comboBoxTableSelector);
            panel1.Controls.Add(labelTotalPrice);
            panel1.Controls.Add(flowLayoutPanelCategory);
            panel1.Controls.Add(orderCheckButton);
            panel1.Controls.Add(orderButton);
            panel1.Controls.Add(shoppingList);
            panel1.Location = new Point(6, 68);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(788, 487);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanelMenus
            // 
            flowLayoutPanelMenus.Location = new Point(180, 3);
            flowLayoutPanelMenus.Name = "flowLayoutPanelMenus";
            flowLayoutPanelMenus.Size = new Size(399, 400);
            flowLayoutPanelMenus.TabIndex = 52;
            // 
            // comboBoxTableSelector
            // 
            comboBoxTableSelector.AutoResize = false;
            comboBoxTableSelector.BackColor = Color.FromArgb(255, 255, 255);
            comboBoxTableSelector.Depth = 0;
            comboBoxTableSelector.DrawMode = DrawMode.OwnerDrawVariable;
            comboBoxTableSelector.DropDownHeight = 174;
            comboBoxTableSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTableSelector.DropDownWidth = 121;
            comboBoxTableSelector.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboBoxTableSelector.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboBoxTableSelector.FormattingEnabled = true;
            comboBoxTableSelector.IntegralHeight = false;
            comboBoxTableSelector.ItemHeight = 43;
            comboBoxTableSelector.Location = new Point(286, 420);
            comboBoxTableSelector.MaxDropDownItems = 4;
            comboBoxTableSelector.MouseState = MaterialSkin.MouseState.OUT;
            comboBoxTableSelector.Name = "comboBoxTableSelector";
            comboBoxTableSelector.Size = new Size(189, 49);
            comboBoxTableSelector.StartIndex = 0;
            comboBoxTableSelector.TabIndex = 54;
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Depth = 0;
            labelTotalPrice.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelTotalPrice.Location = new Point(650, 384);
            labelTotalPrice.MouseState = MaterialSkin.MouseState.HOVER;
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(66, 19);
            labelTotalPrice.TabIndex = 53;
            labelTotalPrice.Text = "총가격: 0원";
            // 
            // flowLayoutPanelCategory
            // 
            flowLayoutPanelCategory.AutoScroll = true;
            flowLayoutPanelCategory.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelCategory.Location = new Point(3, 3);
            flowLayoutPanelCategory.Name = "flowLayoutPanelCategory";
            flowLayoutPanelCategory.Size = new Size(171, 400);
            flowLayoutPanelCategory.TabIndex = 51;
            // 
            // orderCheckButton
            // 
            orderCheckButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            orderCheckButton.Density = MaterialButton.MaterialButtonDensity.Default;
            orderCheckButton.Depth = 0;
            orderCheckButton.HighEmphasis = true;
            orderCheckButton.Icon = null;
            orderCheckButton.Location = new Point(3, 410);
            orderCheckButton.Margin = new Padding(3, 4, 3, 4);
            orderCheckButton.MinimumSize = new Size(174, 67);
            orderCheckButton.MouseState = MaterialSkin.MouseState.HOVER;
            orderCheckButton.Name = "orderCheckButton";
            orderCheckButton.NoAccentTextColor = Color.Empty;
            orderCheckButton.Size = new Size(174, 67);
            orderCheckButton.TabIndex = 8;
            orderCheckButton.Text = "주문내역조회";
            orderCheckButton.Type = MaterialButton.MaterialButtonType.Contained;
            orderCheckButton.UseAccentColor = false;
            orderCheckButton.UseVisualStyleBackColor = true;
            orderCheckButton.Click += orderCheckButton_Click;
            // 
            // orderButton
            // 
            orderButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            orderButton.Density = MaterialButton.MaterialButtonDensity.Default;
            orderButton.Depth = 0;
            orderButton.HighEmphasis = true;
            orderButton.Icon = null;
            orderButton.Location = new Point(585, 411);
            orderButton.Margin = new Padding(3, 4, 3, 4);
            orderButton.MinimumSize = new Size(200, 66);
            orderButton.MouseState = MaterialSkin.MouseState.HOVER;
            orderButton.Name = "orderButton";
            orderButton.NoAccentTextColor = Color.Empty;
            orderButton.Size = new Size(200, 66);
            orderButton.TabIndex = 7;
            orderButton.Text = "주문";
            orderButton.Type = MaterialButton.MaterialButtonType.Contained;
            orderButton.UseAccentColor = false;
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
            shoppingList.Size = new Size(200, 364);
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
            Text = "테이블오더 - 주문하기";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox shoppingList;
        private FlowLayoutPanel flowLayoutPanelMenus;
        private FlowLayoutPanel flowLayoutPanelCategory;
        private MaterialSkin.Controls.MaterialLabel labelTotalPrice;
        private MaterialButton orderCheckButton;
        private MaterialButton orderButton;
        private MaterialComboBox comboBoxTableSelector;
    }
}

