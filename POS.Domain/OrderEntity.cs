namespace POS.Domain
{
    internal class OrderEntity
    {
        private int id { get; set; }
        private string menuName { get; set; }
        private int qty { get; set; }
        private int price { get; set; }
        private int tableId { get; set; }
        private bool isPaid { get; set; }

        public OrderEntity(int price, int qty, string menuName)
        {
        }
    }
}