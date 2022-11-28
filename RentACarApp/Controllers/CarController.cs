using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentACarApp.Contracts;
using RentACarApp.Data;
using RentACarApp.Models;
using System.Security.Claims;

namespace RentACarApp.Controllers
{
    public class CarController : Controller
    {
        private readonly RentACarAppDbContext context;
             private readonly ICarService carService;

        public CarController(ICarService _carService, RentACarAppDbContext _context)
        {
            carService = _carService;
            context = _context;
        }


        [AllowAnonymous]
        public async Task<IActionResult> Details(int carId)
        {
            if (!carService.Exists(carId))
            {
                return BadRequest();
            }

            var carModel = await carService.GetCarDetails(carId);

            return View(carModel);
        }

        [AllowAnonymous]
        public IActionResult BackToList()
        {

            return RedirectToAction("index", "Home");
        }

        public async Task<IActionResult> RentCarToCart(int carId)
        {
            try
            {
                var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
                await carService.RentCarToCartAsync(carId, userId);
            }
            catch (Exception)
            {
                throw;
            }

            return RedirectToAction("index", "Home");
        }

        public async Task<IActionResult> RemoveCarFromCart(int carId)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            await carService.RemoveCarFromCartAsync(carId, userId);

            return RedirectToAction(nameof(Rented));
        }

        public async Task<IActionResult> Rented()
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            var model = await carService.GetRentedAsync(userId);

            return View("Rented", model);
        }


        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new AddCarViewModel()
            {
                Engines = await carService.GetEngneAsync(),
                TypeCars = await carService.GetTypeCarAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddCarViewModel modell)
        {
            if (!ModelState.IsValid)
            {
                return View(modell);
            }


            await carService.AddCarForRentAsync(modell);


            try
            {
                return RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong");

                return View(modell);
            }
        }

       

        //TODO: 27.11
        //public async Task<IActionResult> Sum(string userId)
        //{
        //    var user = await context.Users
        //       .Where(u => u.Id == userId)
        //       .Include(u => u.UsersCars)
        //       .FirstOrDefaultAsync();

        //    if (user == null)
        //    {
        //        throw new ArgumentException("Invalid User Id");
        //    }


        //    var cars = user.UsersCars.ToList();

        //    decimal sum = user.UsersCars.Sum(c => c.Car.Price);

        //    return View(sum);
        //}

    }
}
