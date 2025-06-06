using Microsoft.EntityFrameworkCore;
using POS.Domain;

namespace POS.Repository
{
    public class TableRepository
    {
        public List<TableEntity> GetAllTables()
        {
            using var context = DbContextFactory.Create();
            return context.Tables.AsNoTracking().ToList();
        }

        public void Insert(TableEntity table)
        {
            using var context = DbContextFactory.Create();

            // 테이블 개수 제한 확인
            if (context.Tables.Count() >= 10)
                throw new InvalidOperationException("테이블은 최대 10개까지만 생성할 수 있습니다.");

            context.Tables.Add(table);
            context.SaveChanges();
        }

        public void Update(TableEntity updatedTable)
        {
            using var context = DbContextFactory.Create();
            var existing = context.Tables.Find(updatedTable.Id);
            if (existing != null)
            {
                existing.tableName = updatedTable.tableName;
                context.SaveChanges();
            }
        }

        public bool RemoveTableById(int id)
        {
            using var context = DbContextFactory.Create();
            var table = context.Tables.Find(id);
            if (table != null)
            {
                context.Tables.Remove(table);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
