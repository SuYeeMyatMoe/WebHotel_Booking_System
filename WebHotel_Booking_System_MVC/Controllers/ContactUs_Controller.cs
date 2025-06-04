using Microsoft.AspNetCore.Mvc;

namespace WebHotel_Booking_System_MVC.Controllers
{
    public class ContactUs_Controller : Controller
    {
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
