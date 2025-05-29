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
        [StringLength(100)]
        public string MenuName { get; set; }

        [Required]
        public int Qty { get; set; }

        [Required]
        public int UnitPrice { get; set; }

        [Required]
        public int TotalPrice => Qty * UnitPrice;
    }
}