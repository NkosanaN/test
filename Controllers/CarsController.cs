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
        public async Task<ActionResult> Create(Car model1, IFormFile Car)
        {
            try
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
                var r = await dataHandler.CarAddUpdate(model1, 4);
                if(r)
                {
                    return RedirectToAction("index", "admin");
                }
                return View("Error");
            }
            catch
            {
                return View(model1);
            }
        }

        private byte[] GetByteArrayFromImage(IFormFile file)
        {
            using (var target = new MemoryStream())
            {
                file.CopyTo(target);
                return target.ToArray();
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
                var r = await dataHandler.AddBooking(model);
                if (r)
                {
                    // return RedirectToAction("index", "admin");
                    return View("success");
                }
                return View();
            }
            catch (Exception)
            {

                throw;
            }

            return View();
        }
    }
}
