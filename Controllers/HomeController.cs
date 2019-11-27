using Microsoft.AspNetCore.Mvc;

namespace TMS_Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.isLogged = false;
            return View();
        }
        public IActionResult Login()
        {
            ViewBag.isLogged = false;
            return View();
        }
    }
}