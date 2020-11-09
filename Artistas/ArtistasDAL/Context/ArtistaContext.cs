﻿using ArtistasDAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArtistasDAL.Context
{
    public class ArtistaContext: DbContext
    {
        //construtor
        public ArtistaContext(DbContextOptions<ArtistaContext> options) : base(options)
        { }

        //permite o acesso aos dados
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<ArtistaDetalhe> ArtistaDetalhes { get; set; }

        //fluent API
        //usando a fluent API é feito o mapeamento mantendo as entidades sem referencias externas
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Artistas
            builder.Entity<Artista>().ToTable("Artistas");
            builder.Entity<Artista>().HasKey("ArtistaId");
            builder.Entity<Artista>().Property(x => x.Cidade).HasMaxLength(80);
            builder.Entity<Artista>().Property(x => x.Pais).HasMaxLength(80);
            builder.Entity<Artista>().Property(x => x.Nome).HasMaxLength(80).IsRequired(true);
            builder.Entity<Artista>().Property(x => x.Site).HasMaxLength(80);

            //ArtistaDetalhes
            builder.Entity<ArtistaDetalhe>().ToTable("ArtistaDetalhes");
            builder.Entity<ArtistaDetalhe>().HasKey("ArtistaDetalheId");
            builder.Entity<ArtistaDetalhe>().Property(x => x.Detalhes).HasMaxLength(255);
            builder.Entity<ArtistaDetalhe>().Property(x => x.Talento).IsRequired(true).
            HasMaxLength(80);
        }
    }
}
