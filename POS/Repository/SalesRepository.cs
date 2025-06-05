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
        private readonly AppDbContext _context = AppDbContext.Instance;
        public List<SalesEntity> GetAllSales()
        {
            return _context.Sales.ToList();
        }

        public List<SalesEntity> SearchSales( DateTime startDate, DateTime endDate, string menuName, string receiptNum)
        {
            using (var context = new AppDbContext()) // ← 실제 DbContext 이름 사용
            {
                var query = context.Sales.AsQueryable();

                // 날짜 조건
                query = query.Where(s => s.SalesDate >= startDate && s.SalesDate <= endDate);

                // 메뉴 이름이 비어있지 않으면 필터링
                if (!string.IsNullOrWhiteSpace(menuName))
                {
                    query = query.Where(s => s.MenuName.Contains(menuName));
                }

                // 계산서 번호가 비어있지 않으면 필터링
                if (!string.IsNullOrWhiteSpace(receiptNum))
                {
                    query = query.Where(s => s.RecNum.Contains(receiptNum));
                }

                return query.ToList();
            }
        }

    }
}
