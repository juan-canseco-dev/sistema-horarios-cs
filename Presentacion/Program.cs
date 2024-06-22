using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Presentacion.Grupos;
using Presentacion.Horarios;
using Presentacion.Maestros;
using Presentacion.Mayas;
using SistemaHorarios.Aplicacion;
using SistemaHorarios.Dominio.Maestros;
using SistemaHorarios.Dominio.MayasCurriculares;
using SistemaHorarios.Infrastructura;

namespace Presentacion
{
    internal static class Program
    {
        private static IServiceProvider? _provider = null;

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();

            if (_provider == null)
            {
                _provider = host.Services;
            }

            var context = ServiceProvider.GetRequiredService<ApplicationDbContext>();

            context.Database.EnsureCreated();

            if (!context.Maestros.Any())
            {
                context.Maestros.AddRange(MaestrosEspeciales.All);
                context.SaveChanges();

                context.Materias.AddRange(MateriasEspeciales.All);
                context.SaveChanges();
            }

            Application.Run(host.Services.GetRequiredService<Main>());
        }

        public static IServiceProvider ServiceProvider => _provider!;

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                services.AddInfrastructure();
                services.AddApplication();
                services.AddTransient<Main>();
                services.AddTransient<GruposForm>();
                services.AddTransient<NuevoGrupoForm>();
                services.AddTransient<MaestrosForm>();
                services.AddTransient<NuevoMaestroForm>();
                services.AddTransient<MayasForm>();
                services.AddTransient<AsignarMateriasForm>();
                services.AddTransient<AgregarMateriaForm>();
                services.AddTransient<MayaDetalleForm>();
                services.AddTransient<AsignarHorarioForm>();
                services.AddTransient<AsignarHoraForm>();
            });
        }
    }
}