using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using POS.Domain;

namespace TableOrder.Repository
{
    public class TableOrderMainRepository
    {
        public List<MenuEntity> GetAllMenus()
        {
            using var context = DbContextFactory.Create();
            return context.Menus.AsNoTracking().ToList();
        }

        public List<CategoryEntity> GetAllCategories()
        {
            using var context = DbContextFactory.Create();
            return context.Categories.AsNoTracking().ToList();
        }

        public void SaveOrder(int tableId, List<MenuEntity> menuList)
        {
            using var context = DbContextFactory.Create();
            var order = new OrderEntity
            {
                TableId = tableId,
                CreatedAt = DateTime.Now,
                IsPaid = false,
                Items = new List<OrderItemEntity>()
            };

            var grouped = menuList
                .GroupBy(m => m.Id)
                .Select(g => new
                {
                    Menu = g.First(),
                    Qty = g.Count()
                });

            foreach (var g in grouped)
            {
                var item = new OrderItemEntity
                {
                    MenuId = g.Menu.Id,
                    MenuName = g.Menu.MenuName,
                    Qty = g.Qty,
                    UnitPrice = g.Menu.MenuPrice
                };
                order.Items.Add(item);
            }

            context.Orders.Add(order);
            context.SaveChanges();
        }

        public List<TableEntity> GetAllTables()
        {
            using var context = DbContextFactory.Create();
            return context.Tables.AsNoTracking().ToList();
        }
    }
}
