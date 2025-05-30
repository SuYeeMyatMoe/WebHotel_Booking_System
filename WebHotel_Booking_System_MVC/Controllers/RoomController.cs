using Hotel_Booking_System.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IActionResult> Index()
        {
            var rooms=await _dbContext.Rooms.ToListAsync();
            return View(rooms);//display the list in View by passing rooms parameter
        }
        public async Task<IActionResult> CreateRoom()
        {
            return View();
        }
    }
}
