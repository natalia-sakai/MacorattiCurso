using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.IO;
using AppEmpty.Services;
using Microsoft.Extensions.FileProviders;

namespace AppEmpty
{
    public class Startup
    {
        public IConfiguration _config { get; set; }
        public PhysicalFileProvider FileProvider { get; set; }

        public Startup()
        {
            //chamada de um arquivo de configuração
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                //nome do arquivo json onde está a mensagem
                .AddJsonFile("appsettings.json");
            _config = builder.Build();

        }

        private void Build()
        {
            throw new NotImplementedException();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //registra os serviços
            //instancia unica
            //services.AddSingleton<IMensagemService, TextoMensagemService>();

            //adiciona uma implementação padrão de IDistributedCache
            services.AddDistributedMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //caso não esteja no modo development
                app.UseExceptionHandler();
                //app.UseStatusCodePagesWithRedirects("PaginaDeErro");
                //app.UseStatusCodePagesWithReExecute("PaginaDeErro");
            }
               
            app.UseRouting();

            //app.UseStaticFiles();
            //usar localhostXXXX/teste.html para acessar os arquivos html

            //para arquivos fora do wwwroot
            /*
            app.UseStaticFiles(new StaticFileOptions{
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "@Arquivos")),
                RequestPath = new PathString("/Arquivos")
            });*/

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    //await context.Response.WriteAsync(msg.GetMensagem());
                    /*var mensagem = _config["Mensagem"];
                    var logging = _config["Logging:Default"];
                    await context.Response.WriteAsync(logging);
                    await context.Response.WriteAsync(mensagem);*/
                    await context.Response.WriteAsync("Hello World! By: Startup");
                });
            });
        }
    }
}
