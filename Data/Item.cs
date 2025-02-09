namespace StubSite.Data
{
    public class Item
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Category { get; set; }
        public string Cost { get; set; }
        public Item() { }
        public Item(string name, string desc, string cat, string cost)
        {
            Name = name;
            Desc = desc;
            Category = cat;
            Cost = cost;
        }
    }
}
