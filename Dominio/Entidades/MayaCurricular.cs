using SistemaHorarios.Dominio.Abstractions;
using SistemaHorarios.Dominio.Enums;

namespace SistemaHorarios.Dominio.Entidades;

public class MayaCurricular : BaseEntity
{
    private readonly List<Materia> _materias = new();

    public Grado Grado { get; init; }
    public IReadOnlyCollection<Materia> Materias => _materias.AsReadOnly();
    private MayaCurricular() { }
    public MayaCurricular(Grado grado, List<Materia> materias)
    {
        Grado = grado;
        _materias.AddRange(materias);
    }

    public void Update(List<Materia> materias)
    {
        _materias.Clear();
        _materias.AddRange(materias);
    }
}
