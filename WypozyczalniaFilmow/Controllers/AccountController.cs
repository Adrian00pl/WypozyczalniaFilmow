using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WypozyczalniaFilmow.Models;

namespace WypozyczalniaFilmow.Controllers
{
    public class AccountController : Controller
    {


        private UserManager<AppUser> UserMgr { get; }
        private SignInManager<AppUser> SignInManager { get; }
        public AccountController(UserManager<AppUser> userMgr, SignInManager<AppUser> signInManager)
        {
            UserMgr = userMgr;
            SignInManager = signInManager;
        }
        public async Task<IActionResult> Register()
        {
            try
            {
                ViewBag.message = "User already registered";
                AppUser user = await UserMgr.FindByNameAsync("TestUser");
                if (user == null) {
                    user = new AppUser();
                    user.UserName = "TestUser";
                    user.Email = "TestUser@test.test";
                    user.Firstname = "Jan";
                    user.Lastname = "Kowalski";
                    IdentityResult result = await UserMgr.CreateAsync(user, "User");
                    var errorList = result.Errors.ToList();
                    ViewBag.message = string.Join(" ", errorList.Select(e => e.Description));

                }
            }
            catch (Exception e)
            {
                ViewBag.messae = e.Message;
            }
            return View();
        }
        public async Task<IActionResult> Login(){
            var result = await SignInManager.PasswordSignInAsync("TestUser", "User", false, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.result = result.ToString();
            }
            return View();
            }
        public async Task<IActionResult> Logout()
        {
            await SignInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
