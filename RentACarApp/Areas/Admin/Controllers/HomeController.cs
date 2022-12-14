using Microsoft.AspNetCore.Mvc;

namespace RentACarApp.Areas.Admin.Controllers
{
    public class HomeController : AdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
