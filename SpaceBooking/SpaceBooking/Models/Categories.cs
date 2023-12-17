using System.ComponentModel.DataAnnotations;

namespace SpaceBooking.Models
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public List<Space> Spaces { get; set; }
    }
}
