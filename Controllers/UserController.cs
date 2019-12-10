using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TMS_Web.Models;
using TMS_Web.Models.DAL;

namespace TMS_Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index(int response=0)
        {
            List<UsuarioModel> userList = UserDAL.getAll();
            ViewBag.response = response;
            return View(userList);
        }

        [HttpGet("/Refresh/{id}/{c}/{e}/{s}", Name = "aux")]
        public IActionResult Refresh(int id, byte c, byte e, byte s)
        {
            UserDAL.refreshUsers(new UsuarioModel
            {
                id = id,
                clientType = c,
                employeeType = e,
                supplierType = s
            });
            int response = 1;
            return RedirectToAction("Index",new {response});
        }

        [HttpGet("/SendPassword/{id}", Name = "au")]
        public IActionResult SendPassword(int id)
        {
            UserDAL.sendPassword(id);
            int response = 1;
            return RedirectToAction("Index", new
            {
                response
            });
        }
    }
}