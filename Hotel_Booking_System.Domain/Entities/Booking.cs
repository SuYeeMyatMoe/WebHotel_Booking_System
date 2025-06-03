using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Booking_System.Domain.Entities
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [Display(Name = "First Name")]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [Display(Name = "Last Name")]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        [StringLength(100)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Check-in date is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "Check-In Date")]
        public DateTime CheckInDate { get; set; }

        [Required(ErrorMessage = "Check-out date is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "Check-Out Date")]
        public DateTime CheckOutDate { get; set; }

        [Required(ErrorMessage = "Please specify the number of guests.")]
        [Range(1, 10, ErrorMessage = "Number of guests must be between 1 and 10.")]
        [Display(Name = "Number of Guests")]
        public int NumberOfGuests { get; set; }

        [Display(Name = "Special Requests")]
        [StringLength(500)]
        public string SpecialRequests { get; set; }

        // Optional: Relationship to Room entity if you're assigning bookings to rooms
        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}
