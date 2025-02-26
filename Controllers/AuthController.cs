using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace minerals.Controllers
{
    [Authorize]
    public class AuthController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
    }
}
