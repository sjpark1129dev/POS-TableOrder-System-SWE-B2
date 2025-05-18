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
        private MenuRepository _repository;
        public MenuController(MenuRepository repository)
        {
            _repository = repository;
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
            return list.Any(m => m.State != EntityState.Deleted &&
                                 m.menuName.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public void MarkDeleted(List<MenuEntity> menus, int id)
        {
            var menu = GetById(menus, id);
            if (menu != null)
            {
                menu.State = EntityState.Deleted;
            }
        }

        public MenuEntity? GetById(List<MenuEntity> menus, int id)
        {
            return menus.FirstOrDefault(m => m.Id == id && m.State != EntityState.Deleted);
        }

        public void SaveAllMenus(List<MenuEntity> menuList)
        {
            foreach (var menu in menuList)
            {
                switch (menu.State)
                {
                    case EntityState.New:
                        _repository.Insert(menu);
                        break;
                    case EntityState.Modified:
                        _repository.Update(menu);
                        break;
                    case EntityState.Deleted:
                        _repository.Delete(menu.Id);
                        break;
                }
            }
        }
    }
}
