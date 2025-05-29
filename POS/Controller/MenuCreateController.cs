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

        public bool MenuCreate(string name, int price)
        {
            List<MenuEntity> menuList = menuRepository.GetAllMenus(); // 모든 메뉴 조회

            if (Isduplicated(menuList, name))
            {
                
                return false;
            }

            MenuEntity newMenu = new MenuEntity
            {
                menuName = name,
                menuPrice = price
            };

            menuRepository.Insert(newMenu);
            return true;
        }

        public bool Isduplicated(List<MenuEntity> menuList, string name)
        {
            return menuList.Any(menu => menu.menuName.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

    }

}
