using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewInjection.Models;

namespace ViewInjection.Services
{
    public class EstadosService
    {
        public List<Estado> GetEstados()
        {
            return new List<Estado>()
            {
                new Estado("São Paulo", "SP"),
                new Estado("Rio de Janeiro", "RJ"),
                new Estado("Parana", "PR"),
            };
        }
    }
}
