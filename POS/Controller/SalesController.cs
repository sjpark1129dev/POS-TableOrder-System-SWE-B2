using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Entity;
using POS.Repository;

namespace POS.Controller
{
    public class SalesController
    {
        private SalesRepository salesRepository;

        public List<SalesEntity> getAllSales()
        {

            return new List<SalesEntity>();
        }

        public List<SalesEntity> SearchSales(string menuName, DateTime startDate, DateTime endDate, string receiptNum)
        {
            return new List<SalesEntity>();
        }
    }
}
