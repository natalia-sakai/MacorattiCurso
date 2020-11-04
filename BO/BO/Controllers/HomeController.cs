using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BO.Models;

namespace BO.Controllers
{
    public class HomeController : Controller
    {
        private IAlunoBLL alunoBll;
        public HomeController(IAlunoBLL _alunoBll)
        {
            /*
             injeção de dependencia
            antes todas as funcoes tinham que ter:
            AlunoBLL _aluno = new AlunoBLL();
            */
            alunoBll = _alunoBll;
        }

        public IActionResult Index()
        {

            //apresenta a lista de alunos retornada do AlunoBBL
            List<Aluno> alunos = alunoBll.GetAlunos().ToList();

            return View("Lista", alunos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Aluno aluno)
        {
            /*
             VALIDAÇÂO POR CONTA DO CONTROLLER
            if (string.IsNullOrEmpty(aluno.Nome))
                ModelState.AddModelError("Nome", "O campo é obrigatorio.");
            if (string.IsNullOrEmpty(aluno.Email))
                ModelState.AddModelError("Email", "O campo é obrigatorio.");
            if (string.IsNullOrEmpty(aluno.Sexo))
                ModelState.AddModelError("Sexo", "O campo é obrigatorio.");
            if (aluno.Nascimento <= DateTime.Now.AddYears(-18))
                ModelState.AddModelError("Nascimento", "Idade inválida.");
            */

            
            /*
                VALIDAÇÃO SIMPLES
            if (aluno?.Nome == null || aluno?.Email == null || aluno ?.Sexo == null)
            {
                ViewBag.Erro = "Dados invalidos";
                return View();
            }
            */
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                alunoBll.IncluirAluno(aluno);
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            //consulta no getalunos um unico usuario cujo o id foi passado por parametro
            Aluno aluno = alunoBll.GetAlunos().Single(x => x.Id == id);
            return View(aluno);
        }

        [HttpPost]
        /*exemplo de model binding
         o Bind vincula os atributos relacionados, então o Aluno aluno vai ter apenas os atributos passados
         */
        public ActionResult Edit([Bind(nameof(Aluno.Id), nameof(Aluno.Sexo), nameof(Aluno.Email), nameof(Aluno.Nascimento))]Aluno aluno)
        {
            //o Nome não veio como atributo (para o exemplo), como contornar?
            //usando a instancia alunoBll
            aluno.Nome = alunoBll.GetAlunos().Single(a => a.Id == aluno.Id).Nome;
            if (ModelState.IsValid)
            {
                alunoBll.AtualizarAluno(aluno);
                return RedirectToAction("Index");

            }
            return View(aluno);
        }

        public ActionResult Delete(int id)
        {
            /*
             * NÃO FAZER ASSIM
            alunoBll.DeletarAluno(id);
            return RedirectToAction("Index");
            */
            Aluno aluno = alunoBll.GetAlunos().Single(a => a.Id == id);
            return View(aluno);
        }

        [HttpPost]
        public ActionResult Delete(Aluno aluno)
        {
            alunoBll.DeletarAluno(aluno.Id);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Aluno aluno = alunoBll.GetAlunos().Single(a => a.Id == id);
            return View(aluno);
        }
        public IActionResult Procurar(string procurarPor, string criterio)
        {
            //vai procurar no banco exatamente oq foi digitado
            if (procurarPor == "Email")
            {
                Aluno aluno = alunoBll.GetAlunos().SingleOrDefault(a => a.Email == criterio);
                return View(aluno);
            }
            else
            {
                Aluno aluno = alunoBll.GetAlunos().SingleOrDefault(a => a.Nome == criterio);
                return View(aluno);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
