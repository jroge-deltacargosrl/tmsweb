using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TMS_Web.Models;

namespace TMS_Web.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet()]
        public IActionResult RefreshUser(bool a1,bool a2, bool a3)
        {
            int x = 1;
            return null;    
        }

    }
}