using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proiect_open_discusion.Data;
using Proiect_open_discusion.Models;
using System.Diagnostics;

namespace Proiect_open_discusion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public readonly ApplicationDbContext db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            this.db = db;
        }

        public IActionResult Index()
        {
            var categories = db.Categories;
            ViewBag.Categories = categories;
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