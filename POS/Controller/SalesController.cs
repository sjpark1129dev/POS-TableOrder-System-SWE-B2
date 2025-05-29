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

        public SalesController()
        {
            salesRepository = new SalesRepository();
        }

        public List<SalesEntity> GetAllSales()
        {
            return salesRepository.GetAllSales();
        }

        public List<SalesEntity> SearchSales(string menuName, DateTime startDate, DateTime endDate, string receiptNum)
        {
            return salesRepository.SearchSales(menuName, startDate, endDate, receiptNum);
        }
    }
}
