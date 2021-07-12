using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieApiV.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApiV.Model;

namespace MovieApiV2Web1.Controllers
{
    public class LandingPageController : Controller
    {
        private readonly ILogger<LandingPageController> _logger;
        private readonly DataHandler dataHandler;
        public LandingPageController(ILogger<HomeController> logger, DataHandler handler)
        {
            //  _logger = logger;
            dataHandler = handler;
        }
        // GET: LandingPage
        public async Task<IActionResult> Index(string make = null, decimal price = 0)
        {
            var list = new List<Car>();
            list = await dataHandler.CarListGet();
            if (!string.IsNullOrEmpty(make))
            {
                var l = await dataHandler.CarListGet();
                list = l.Where(l => l.ManufactureCode == make).ToList();
            }

            if (price > 0)
            {
                var l = await dataHandler.CarListGet();
                list = l.Where(l => l.Price >= price && l.Price <= price).ToList();
            }

            return View(list);
        }

    }
}
