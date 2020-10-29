using System;
using Microsoft.AspNetCore.Mvc;

namespace mvcVS.Controllers
{
    [Route("[controller]/[action]")]
    public class TesteController:Controller
    {
        public IActionResult Index(){
            
            ViewData["Saudacao"] = "Hello World";
            ViewData["DataInicio"] = new DateTime(2020, 10, 27);
            
            ViewData["Endereco"] = new Endereco(){
                Nome = "Natalia",
                Rua = "Rua um, 11",
                Cidade = "Bauru",
                Estado = "SP"
            };

            return View();
        }
    }
}