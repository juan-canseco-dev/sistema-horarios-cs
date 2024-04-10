
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaHorarios.Dominio.Maestros;

namespace SistemaHorarios.Infrastructura.Configurations;

public class MaestroConfiguration : IEntityTypeConfiguration<Maestro>
{
    public void Configure(EntityTypeBuilder<Maestro> builder)
    {
        builder.ToTable("maestros");

        builder.Property(m => m.Id);
        builder.HasKey(m => m.Id);

        builder.Property(m => m.Nombres)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(m => m.Apellidos)
            .IsRequired()
            .HasMaxLength(50);
    }
}
