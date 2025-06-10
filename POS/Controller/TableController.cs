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

        public void CreateTable(string name)
        {
            var table = new TableEntity(name);
            _repository.Insert(table);
        }

        public void RemoveTable(int tableId)
        {
            _repository.RemoveTableById(tableId);
        }

        public void UpdateTable(TableEntity table)
        {
            _repository.Update(table);
        }

        public bool IsDuplicateName(List<TableEntity> list, string name)
        {
            return list.Any(t => t.tableName.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
