using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static RentACarApp.Areas.Admin.Constants.AdminConstants;

namespace RentACarApp.Areas.Admin.Controllers
{
    [Area(AreaName)]
    [Authorize(Roles = AdminRoleName)]
    public class AdminController : Controller
    {
         
    }
}
