namespace StubSite
{
    public class Constants
    {
        public static Dictionary<string, string> ColorScheme = new Dictionary<string, string> {
            { "Main", "#efe1d6" }
            ,{ "Accent", "#7A9E7E" }
            ,{ "Text", "#000000" }
            ,{ "ButtonText", "#000000" }
        };

        public static bool Mobile { get; set; }
        public static EventHandler<string> CurPageChanged = (sender, value) => { };
        public static string CompanyName = "Bersani Yoga";
        public static string CompanyEmail = "annabersani@gmail.com";
        public static string CompanyPhone = "(513) 683-4611";
        public static string CompanyAddress = "174 Karl Brown Way Loveland, OH 45140";
        public static string CompanyMapsURL = "https://maps.app.goo.gl/uJGaX9ShQaHHAie36";
        public static Dictionary<string,string> CompanyHours = new() { 
            
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
            //{ "Instagram" ,"https://www.instagram.com/loveland_yoga" } 
            //,{ "Facebook" ,"https://www.facebook.com/LovelandYoga" }
            //,{ "X" ,"https://x.com/lovelandyoga" }
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
