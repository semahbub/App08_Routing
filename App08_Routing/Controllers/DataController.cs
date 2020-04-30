using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace App08_Routing.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Show(int yr, int mn, int dd)
        {
            DateTime bdt = new DateTime(yr, mn, dd);

            string bday = bdt.DayOfWeek.ToString();

            ViewBag.date = bdt.ToString("dd MMMM yyyy");
            ViewBag.day = bday;

            return View();
        }

        public IActionResult Hide()
        {
            return View();
        }

        public IActionResult Person(string name, int mobile, string address)
        {
            ViewBag.name = name;
            ViewBag.mobile = mobile;
            ViewBag.address = address;

            return View();
        }
    }
}