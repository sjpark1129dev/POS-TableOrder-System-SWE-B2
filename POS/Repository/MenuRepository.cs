using POS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Repository
{
    public class MenuRepository
    {
        private readonly AppDbContext _context = AppDbContext.Instance;
        public MenuRepository()
        {
        }
        public List<MenuEntity> GetAllMenus()
        {
            return _context.Menus.ToList(); // DB에서 메뉴 목록 조회
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

        public void Delete(int id)
        {
            var menu = _context.Menus.Find(id);
            if (menu != null)
            {
                _context.Menus.Remove(menu);
                _context.SaveChanges(); // 삭제 후 커밋
            }
        }
    }
}
