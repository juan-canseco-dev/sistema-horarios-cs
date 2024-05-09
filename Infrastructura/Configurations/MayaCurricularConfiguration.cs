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

        builder.HasMany(m => m.Materias)
            .WithOne()
            .HasForeignKey(m => m.MayaCurricularId)
            .IsRequired();

        builder.HasData(MayaCurricular.All);
    }
}
