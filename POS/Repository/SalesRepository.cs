using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Entity;

namespace POS.Repository
{
    public class SalesRepository
    {
        private readonly AppDbContext _context;
        public List<SalesEntity> getAllSales()
        {
            return new List<SalesEntity>();
        }

        public List<SalesEntity> searchSales(string menuName, DateTime startDate, DateTime endTime, string receiptNum)
        {
            return new List<SalesEntity>();
        }
    }
}
