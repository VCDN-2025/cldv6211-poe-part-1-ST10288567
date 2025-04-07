using System;

namespace EventEase2
{
    public class Bookings
    {

       
            public int BookingsId { get; set; }
            public DateTime BookingsDate { get; set; }

            public int EventId { get; set; }
            public required Event Event { get; set; }

            public int VenueId { get; set; }
            public required Venues Venues { get; set; }

            public required string CustomerName { get; set; }
            public required string CustomerEmail { get; set; }
            public required string CustomerPhone { get; set; }
        
    }
}
