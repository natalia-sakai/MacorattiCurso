using Microsoft.AspNetCore.Mvc;
using mvcVS.Models;
using mvcVS.ViewModels;
using System.Collections.Generic;

namespace mvcVS.Controllers
{
    [Route("[controller]/[action]")]
    public class ClientesController : Controller
    {
        public IActionResult Detalhe(){
            Cliente cliente = new Cliente{
                ClienteId = 1,
                Nome = "Natalia",
                Email = "nat@sakai.com"
            };

            var pedidos = new List<Pedido>
            {
                new Pedido {Nome = "Pedido 1"},
                new Pedido {Nome = "Pedido 2"}
            };

            var viewModel = new ClientePedidoViewModel
            {
                Cliente = cliente,
                Pedidos = pedidos
            };


            //return View(cliente);
            return View(viewModel);
        }
    
    }
}