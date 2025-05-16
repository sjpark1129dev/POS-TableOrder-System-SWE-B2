using POS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Repostiory;
using POS.Entity;

namespace POS.Controller
{
    internal class TableController
    {
        public List<TableEntity> GetAllTables()
        {
            return TableRepository.GetAllTables();
        }
        
        public TableEntity CreateTable()
        {
            return new TableEntity();
            // Logic to create a new table
            // This could involve showing a form to get user input and then saving it to the database
        }

        public bool DeleteTable()
        {
            return false;
            // Logic to delete a table
            // This could involve showing a confirmation dialog and then removing the table from the database
        }

        public void SaveAllTables(List<TableEntity> tableList)
        {
            foreach (var table in tableList)
            {
                switch (table.State)
                {
                    case EntityState.New:
                        TableRepository.Insert(table);
                        break;
                    case EntityState.Modified:
                        TableRepository.Update(table);
                        break;
                    case EntityState.Deleted:
                        TableRepository.Delete(table.Id);
                        break;
                }
            }
        }
    }
}
