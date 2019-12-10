using Microsoft.AspNetCore.Mvc;

namespace TMS_Web.Controllers
{
    public class FileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}