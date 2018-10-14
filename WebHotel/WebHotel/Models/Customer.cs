using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebHotel.Models
{
    public class Customer
    {
        //Primary Key
        [Key, Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Email { get; set; }

        //Length ranges between 2 and 20 characters, only english letters, hypen and apostrophe
        [Required]
        [Display (Name = "Surname")]
        [RegularExpression(@"[A-Z[a-z'-]{1-19}")]
        public string Surname { get; set; }

        //Length ranges between 2 and 20 characters, only english letters, hypen and apostrophe
        [Required]
        [Display(Name = "Given Name")]
        [RegularExpression(@"[A-Z[a-z'-]{1-19}")]
        public string GivenName { get; set; }

        [Required]
        [Display(Name = "Postcode")]
        [RegularExpression(@"^[0-9]{4}$")]
        public string Postcode { get; set; }

        //Navigation prop
        public ICollection<Booking> TheBookings { get; set; }
    }
}
