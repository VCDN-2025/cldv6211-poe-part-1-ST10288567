namespace EventEase2
{
    public class Venues
    {
       
            public int VenuesId { get; set; }
            public required string VenuesName { get; set; }
            public required string Location { get; set; }
            public int Capacity { get; set; }
            public required string ImageUrl { get; set; }

            public required ICollection<Bookings> Bookings { get; set; }
            public required ICollection<Event> Events { get; set; }
        
    }
}
