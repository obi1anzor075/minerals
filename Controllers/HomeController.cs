using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using minerals.Models;

namespace minerals.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Katalog()
        {
            return View();
        }

        public IActionResult Articles()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Favorites()
        {
            return View();
        }

        public IActionResult Item()
        {
            return View();
        }

        public IActionResult AboutUs()
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
