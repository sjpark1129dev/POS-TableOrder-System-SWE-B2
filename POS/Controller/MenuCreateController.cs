using POS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Entity;

namespace POS.Controller
{

    public class MenuCreateController {
    
        private MenuRepository menuRepository;

        public void MenuCreate(string name, int price)
        {

        }

        public bool Isduplicated(List<MenuEntity> menuList, string name)
        {
            return false;
        }

    }

}
