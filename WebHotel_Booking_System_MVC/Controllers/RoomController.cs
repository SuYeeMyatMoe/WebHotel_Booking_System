using Hotel_Booking_System.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace WebHotel_Booking_System_MVC.Controllers
{
    
    //Instead of registering DbContext directly, as DbContext is registered in program.cs, we can inject dbcontext and automatically configure connectionstring, open connection and give implemation for constructor
    
    public class RoomController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public RoomController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var rooms=_dbContext.Rooms.ToList();
            return View();
        }
    }
}
