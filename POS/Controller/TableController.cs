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
            var table = new TableEntity(name);
            _repository.Insert(table);
            return table;
        }
        public bool IsDuplicateName(List<TableEntity> list, string name)
        {
            return list.Any(t => t.tableName.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
        public bool DeleteTable()
        {
            return false; // 구현? MarkDeleted가 시행하긴 함.
        }
        public void MarkDeleted(List<TableEntity> tables, int id)
        {
            _repository.Delete(id);
        }
        public TableEntity? GetById(List<TableEntity> tables, int id)
        {
            return tables.FirstOrDefault(t => t.Id == id);
        }

      


    }
}
