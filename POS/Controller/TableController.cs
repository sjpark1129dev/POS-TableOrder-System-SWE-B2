using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Entity;
using POS.Repository;

namespace POS.Controller
{
    public class TableController
    {
        private readonly TableRepository _repository;

        public TableController(TableRepository repository)
        {
            _repository = repository;
        }

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
            return list.Any(t => t.State != EntityState.Deleted &&
                                 t.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
        public bool DeleteTable()
        {
            // 향후 실제 삭제 로직 추가 시 구현
            return false;
        }
        public void MarkDeleted(List<TableEntity> tables, int id)
        {
            var table = GetById(tables, id);
            if (table != null)
            {
                table.State = EntityState.Deleted;
            }
        }
        public TableEntity? GetById(List<TableEntity> tables, int id)
        {
            return tables.FirstOrDefault(t => t.Id == id && t.State != EntityState.Deleted);
        }
        public void SaveAllTables(List<TableEntity> tableList)
        {
            foreach (var table in tableList)
            {
                switch (table.State)
                {
                    case EntityState.New:
                        _repository.Insert(table);
                        break;
                    case EntityState.Modified:
                        _repository.Update(table);
                        break;
                    case EntityState.Deleted:
                        _repository.Delete(table.Id);
                        break;
                }
            }
        }
    }
}
