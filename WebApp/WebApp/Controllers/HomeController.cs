using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Results(int firstYear, int secondYear)
        {
            
            return View(TimePerson.GetPersons(firstYear, secondYear));
        }

        [HttpPost]
        public IActionResult Index(int firstYear, int secondYear)
        {
            TimePerson.GetPersons(firstYear, secondYear);
            return RedirectToAction("Results", new { firstYear, secondYear });
        }




    }
}
