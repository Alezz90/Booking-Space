using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpaceBooking.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int customerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? work { get; set; }
        public int Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public List<Booking> Booking { get; set; }
    }
}
