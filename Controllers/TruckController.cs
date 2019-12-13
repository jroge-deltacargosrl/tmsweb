using Microsoft.AspNetCore.Mvc;
using TMS_Web.Models;
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
        [HttpGet("/Truck/Update/{id}/{newName}/{newDescription}", Name = "truckUpdate")]
        public IActionResult UpdateTruck(int id, string newName, string newDescription)
        {
            ViewBag.response = TruckDAL.update(new TruckModel()
            {
                id = id,
                description = newDescription,
                type = newName
            });
            return RedirectToAction("Index");
        }
    }
}