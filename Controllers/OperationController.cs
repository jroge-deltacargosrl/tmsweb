using Microsoft.AspNetCore.Mvc;
using System;

namespace TMS_Web.Controllers
{
    public class OperationController : Controller
    {
        [HttpPost]
        public IActionResult Index()
        {
            ViewBag.isLogged = false;
            return View();
        }
    }
}