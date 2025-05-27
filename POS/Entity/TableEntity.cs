using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis; // Optional: For detailed mapping

namespace POS.Entity
{
    public class TableEntity
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(50)]
        [Column("table_name")]
        public string tableName { get; set; }

        public TableEntity() { }
        public TableEntity(string name)
        {
            this.tableName = name;
        }
    }
}
