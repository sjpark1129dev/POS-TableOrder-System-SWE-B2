using Microsoft.EntityFrameworkCore;
using POS.Domain;
using System;
using System.Linq;

namespace POS.Repository
{
    internal class OrderAndPaymentRepository
    {
        private readonly AppDbContext _context = AppDbContext.Instance;
        public bool ProcessPaymentByTable(int tableId)
        {
            using var transaction = _context.Database.BeginTransaction();

            try
            {
                var unpaidOrders = _context.Orders
                    .Include(o => o.Items)
                    .Where(o => o.TableId == tableId && !o.IsPaid)
                    .ToList();

                if (!unpaidOrders.Any())
                    return false;

                string recNum = $"{DateTime.Now:yyyyMMdd}-{Guid.NewGuid().ToString()[..4]}";

                foreach (var order in unpaidOrders)
                {
                    foreach (var item in order.Items)
                    {
                        var sale = new SalesEntity
                        {
                            SalesDate = DateTime.Now,
                            RecNum = recNum,
                            TableId = order.TableId,
                            MenuName = item.MenuName,
                            Qty = item.Qty,
                            UnitPrice = item.UnitPrice,
                            Price = item.Qty * item.UnitPrice
                        };

                        _context.Sales.Add(sale);
                    }

                    order.IsPaid = true;
                }

                _context.SaveChanges();
                transaction.Commit();

                return true;
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public List<dynamic> GetUnpaidOrdersForGridByTable(int tableId)
        {
            var result = _context.Orders
                .Include(o => o.Items)
                .Where(o => o.TableId == tableId && !o.IsPaid)  // ✅ 여기!
                .SelectMany(order => order.Items.Select(item => new
                {
                    TableId = order.TableId,
                    MenuName = item.MenuName,
                    Qty = item.Qty,
                    UnitPrice = item.UnitPrice,
                    Total = item.Qty * item.UnitPrice,
                    OrderTime = order.CreatedAt
                }))
                .ToList<dynamic>();

            return result;
        }
    }
}