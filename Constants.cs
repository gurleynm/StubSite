namespace StubSite
{
    public class Constants
    {
        public static Dictionary<string, string> ColorScheme = new Dictionary<string, string> {
            { "Main", "#4995c6" }
            ,{ "Accent", "#c83738" }
            ,{ "Text", "#000000" }
            ,{ "ButtonText", "#ffffff" }
        };

        public static bool Mobile { get; set; }
        public static EventHandler<string> CurPageChanged = (sender, value) => { };
        public static string CompanyName = "Fairfield Cyclery";
        public static string CompanyEmail = "sales@fairfieldcyclery.com";
        public static string CompanyPhone = "(513) 829-7586";
        public static string CompanyAddress = "4860 Dixie HwyFairfield, OH 45014";
        public static string CompanyMapsURL = "https://maps.app.goo.gl/oUagEPM9HPXH2y8E8";
        public static Dictionary<string,string> CompanyHours = new() { 
            { "Sunday" ,"Closed" } 
            ,{ "Monday" ,"Closed" } 
            ,{ "Tuesday" ,"12PM-4PM" } 
            ,{ "Wednesday" ,"12PM-4PM" } 
            ,{ "Thursday" ,"12PM-4PM" } 
            ,{ "Friday" ,"12PM-4PM" } 
            ,{ "Saturday" ,"Closed" } 
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
            { "Facebook" ,"https://www.facebook.com/profile.php?id=100063608798992" }
            ,{ "Instagram" ,"https://www.instagram.com/fairfieldcyclery/" } 
            //,{ "X" ,"https://x.com/lovelandcanoe" }
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
