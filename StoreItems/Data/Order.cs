namespace StubSite.StoreItems.Data
{
    public class Order
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Email { get; set; } = "";
        public string Name { get; set; } = "";
        public string OrderNumber { get; set; } = "";
        public string Status { get; set; } = "";
        public decimal Total { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public Order() { }
    }
}
