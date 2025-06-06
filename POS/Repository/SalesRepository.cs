using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using POS.Domain;

namespace POS.Repository
{
    public class SalesRepository
    {
        public List<SalesEntity> SearchSales(DateTime startDate, DateTime endDate, string menuName, string receiptNum)
        {
            using var context = DbContextFactory.Create();
            var query = context.Sales.AsQueryable();
            query = query.Where(s => s.SalesDate >= startDate && s.SalesDate <= endDate.AddDays(1));

            if (!string.IsNullOrWhiteSpace(menuName))
                query = query.Where(s => s.MenuName.Contains(menuName));
            if (!string.IsNullOrWhiteSpace(receiptNum))
                query = query.Where(s => s.RecNum.Contains(receiptNum));

            return query.AsNoTracking().ToList();
        }
    }
}
