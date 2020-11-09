using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mvc_Identity.Data;

namespace Mvc_Identity.Controllers
{
    //esse atributo so permite acesso aos usuarios autenticados
    //toda as view do contato
    //[Authorize]

    //autoriza apenas o admin
    [Authorize(Roles = "Admin")]
    public class ContatoController : Controller
    {
        private ApplicationDbContext _context;

        public ContatoController(ApplicationDbContext contexto)
        {
            _context = contexto;
        }

        //se tentar acessar o index
        //[Authorize]
        public IActionResult Index()
        {
            //sempre verifica se esta autenticado
            //if (User.Identity.IsAuthenticated)
            //{

            //usando o authoriza ele ja verifica sempre
            var contatos = _context.Contatos.ToList();
            return View(contatos);


            //}
            //else
            //{
            //    return RedirectToAction("Login", "Account");
            //}
        }

        public IActionResult AcessoAutorizado()
        {
            return Content("ACESSO AUTORIZADO..........");
        }

        //permite que mesmo que tenha o authorize la em cima, o usuario sem login acesse
        [AllowAnonymous]
        public IActionResult AcessoAnonimo()
        {
            return Content("ACESSO ANÔNIMO..........");
        }
    }
}
