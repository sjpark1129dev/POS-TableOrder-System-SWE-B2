using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public int getPendingPaymentAmount()
        {
            return 0;
        }

        public void processCashPayment()
        {
        }

        public void processCardPayment()
        {
        }

        public void toggleSpecialMenu()
        {
        }

        public void registerServiceItem()
        {
        }

        public void cancelPayment()
        {
        }

        public List<OrderEntity> getAllOrder()
        {
            return null;
        }

        public void updateOrder(OrderEntity order)
        {
        }

        public void deleteOrder(OrderEntity order)
        {
        }

        public void saveOrder(List<OrderEntity> orders)
        {
        }
    }
}