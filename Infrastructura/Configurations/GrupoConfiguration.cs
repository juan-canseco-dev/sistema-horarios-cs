using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaHorarios.Dominio.Grupos;

namespace SistemaHorarios.Infrastructura.Configurations;

public class GrupoConfiguration : IEntityTypeConfiguration<Grupo>
{
    public void Configure(EntityTypeBuilder<Grupo> builder)
    {
        builder.ToTable("grupos");

        builder.Property(g => g.Id);
        builder.HasKey(g => g.Id);

        builder.Property(g => g.Nombre)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(g => g.Grado)
            .HasConversion<int>();
    }
}
