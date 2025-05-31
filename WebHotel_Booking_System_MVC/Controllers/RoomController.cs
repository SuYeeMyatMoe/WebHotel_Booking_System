using Hotel_Booking_System.Domain.Entities;
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

        //Get endpoint when user open the form
        [HttpGet]
        public async Task<IActionResult> CreateRoom()
        {
            return View();//it means no data is reloaded in form when it is opened.
        }

        //Post endpoint when user submitted the data for CreateRoom form and .net core will automatically provide Model in view when the form is submitted. 
        //Because of that, we can retrieve data and extract value from model
        [HttpPost]
        public async Task<IActionResult> CreateRoom(Room room)
        {
            await _dbContext.Rooms.AddAsync(room);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index", "Room");
        }
    }
}
