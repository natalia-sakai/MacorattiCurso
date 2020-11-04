using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Atividade3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Atividade3.Controllers
{
    public class PaisesController : Controller
    {
        private readonly AplicacaoContext _context;

        public PaisesController(AplicacaoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Pais> listaPaises = new List<Pais>();

            //pega dados da tabela
            listaPaises = (from pais in _context.Paises select pais).ToList();

            //insere dados na tabela
            listaPaises.Insert(0, new Pais { Id = 0, Nome = "Selecione" });

            ViewBag.ListaPaises = listaPaises;

            return View();
        }

        [HttpPost]
        public IActionResult Index(Pais pais)
        {
            if(pais.Id == 0)
            {
                ModelState.AddModelError("", "Selecione um pais");
            }

            ViewBag.ValorSelecionado = pais.Id;

            List<Pais> listaPaises = new List<Pais>();

            //pega dados da tabela
            listaPaises = (from p in _context.Paises select p).ToList();

            //insere dados na tabela
            listaPaises.Insert(0, new Pais { Id = 0, Nome = "Selecione" });

            ViewBag.ListaPaises = listaPaises;

            return View();
        }
    }
}
