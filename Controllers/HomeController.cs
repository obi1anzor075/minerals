using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using minerals.Extensions;
using minerals.Interfaces;
using minerals.Models;

namespace minerals.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IItemService _itemService;

        public HomeController(ILogger<HomeController> logger, IItemService itemService)
        {
            _logger = logger;
            _itemService = itemService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Catalog()
        {
            var items = _itemService.GetProducts();
            return View(items);
        }

        public IActionResult Katalog(string[] color, string price)
        {
            var items = _itemService.GetProducts();

            if (color.Length > 0)
            {
                items = items.Where(i => color.Contains(i.Color.ToLower())).ToList();
            }

            if (!string.IsNullOrEmpty(price))
            {
                items = price switch
                {
                    "under1000" => items.Where(i => i.Price < 1000).ToList(),
                    "1000-5000" => items.Where(i => i.Price >= 1000 && i.Price <= 5000).ToList(),
                    "5000-10000" => items.Where(i => i.Price > 5000 && i.Price <= 10000).ToList(),
                    "over10000" => items.Where(i => i.Price > 10000).ToList(),
                    _ => items
                };
            }

            return View(items);
        }


        public IActionResult Articles()
        {
            return View();
        }

        [Authorize]
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
