using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCvsModelBinding.Models;

namespace MVCvsModelBinding.Controllers
{
    public class FormsController : Controller
    {
        [HttpGet]
        public IActionResult Appointments()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Appointments(IFormCollection data)
        {
            SunshinePeople sp = new SunshinePeople();

            sp.FullName = data["full-name"];
            sp.DateOfBirth = Convert.ToDateTime(data["dob"]);
            sp.AppointmentDate = Convert.ToDateTime(data["AppTime"]);

            //Add to database

            ViewData["Message"] = "Confimred your Appointment Successfully";


            return View();
        }
    }
}