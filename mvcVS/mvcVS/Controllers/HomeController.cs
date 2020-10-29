using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvcVS.Models;

namespace mvcVS.Controllers
{
    //[Route("home")]

    //usando esse não é necessário colocar cada rota
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        //[Route("lista")]
        public string Lista(){
            //tem um route fora da classe para ficar home/lista
            return "Action Lista";
        }
        //outra abordagem de roteamento
        //[Route("")]
        //[Route("Home")]
        //[Route("Home/Index")]
        //[HttpGet("Home/Index")]

        public IActionResult Index()
        {
            return View();
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
