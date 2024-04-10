
using Microsoft.EntityFrameworkCore;
using SistemaHorarios.Aplicacion.Abstractions;
using SistemaHorarios.Dominio.Grupos;
using SistemaHorarios.Dominio.Horarios;
using SistemaHorarios.Dominio.Maestros;
using SistemaHorarios.Dominio.MayasCurriculares;
using SistemaHorarios.Dominio.Shared;

namespace SistemaHorarios.Infrastructura;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Maestro> Maestros => Set<Maestro>();
    public DbSet<Grupo> Grupos => Set<Grupo>();
    public DbSet<Horario> Horarios => Set<Horario>();
    public DbSet<HorarioItem> HorarioItems => Set<HorarioItem>();
    public DbSet<MayaCurricular> MayasCurriculares => Set<MayaCurricular>();
    public DbSet<Materia> Materias => Set<Materia>();
    public DbSet<Hora> Horas => Set<Hora>();


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }
}
