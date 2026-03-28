using EventBooking.API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EventBooking.API.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Event> Events => Set<Event>();
        public DbSet<Booking> Bookings => Set<Booking>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Seed sample events
            
            builder.Entity<Event>().HasData(
                new Event
                {
                    Id = 1,
                    Title = "World Gaming Summit 2025",
                    Description = "Annual Gaming Summit",
                    Date = new DateTime(2025, 10, 15, 9, 0, 0),
                    Location = "Mumbai",
                    AvailableSeats = 500
                },
                new Event
                {
                    Id = 2,
                    Title = "Resident Evil Marathon",
                    Description = "Play Resident Evil with Friends",
                    Date = new DateTime(2025, 9, 20, 18, 0, 0),
                    Location = "Bangalore",
                    AvailableSeats = 200
                },
                new Event
                {
                    Id = 3,
                    Title = "Cyberpunk Summit",
                    Description = "Dive into the world of Cyberpunk 2077.",
                    Date = new DateTime(2025, 11, 5, 10, 0, 0),
                    Location = "Delhi",
                    AvailableSeats = 350
                }
            );
        }
    }
}