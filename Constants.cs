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

        public static Dictionary<string, string> CompanyInfo = new()
        {
            ["BusinessName"] = "Blue Collar Grooming LLC",
            ["Tagline"] = "Good People. Good Cuts.",
            ["Logo"] = "https://seller-brand-assets-f.squarecdn.com/MLZNJ3YX46RF2/7089623ceb3c3822bae9ae3d519f0fb3.jpeg?height=250",

            ["Address"] = "15168 Eastwood Rd Unit 105",
            ["City"] = "Williamsburg",
            ["State"] = "OH",
            ["Zip"] = "45176-9265",

            ["BookingUrl"] = "https://book.squareup.com/appointments/p9mg1leagi1dhw/location/LJ4Y9FNPTJNXV/services?rwg_token=ALcMQYaDnrVUZB44r6OU8N9lDrDwuFXM9yVSTRTT5ceEnZskJWA-0Bx3v50edbzqW96pFRsCRW-_S65s_oywsSSasq_ZJ8sUoA%3D%3D",

            ["Phone"] = "",
            ["Email"] = "",
            ["Hours"] = "",
            ["Instagram"] = "",
            ["Facebook"] = "",

            // Services and pricing
            ["Service1Name"] = "Signature Haircut",
            ["Service1Description"] = "A fresh, personalized haircut with attention to every detail.",
            ["Service1Price"] = "",

            ["Service2Name"] = "Beard Trim",
            ["Service2Description"] = "Clean shaping, crisp lines, and a polished finish.",
            ["Service2Price"] = "",

            ["Service3Name"] = "Haircut & Beard",
            ["Service3Description"] = "The complete cleanup. A fresh cut and a perfectly shaped beard.",
            ["Service3Price"] = "",

            // Additional business information
            ["About"] = "Blue Collar Grooming is about more than just getting a haircut. It's about quality service, attention to detail, and making sure every customer leaves looking and feeling their best.",

            // Optional gallery images
            ["GalleryImage1"] = "",
            ["GalleryImage2"] = "",
            ["GalleryImage3"] = "",
            ["GalleryImage4"] = ""
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
