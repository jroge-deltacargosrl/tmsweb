using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TMS_Web.Models.DAL;

namespace TMS_Web.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.serviceCompanyList = ServiceDAL.getByCompany();
            return View();
        }
    }
}