using Microsoft.AspNetCore.Mvc;
using TMS_Web.Models.DAL;

namespace TMS_Web.Controllers
{
    public class TruckController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.truckList = TruckDAL.getAll();
            return View();
        }
        [HttpGet("/Truck/Update/{id}/{newName}", Name = "truckUpdate")]
        public IActionResult UpdateTruck(int id, string newName)
        {
            ViewBag.response = 1;   
            return View("Index");
        }
    }
}