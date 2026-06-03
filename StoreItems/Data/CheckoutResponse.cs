namespace StubSite.StoreItems.Data
{
    public class CheckoutResponse
    {
        public bool Success { get; set; }
        public string Reason { get; set; }
        public string Url { get; set; }
        public string CartId { get; set; }
    }
}
