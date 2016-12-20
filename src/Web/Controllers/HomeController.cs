using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dal;
using Dal.Models;
using Microsoft.Extensions.Logging;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly BusinessProContext context;
        private readonly ILogger logger;

        public HomeController(BusinessProContext context, ILoggerFactory loggerFactory)
        {
            this.context = context;
            logger = loggerFactory.CreateLogger<HomeController>();
        }

        public IActionResult Index()
        {
            logger.LogInformation("My Information Logger: Index");
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
