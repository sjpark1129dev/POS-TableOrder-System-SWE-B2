using POS.Entity;

namespace POS.Repository
{
    public class TableRepository
    {
        private readonly AppDbContext _context;

        public TableRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<TableEntity> GetAllTables()
        {
            return _context.Tables.ToList(); // DB에서 테이블 목록 조회
        }

        public void Insert(TableEntity table)
        {
            _context.Tables.Add(table);
            _context.SaveChanges(); // 삽입 후 커밋
        }

        public void Update(TableEntity table)
        {
            _context.Tables.Update(table);
            _context.SaveChanges(); // 수정 후 커밋
        }

        public void Delete(int id)
        {
            var table = _context.Tables.Find(id);
            if (table != null)
            {
                _context.Tables.Remove(table);
                _context.SaveChanges(); // 삭제 후 커밋
            }
        }
    }
}
