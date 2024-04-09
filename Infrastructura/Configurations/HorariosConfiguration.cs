
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaHorarios.Dominio.Grupos;
using SistemaHorarios.Dominio.Horarios;
using SistemaHorarios.Dominio.Maestros;
using SistemaHorarios.Dominio.MayasCurriculares;
using SistemaHorarios.Dominio.Shared;

namespace SistemaHorarios.Infrastructura.Configurations;

public class HorariosConfiguration : IEntityTypeConfiguration<Horario>
{
    public void Configure(EntityTypeBuilder<Horario> builder)
    {
        builder.ToTable("horarios");
        builder.Property(h => h.Id);
        builder.HasKey(h => h.Id);

        builder.Property(h => h.MayaCurricularId);
        builder.HasOne<MayaCurricular>()
            .WithMany()
            .HasForeignKey(h => h.MayaCurricularId);

        builder.Property(h => h.GrupoId);
        builder.HasOne<Grupo>()
            .WithMany()
            .HasForeignKey(h => h.GrupoId);

        builder.OwnsMany(h => h.Items, i =>
        {
            i.WithOwner().HasForeignKey(i => i.HorarioId);
            i.ToTable("horarios_items");

            i.Property(i => i.Dia).HasConversion<int>();

            i.Property(i => i.HoraId);
            i.HasOne<Hora>()
            .WithMany()
            .HasForeignKey(i => i.HoraId);

            i.Property(i => i.Materia);
            i.HasOne<Materia>()
            .WithMany()
            .HasForeignKey(i => i.MateriaId);

            i.Property(i => i.Maestro);
            i.HasOne<Maestro>()
            .WithMany()
            .HasForeignKey(i => i.MaestroId);

            i.HasKey(i => new { i.Dia, i.HoraId, i.MaestroId });
        });

    }
}
