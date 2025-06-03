using Microsoft.AspNetCore.Mvc;

namespace WebHotel_Booking_System_MVC.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult BookNow()
        {
            return View();
        }
    }
}
