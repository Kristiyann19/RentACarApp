using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RentACarApp.Constants;
using RentACarApp.Contracts;
using RentACarApp.Extensions;
using RentACarApp.Models;

namespace RentACarApp.Controllers
{
    [Authorize]
    public class AgentController : Controller
    {
        private readonly IAgentService agentService;

        public AgentController(IAgentService _agentService)
        {
            agentService = _agentService;
        }


        [HttpGet]
        public IActionResult Become()
        {
            if (agentService.ExistsById(User.Id()))
            {
                TempData[MessageConstant.ErrorMessage] = "You are already agent.";

                return RedirectToAction("Index", "Home");
            }

            var model = new BecomeAgentModel();

            return View(model);
        }

        [HttpPost]
        public IActionResult Become(BecomeAgentModel model)
        {
            var userId = User.Id();

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (agentService.ExistsById(userId))
            {
                TempData[MessageConstant.ErrorMessage] = "You are already agent.";

                return RedirectToAction("Index", "Home");
            }

            if (agentService.AgentWithPhoneNumberExists(model.PhoneNumber))
            {
                TempData[MessageConstant.ErrorMessage] = "The phone already exists";

                return RedirectToAction("Index", "Home");
            }

            agentService.Create(userId, model.PhoneNumber);

            return RedirectToAction("Index", "Home");
        }
    }
}
