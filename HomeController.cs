using Microsoft.AspNetCore.Mvc;
using NotSözlüWebApplication.Models;
using System.Diagnostics;

namespace NotSözlüWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(NotSözlü notSözlü)
        {
            var not_1 = notSözlü.Not_1;
            var not_2 = notSözlü.Not_2;
            var sözlü_ = notSözlü.Sözlü;
            var ortalama = ((not_1 * 30) / 100 + ((not_2 * 30) / 100) + ((sözlü_ * 40) / 100));
            var message = string.Empty;
            if (ortalama >= 50)
            {
                message = "Geçme Notunuz : " + ortalama;
            }
            else
            {
                message = "Kalma Notunuz : " + ortalama;

            }
            ViewBag.Message = message;
            return View("notSözlü");
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