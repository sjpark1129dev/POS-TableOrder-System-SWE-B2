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
        public DateTime salesDate { get; set; }
        public string recnum { get; set; }
        public int tableID { get; set; }
        public string menuName { get; set; }
        public int qty { get; set; }
        public int unitPrice { get; set; }
        public int price { get; set; }
    }
}
