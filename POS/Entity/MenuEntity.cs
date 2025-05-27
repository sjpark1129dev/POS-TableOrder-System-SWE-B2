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
        public string menuName { get; set; }

        [Required]
        [Column("menu_price")]
        public int menuPrice { get; set; }

        public MenuEntity() { }

        public MenuEntity(string name, int price)
        {
            menuName = name;
            menuPrice = price;
        }
    }
}
