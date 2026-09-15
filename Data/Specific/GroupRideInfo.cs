namespace StubSite.Data.Specific
{
    public class GroupRideInfo
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = DateTime.Now.ToString("dddd") + " Ride";
        public RideDifficulty Difficulty { get; set; } = RideDifficulty.Casual;
        public string Description { get; set; } = "A casual group ride for all skill levels.";
        public string When { get;set; } = DateTime.Now.ToString("dddd · h:mm tt");
        public string MeetAt { get;set; } = "Fairfield Cyclery";
        public string Distance { get;set; } = "10 miles";
        public string RouteUrl { get; set; } = "";
    }
}
