using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Push_RPM.Models;
using System.Diagnostics;

namespace Push_RPM.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;


        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _context.Products
                              .Include(p => p.Categories)
                              .ToListAsync();

            var category = await _context.Categories.ToListAsync();

            var times = new Dictionary<string, DateTime>
        {
            { "Нью-Йорк, США", TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, "Eastern Standard Time") },
            { "Лондон, Великобритания", TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, "GMT Standard Time") },
            { "Париж, Франция", TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, "Romance Standard Time") },
            { "Токио, Япония", TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, "Tokyo Standard Time") },
            { "Сидней, Австралия", TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, "AUS Eastern Standard Time") }
        };

            var model = new HomeViewModel { Product = products, Category = category, Time = times };
            return View(model);
        }

        public async Task<IActionResult> Catalog()
        {

            var products = await _context.Products.Include(p => p.Categories).ToListAsync();

            return View(products);

            
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
