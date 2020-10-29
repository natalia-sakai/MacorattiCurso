using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AreasDemo.Areas.Produtos.Models
{
    public class ProdutoService
    {
        public static List<Produto> GetListaProdutos()
        {
            return new List<Produto>()
            {
                new Produto {Nome = "Lapis"},
                new Produto {Nome = "Borracha"},
                new Produto {Nome = "Caneta"},
                new Produto {Nome = "Estojo"},
                new Produto {Nome = "caderno"}
            };
        }
    }
}
