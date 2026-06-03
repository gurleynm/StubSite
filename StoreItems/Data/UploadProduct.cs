namespace StubSite.StoreItems.Data
{
    public class UploadedProduct
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public decimal DefaultPrice { get; set; }
        public string Description { get; set; } = "";
        public List<string> Images { get; set; } = new();
        public Dictionary<string, string> Metadata { get; set; } = new();
        public UploadedProduct() { }
        public UploadedProduct(SaleItem item) 
        {
            Id = item.Id;
            Name = item.Name;
            DefaultPrice = item.Cost;
            Description = item.Description;
            Images = item.Images;
        }
    }
}
