using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvc_EFCore.Models;

namespace Mvc_EFCore.Controllers
{
    public class AlunoTipoSocioController : Controller
    {
        private AlunoContext context;
        public AlunoTipoSocioController(AlunoContext _alunoContext)
        {
            context = _alunoContext;
        }
        public IActionResult Index()
        {
            var infoAluno = context.Alunos.Include(tp => tp.TipoSocio);

            return View(infoAluno);
        }
    }
}
