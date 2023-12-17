using Microsoft.EntityFrameworkCore;
using SpaceBooking.Models;

namespace SpaceBooking.DataContext
{
    public class Mydbcontext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = ALEZZ; Database = AcademyBooking; Integrated Security = true; TrustServerCertificate = true");
        }


        public DbSet<Booking> bookings { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Space> Spaces { get; set; }
    }
}
