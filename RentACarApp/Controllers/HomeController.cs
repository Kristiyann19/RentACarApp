using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentACarApp.Contracts;
using RentACarApp.Data;

namespace RentACarApp.Controllers
{
    public class HomeController : Controller    
    {

        private readonly ICarService carService;

        public HomeController(ICarService _carService)
        {
            carService = _carService;
        }


        public async Task<IActionResult> Index(string SearchString)
        {
            //if (User.IsInRole("Administrator"))
            //{
            //    return RedirectToAction("Index", "Home", new { area = "Admin" });
            //}

            ViewData["CurrentFilter"] = SearchString;

            var cars = await carService.GetAllCarsAsync();

            if (!String.IsNullOrEmpty(SearchString))
            {
                cars = cars.Where(c => c.Make.ToLower().Contains(SearchString.ToLower()) || c.Model.Contains(SearchString));
            }

            return View(cars);
        }

        public IActionResult Contact()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "User");
            }

            return View(); 
        }
    }
}
