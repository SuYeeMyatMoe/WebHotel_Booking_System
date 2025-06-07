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

        [MaxLength(100, ErrorMessage = "Room name cannot exceed 100 characters.")]//this will auto added max length in input (can check by inspect)
        public required string Name { get; set; }
        public string? Description { get; set; }

        [Display(Name = "Price ($)")]
        [Range(10,10000, ErrorMessage = "Price per night must be at least $10 and at most $10,000.")]//at least $10 and at most $10,000.
        public double PriceinDoller { get; set; }

        [Display(Name = "Room Size (Sqft)")]
        public int RoomSize { get; set; }

        [Range(1, 10, ErrorMessage = "Occupancy must be between 1 and 10.")]//between 1 and 10 to prevent 0 and overtyping
        public int Occupancy { get; set; }

        [Display(Name = "Image URL)")]
        public string? ImageUrl { get; set; }

        // Tracking in Logging
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

    }
}
