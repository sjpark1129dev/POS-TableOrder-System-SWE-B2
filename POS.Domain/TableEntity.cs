using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Optional: For detailed mapping

namespace POS.Domain
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
