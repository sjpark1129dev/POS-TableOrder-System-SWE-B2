using POS.Entity;

namespace POS.Boundary
{
    partial class PayAndOrderManagerBoundary
    {
       
        private System.ComponentModel.IContainer components = null;

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
            listView1 = new ListView();
            Total = new Label();
            cancelAll = new Button();
            cancelselect = new Button();
            EditOrder = new Button();
            cardPayment = new Button();
            cashPayment = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(147, 72);
            listView1.Name = "listView1";
            listView1.Size = new Size(465, 150);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Location = new Point(472, 225);
            Total.Name = "Total";
            Total.Size = new Size(42, 15);
            Total.TabIndex = 1;
            Total.Text = "총액 : ";
            Total.Click += label1_Click;
            // 
            // cancelAll
            // 
            cancelAll.Location = new Point(147, 253);
            cancelAll.Name = "cancelAll";
            cancelAll.Size = new Size(130, 26);
            cancelAll.TabIndex = 2;
            cancelAll.Text = "전체 취소";
            cancelAll.UseVisualStyleBackColor = true;
            // 
            // cancelselect
            // 
            cancelselect.Location = new Point(312, 253);
            cancelselect.Name = "cancelselect";
            cancelselect.Size = new Size(130, 26);
            cancelselect.TabIndex = 3;
            cancelselect.Text = "선택 취소";
            cancelselect.UseVisualStyleBackColor = true;
            // 
            // EditOrder
            // 
            EditOrder.Location = new Point(482, 253);
            EditOrder.Name = "EditOrder";
            EditOrder.Size = new Size(130, 26);
            EditOrder.TabIndex = 4;
            EditOrder.Text = "주문 수정";
            EditOrder.UseVisualStyleBackColor = true;
            // 
            // cardPayment
            // 
            cardPayment.Location = new Point(147, 298);
            cardPayment.Name = "cardPayment";
            cardPayment.Size = new Size(130, 26);
            cardPayment.TabIndex = 5;
            cardPayment.Text = "카드 결제";
            cardPayment.UseVisualStyleBackColor = true;
            // 
            // cashPayment
            // 
            cashPayment.Location = new Point(312, 298);
            cashPayment.Name = "cashPayment";
            cashPayment.Size = new Size(130, 26);
            cashPayment.TabIndex = 6;
            cashPayment.Text = "현금 결제";
            cashPayment.UseVisualStyleBackColor = true;
            // 
            // PayManagerBoundary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 450);
            Controls.Add(cashPayment);
            Controls.Add(cardPayment);
            Controls.Add(EditOrder);
            Controls.Add(cancelselect);
            Controls.Add(cancelAll);
            Controls.Add(Total);
            Controls.Add(listView1);
            Name = "PayManagerBoundary";
            Text = "Form1";
            Load += PayManagerBoundary_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label Total;
        private Button cancelAll;
        private Button cancelselect;
        private Button EditOrder;
        private Button cardPayment;
        private Button cashPayment;

        // 추가된 필드
        private object payController;
        private Label totalAmountLabel;
        private int tableId;
        private List<OrderEntity> orderList;
        private int finalPrice;
        private DataGridView OrderDataView;

        // 추가된 메서드
        private void LoadOrdersToListView()
        {
        }

        private void cancelAllButton_Click(object sender, EventArgs e)
        {
        }

        private void paymentCancelButton_Click(object sender, EventArgs e)
        {
        }

        private void cardPaymentButton_Click(object sender, EventArgs e)
        {
        }

        private void cashPaymentButton_Click(object sender, EventArgs e)
        {
        }

        private void addOrder(int tableId, string menuName, int qty, int price)
        {
        }

        private OrderEntity updateOrde(string receiptnum, string menuName, int qty, int price)
        {
            return null;
        }

        private void deleteOrder(string receiptnum)
        {
        }

        private void saveOrder(string receiptnum, string menuName, int qty, int price)
        {
        }

        private void CalculateTotalPrice()
        {
        }
    }
}