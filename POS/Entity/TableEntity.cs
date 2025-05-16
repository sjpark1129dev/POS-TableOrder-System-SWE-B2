using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Entity
{
    public enum EntityState { Unchanged, New, Modified, Deleted }
    internal class TableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EntityState State { get; set; } = EntityState.Unchanged; // Default state is New
    }
}
