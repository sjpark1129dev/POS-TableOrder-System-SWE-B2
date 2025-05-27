using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Entity
{
    public class SalesEntity
    {
        public DateTime salesDate;
        public string recnum;
        public int tableID;
        public string menuName;
        public int qty;
        public int unitPrice;
        public int price;
    }
}
