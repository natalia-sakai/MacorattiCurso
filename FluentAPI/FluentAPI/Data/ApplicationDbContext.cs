using System;
using System.Collections.Generic;
using System.Text;
using FluentAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FluentAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; } 
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //exclui a tabela do modelo do EF e logo a entidade não sera mapeada
            builder.Ignore<LogAudit>();

            //mapeamento para a entidade usuario
            builder.Entity<Usuario>().ToTable("Usuarios");

            //valor da propriedade Id não deve ser gerado pelo banco de dados
            builder.Entity<Usuario>().Property(p => p.Id).ValueGeneratedNever();

            //tamanho maximo para nome e email
            builder.Entity<Usuario>().Property(u => u.Nome).HasMaxLength(80).IsRequired();
            builder.Entity<Usuario>().Property(u => u.Email).HasMaxLength(150).IsRequired();

            //mapeamento para a entidade cliente
            builder.Entity<Cliente>().ToTable("Clientes");

            //chave primaria
            builder.Entity<Cliente>().HasKey(c => c.ClienteId);

            //tamanho maximo
            builder.Entity<Cliente>().Property(c => c.Nome).HasMaxLength(20);
            builder.Entity<Cliente>().Property(c => c.Endereco).HasMaxLength(50);
            builder.Entity<Cliente>().Property(c => c.Telefone).HasMaxLength(20);
            builder.Entity<Cliente>().Property(c => c.Cidade).HasMaxLength(50);

            //mapeamento para a entidade pedido
            builder.Entity<Pedido>().ToTable("Pedidos");

            builder.Entity<Pedido>().HasKey(p => p.PedidoId);

            //desabilida remoção em cascata
            builder.Entity<Pedido>()
                .HasOne(c => c.Cliente)
                .WithMany(p => p.Pedidos)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
