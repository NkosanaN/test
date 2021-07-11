using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieApiV.Model;
using MovieApiV.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApiV2Web1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataHandler dataHandler;
        public HomeController(ILogger<HomeController> logger, DataHandler handler)
        {
            _logger = logger;
            dataHandler = handler;
        }

        public async Task<IActionResult> Index(string make = null,decimal price = 0)
        {
            var list = new List<Car>();
            if(!string.IsNullOrEmpty(make))
            {
                var l = await dataHandler.CarListGet();
                list = l.Where(l => l.ManufactureCode == make).ToList();
            }

            if (price > 0)
            {
                var l = await dataHandler.CarListGet();
                list = l.Where(l => l.Price  >= price && l.Price <= price).ToList();
            }

            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
