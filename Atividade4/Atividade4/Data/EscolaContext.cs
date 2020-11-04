using Atividade4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade4.Data
{
    public class EscolaContext:DbContext
    {
        public EscolaContext(DbContextOptions<EscolaContext> options)
            :base(options)
        {
        }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Estudante> Estudantes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //curso
            builder.Entity<Curso>().ToTable("Cursos");
            builder.Entity<Curso>().HasKey(c => c.CursoId);
            builder.Entity<Curso>().Property(c => c.Titulo).HasMaxLength(100).IsRequired();

            //estudante
            builder.Entity<Estudante>().ToTable("Estudante");
            builder.Entity<Estudante>().HasKey(e => e.Id);
            builder.Entity<Estudante>().Property(e => e.Nome).HasMaxLength(100).IsRequired();
        }
    }
}
