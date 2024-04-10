
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaHorarios.Dominio.Horarios;

namespace SistemaHorarios.Infrastructura.Configurations;

public class HorarioItemConfiguration : IEntityTypeConfiguration<HorarioItem>
{
    public void Configure(EntityTypeBuilder<HorarioItem> builder)
    {
        builder.ToTable("HorarioItems");

        builder.HasKey(h => h.Id);

        builder.Property(h => h.HorarioId).IsRequired(); 
        builder.Property(h => h.HoraId).IsRequired(); 
        builder.Property(h => h.MateriaId).IsRequired();
        builder.Property(h => h.MaestroId).IsRequired();

        builder.Property(h => h.Dia)
               .HasConversion<int>();

        builder.HasOne(h => h.Hora)
               .WithMany()
               .HasForeignKey(h => h.HoraId)
               .IsRequired(); 

        builder.HasOne(h => h.Materia)
               .WithMany()
               .HasForeignKey(h => h.MateriaId) 
               .IsRequired();

        builder.HasOne(h => h.Maestro)
               .WithMany()
               .HasForeignKey(h => h.MaestroId) 
               .IsRequired();
    }
}
