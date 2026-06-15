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
        public static string CompanyAddress = "Locations vary";
        public static string CompanyMapsURL = ""; //"https://maps.app.goo.gl/uJGaX9ShQaHHAie36";
        
        public static Dictionary<string,string> CompanyHours = new() { 
            { "Hours" ,"Times vary" } 
        };
        public static Dictionary<string,string> CompanySocials = new() { 
            { "Instagram" ,"https://www.instagram.com/aebersani" } 
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
