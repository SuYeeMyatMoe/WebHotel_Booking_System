using Microsoft.AspNetCore.Mvc;

namespace WebHotel_Booking_System_MVC.Controllers
{
    public class ContactUsController : Controller
    {
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
