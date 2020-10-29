using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Atividade1.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Saudacoes
    {
        private readonly RequestDelegate _next;

        public Saudacoes(RequestDelegate next)
        {
            _next = next;
        }

        //logica do midddleware
        public async Task Invoke(HttpContext context)
        {
            context.Response.StatusCode = 400;

            //verifica o caminho da requisição (end-point)
            if(!context.Request.Path.Equals("/saudacoes", StringComparison.Ordinal))
            {
                await context.Response.WriteAsync("Caminho de requisito invalido");
                return;
            }
            //verifica o método usado
            if (!context.Request.Method.Equals("GET"))
            {
                await context.Response.WriteAsync($"{context.Request.Method} Metodo não suportado");
                return;
            }
            //verifica no contexto não tiver a palavra nome
            if(!context.Request.Query.Any()||string.IsNullOrEmpty(context.Request.Query["nomes"]))
            {
                await context.Response.WriteAsync("A consulta esta vazia ou invalida");
                return;
            }
            context.Response.StatusCode = 200;

            //array de nomes
            //separa os nomes com virgulas
            var nomes = context.Request.Query["nomes"].ToString().Split(',').ToList();
            var sb = new StringBuilder();

            //percorre o array e envia Olá + nome e pula de linha
            nomes.ForEach(n => sb.Append($"Ola {n}{Environment.NewLine}"));
            await context.Response.WriteAsync(sb.ToString());
            return;
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Saudacoes>();
        }
    }
}
