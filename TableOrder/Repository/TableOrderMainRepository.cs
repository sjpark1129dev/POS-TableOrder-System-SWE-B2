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

        public void InsertOrder(int tableId, List<MenuEntity> cart)
        {
            if (cart == null || cart.Count == 0)
                throw new ArgumentException("Cart is empty.");

            // 주문 생성
            var order = new OrderEntity
            {
                TableId = tableId,
                CreatedAt = DateTime.Now,
                IsPaid = false,
                Items = new List<OrderItemEntity>()
            };

            // 메뉴별 수량 집계
            var grouped = cart.GroupBy(m => m.MenuName);

            foreach (var group in grouped)
            {
                var menu = group.First();
                int qty = group.Count();

                order.Items.Add(new OrderItemEntity
                {
                    MenuName = menu.MenuName,
                    Qty = qty,
                    UnitPrice = menu.MenuPrice,
                    // Order 속성은 자동 설정됨
                });
            }
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public List<MenuEntity> GetAllMenus()
        {
            return _context.Menus.ToList();
        }
    }
}
