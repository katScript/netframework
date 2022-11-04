using System.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WDP2022A2Win.Data;
using WDP2022A2Win.Models;

namespace WDP2022A2Win.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _dbContext; 

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            this._dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Companies()
        {
            var companies = await _dbContext.Companies.ToListAsync();
            return View(companies);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        public IActionResult Privacy()
        {
            return View();
        }
    }
}