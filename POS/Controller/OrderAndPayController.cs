using System.Collections.Generic;
using POS.Repository;
using POS.Domain;

namespace POS.Controller
{
    internal class OrderAndPayController
    {
        private OrderAndPaymentRepository paymentRepository;

        public OrderAndPayController()
        {
            paymentRepository = new OrderAndPaymentRepository();
        }

        // 결제 예정 금액 계산: 결제 안된 주문들의 아이템 가격 * 수량 합산
        public int getPendingPaymentAmount()
        {
            var unpaidOrders = paymentRepository.LoadAllOrders();

            int totalAmount = 0;

            foreach (var order in unpaidOrders)
            {
                // 결제 안 된 주문만 합산
                if (!order.IsPaid)
                {
                    foreach (var item in order.Items)
                    {
                        totalAmount += item.UnitPrice * item.Qty;
                    }
                }
            }

            return totalAmount;
        }

        // 결제 처리 시 호출: 주문 Entity 받아서 결제 정보 저장
        public void insertPayment(OrderEntity order)
        {
            paymentRepository.insertPayment(order);
        }
    }
}