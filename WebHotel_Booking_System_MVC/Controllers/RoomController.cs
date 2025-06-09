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
            //custom validation which prevent saving but cannot be seen in UI
            if (room.Name == room.Description)
            {
                ModelState.AddModelError("", "The Room description cannot exactly match the Name.");//key, value and since key is empty it don't know where to show so must use with asp-validation-summary="ModelOnly" in div
                //after checking other validation, it will check custom validation in last before saving and show message if it is invalid
            }

            //check for validation (to handle exception error due to required model attribute)
            if (ModelState.IsValid)//ModelState can help to debug invalid
            {
                room.CreatedDate = DateTime.UtcNow; // Set current UTC time on creation
                await _dbContext.Rooms.AddAsync(room);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction("Index", "Room");
            }
            return View(room);
        }

        [HttpGet]
        public async Task<IActionResult> EditRoom(int id)
        {
            var room = await _dbContext.Rooms.FirstOrDefaultAsync(r => r.Id == id);
            if (room == null)
            {
                return NotFound();
            }
            return View(room); // load existing room data into the form
        }

        [HttpPost]
        public async Task<IActionResult> EditRoom(Room room)//same name but different parameter
        {
            return View(room);
        }

        [HttpGet]
        public async Task<IActionResult> RoomDetails(int id)
        {
            var room = await _dbContext.Rooms.FirstOrDefaultAsync(r => r.Id == id);
            if (room == null)
            {
                return NotFound();
            }
            return View(room);
        }




    }
}
