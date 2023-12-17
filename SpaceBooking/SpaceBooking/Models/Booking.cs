using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SpaceBooking.Models
{
    public class Booking
    {
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingID { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}")]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt}")]
        public DateTime StartHuors { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt}")]
        public DateTime EndHuors { get; set; }

        public string? Title { get; set; }
        [ForeignKey("SpaceID")]
        public int SpaceID { get; set; }
        [ForeignKey("customerID")]
        public int CustomerID { get; set; }
        public Space Spaces { get; set; }
        public Customer Customer { get; set; }

    }
}
