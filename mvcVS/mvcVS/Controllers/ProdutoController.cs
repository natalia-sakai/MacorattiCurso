using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mvcVS.Controllers
{
    public class ProdutoController : Controller
    {
        public string Index()
        {
            return "Esse é um metodo action padrao";
        }

        public string https()
        {
            var https = HttpContext.Request.IsHttps;
            var caminho = HttpContext.Request.Path;
            var status = HttpContext.Response.StatusCode;
            var conexao = HttpContext.Connection.ToString();

            return https + "\r\n" + caminho + "\r\n" + status +"\r\n"+ conexao;
        }

        public IActionResult Detalhe()
        {
            //mostra a view
            return View();

            //redireciona para outra action dentro do controller
            //return RedirectToAction("Index");

            //redireciona para outra action em outro controller
            //é possivel passar parametros também
            //return RedirectToAction("Index","Home", new {pagina=1, ordem="nome"});

            //retornar um content
            //return Content("uma string simples");

            //retorna um arquivo
            //return File("img/download.png", "image/png");

            //retorna um objeto
            //var pessoa = new {ID = 1, Nome = "Natalia"};
            //return new ObjectResult(pessoa);
        }

        public IActionResult Edit(int id){
            //nome do parametro tem q ser igual ao do mapeamento no startup
            return Content("valor do id = "+ id);
        }

        //passagem de parametros opcionais, se nao colocar um valor ele apresenta um default
        public IActionResult paginacao(int? pagina, string ordem){
            //se colocar apenas produto/paginacao apresenta default
            //localhost:5001/produto/paginacao?pagina=7&ordem=JK
            if(!pagina.HasValue)
                pagina = 1;
            if(String.IsNullOrEmpty(ordem))
                ordem = "Natalia";

            return Content(String.Format("pagina={0}&ordem={1}", pagina, ordem));
        }

        //[Route ("produto/lancamento/{ano:int}/{mes:range(1,12)}")]
        public ActionResult DataLancamento(int ano, int mes){
            return Content(ano+"/"+mes);
        }
    }
}