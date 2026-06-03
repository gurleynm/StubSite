using System.Threading.Tasks;

namespace StubSite.StoreItems.Data
{
    public class TestRunner
    {
        public static async Task<List<SaleItem>> GetSaleItems(HttpClient Http)
        {
            return new List<SaleItem>
            {
                new SaleItem
                {
                    Id = "1",
                    Name = "Crescent Primo Recreational Kayak",
                    Description = "This is a test product.",
                    Cost = 799.00m,
                    Images = new List<string> {
                        "https://lovelandpaddlesports.com/wp-content/uploads/2026/04/crescent-primo-1.jpg"
                        ,"https://lovelandpaddlesports.com/wp-content/uploads/2026/04/crescent-primo-2.jpg"
                        ,"https://lovelandpaddlesports.com/wp-content/uploads/2024/03/primo-nor.webp"
                    }
                },
                new SaleItem
                {
                    Id = "2",
                    Name = "Crescent K-Craft PaddleSkiff",
                    Description = "This is another test product.",
                    Cost = 1199.00m,
                    Images = new List<string> {
                        "https://lovelandpaddlesports.com/wp-content/uploads/2024/03/kcraft-sea.webp"
                        ,"https://lovelandpaddlesports.com/wp-content/uploads/2024/03/kcraft-nor.webp"
                        ,"https://lovelandpaddlesports.com/wp-content/uploads/2024/03/kcraft-moon.webp"
                    }
                }
            };
        }
    }
    public class ProductResponse
    {
        public bool Success { get; set; }
        public string Reason { get; set; }
        public List<SaleItem> Products { get; set; }
    }
}
