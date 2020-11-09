using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWT.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace JWT.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //recebe as informações do login
        public IActionResult Login(LoginViewModel model)
        {
            //verifica se o usuario é o admin, se for, ele é autorizado a entrar
            if (model.Email == "natalia@gmail.com" && model.Password == "numsey")
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Logout()
        {
            return Redirect("/Account/Login");
        }
    }
}
