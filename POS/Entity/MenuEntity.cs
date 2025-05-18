using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Entity
{
    public class MenuEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Column("menu_name")]
        public string Name { get; set; }

        [Required]
        [Column("menu_price")]
        public decimal Price { get; set; }

        [NotMapped]
        public EntityState State { get; set; } = EntityState.Unchanged;

        public MenuEntity() { }

        public MenuEntity(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
