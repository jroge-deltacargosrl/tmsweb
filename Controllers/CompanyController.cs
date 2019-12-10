using Microsoft.AspNetCore.Mvc;
using TMS_Web.Models.DAL;

namespace TMS_Web.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.companyList = CompanyDAL.getAll();
            return View();
        }
    }
}