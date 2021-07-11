using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MovieApiV.Model;
using MovieApiV.Services;
using MovieApiV2Web1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApiV2Web1.Controllers
{
    /* Admin steps 
     * View Test Driving Bookings 
     * Create Role(s)
     */
    //[Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        //private readonly DataHandler dataHandler;
        private readonly DataHandler dataHandler;
        public AdminController(RoleManager<IdentityRole> roleManager, DataHandler handler) 
        {
            _roleManager = roleManager;
            dataHandler = handler;
        }
        // GET: AdminController
        public async Task<ActionResult> Index()
        {
            var model = await dataHandler.BookingListGet();
            return View(model);
        }

        // GET: AdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Role role)
        {
            try
            {
                ModelState.AddModelError("RoleName", "The Role already exist.");
                var roleExist = await _roleManager.RoleExistsAsync(role.RoleName);
                if (!roleExist) 
                {
                    var r = await _roleManager.CreateAsync(new IdentityRole(role.RoleName));
                }
            }
            catch
            {
            }

            return View(role);
        }

        // GET: AdminController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var model = await dataHandler.BookingGetSingle(id);
            return View(model);
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Bookings model)
        {
            try
            {
                var r = await dataHandler.UpdateBooking(model, id);
                if (r)
                    return RedirectToAction(nameof(Index));
                else 
                    View("Error");

            }
            catch (Exception ex)
            {
                return View(ex);
            }
            return View(model);
        }

        // GET: AdminController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var model = await dataHandler.BookingGetSingle(id);
            return View(model);
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id,Bookings model)
        {
            try
            {
                var r = await dataHandler.DeleteBooking(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }
    }
}
