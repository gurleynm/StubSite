namespace StubSite.Data.Specific
{
    public class PricingProduct
    {
        public string Title { get; set; } = "Monthly";
        public bool Beautify { get; set; }
        public string Cost { get; set; } = "$200";
        public string Duration { get; set; } = "Per Month";
        public List<string> Features { get; set; } = new();
        public PricingProduct() { }
        public PricingProduct(bool beaut)
        {
            Beautify = beaut;
        }
        public PricingProduct(string title)
        {
            Title = title;
        }

        public PricingProduct(string title, string cost)
        {
            Title = title;
            Cost = cost;
        }

        public PricingProduct(string title, string cost, string duration)
        {
            Title = title;
            Cost = cost;
            Duration = duration;
        }

        public PricingProduct(string title, string cost, string duration, List<string> features)
        {
            Title = title;
            Cost = cost;
            Duration = duration;
            Features = features;
        }

        public void AddFeature(string thing)
        {
            Features.Add(thing);
        }
    }
}
