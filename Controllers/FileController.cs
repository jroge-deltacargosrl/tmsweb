using Microsoft.AspNetCore.Mvc;
using TMS_Web.Models.DAL;

namespace TMS_Web.Controllers
{
    public class FileController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.fileList = FileDAL.getAll();
            return View();
        }
    }
}