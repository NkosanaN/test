﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieApiV.Services;
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
            var r = await dataHandler.CarListGet();
            return View(r);
        }

        // GET: CarsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CarsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: CarsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CarsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: CarsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CarsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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