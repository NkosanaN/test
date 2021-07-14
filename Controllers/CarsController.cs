using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieApiV.Services;
using MovieApiV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

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
            var data = await dataHandler.CarListGet();
            var model = data.FirstOrDefault(p => p.CarCode == code);
            return View(model);
        }

        // GET: CarsController/Create
        public ActionResult Create()
        {
            var m = new Car { DateAcquired = DateTime.Now , ReqistationYear = DateTime.Now };
            return View(m);
           
        }

        public List<string> validImageTypes = new List<string>
        {
            "image/gif",
            "image/jpeg",
            "image/pjpeg",
            "image/png"
        };

        // POST: CarsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Car model1)
        {
            try
            {
                if (model1.Image != null)
                {
                    if (model1.Image.Length > 48000)
                    {
                        ModelState.AddModelError("ImagePicture", "The file is too large, 48kb maximum");
                    }
                    if (!validImageTypes.Contains(model1.Image.ContentType))
                    {
                        ModelState.AddModelError("ImagePicture", "Invalid file type, please upload jpg or png files only");
                    }
                    using (var memoryStream = new MemoryStream())
                    {
                        await model1.Image.CopyToAsync(memoryStream);

                        model1.ImagePicture = memoryStream.ToArray();
                    }
                    model1.ImagePath = Path.GetFileName(model1.Image.FileName);
                }

                var updated = await dataHandler.CarAddUpdate(model1, 5);
                if(updated)
                {
                    return RedirectToAction("cars", "admin");
                }
                return View("Error");
            }
            catch
            {
                return View(model1);
            }
        }


        // GET: CarsController/Edit/5
        public async Task<ActionResult> Edit(string code)
        {
            var car = await dataHandler.CarGetSingle(code);
            return View(car);
        }

        // POST: CarsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Car model1)
        {
            try
            {
                if (model1.Image != null)
                {
                    if (model1.Image.Length > 48000)
                    {
                        ModelState.AddModelError("ImagePicture", "The file is too large, 48kb maximum");
                    }
                    if (!validImageTypes.Contains(model1.Image.ContentType))
                    {
                        ModelState.AddModelError("ImagePicture", "Invalid file type, please upload jpg or png files only");
                    }
                    using (var memoryStream = new MemoryStream())
                    {
                        await model1.Image.CopyToAsync(memoryStream);

                        model1.ImagePicture = memoryStream.ToArray();
                    }
                    model1.ImagePath = Path.GetFileName(model1.Image.FileName);
                }
                var edited = await dataHandler.CarAddUpdate(model1, 5);
                if (edited)
                {
                    return RedirectToAction("cars", "admin");
                }
                return View(model1);
            }
            catch
            {
                return View(model1);
            }
        }

        // GET: CarsController/Delete/5
        public async Task<IActionResult> Delete(string code)
        {
            var car = await dataHandler.CarGetSingle(code);
            return View(car);
        }

        // POST: CarsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Car model)
        {
            try
            {
                var delete = await dataHandler.CarDelete(model.CarCode);
                if (delete)
                {
                    return RedirectToAction("cars", "admin");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult BookToDriver(string carname)
        {
            var model = new Bookings { CustName= User.Identity.Name, Revdate = DateTime.Now, TestingCarName= carname };
            return View(model);
        }
        [HttpPost]
        public async Task<ActionResult> BookToDriver(Bookings model)
        {
            try
            {
                var booked = await dataHandler.AddBooking(model);
                if (booked)
                {
                    return View("_BookingSuccess");
                }
                return View();
            }
            catch 
            {
                return View("error");
            }

        }

        [HttpPost]

        public async Task<IActionResult> DeleteImage(string id)
        {
            var delete = await dataHandler.DeleteCarPicture(id);
            if (delete)
            {
                return Ok(new { success = true });
            }
            return Ok(new { success = false });
        }
    }
}
