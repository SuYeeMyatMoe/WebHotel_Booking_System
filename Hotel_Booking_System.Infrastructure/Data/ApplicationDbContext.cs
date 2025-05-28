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
            base.OnModelCreating(modelBuilder);
        }
    }
}
