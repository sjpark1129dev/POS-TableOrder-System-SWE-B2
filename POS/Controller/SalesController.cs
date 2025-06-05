using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Domain;
using POS.Repository;

namespace POS.Controller
{
    public class SalesController
    {
        private SalesRepository salesRepository;

        public SalesController()
        {
            salesRepository = new SalesRepository();
        }
        public List<SalesEntity> SearchSales(DateTime startDate, DateTime endDate, string menuName, string receiptNum)
        {
            return salesRepository.SearchSales(startDate, endDate, menuName, receiptNum);
        }
    }
}
