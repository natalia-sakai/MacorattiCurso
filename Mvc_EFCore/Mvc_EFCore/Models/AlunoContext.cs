using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_EFCore.Models
{
    public class AlunoContext: DbContext
    {
        //DbContext é uma classe do EntityFramework
        public AlunoContext(DbContextOptions<AlunoContext> options)
           : base(options)
        { }


        //nome que vai ser mapeado
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<TipoSocio> TipoSocios { get; set; }
    }
}
