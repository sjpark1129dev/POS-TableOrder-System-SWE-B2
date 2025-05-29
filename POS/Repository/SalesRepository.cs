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
                s.SalesDate >= startDate && s.SalesDate <= endDate 

            );

            return result;
        }

        // 임시 더미 데이터
        private List<SalesEntity> GetMockSales()
        {
            return new List<SalesEntity>
            {
                new SalesEntity { SalesDate = new DateTime(2025, 5, 28), RecNum = "R001", TableId = 1, MenuName = "Burger", Qty = 2, UnitPrice = 5000, Price = 10000 },
                new SalesEntity { SalesDate = new DateTime(2025, 5, 28), RecNum = "R002", TableId = 2, MenuName = "Pizza", Qty = 1, UnitPrice = 12000, Price = 12000 },
                new SalesEntity { SalesDate = new DateTime(2025, 5, 28), RecNum = "R003", TableId = 3, MenuName = "Burger", Qty = 3, UnitPrice = 5000, Price = 15000 }
            };
        }
    }
}
