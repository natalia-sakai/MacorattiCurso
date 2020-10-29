using mvcVS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcVS.ViewModels
{
    public class ClientePedidoViewModel
    {
        public Cliente Cliente { get; set; }
        public List<Pedido> Pedidos { get; set; }
    }
}
