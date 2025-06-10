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

        public bool IsDuplicated(List<MenuEntity> menus, string newName, int? currentId = null)
        {
            return menus.Any(m =>
                m.MenuName == newName &&
                (!currentId.HasValue || m.Id != currentId.Value)
            );
        }
    }
}
