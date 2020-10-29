using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AreasDemo.Areas.Produtos.Models;
using Microsoft.AspNetCore.Mvc;

namespace AreasDemo.Areas.Produtos.Controllers
{
    [Area("Produtos")]
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            var produtos = ProdutoService.GetListaProdutos();
            return View(produtos);
        }
    }
}
