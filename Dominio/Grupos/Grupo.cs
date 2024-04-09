using SistemaHorarios.Dominio.Abstractions;
using SistemaHorarios.Dominio.Enums;

namespace SistemaHorarios.Dominio.Grupos;

public class Grupo : BaseEntity
{
    public string Nombre { get; private set; }
    public Grado Grado { get; private set; }

    public void Update(string nombre)
    {
        Nombre = nombre;
    }

    private Grupo()
    {
        Nombre = default!;
    }

    public Grupo(string nombre, Grado grado)
    {
        Nombre = nombre;
        Grado = grado;
    }

}
