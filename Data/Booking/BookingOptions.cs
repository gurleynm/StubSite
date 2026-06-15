namespace StubSite.Data.Booking
{
    public class BookingOptions
    {
        public string PrimaryColor { get; set; } = Constants.ColorScheme["Accent"];

        public string AccentColor { get; set; } = "#E8F1FB";

        public bool ShowAvailabilityCount { get; set; } = true;

        public bool ShowSessions { get; set; } = true;

        public bool ShowSessionDescriptions { get; set; } = true;

        public bool Compact { get; set; } = false;

        public int DaysToShow { get; set; } = 30;
    }
}
