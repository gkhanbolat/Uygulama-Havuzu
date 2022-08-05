using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proje.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Proje.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Bmi()
        {
            return View();
        }
        public IActionResult Weather()
        {
            
            return View();
        }
        public IActionResult Deneme()
        {
            return View();
        }

        public IActionResult Quote()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
