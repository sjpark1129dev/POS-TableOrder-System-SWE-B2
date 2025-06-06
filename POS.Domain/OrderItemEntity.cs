using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Domain
{
    public class OrderItemEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }

        [ForeignKey("OrderId")]
        public virtual OrderEntity Order { get; set; }

        [Required]
        public int MenuId { get; set; } // 외래키 추가

        [ForeignKey("MenuId")]
        public virtual MenuEntity Menu { get; set; }

        [Required]
        [StringLength(100)]
        public string MenuName { get; set; } // 복사본 유지

        [Required]
        public int Qty { get; set; }

        [Required]
        public int UnitPrice { get; set; }

        [NotMapped]
        public int TotalPrice => Qty * UnitPrice;
    }

}