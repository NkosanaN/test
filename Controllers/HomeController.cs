using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using MovieApiV.Model;
using MovieApiV.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApiV2Web1.Controllers
{
    [Authorize(Roles = "User")]

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataHandler dataHandler;

        private readonly IWebHostEnvironment webHostEnvironment;

        public HomeController(ILogger<HomeController> logger, DataHandler handler, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            dataHandler = handler;
            this.webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index(string make = null,decimal price = 0)
        {
            var cars = await dataHandler.CarListGet();
            var parts = await dataHandler.PartListGet();
            return View((cars, parts));
        }

        public IActionResult OnGet()
        {
            var provider = new PhysicalFileProvider(webHostEnvironment.WebRootPath);
            var contents = provider.GetDirectoryContents(Path.Combine("pictures"));
            var objFiles = contents.OrderBy(m => m.LastModified);

            return new JsonResult(objFiles);
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
