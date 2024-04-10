
using Microsoft.Extensions.DependencyInjection;
using SistemaHorarios.Aplicacion.Grupos;
using SistemaHorarios.Aplicacion.Horarios;
using SistemaHorarios.Aplicacion.Maestros;
using SistemaHorarios.Aplicacion.MayasCurriculares;

namespace SistemaHorarios.Aplicacion;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddTransient<IGrupoService, GrupoService>();
        services.AddTransient<IHorarioService, HorarioService>();
        services.AddTransient<IMaestroService, MaestroService>();
        services.AddTransient<IMayaCurricularService, MayaCurricularService>();

        return services;
    }
}
