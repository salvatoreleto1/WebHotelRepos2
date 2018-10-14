using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebHotel.Models
{
    public class Room
    {
        // Primary Key
        public int ID { get; set; }

        // level of room, G, 1, 2, 3...
        public string Level { get; set; }

        // Number of beds in room
        public int BedCount { get; set; }

        // Price per night should be between 50-$300
        public decimal Price { get; set; }

        //Navigation prop
        public ICollection<Booking> TheBookings { get; set; }
    }
}
