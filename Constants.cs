namespace StubSite
{
    public class Constants
    {
        public static Dictionary<string, string> ColorScheme = new Dictionary<string, string> {
            { "Main", "#8c8c8c" }
            ,{ "Accent", "#ad5b25" }
            ,{ "Text", "#5d5250" }
            ,{ "ButtonText", "#ffffff" }
        };

        public static bool Mobile { get; set; }
        public static EventHandler<string> CurPageChanged = (sender, value) => { };
        public static string CompanyName = "The Hive - Coffee Co. & Mercantile";
        public static string CompanyEmail = "thehivemobilecoffee@gmail.com";//"lotno1coffee@gmail.com";
        public static string CompanyPhone = "(937) 515-0272";
        public static string CompanyAddress = "15168 Eastwood Rd unit 113, Williamsburg, OH 45176";
        public static string CompanyMapsURL = "https://maps.app.goo.gl/4faocZ1JuWFxCiMd7";
        public static Dictionary<string,string> CompanyHours = new() { 
            { "Monday - Friday" ,"6:30AM-3PM" } 
            ,{ "Saturday" ,"7:30AM-2:00PM" } 
            ,{ "Sunday" ,"CLOSED" } 
        };
        //public static Dictionary<string,string> CompanyHours = new() { 
        //    { "Monday" ,"7:30AM-6:00PM" } 
        //    ,{ "Tuesday" ,"7:30AM-6:00PM" } 
        //    ,{ "Wednesday" ,"7:30AM-6:00PM" } 
        //    ,{ "Thursday" ,"7:30AM-6:00PM" } 
        //    ,{ "Friday" ,"7:30AM-6:00PM" } 
        //    ,{ "Saturday" ,"8:00AM-6:00PM" } 
        //    ,{ "Sunday" ,"12:00PM-6:00PM" } 
        //};
        public static Dictionary<string,string> CompanySocials = new() { 
            { "Instagram" ,"https://www.instagram.com/thehivecoffeeco_merc/" } 
            ,{ "Facebook" ,"https://www.facebook.com/profile.php?id=100090287984313&locale=de_DE" }
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
