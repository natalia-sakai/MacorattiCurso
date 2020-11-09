using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.ViewsModel;

namespace WebAPI.Controllers
{
    public class AccountController: Controller
    {
        private readonly UserManager<MyUserIdentity> userManager;
        private readonly SignInManager<MyUserIdentity> loginManager;
        private readonly RoleManager<MyRoleIdentity> roleManager;

        public AccountController(UserManager<MyUserIdentity> userManager,
            SignInManager<MyUserIdentity> loginManager,
            RoleManager<MyRoleIdentity> roleManager)
        {
            this.userManager = userManager;
            this.loginManager = loginManager;
            this.roleManager = roleManager;
        }
        

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel obj)
        {
            if (ModelState.IsValid)
            {
                var result = loginManager.PasswordSignInAsync(obj.UserName, obj.Password, obj.RememberMe, false).Result;
                if (result.Succeeded)
                    return Content("Autorizado");
                ModelState.AddModelError("", "Login Inválido");
            }   

            return View(obj);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel obj)
        {
            if (ModelState.IsValid)
            {
                MyUserIdentity user = new MyUserIdentity();
                user.UserName = obj.UserName;
                user.Email = obj.Email;

                IdentityResult result = userManager.CreateAsync(user, obj.Password).Result;

                if (result.Succeeded)
                {
                    if (!roleManager.RoleExistsAsync("NormalUser").Result)
                    {
                        MyRoleIdentity role = new MyRoleIdentity();
                        role.Name = "NormalUser";
                        role.Descricao = "Realiza operações básicas.";
                        IdentityResult roleResult = roleManager.
                        CreateAsync(role).Result;
                        if (!roleResult.Succeeded)
                        {
                            ModelState.AddModelError("", "Error ao criar o perfil!");
                            return View(obj);
                        }
                    }

                    userManager.AddToRoleAsync(user, "NormalUser").Wait();
                    return RedirectToAction("Login", "Account");
                }
            }
            return View(obj);
        }
    }
}
