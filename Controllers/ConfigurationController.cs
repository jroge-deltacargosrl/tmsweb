using Microsoft.AspNetCore.Mvc;
using TMS_Web.Models.DAL;

namespace TMS_Web.Controllers
{
    public class ConfigurationController : Controller
    {
        public IActionResult Index(int response = 0)
        {
            ViewBag.response = response;
            return View();
        }

        public IActionResult Sincronize()
        {
            ConfigurationDAL.sincronizeOdooContacts();
            int response = 1;
            return RedirectToAction("Index", new { response });
        }
    }
}