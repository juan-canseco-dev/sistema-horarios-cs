
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaHorarios.Dominio.Shared;

namespace SistemaHorarios.Infrastructura.Configurations;

public class HoraConfiguration : IEntityTypeConfiguration<Hora>
{
    public void Configure(EntityTypeBuilder<Hora> builder)
    {
        builder.Property(h => h.Id);
        builder.HasKey(h => h.Id);
        builder.Property(h => h.Inicio).IsRequired();
        builder.Property(h => h.Fin).IsRequired();
        builder.Property(h => h.EsReceso).IsRequired();

        builder.HasData(Hora.All);
    }
}
