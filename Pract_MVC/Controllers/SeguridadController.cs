using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pract_MVC.Controllers
{
    public class SeguridadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if(email=="luis@esan.edu.pe" && password == "12345")
            {
                return RedirectToAction("Index", "Home", new { area = "Marketing" });
            }
            return View();
        }
    }
}
