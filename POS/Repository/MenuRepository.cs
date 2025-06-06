using Microsoft.EntityFrameworkCore;
using POS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POS.Repository
{
    public class MenuRepository
    {
        private readonly AppDbContext _context;
        public MenuRepository()
        {
            _context = AppDbContext.Instance;
        }
        public List<MenuEntity> GetAllMenus()
        {
            return _context.Menus.AsNoTracking().ToList(); // DB에서 메뉴 목록 조회
        }

        public void Insert(MenuEntity menu)
        {
            _context.Menus.Add(menu);
            _context.SaveChanges(); // 삽입 후 커밋
        }

        public void Update(MenuEntity menu)
        {
            _context.Menus.Update(menu);
            _context.SaveChanges(); // 수정 후 커밋
        }

        public void Delete(MenuEntity menuEntity)
        {
            int menuId = menuEntity.Id;
            // 1. 사용 내역 있는지 확인
            bool hasOrderItems = _context.OrderItems.Any(o => o.MenuId == menuId);
            if (hasOrderItems)
            {
                throw new InvalidOperationException("해당 메뉴는 주문 내역에 포함되어 있어 삭제할 수 없습니다.");
            }

            // 2. DB에서 직접 조회 후 삭제
            var menu = _context.Menus.Find(menuId);
            if (menu != null)
            {
                _context.Menus.Remove(menu);
                _context.SaveChanges();
            }
        }
    }
}
