using POS.Entity;
using POS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Controller
{
    public class MenuEditController
    {
        private MenuRepository menuRepository;

        public void MenuEdit(MenuEntity menu,string name,int price)
        {
            menu.menuName = name;
            menu.menuPrice = price;

            menuRepository.Update(menu);
        }

    }
}
