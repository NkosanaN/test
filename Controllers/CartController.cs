using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieApiV.Model;
using MovieApiV.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApiV2Web1.Controllers
{
    public class CartController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataHandler dataHandler;
        public CartController(ILogger<HomeController> logger, DataHandler handler)
        {
            _logger = logger;
            dataHandler = handler;
        }
        public async Task<IActionResult> Index()
        {
            var cars = await dataHandler.CarListGet();
            var parts = await dataHandler.PartListGet();
            var carts = await dataHandler.CartGetList();

            foreach (var cart in carts)
            {
                foreach (var car in cars)
                {
                    if(car.CarCode == cart.ItemCode)
                    {
                        cart.ImagePicture = car.ImagePicture;
                    }
                }

                foreach (var part in parts)
                {
                    if (part.PartCode == cart.ItemCode)
                    {
                        cart.ImagePicture = part.ImagePicture;
                    }
                }
            }
            return View(carts);
        }

        

        // POST: CartController/Create
        [HttpPost]
        public async Task<IActionResult> Create(string id, bool iscar)
        {
            try
            {
                var model = new Cart();
                if (iscar)
                {
                    var r = await dataHandler.CarGetSingle(id);
                    model.ItemCode = r.CarCode;
                    model.ItemName = r.CarCode;
                    model.Description = r.CarDescription;
                    model.Price = r.Price;
                    model.Quantity = 1;
                }
                else
                {
                    var r = await dataHandler.PartListGet();
                    var part = r.FirstOrDefault(p => p.PartCode == id);
                    model.ItemCode = part.PartCode;
                    model.ItemName = part.PartName;
                    model.Description = part.PartName;
                    model.Price = part.Price;
                    model.Quantity = 1;
                }
               
                var addcart = await dataHandler.CartAddUpdate(model,4);
                if(addcart)
                {
                    return Ok(new { success=true });
                }
                return Ok(new { success = false });
            }
            catch
            {
                return View();
            }
        }


        // POST: CartController/Delete/5
        [HttpPost]
        public async Task<IActionResult> Delete(string code)
        {
            try
            {
                var r = await dataHandler.CartDelete(code);
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


        public async Task<IActionResult> CustomerPayment(string code)
        {
            var model = new Payments { CarSoldCode = code, PaymentDateDue = DateTime.Now}; ;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CustomerPayment(Payments model)
        {
            try
            {
                model.PaymentDateDue = DateTime.Now;

                var paid = await dataHandler.Payment(model);
                if (paid)
                {
                    return RedirectToAction("PaymentList", "Cart", new {  });
                }
                return View(model);
            }
            catch
            {
                return View(model);
            }
        }

        public async Task<IActionResult> PaymentList()
        {
            var payment = await dataHandler.CarListGet();
            return View(payment);
        }

        public async Task<IActionResult> Payment(string type,string code)
        {
            var customer = "";
            var payment = await dataHandler.Payment(type, code, customer);
            if (payment)
            {
                return View("success");
            }
            return View();
        }

        public async Task<IActionResult> CreditCardPayment(decimal amount,string item, string name)
        {
            ViewBag.Amount = amount;
            return View((amount, item,name));
        }

        [HttpPost]
        public async Task<IActionResult> CreditCardPayment(string item)
        {
            var r = await dataHandler.CartDelete(item);
            if (r)
            {
                return View("success");
            }
            return View();
        }
    }
}
