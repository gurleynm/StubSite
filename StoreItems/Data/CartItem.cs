namespace StubSite.StoreItems.Data
{
    public class CartItem
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public long Quantity { get; set; }
        public CartItem(string id, long quant) 
        {
            Id = id;
            Quantity = quant;
        }
        public CartItem() { }
    }
}
