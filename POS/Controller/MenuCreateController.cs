using POS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Domain;

namespace POS.Controller
{
    public class MenuCreateController {
    
        private MenuRepository menuRepository;
        public MenuCreateController()
        {
            menuRepository = new MenuRepository();
        }

        public void MenuCreate(string name, int price, int categoryId, byte[]? imageBytes)
        {
            menuRepository.Insert(name, price, categoryId, imageBytes);
        }

        public bool Isduplicated(List<MenuEntity> menuList, string name)
        {
            return menuList.Any(menu => menu.MenuName.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
