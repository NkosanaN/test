using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApiV2Web1.Controllers
{
    public class ManufacturesController : Controller
    {
        // GET: ManufacturesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ManufacturesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ManufacturesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManufacturesController/Create
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

        // GET: ManufacturesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ManufacturesController/Edit/5
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

        // GET: ManufacturesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ManufacturesController/Delete/5
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
