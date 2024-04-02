
using Microsoft.EntityFrameworkCore;
using SistemaHorarios.Dominio.Entidades;

namespace SistemaHorarios.Aplicacion.Abstractions;

public interface IApplicationDbContext
{
    DbSet<Maestro> Maestros { get; }
    DbSet<Grupo> Grupos { get; }
    DbSet<Horario> Horarios { get; }
    DbSet<HorarioItem> HorarioItems { get;  }
    DbSet<MayaCurricular> MayasCurriculares { get; }
    DbSet<Materia> Materias { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
