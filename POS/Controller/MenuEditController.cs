using POS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Domain;

namespace POS.Controller
{
    public class MenuEditController
    {
        private MenuRepository menuRepository;
        public MenuEditController()
        {
            menuRepository = new MenuRepository();
        }

        public void MenuEdit(MenuEntity menu,string name,int price)
        {
            menu.menuName = name;
            menu.menuPrice = price;

            menuRepository.Update(menu);
        }

    }
}
