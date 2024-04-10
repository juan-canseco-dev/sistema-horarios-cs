using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Presentacion.Grupos;
using SistemaHorarios.Aplicacion;
using SistemaHorarios.Infrastructura;

namespace Presentacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            var context = host.Services.GetRequiredService<ApplicationDbContext>();
            context.Database.EnsureCreated();
            Application.Run(host.Services.GetRequiredService<Main>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                services.AddInfrastructure();
                services.AddApplication();
                services.AddTransient<Main>();
                services.AddTransient<GruposForm>();
                services.AddTransient<NuevoGrupoForm>();
            });
        }
    }
}