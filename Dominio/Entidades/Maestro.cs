using SistemaHorarios.Dominio.Abstractions;

namespace SistemaHorarios.Dominio.Entidades;

public sealed class Maestro : BaseEntity
{
    public string Nombres { get; init; } = default!;
    public string Apellidos { get; init; } = default!;

    public Maestro(string nombres, string apellidos)
    {
        Nombres = nombres;
        Apellidos = apellidos;
    }

    private Maestro()
    {
        Nombres = default!;
        Apellidos = default!;
    }
}
