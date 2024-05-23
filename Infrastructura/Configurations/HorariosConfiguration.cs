
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaHorarios.Dominio.Horarios;

namespace SistemaHorarios.Infrastructura.Configurations;

public class HorariosConfiguration : IEntityTypeConfiguration<Horario>
{
    public void Configure(EntityTypeBuilder<Horario> builder)
    {
        builder.ToTable("horarios");
        builder.Property(h => h.Id);
        builder.HasKey(h => h.Id);

        builder.Property(h => h.GrupoId);

        builder.HasOne(h => h.Grupo)
            .WithOne(g => g.Horario)
            .HasForeignKey<Horario>(h => h.GrupoId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(m => m.Items)
            .WithOne()
            .HasForeignKey(m => m.HorarioId)
            .IsRequired();
    }
}
