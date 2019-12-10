using Microsoft.AspNetCore.Mvc;
using TMS_Web.Models.DAL;

namespace TMS_Web.Controllers
{
    public class TruckController : Controller
    {
        [HttpGet("/Truck/Index", Name = "truckIndex")]
        public IActionResult Index()
        {
            ViewBag.truckList = TruckDAL.getAll();
            return View();
        }
    }
}