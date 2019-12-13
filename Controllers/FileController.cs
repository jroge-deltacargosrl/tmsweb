using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TMS_Web.Models.DAL;

namespace TMS_Web.Controllers
{
    public class FileController : Controller
    {
        public IActionResult Index()
        {
            List<string> fileList = FileDAL.getAll();
            List<string> newFileList = new List<string>();
            foreach (string cad in fileList)
            {
                //string[] s = cad.Split("https://deltacargostorage.blob.core.windows.net/pdf/");
                int pos = cad.LastIndexOf("/");
                newFileList.Add(cad.Substring(pos + 1));
            }
            ViewBag.fileList = newFileList;
            return View();
        }

        [HttpGet("/File/Delete/{fileName}", Name = "fileDelete")]
        public IActionResult Delete(string fileName)
        {
            ViewBag.response = 2;
            return View("Index");
        }
    }
}