namespace StubSite.StoreItems.Data
{
    public class CustomField
    {
        public string Key { get; set; }
        public string Label { get; set; }
        public string FieldType { get; set; }
        public List<(string, string)> FieldValues { get; set; }
        public string DefaultValue { get; set; }
        public bool Optional { get; set; }
        public int TextMinLength { get; set; }
        public int TextMaxLength { get; set; } = 255;
        public CustomField() { }
    }
}
