namespace StubSite
{
    public class Constants
    {
        public static Dictionary<string, string> ColorScheme = new Dictionary<string, string> {
            { "Main", "#efe1d6" }
            ,{ "Accent", "#a8c3b2" }
            ,{ "Text", "#5d5250" }
            ,{ "ButtonText", "#000000" }
        };

        public static bool Mobile { get; set; }
        public static EventHandler<string> CurPageChanged = (sender, value) => { };
        public static string CompanyName = "Lot No. 1 Coffee";
        public static string CompanyEmail = "";//"lotno1coffee@gmail.com";
        public static string CompanyPhone = "(513) 836-3103";
        public static string CompanyAddress = "9 E Main St, Lebanon, OH, United States, 45036";
        public static string CompanyMapsURL = "https://maps.app.goo.gl/15o6sYDL42qmk3MT6";
        public static Dictionary<string,string> CompanyHours = new() { 
            { "Monday - Friday" ,"7:30AM-6PM" } 
            ,{ "Saturday" ,"8AM-6PM" } 
            ,{ "Sunday" ,"12PM-6PM" } 
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
            { "Instagram" ,"https://www.instagram.com/lotno1coffee?igsh=MWY3a2t1cHc2M3Mzaw==" } 
            ,{ "Facebook" ,"https://www.facebook.com/profile.php?id=61564617675174&locale=nl_BE" }
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
