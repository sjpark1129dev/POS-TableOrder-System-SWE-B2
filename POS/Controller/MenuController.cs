using POS.Entity;
using POS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Controller
{
    public class MenuController
    {
        private MenuRepository _repository = new MenuRepository();
        public MenuController()
        {

        }
        public List<MenuEntity> GetAllMenus()
        {
            return _repository.GetAllMenus();
        }

        public MenuEntity CreateMenu(string name, decimal price)
        {
            return new MenuEntity(name, price);
        }

        public bool IsDuplicateName(List<MenuEntity> list, string name)
        {
            return list.Any(m => m.menuName.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public void MarkDeleted(List<MenuEntity> menus, int id)
        {
            var menu = GetById(menus, id);
        }

        public MenuEntity? GetById(List<MenuEntity> menus, int id)
        {
            return menus.FirstOrDefault(m => m.Id == id);
        }
    }
}
