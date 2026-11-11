using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web_Server_Application_Final_Project.Models;

namespace Web_Server_Application_Final_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutGame()
        {
            return View();
        }

        public IActionResult WhyDifferent()
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
