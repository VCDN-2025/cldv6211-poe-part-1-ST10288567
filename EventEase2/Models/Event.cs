using System;

namespace EventEase2
{
    public class Event
    {
        
            public int EventId { get; set; }
            public required string EventName { get; set; }
            public DateTime EventDate { get; set; }
            public required string Description { get; set; }

            public int? VenueId { get; set; }
            public required Venues Venue { get; set; }

            public required ICollection<Bookings> Bookings { get; set; }
        




    }
}
