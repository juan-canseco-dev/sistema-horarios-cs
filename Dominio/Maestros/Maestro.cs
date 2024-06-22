using SistemaHorarios.Dominio.Abstractions;

namespace SistemaHorarios.Dominio.Maestros;

public sealed class Maestro : BaseEntity
{
    public string Nombres { get; private set; } = default!;
    public string Apellidos { get; private set; } = default!;

    public void Update(string nombres, string apellidos)
    {
        Nombres = nombres;
        Apellidos = apellidos;
    }


    public Maestro(int id, string nombres, string apellidos)
    {
        Id = id;
        Nombres = nombres;
        Apellidos = apellidos;
    }

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
