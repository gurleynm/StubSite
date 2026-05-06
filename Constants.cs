namespace StubSite
{
    public class Constants
    {
        public static Dictionary<string, string> ColorScheme = new Dictionary<string, string> {
            { "Main", "#000000" }
            ,{ "Accent", "#161b6a" }
            ,{ "Text", "white" }
        };

        public static bool Mobile { get; set; }
        public static EventHandler<string> CurPageChanged = (sender, value) => { };
        public static string CompanyName = "Hometown Cafe Loveland ";
        public static string CompanyEmail = "hometowncafeloveland@gmail.com";
        public static string CompanyPhone = "(513) 677-2600";
        public static string CompanyAddress = "111 Railroad Ave, Loveland, OH 45140";
        public static Dictionary<string,string> CompanyHours = new() { 
            { "Monday" ,"8AM-3PM" } 
            ,{ "Tuesday" ,"8AM-3PM" } 
            ,{ "Wednesday" ,"8AM-3PM" } 
            ,{ "Thursday" ,"8AM-3PM" } 
            ,{ "Friday" ,"8AM-3PM" } 
            ,{ "Saturday" ,"8AM-3PM" } 
            ,{ "Sunday" ,"8AM-3PM" } 
        };
        public static Dictionary<string,string> CompanySocials = new() { 
            { "Instagram" ,"https://www.instagram.com/hometowncafeloveland/" } 
            ,{ "Facebook" ,"https://www.facebook.com/hometowncafeloveland/" }
        };

        private static string curPage;
        public static string CurPage
        {
            get => curPage;
            set
            {
                if (curPage != value)
                {
                    curPage = value;
                    CurPageChanged?.Invoke(typeof(Constants), curPage);
                }
            }
        }
    }
}
