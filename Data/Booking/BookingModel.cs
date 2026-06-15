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

    public int AvailableSpots { get; set; }

    public bool IsAvailable => AvailableSpots > 0;

    public List<BookingSession> Sessions { get; set; } = new();
}


public class BookingSession
{
    public string Title { get; set; } = "";

    public string Description { get; set; } = "";

    public int AvailableSpots { get; set; }
}