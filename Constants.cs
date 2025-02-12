namespace StubSite
{
    public class Constants
    {
        public static Dictionary<string, string> ColorScheme = new Dictionary<string, string> {
            { "Main", "#f9da56" }
            ,{ "Accent", "#fd8748" }
            ,{ "Text", "black" }
        };

        public static bool Mobile { get; set; }
        public static EventHandler<string> CurPageChanged = (sender, value) => { };
        public static string CompanyName = "Sitwell's Coffee House Act II";
        public static string CompanyEmail = "Info.Sitwells@gmail.com";
        public static string CompanyPhone = "(513) 281-7487";
        public static string CompanyAddress = "324 Ludlow Ave, Cincinnati, OH 45220";
        public static Dictionary<string,string> CompanyHours = new() { 
            { "Monday" ,"8AM-9PM" } 
            ,{ "Tuesday" ,"8AM-9PM" } 
            ,{ "Wednesday" ,"8AM-9PM" } 
            ,{ "Thursday" ,"8AM-9PM" } 
            ,{ "Friday" ,"8AM-9PM" } 
            ,{ "Saturday" ,"9AM-9PM" } 
            ,{ "Sunday" ,"9AM-5PM" } 
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
