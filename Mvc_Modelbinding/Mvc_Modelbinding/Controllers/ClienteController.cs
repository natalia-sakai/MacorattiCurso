using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvc_Modelbinding.Models;

namespace Mvc_Modelbinding.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //esse index é para tratar a resposta
        [HttpPost]
        public IActionResult Index(Cliente cliente)
        {
            if (cliente?.Id == 0 || cliente?.Nome == null || cliente?.Email == null)
            {
                ViewBag.Erro = "Dados invalidos...";
                return View();
            }
            else
            {
                return View("ExibirDados", cliente);
            }
        }
    }
}
