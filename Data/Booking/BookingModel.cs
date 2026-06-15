namespace StubSite.Data.Booking;

public class BookingSlot
{
    public DateTime Date { get; set; }

    public List<BookingTime> Times { get; set; } = new();
}


public class BookingTime
{
    public TimeOnly StartTime { get; set; }

    public TimeOnly EndTime { get; set; }

    public bool IsAvailable => Sessions.Sum(sess => sess.TakenSpots) < Sessions.Sum(sess => sess.TotalSpots);

    public List<BookingSession> Sessions { get; set; } = new();

    public BookingTime() { }
    public BookingTime(BookingTime other)
    {
        StartTime = other.StartTime;
        EndTime = other.EndTime;
        Sessions = other.Sessions.Select(s => new BookingSession
        {
            Title = s.Title,
            Description = s.Description,
            Location = s.Location,
            LocationURL = s.LocationURL,
            TotalSpots = s.TotalSpots,
            TakenSpots = s.TakenSpots,
            Cost = s.Cost
        }).ToList();
    }
}


public class BookingSession
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Title { get; set; } = "";

    public string Description { get; set; } = "";
    public string Location { get; set; } = "";
    public string LocationURL { get; set; } = "";

    public int TotalSpots { get; set; }
    public int TakenSpots { get; set; }
    public int AvailableSpots => TotalSpots - TakenSpots;
    public decimal Cost { get; set; }
    public bool Selected { get; set; } = false;
    public BookingSession() { }
    public BookingSession(BookingSession other)
    {
        Id = other.Id;
        Title = other.Title;
        Description = other.Description;
        Location = other.Location;
        LocationURL = other.LocationURL;
        TotalSpots = other.TotalSpots;
        TakenSpots = other.TakenSpots;
        Cost = other.Cost;
        Selected = other.Selected;
    }
}