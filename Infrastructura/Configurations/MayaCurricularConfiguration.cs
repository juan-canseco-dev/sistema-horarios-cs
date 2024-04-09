using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaHorarios.Dominio.MayasCurriculares;

namespace SistemaHorarios.Infrastructura.Configurations;

public class MayaCurricularConfiguration : IEntityTypeConfiguration<MayaCurricular>
{
    public void Configure(EntityTypeBuilder<MayaCurricular> builder)
    {
        builder.ToTable("mayas_curriculares");

        builder.Property(m => m.Id);
        builder.HasKey(m => m.Id);

        builder.Property(m => m.Grado)
            .HasConversion<int>();

        builder.OwnsMany(m => m.Materias, i =>
        {
            i.WithOwner().HasForeignKey(i => i.MayaCurricularId);
            i.ToTable("mayas_curriculares_materias");

            i.Property(m => m.Nombre).IsRequired().HasMaxLength(50);
            i.HasIndex(m => m.Nombre).IsUnique();
            i.Property(m => m.Codigo).IsRequired().HasMaxLength(50);
            i.HasIndex(m => m.Codigo).IsUnique();
            i.Property(m => m.HorasSemanales).IsRequired();

        });

    }
}
