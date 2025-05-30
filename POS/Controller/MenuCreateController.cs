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

        public bool MenuCreate(string name, int price, int categoryId)
        {
            List<MenuEntity> menuList = menuRepository.GetAllMenus(); // 모든 메뉴 조회

            if (Isduplicated(menuList, name))
            {
                
                return false;
            }

            var menu = new MenuEntity
            {
                MenuName = name,
                MenuPrice = price,
                CategoryId = categoryId
            };

            menuRepository.Insert(menu);
            return true;
        }

        public bool Isduplicated(List<MenuEntity> menuList, string name)
        {
            return menuList.Any(menu => menu.MenuName.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

    }

}
