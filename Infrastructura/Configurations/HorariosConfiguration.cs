
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaHorarios.Dominio.Grupos;
using SistemaHorarios.Dominio.Horarios;
using SistemaHorarios.Dominio.MayasCurriculares;

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

        builder.HasMany(m => m.Items)
            .WithOne()
            .HasForeignKey(m => m.HorarioId)
            .IsRequired();
    }
}
