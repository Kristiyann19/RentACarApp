using Microsoft.AspNetCore.Mvc;
using RentACarApp.Contracts;

namespace RentACarApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarService carService;

        public HomeController(ICarService _carService)
        {
            carService = _carService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await carService.GetAllCarsAsync();

            return View(model);
        }
    }
}
