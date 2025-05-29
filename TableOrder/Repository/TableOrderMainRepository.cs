using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Domain;
using POS.Repository;

namespace TableOrder.Repository
{
    public class TableOrderMainRepository
    {
        private readonly AppDbContext _context;

        public TableOrderMainRepository(AppDbContext context)
        {
            _context = context;
        }

        public void InsertOrder(List<MenuEntity> cart)
        {

        }

        public List<MenuEntity> GetAllMenus()
        {
            return _context.Menus.ToList();
        }
    }
}
