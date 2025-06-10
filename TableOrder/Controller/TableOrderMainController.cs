using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using POS.Domain;
using TableOrder.Repository;

namespace TableOrder.Controller
{

    public class TableOrderMainController
    {
        private readonly TableOrderMainRepository tableOrderMainRepository;

        public TableOrderMainController()
        {
            tableOrderMainRepository = new TableOrderMainRepository();
        }

        public List<MenuEntity> LoadMenus()
        {
            return tableOrderMainRepository.GetAllMenus();
        }

        public List<CategoryEntity> LoadCategories()
        {
            return tableOrderMainRepository.GetAllCategories();
        }

        public void OrderRequest(int tableId, List<MenuEntity> menuList)
        {
            tableOrderMainRepository.SaveOrder(tableId, menuList);
        }

        public List<TableEntity> GetAllTables()
        {
            return tableOrderMainRepository.GetAllTables();
        }
    }
}
