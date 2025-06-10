using Microsoft.EntityFrameworkCore;
using POS.Domain;
using System;
using System.Linq;

namespace POS.Repository
{
    public class OrderAndPayRepository
    {
        public bool ProcessPaymentByTable(int tableId)
        {
            using var context = DbContextFactory.Create();
            using var transaction = context.Database.BeginTransaction();

            try
            {
                var unpaidOrders = context.Orders
                    .Include(o => o.Items)
                    .Where(o => o.TableId == tableId && !o.IsPaid)
                    .ToList();

                if (!unpaidOrders.Any()) return false;

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
                        context.Sales.Add(sale);
                    }
                    order.IsPaid = true;
                }

                context.SaveChanges();
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
            using var context = DbContextFactory.Create();
            return context.Orders
                .Include(o => o.Items)
                .Where(o => o.TableId == tableId && !o.IsPaid)
                .SelectMany(order => order.Items.Select(item => new
                {
                    TableId = order.TableId,
                    MenuName = item.MenuName,
                    Qty = item.Qty,
                    UnitPrice = item.UnitPrice,
                    Total = item.Qty * item.UnitPrice,
                    OrderTime = order.CreatedAt
                })).AsNoTracking().ToList<dynamic>();
        }
    }
}