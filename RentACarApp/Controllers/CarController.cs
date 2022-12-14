using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentACarApp.Contracts;
using RentACarApp.Data;
using RentACarApp.Extensions;
using RentACarApp.Models;
using System.Security.Claims;

namespace RentACarApp.Controllers
{
    [Authorize]
    public class CarController : Controller
    {
        private readonly ICarService carService;

        private readonly IAgentService agentService;

        public CarController(ICarService _carService, IAgentService _agentService)
        {
            carService = _carService;
            agentService = _agentService;
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
        public async Task<IActionResult> AgentDetails(int carId)
        {
            if (!carService.Exists(carId))
            {
                return BadRequest();
            }

            var agentModel = await carService.GetAgentDetails(carId);

            return View(agentModel);
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
            if ((agentService.ExistsById(User.Id())) == false)
            {
                return RedirectToAction("Become", "Agent");
            }


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

            if (agentService.ExistsById(User.Id()) == false)
            {
                return RedirectToAction("Become", "Agent");
            }

            int agentId = agentService.GetAgentId(User.Id());

            await carService.AddCarForRentAsync(modell, agentId);


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

        public async Task<IActionResult> Delete(int carId)
        {
            if ((carService.Exists(carId)) == false)
            {
                return RedirectToAction("index", "home");
            }

            if ((await carService.HasAgentWithId(carId, User.Id())) == false && !User.IsAdmin())
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            carService.Delete(carId);

            return RedirectToAction("index", "home");
        }
    }
}
