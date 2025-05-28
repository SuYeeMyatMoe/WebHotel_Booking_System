using Hotel_Booking_System.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Booking_System.Infrastructure.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {
        }
        public DbSet<Room> Rooms { get; set; }//must use ctrl . and choose reference to Hotel_Booking_System.Domain.Entities;

        //Adding Initial record for Room in DBS
        protected override void OnModelCreating(ModelBuilder modelBuilder)//protected override and choose OnModel in dropdown
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Room>()
                .HasData(
                new Room
                {
                    Id = 1,
                    Name = "Room 1",
                    Description = "Classic Single Room",
                    PriceinDoller = 30,
                    RoomSize = 260,//area length in square ft (20ft*13ft)
                    Occupancy = 1,
                    ImageUrl = "https://www.classichotel.al/wp-content/uploads/2019/07/Optimized-single1.jpg"

                },
                new Room
                {
                    Id = 2,
                    Name = "Room 2",
                    Description = "Deluxe Double Room",
                    PriceinDoller = 50,
                    RoomSize = 400, // 20ft * 20ft
                    Occupancy = 2,
                    ImageUrl = "https://www.pearlhotelnyc.com/hs-fs/hubfs/2.jpg?width=1488&height=992&name=2.jpg"
                },

                new Room
                {
                    Id = 3,
                    Name = "Room 3",
                    Description = "Executive Suite",
                    PriceinDoller = 90,
                    RoomSize = 600, // 30ft * 20ft
                    Occupancy = 3,
                    ImageUrl = "https://image-tc.galaxy.tf/wijpeg-eyy6alr2se13uffg555o3iapg/executive-suite-room-2_wide.jpg"
                });

        }
    }
}
