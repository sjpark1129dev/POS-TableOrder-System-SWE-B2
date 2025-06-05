using POS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableOrder.Entity
{
    public class CartItem
    {
        public MenuEntity Menu { get; set; }
        public int Quantity { get; set; }

        public CartItem(MenuEntity menu)
        {
            Menu = menu;
            Quantity = 1;
        }
    }
}
