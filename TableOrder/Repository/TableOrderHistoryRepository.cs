using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Repository;

namespace TableOrder.Repository
{
    public class TableOrderHistoryRepository
    {
        private readonly AppDbContext _context;

        public TableOrderHistoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool SearchOrderData(int tableID)
        {
            return false;
            // return _context.Any(o => o.TableID == tableID);
        }

        public void GetAllOrder()
        {
            // return new List<OrderEntity>();
            // return _context.Orders;
        }

        public void ShowErrorMessage()
        {
            Console.WriteLine("주문 내역 없음");
        }
    }
}
