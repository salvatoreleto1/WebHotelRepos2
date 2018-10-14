using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebHotel.Models
{
    public class Booking
    {
        // Primary Key
        public int ID { get; set; }

        // Foreign Key
        public int RoomID { get; set; }

        // Foreign Key
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string CustomerEmail { get; set; }

        //Check in date only needed
        public DateTime CheckIn { get; set; }

        //Check out date only needed
        public DateTime CheckOut { get; set; }

        //Cost of total booking
        public decimal Cost { get; set; }

        //Navigation properties:
        public Room TheRoom { get; set; }
        public Customer TheCustomer { get; set; }

    }
}
