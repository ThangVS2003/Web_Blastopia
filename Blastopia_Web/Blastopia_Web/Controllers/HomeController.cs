using Blastopia_Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Blastopia_Web.Controllers
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
            return View(); // Lệnh này sẽ tự động tìm Views/Home/Index.cshtml
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
        // Dán 3 hàm này vào file Controllers/HomeController.cs


        public IActionResult Community()
        {
            return View();
        }

        public IActionResult Terms()
        {
            return View();
        }
        public IActionResult Story()
        {
            return View();
        }
        public IActionResult Collection()
        {
            return View();
        }
    }
}
