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
    public class AccountController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        private readonly DataHandler dataHandler;
        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, 
            RoleManager<IdentityRole> roleManager, DataHandler handler)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            dataHandler = handler;
        }
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {

            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = model.Email,
                    Email = model.Email

                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    //add role here
                    //await _userManager.AddToRoleAsync(user, "Admin");
                    return RedirectToAction("RegisterSuccess", "Account");
                }
            }
            ModelState.AddModelError("", "Invalid Register.");
            //ModelState.AddModelError("Email", "Invalid Register.");
            return View(model);
        }
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: false, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    var user = await _userManager.FindByNameAsync(model.Email);
                    //user role list here
                    var roles = await _userManager.GetRolesAsync(user);
                    //get default role here
                    string role = roles.FirstOrDefault();
                    if (role.Equals("Admin"))
                    {
                        return RedirectToAction("Index", "Admin");
                    }
                    else if (role.Equals("User"))
                    {
                        return RedirectToAction("UserActionName", "UserControllerName");
                    }
                    else
                    {
                        //do somthing here.put in your logic 
                    }
                }
            }
            ModelState.AddModelError("", "Invalid ID or Password");
            return View(model);
        }

        //must go to loyd's part

        public async Task<ActionResult> BookToDriver()
        { return View(); }
        [HttpPost]
        public async Task<ActionResult> BookToDriver(Bookings model) 
        {
            try
            {
                var r = await dataHandler.AddBooking(model);
            }
            catch (Exception)
            {

                throw;
            }
  
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        public ActionResult RegisterSuccess()
        {
            return View();
        }
        public ActionResult LoginSuccess() 
        {
            return View();
        }
    }
}