using Microsoft.AspNetCore.Mvc;
using TMS_Web.Models;
using TMS_Web.Models.DAL;

namespace TMS_Web.Controllers
{
    public class TaskController : Controller
    {
        [HttpGet]
        public IActionResult Index(int response=0)
        {
            ViewBag.taskList = TaskDAL.getAll();
            ViewBag.response = response;
            return View();
        }

        [HttpGet("/TaskChange/{id}/{f}/{v}", Name = "taskChange")]
        public IActionResult TaskChange(int id,byte f,byte v)
        {
            ViewBag.taskList = TaskDAL.refreshTasks(new TaskConfigurationModel {
                id=id,
                allowDocuments=f,
                state=v
            });
            int response = 1;
            return RedirectToAction("Index", new
            {
                response
            });
        }
    }
}