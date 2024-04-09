using SistemaHorarios.Dominio.Abstractions;

namespace SistemaHorarios.Dominio.MayasCurriculares;

public class Materia : BaseEntity
{
    public int MayaCurricularId { get; init; }
    public string Nombre { get; init; }
    public string Codigo { get; init; }
    public int HorasSemanales { get; init; }

    private Materia()
    {
        Nombre = default!;
        Codigo = default!;
    }

    public Materia(string nombre, string codigo, int horasSemanales)
    {
        Nombre = nombre;
        Codigo = codigo;
        HorasSemanales = horasSemanales;
    }
}
