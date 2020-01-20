using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCvsModelBinding.Models;

namespace MVCvsModelBinding.Controllers
{
    public class ModelBindingController : Controller
    {   
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SunshinePeople sp)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(sp);
            }
        }
    }
}