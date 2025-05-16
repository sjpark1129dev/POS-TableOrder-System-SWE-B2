using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Entity;

namespace POS.Repostiory
{
    internal class TableRepository
    {
        public static List<TableEntity> GetAllTables()
        {
            // Simulate fetching data from a database or other data source
            return new List<TableEntity>
            {
                new TableEntity { /* Initialize properties */ },
                new TableEntity { /* Initialize properties */ },
                // Add more TableEntity instances as needed
            };
        }
        public static void Insert(TableEntity table) { /* DB 삽입 */ }
        public static void Update(TableEntity table) { /* DB 수정 */ }
        public static void Delete(int id) { /* DB 삭제 */ }
    }
}
