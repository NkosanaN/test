using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieApiV.Model;
using MovieApiV.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace MovieApiV2Web1.Controllers
{
    public class PartsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataHandler dataHandler;
        private readonly IHttpContextAccessor _accessor;
        private readonly IWebHostEnvironment _env;
        private string LogoFolderPath { get => Path.Combine(_env.ContentRootPath, "wwwroot", "Pictures"); }
        public PartsController(ILogger<HomeController> logger, DataHandler handler, IWebHostEnvironment env)
        {
            _logger = logger;
            dataHandler = handler;
            _env = env;
        }
        public List<string> validImageTypes = new List<string>
        {
            "image/gif",
            "image/jpeg",
            "image/pjpeg",
            "image/png"
        };
        // GET: PartsController
        public async Task<IActionResult> Index()
        {
            var list = await dataHandler.PartListGet();
            return View(list);
        }

        // GET: PartsController/Details/5
        public async Task<IActionResult> Details(string id)
        {
            var data = await dataHandler.PartListGet();
            var model = data.FirstOrDefault(p => p.PartCode == id);
            return View(model);
        }

        // GET: PartsController/Create
        public ActionResult Create()
        {
            var model = new Part { Year = DateTime.Now };
            return View(model);
        }

        // POST: PartsController/Create
        [HttpPost]

        public async Task<IActionResult> Create(Part model1 )
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

                if (ModelState.IsValid)
                {
                    var r = await dataHandler.PartAddUpdate(model1, 4);
                    if (r)
                    {
                        return RedirectToAction("index", "admin");
                    }
                    return View("Error");
                }
            }
            catch
            {
                return View("Error");
            }
            return View(model1);
        }

        // GET: PartsController/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            var data = await dataHandler.PartListGet();
            var model = data.FirstOrDefault(p => p.PartCode == id);
            return View(model);
        }

        // POST: PartsController/Edit/5
        [HttpPost]

        public async Task<IActionResult> Edit(Part model1)
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

                if (ModelState.IsValid)
                {
                    var r = await dataHandler.PartAddUpdate(model1, 5);
                    if (r)
                    {
                        return RedirectToAction("parts", "admin");
                    }
                    return View("Error");
                }
            }
            catch
            {
                return View("Error");
            }
            return View(model1);
        }

        // GET: PartsController/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            var data = await dataHandler.PartListGet();
            var model = data.FirstOrDefault(p => p.PartCode == id);
            return View(model);
        }

        // POST: PartsController/Delete/5
        [HttpPost]

        public async Task<IActionResult> Delete(Part model1)
        {
            try
            {
                var delete = await dataHandler.PartDelete(model1.PartCode);
                if (delete)
                {
                    return RedirectToAction("parts", "admin");
                }
                return View("Error");
            }
            catch
            {
                return View(model1);
            }
        }

        [HttpPost]

        public async Task<IActionResult> DeleteImage(string id)
        {
            var delete = await dataHandler.DeletePicture(id);
            if (delete)
            {
                return Ok(new { success = true });
            }
            return Ok(new { success = false });
        }
    }
}
