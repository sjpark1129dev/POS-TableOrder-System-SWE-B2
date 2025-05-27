using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableOrder.Repository;
using POS.Entity;

namespace TableOrder.Controller
{
    
    public class TableOrderMainController
    {
        private readonly TableOrderMainRepository _tableOrderMainRepository;

        public TableOrderMainController(TableOrderMainRepository repository)
        {
            _tableOrderMainRepository = repository;
        }

        public List<MenuEntity> MenuAndCategoryLoad()
        {
            return _tableOrderMainRepository.GetAllMenus();
        }

        public int CartPriceSum(List<MenuEntity> cart)
        {
            return 1;
            // return cart.Sum(item => item.menuPrice * item.Quantity);
        }

        public void OrderRequest(List<MenuEntity> cart)
        {
            _tableOrderMainRepository.InsertOrder(cart);
        }
    }
}
