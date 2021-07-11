using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieApiV2Web1.Models;
using MovieApiV.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace MovieApiV2Web1.Controllers
{
    public class PartsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataHandler dataHandler;
        public PartsController(ILogger<HomeController> logger, DataHandler handler)
        {
            _logger = logger;
            dataHandler = handler;
        }
        // GET: PartsController
        public async Task<IActionResult> Index()
        {
            var r = await dataHandler.PartListGet();
            return View(r);
        }

        // GET: PartsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PartsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PartsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PartsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PartsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, string collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PartsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PartsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, string collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
