using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Domain;

namespace POS.Repository
{
    internal class OrderAndPaymentRepository
    {

        private readonly AppDbContext _context = AppDbContext.Instance;


        public void insertPayment()
        {
        }

        public void updatePayment()
        {
        }

        public void deletePayment()
        {
        }

        public List<OrderEntity> LoadAllOrders()
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