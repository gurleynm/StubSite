namespace StubSite
{
    public class Constants
    {
        public static Dictionary<string, string> ColorScheme = new Dictionary<string, string> {
            { "Main", "#f4b933" }
            ,{ "Accent", "#063558" }
            ,{ "Text", "silver" }
        };

        public static bool Mobile { get; set; }
        public static EventHandler<string> CurPageChanged = (sender, value) => { };
        public static string CompanyName = "Sitwell's Coffee House Act II";
        public static string CompanyContact = "Info.Sitwells@gmail.com";

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
