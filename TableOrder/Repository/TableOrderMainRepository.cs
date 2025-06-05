using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using POS.Domain;

namespace TableOrder.Repository
{
    public class TableOrderMainRepository
    {
        private readonly AppDbContext _context;

        public TableOrderMainRepository()
        {
            _context = AppDbContext.Instance;
        }

        public List<MenuEntity> GetAllMenus()
        {
            return _context.Menus.ToList(); // ImageData 포함
        }

        public List<CategoryEntity> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public bool SaveOrder(int tableId, List<MenuEntity> menuList)
        {
            var context = AppDbContext.Instance;

            var order = new OrderEntity
            {
                TableId = tableId,
                CreatedAt = DateTime.Now,
                IsPaid = false,
                Items = new List<OrderItemEntity>()
            };

            // 그룹핑: 메뉴별 수량 계산
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
                    MenuName = g.Menu.MenuName,
                    Qty = g.Qty,
                    UnitPrice = g.Menu.MenuPrice
                };
                order.Items.Add(item);
            }

            context.Orders.Add(order);
            context.SaveChanges();
            return true;
        }

        public List<TableEntity> GetAllTables()
        {
            return _context.Tables.ToList();
        }
    }
}
