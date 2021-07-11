using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieApiV.Services;
using MovieApiV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApiV2Web1.Controllers
{
    public class CarsController : Controller
    {
        private readonly ILogger<CarsController> _logger;
        private readonly DataHandler dataHandler;
        public CarsController(ILogger<HomeController> logger, DataHandler handler)
        {
            //  _logger = logger;
            dataHandler = handler;
        }
        // GET: LandingPage
        public async Task<IActionResult> Index()
        {
            var car = await dataHandler.CarListGet();
            var part = await dataHandler.PartListGet();
            return View((car,part) );
        }

        // GET: CarsController/Details/5
        public async Task<IActionResult> Details(string code)
        {
            var r = await dataHandler.CarGetSingle(code);
            return View(r);
        }

        // GET: CarsController/Create
        public ActionResult Create()
        {
            return View(new Car());
        }

        // POST: CarsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Car model)
        {
            try
            {
                var r = await dataHandler.CarAddUpdate(model,4);
                if(r)
                {
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: CarsController/Edit/5
        public async Task<ActionResult> Edit(string code)
        {
            var r = await dataHandler.CarGetSingle(code);
            return View(r);
        }

        // POST: CarsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Car model)
        {
            try
            {
                var r = await dataHandler.CarAddUpdate(model, 5);
                if (r)
                {
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: CarsController/Delete/5
        public async Task<IActionResult> Delete(string code)
        {
            var r = await dataHandler.CarGetSingle(code);
            return View(r);
        }

        // POST: CarsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Car model)
        {
            try
            {
                var r = await dataHandler.CarDelete(model.CarCode);
                if (r)
                {
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
