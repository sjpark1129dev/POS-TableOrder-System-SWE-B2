using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Domain
{
    public class MenuEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Column("menu_name")]
        public string MenuName { get; set; }

        [Required]
        [Column("menu_price")]
        public int MenuPrice { get; set; }

        // 🔽 FK 컬럼 명시
        [Required]
        [ForeignKey("Category")]
        [Column("category_id")]
        public int CategoryId { get; set; }

        // 🔽 네비게이션 속성 (optional: virtual 붙이면 LazyLoading 가능)
        public virtual CategoryEntity Category { get; set; }

        [Column("menu_image")]
        public byte[]? MenuImage { get; set; } // 기본값 null

        public MenuEntity() { }

        public MenuEntity(string name, int price, int categoryId)
        {
            MenuName = name;
            MenuPrice = price;
            CategoryId = categoryId;
        }
    }
}