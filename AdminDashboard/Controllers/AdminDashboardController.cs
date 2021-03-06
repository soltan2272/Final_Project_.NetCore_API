using AdminDashboard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AdminDashboard.Controllers
{
    public class AdminDashboardController : Controller
    {
        private readonly ILogger<AdminDashboardController> _logger;

        public AdminDashboardController(ILogger<AdminDashboardController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult Orders()
        {
            
            return View();
        }
        public IActionResult Products()
        {
            return View();
        }
        public IActionResult Detiles()
        {
            return View();
        }
        public IActionResult Users()
        {
            return View();
        }
        public IActionResult Suppliers()
        {
            return View();
        }
        public IActionResult Reports()
        {
            return View();
        }
        public IActionResult Integrations()
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
