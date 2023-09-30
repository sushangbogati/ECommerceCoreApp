using Microsoft.AspNetCore.Mvc;
using ECommerceCoreApp.Models;
namespace ECommerceCoreApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(SiteUser user)
        {
            return View();
        }
    }
}
