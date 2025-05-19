using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace PosServer.Entities
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
            tableName = name;
        }
    }
}
