using Microsoft.EntityFrameworkCore;
using POS.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POS.Repository
{
    public class MenuRepository
    {
        public List<MenuEntity> GetAllMenus()
        {
            using var context = DbContextFactory.Create();
            return context.Menus.AsNoTracking().ToList();
        }

        public void Insert(string name, int price, int categoryId, byte[]? imageBytes)
        {
            using var context = DbContextFactory.Create();
            var menu = new MenuEntity
            {
                MenuName = name,
                MenuPrice = price,
                CategoryId = categoryId,
                MenuImage = imageBytes,
            };
            context.Menus.Add(menu);
            context.SaveChanges();
        }

        public void Update(MenuEntity menuEntity)
        {
            using var context = DbContextFactory.Create();
            var existing = context.Menus.Find(menuEntity.Id);
            if (existing != null)
            {
                context.Entry(existing).CurrentValues.SetValues(menuEntity);
                context.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("수정할 메뉴를 찾을 수 없습니다.");
            }
        }

        public void Delete(MenuEntity menuEntity)
        {
            using var context = DbContextFactory.Create();
            int menuId = menuEntity.Id;
            bool hasOrderItems = context.OrderItems.Any(o => o.MenuId == menuId);
            if (hasOrderItems)
                throw new InvalidOperationException("해당 메뉴는 주문 내역에 포함되어 있어 삭제할 수 없습니다.");

            var menu = context.Menus.Find(menuId);
            if (menu != null)
            {
                context.Menus.Remove(menu);
                context.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("삭제할 메뉴를 찾을 수 없습니다.");
            }
        }
    }
}
