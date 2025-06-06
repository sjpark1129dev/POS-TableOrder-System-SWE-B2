using Microsoft.EntityFrameworkCore;
using POS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Delete(MenuEntity menu)
        {
            // 1. 메뉴가 사용된 적 있는지 검사
            bool hasOrderItems = _context.OrderItems.Any(o => o.MenuId == menu.Id);

            if (hasOrderItems)
            {
                throw new InvalidOperationException("해당 메뉴는 주문 내역에 포함되어 있어 삭제할 수 없습니다.");
            }

            // 2. 기존 추적 확인 후 삭제
            var existing = _context.Menus.Local.FirstOrDefault(m => m.Id == menu.Id);
            if (existing == null)
            {
                _context.Menus.Attach(menu);
            }

            _context.Menus.Remove(menu);
            _context.SaveChanges();
        }
    }
}
