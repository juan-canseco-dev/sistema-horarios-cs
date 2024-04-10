using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaHorarios.Dominio.MayasCurriculares;

namespace SistemaHorarios.Infrastructura.Configurations;

public class MateriaConfiguration : IEntityTypeConfiguration<Materia>
{
    public void Configure(EntityTypeBuilder<Materia> builder)
    {
        builder.ToTable("materias");
        builder.Property(m => m.Id);
        builder.HasKey(m => m.Id);
        builder.Property(m => m.Nombre).IsRequired().HasMaxLength(50);
        builder.HasIndex(m => m.Nombre).IsUnique();
        builder.Property(m => m.Codigo).IsRequired().HasMaxLength(50);
        builder.HasIndex(m => m.Codigo).IsUnique();
        builder.Property(m => m.HorasSemanales).IsRequired();
    }
}
