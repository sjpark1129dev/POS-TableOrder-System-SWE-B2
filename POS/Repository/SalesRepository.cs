using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Domain;

namespace POS.Repository
{
    public class SalesRepository
    {
        private readonly AppDbContext _context;
        public List<SalesEntity> GetAllSales()
        {
            // 모든 데이터 반환 (임시)
            return GetMockSales();
        }

        public List<SalesEntity> SearchSales(string menuName, DateTime startDate, DateTime endDate, string receiptNum)
        {
            var allSales = GetMockSales();

            // 조건에 맞는 데이터만 필터링 (실제 구현 시 DB 쿼리로 대체됨)
            var result = allSales.FindAll(s =>
                s.salesDate >= startDate && s.salesDate <= endDate 

            );

            return result;
        }

        // 임시 더미 데이터
        private List<SalesEntity> GetMockSales()
        {
            return new List<SalesEntity>
            {
                new SalesEntity { salesDate = new DateTime(2025, 5, 28), recnum = "R001", tableID = 1, menuName = "Burger", qty = 2, unitPrice = 5000, price = 10000 },
                new SalesEntity { salesDate = new DateTime(2025, 5, 28), recnum = "R002", tableID = 2, menuName = "Pizza", qty = 1, unitPrice = 12000, price = 12000 },
                new SalesEntity { salesDate = new DateTime(2025, 5, 28), recnum = "R003", tableID = 3, menuName = "Burger", qty = 3, unitPrice = 5000, price = 15000 }
            };
        }
    }
}
