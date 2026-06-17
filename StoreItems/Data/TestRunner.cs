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
                    Name = "Steintrikes",
                    Description = "This is a test product.",
                    Cost = 6000.00m,
                    Images = new List<string> {
                        "https://nebula.wsimg.com/a000f4354ef406578828d3cccdd230b7?AccessKeyId=22876B868D3CCEA2C3AA&disposition=0&alloworigin=1"
                    }
                }
                ,new SaleItem
                {
                    Id = "2",
                    Name = "Catrike",
                    Description = "This is another test product.",
                    Cost = 4050.00m,
                    Images = new List<string> {
                        "https://nebula.wsimg.com/b47068b2092a10234b8ad4c699a61a47?AccessKeyId=22876B868D3CCEA2C3AA&disposition=0&alloworigin=1"
                        ,"https://nebula.wsimg.com/8e7dc6a2e869e3ce58e38d8daaf49209?AccessKeyId=22876B868D3CCEA2C3AA&disposition=0&alloworigin=1"
                        ,"https://nebula.wsimg.com/ee9274611fdf18c2d8fff8f11493c3f4?AccessKeyId=22876B868D3CCEA2C3AA&disposition=0&alloworigin=1"
                    }
                }
                ,new SaleItem
                {
                    Id = "3",
                    Name = "HP Velotechnik",
                    Description = "This is 3rd test product.",
                    Cost = 2000.00m,
                    Images = new List<string> {
                        "https://nebula.wsimg.com/98c8dd78bb33dfec4a05aa31c011a318?AccessKeyId=22876B868D3CCEA2C3AA&disposition=0&alloworigin=1"
                        ,"https://nebula.wsimg.com/8e7dc6a2e869e3ce58e38d8daaf49209?AccessKeyId=22876B868D3CCEA2C3AA&disposition=0&alloworigin=1"
                    }
                }
                ,new SaleItem
                {
                    Id = "4",
                    Name = "ICE",
                    Description = "This is 4th test product.",
                    Cost = 2000.00m,
                    Images = new List<string> {
                        "https://nebula.wsimg.com/24535d6248383344a5eb2786e5317a57?AccessKeyId=22876B868D3CCEA2C3AA&disposition=0&alloworigin=1"
                        ,"https://nebula.wsimg.com/d054f40f0eee658568189563226a30e3?AccessKeyId=22876B868D3CCEA2C3AA&disposition=0&alloworigin=1"
                        ,"https://nebula.wsimg.com/03ec8b5e3d31d1a89a6440b98a142fac?AccessKeyId=22876B868D3CCEA2C3AA&disposition=0&alloworigin=1"
                        ,"https://nebula.wsimg.com/03df83ac2d5ef7b31de0c13fb5f612a3?AccessKeyId=22876B868D3CCEA2C3AA&disposition=0&alloworigin=1"
                    }
                }
                ,new SaleItem
                {
                    Id = "5",
                    Name = "Sunseeker",
                    Description = "This is 5th test product.",
                    Cost = 2000.00m,
                    Images = new List<string> {
                        "https://nebula.wsimg.com/8c445295d314233dad05bbdf0ae00af6?AccessKeyId=22876B868D3CCEA2C3AA&disposition=0&alloworigin=1"
                        ,"https://nebula.wsimg.com/03df83ac2d5ef7b31de0c13fb5f612a3?AccessKeyId=22876B868D3CCEA2C3AA&disposition=0&alloworigin=1"
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
