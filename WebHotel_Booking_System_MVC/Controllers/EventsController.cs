using Hotel_Booking_System.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebHotel_Booking_System_MVC.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult EventList()
        {
            // It is Sample data — later, I will pull this from a database
            var events = new List<Event>
            {
                new Event { Title = "Summer Festival", Description = "Join us for a fun-filled summer!", ImageUrl = "/images/summer-festival.jpg" },
                new Event { Title = "Wine Tasting Night", Description = "Experience the best wines.", ImageUrl = "/images/wine-night.jpg" },
                new Event { Title = "New Year's Eve Gala", Description = "Celebrate the new year in style.", ImageUrl = "/images/newyear-gala.jpg" }
            };

            return View(events);
        }
    }
}
