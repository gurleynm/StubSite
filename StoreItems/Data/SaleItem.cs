namespace StubSite.StoreItems.Data
{
    public class SaleItem
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public List<string> Images { get; set; } = new List<string>() { "https://api.games.gurleytech.com/Uploads/NFXRU_68b7f9b1-b36c-442c-8afe-0759140dd10c.jpg", "https://demos.blazorbootstrap.com/_content/BlazorBootstrap.Demo.RCL/images/slide-01.png" };
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public int Quantity { get; set; }
        public string PromoCode { get; set; }
        public decimal SalePercent { get; set; }
        public decimal SaleAmount { get; set; }
        public decimal DisplayCost => SalePercent == 0 ? SaleAmount == 0 ? Cost : SaleAmount : Math.Round(Cost * (1 - SalePercent), 2);
        public SaleItem() { }
        public SaleItem(string name, string desc, decimal cost)
        {
            Name = name;
            Description = desc;
            Cost = cost;
        }
    }
}
