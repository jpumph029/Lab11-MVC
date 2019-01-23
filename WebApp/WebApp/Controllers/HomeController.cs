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

        public IActionResult Results()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int firstYear, int secondYear)
        {
            TimePerson.GetPersons(firstYear, secondYear);
            return RedirectToAction("Results", new { firstYear, secondYear });
        }



    }
}
