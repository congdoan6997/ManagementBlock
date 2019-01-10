using ManagementBlock.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ManagementBlock.Areas.Admin.Controllers
{

    [Area("Admin")]
  
    public class HomeController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            var email = User.GetSpecificClaim("Email");

            return View();
        }
    }
}