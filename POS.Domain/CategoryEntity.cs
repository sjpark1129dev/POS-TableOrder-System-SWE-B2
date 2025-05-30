using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Domain
{
    public class CategoryEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column("category_name")]
        public string CategoryName { get; set; }

        // 관계 설정 (Navigation Property)
        public virtual ICollection<MenuEntity> Menus { get; set; }

        public CategoryEntity()
        {
            Menus = new List<MenuEntity>();
        }
    }
}