﻿using EmailApp.Entities;
using EmailApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmailApp.Controllers
{
    public class LoginController(UserManager<AppUser> _userManager, SignInManager<AppUser> _signInManager) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user is null)
            {
                ModelState.AddModelError("", "Bu email sistemde kayıtlı değil");
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Email veya Şifre Hatalı");
                return View(model);
            }

            return RedirectToAction("Index", "Message");
        }
    }
}
