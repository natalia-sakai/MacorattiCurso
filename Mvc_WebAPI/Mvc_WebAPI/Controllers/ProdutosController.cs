using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvc_WebAPI.Models;

namespace Mvc_WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ProdutosController : Controller
    {
        static readonly IProdutoRepositorio repositorio = new ProdutoRepositorio();

        [HttpGet]
        public IEnumerable<Produto> GetTodos()
        {
            return repositorio.GetAll();
        }

        [HttpGet("{id}", Name = "GetProduto")]
        public IActionResult GetProdutoPorId(int id)
        {
            Produto produto = repositorio.Get(id);
            if(produto == null)
            {
                return NotFound();
            }
            return new ObjectResult(produto);
        }

        [HttpPost]
        public IActionResult CriarProduto([FromBody] Produto item)
        {
            if(item == null)
            {
                return BadRequest();
            }

            item = repositorio.Add(item);
            return CreatedAtRoute("GetProduto", new { id = item.Id }, item);
        }

        [HttpPut]
        public IActionResult AtualizaProduto(int id, [FromBody] Produto item)
        {
            if(item == null)
            {
                return BadRequest();
            }
            //atribui o id do produto ao que quer atualizar
            item.Id = id;
            //atualiza o item, se não ele da notfound
            if (!repositorio.Update(item))
            {
                return NotFound();
            }
            return new NoContentResult();
        }
    }
}
