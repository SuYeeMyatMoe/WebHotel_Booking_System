using Microsoft.AspNetCore.Mvc;

namespace WebHotel_Booking_System_MVC.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult EventList()
        {
            return View();
        }
    }
}
