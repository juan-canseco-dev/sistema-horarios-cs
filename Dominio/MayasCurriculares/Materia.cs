using SistemaHorarios.Dominio.Abstractions;

namespace SistemaHorarios.Dominio.MayasCurriculares;

public class Materia : BaseEntity, IEquatable<Materia?>
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

    public override bool Equals(object? obj)
    {
        return Equals(obj as Materia);
    }

    public bool Equals(Materia? other)
    {
        return other is not null &&
               Nombre == other.Nombre &&
               Codigo == other.Codigo &&
               HorasSemanales == other.HorasSemanales;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Nombre, Codigo, HorasSemanales);
    }

    public static bool operator ==(Materia? left, Materia? right)
    {
        return EqualityComparer<Materia>.Default.Equals(left, right);
    }

    public static bool operator !=(Materia? left, Materia? right)
    {
        return !(left == right);
    }
}
