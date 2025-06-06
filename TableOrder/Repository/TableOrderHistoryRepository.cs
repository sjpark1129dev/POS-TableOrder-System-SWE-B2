using Microsoft.EntityFrameworkCore;
using POS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableOrder.Repository
{
    public class TableOrderHistoryRepository
    {
        public List<OrderEntity> GetUnpaidOrdersByTable(int tableId)
        {
            using var context = DbContextFactory.Create();
            return context.Orders
                .Where(o => o.TableId == tableId && !o.IsPaid)
                .Include(o => o.Items)
                .ToList();
        }
    }
}
