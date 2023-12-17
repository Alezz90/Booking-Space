using System.ComponentModel.DataAnnotations;

namespace SpaceBooking.Models
{
    public class Space
    {
        [Key]
        public int SpaceID { get; set; }
        public string spaceName { get; set; }
        public int Capacity { get; set; }
        public Categories Categories { get; set; }
    }
}
