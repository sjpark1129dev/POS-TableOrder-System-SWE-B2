using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Domain;
using POS.Repository;

namespace POS.Controller
{
    public class TableController
    {
        private readonly TableRepository _repository = new TableRepository();

        public List<TableEntity> GetAllTables()
        {
            return _repository.GetAllTables();
        }

        public TableEntity CreateTable(string name)
        {
            return new TableEntity(name);
        }
        public bool IsDuplicateName(List<TableEntity> list, string name)
        {
            return list.Any(t => t.tableName.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
        public bool DeleteTable()
        {
            // 향후 실제 삭제 로직 추가 시 구현
            return false;
        }
        public void MarkDeleted(List<TableEntity> tables, int id)
        {
            var table = GetById(tables, id);
        }
        public TableEntity? GetById(List<TableEntity> tables, int id)
        {
            return tables.FirstOrDefault(t => t.Id == id);
        }
    }
}
