using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Entity
{
    internal class OrderEntity
    {
        private int id;
        private string menuName;
        private int qty;
        private int price;
        private int tableId;
        private bool isPaid;

        public OrderEntity(int price, int qty, string menuName)
        {
        }

        public string getMenuName()
        {
            return null;
        }

        public int getQty()
        {
            return 0;
        }

        public int getPrice()
        {
            return 0;
        }

        public void setMenuName(string menuName)
        {
        }

        public void setQty(int qty)
        {
        }

        public void setPrice(int price)
        {
        }

        public int Getid()
        {
            return 0;
        }

        public void SettableId(int tableId)
        {
        }

        public int GettableId()
        {
            return 0;
        }
    }
}