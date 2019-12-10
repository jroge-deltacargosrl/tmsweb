using Microsoft.AspNetCore.Mvc;
using TMS_Web.Models.DAL;

namespace TMS_Web.Controllers
{
    public class ConfigurationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sincronize()
        {
            ConfigurationDAL.sincronizeOdooContacts();
            return RedirectToAction("Index");
        }
    }
}