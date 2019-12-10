using Microsoft.AspNetCore.Mvc;
using TMS_Web.Models;
using TMS_Web.Utils;

namespace TMS_Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            UserModel user = new UserModel
            {
                email = "",
                password = "",
                typeAccess = 0
            };
            HttpContext.Session.setObjectAsJson("actualUser",user);
            return View();
        }

        public IActionResult Login(int estadoUsuario = 0, int estadoContraseña = 0, string antiguoUsuario = "")
        {
            ViewBag.estadoUsuario = estadoUsuario;
            ViewBag.estadoContraseña = estadoContraseña;
            ViewBag.antiguoUsuario = antiguoUsuario;
            ViewBag.isLogged = false;
            return View();
        }

        public IActionResult Extra()
        {
            return View();
        }
    }
}