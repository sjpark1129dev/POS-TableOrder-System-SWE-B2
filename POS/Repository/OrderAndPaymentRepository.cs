using System.Collections.Generic;
using System.Linq;
using POS.Domain;

namespace POS.Repository
{
    internal class OrderAndPaymentRepository
    {
        private readonly AppDbContext _context = AppDbContext.Instance;

        public void insertPayment(OrderEntity order)
        {
            var existingOrder = _context.Orders.Find(order.Id);
            if (existingOrder != null)
            {
                existingOrder.IsPaid = true;
                _context.SaveChanges();
            }
            else
            {
                order.IsPaid = true;
                _context.Orders.Add(order);
                _context.SaveChanges();
            }
        }

        public List<OrderEntity> LoadAllOrders()
        {
            return _context.Orders.Where(o => !o.IsPaid).ToList();
        }
    }
}