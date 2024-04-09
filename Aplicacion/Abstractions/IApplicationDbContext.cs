
using Microsoft.EntityFrameworkCore;
using SistemaHorarios.Dominio.Grupos;
using SistemaHorarios.Dominio.Horarios;
using SistemaHorarios.Dominio.Maestros;
using SistemaHorarios.Dominio.MayasCurriculares;
using SistemaHorarios.Dominio.Shared;

namespace SistemaHorarios.Aplicacion.Abstractions;

public interface IApplicationDbContext
{
    DbSet<Maestro> Maestros { get; }
    DbSet<Grupo> Grupos { get; }
    DbSet<Horario> Horarios { get; }
    DbSet<HorarioItem> HorarioItems { get;  }
    DbSet<MayaCurricular> MayasCurriculares { get; }
    DbSet<Materia> Materias { get; }
    DbSet<Hora> Horas { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
