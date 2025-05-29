using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Domain
{
    public class OrderEntity
    {
        [Key]
        public int Id { get; set; } // 영수증 ID

        [Required]
        public int TableId { get; set; }

        [Required]
        public bool IsPaid { get; set; } = false;

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // 네비게이션 속성
        public virtual ICollection<OrderItemEntity> Items { get; set; }

        public OrderEntity()
        {
            Items = new List<OrderItemEntity>();
        }
    }
}