using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Domain;

namespace TableOrder.Repository
{
    public class TableOrderHistoryRepository
    {
        private readonly AppDbContext _context;

        public TableOrderHistoryRepository()
        {
            _context = AppDbContext.Instance;
        }

        public bool SearchOrderData(int tableID)
        {
            
            return _context.Orders.Any(o => o.TableId == tableID);
        }

        public List<OrderEntity> GetAllOrder()
        {

            return _context.Orders.ToList();
        }

        public void ShowErrorMessage()
        {
            Console.WriteLine("주문 내역 없음");
        }
    }
}
