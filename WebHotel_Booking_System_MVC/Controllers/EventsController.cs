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
                new Event
                {
                    Title = "Summer Festival",
                    Description = "Join us for an unforgettable summer celebration filled with music, games, and delicious local food. Families and friends can enjoy outdoor activities and entertainment throughout the day and create lasting memories.",
                    ImageUrl = "https://livelyhotels.jp/wp-content/uploads/2024/05/604A3669%E3%82%AD%E3%83%BC%E3%83%935mb400-scaled.jpg"
                },
                new Event
                {
                    Title = "Wine Tasting Night",
                    Description = "Indulge in a relaxing evening of premium wine tasting accompanied by gourmet bites. Our sommeliers will guide you through a variety of rich flavors in an elegant setting. Ideal for couples or friends looking for a refined night out.",
                    ImageUrl = "https://media.istockphoto.com/id/505962870/photo/group-of-female-friends-enjoying-night-out-at-rooftop-bar.jpg?s=612x612&w=0&k=20&c=z0la6eFu_qKNfMDv0jdCr555w6vQ3ehb22wr56hZcQM="
                },
                new Event
                {
                    Title = "New Year's Eve Gala",
                    Description = "Welcome the new year in style at our luxurious gala event. Enjoy fine dining, live performances, and a countdown party with a breathtaking fireworks display. Dress your best and get ready for an unforgettable night of celebration.",
                    ImageUrl = "https://desk.insidecom.it/ch24.img/hotel/12-metropole.jpg"
                }
            };

            return View(events);
        }
    }
}
