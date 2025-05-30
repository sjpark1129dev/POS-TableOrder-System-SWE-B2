using POS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Domain;

namespace POS.Controller
{
    public class MenuLoadController
    {
        private MenuRepository menuRepository;
        public MenuLoadController()
        {
            menuRepository = new MenuRepository();
        }
        public List<MenuEntity> MenuLoad()
        {
            return menuRepository.GetAllMenus();
        }
    }
}
