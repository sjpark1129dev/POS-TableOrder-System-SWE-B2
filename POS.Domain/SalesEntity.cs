using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Domain
{
    public class SalesEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; } // Primary Key

        [Required]
        [Column("sales_date")]
        public DateTime SalesDate { get; set; } // 판매 일자

        [Required]
        [StringLength(50)]
        [Column("rec_num")]
        public string RecNum { get; set; } // 영수증 번호

        [Required]
        [Column("table_id")]
        public int TableId { get; set; } // 테이블 ID (테이블 외래키 가능)

        [Required]
        [StringLength(100)]
        [Column("menu_name")]
        public string MenuName { get; set; } // 메뉴 이름 (중복 허용)

        [Required]
        [Column("qty")]
        public int Qty { get; set; } // 수량

        [Required]
        [Column("unit_price")]
        public int UnitPrice { get; set; } // 단가

        [Required]
        [Column("price")]
        public int Price { get; set; } // 합계 (단가 × 수량)

        public SalesEntity() { }

        public SalesEntity(DateTime salesDate, string recNum, int tableId, string menuName, int qty, int unitPrice)
        {
            SalesDate = salesDate;
            RecNum = recNum;
            TableId = tableId;
            MenuName = menuName;
            Qty = qty;
            UnitPrice = unitPrice;
            Price = unitPrice * qty;
        }
    }
}