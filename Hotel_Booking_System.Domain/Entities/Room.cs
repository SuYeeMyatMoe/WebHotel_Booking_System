using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Booking_System.Domain.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }

        [Display(Name = "Price ($)")]
        public double PriceinDoller { get; set; }

        [Display(Name = "Room Size (Sqft)")]
        public int RoomSize { get; set; }
        public int Occupancy { get; set; }

        [Display(Name = "Image URL)")]
        public string? ImageUrl { get; set; }

        // Tracking in Logging
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

    }
}
