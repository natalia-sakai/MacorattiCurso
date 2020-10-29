using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Components
{
    public class ListaViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(String sequencia)
        {
            var resultado = await Task.FromResult(sequencia.Split(new char[] { ',' }));
            return View("Lista", resultado);
        }
    }
}
