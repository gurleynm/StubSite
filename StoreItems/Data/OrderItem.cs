namespace StubSite.StoreItems.Data
{
    public class OrderItem
    {
        public string Id { get; set; }
        public string OrderNumber { get; set; }
        public string Name { get; set; }
        public long Quantity { get; set; }
        public decimal Cost { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public OrderItem() { }
    }
}
