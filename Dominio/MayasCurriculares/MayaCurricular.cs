using SistemaHorarios.Dominio.Abstractions;
using SistemaHorarios.Dominio.Enums;

namespace SistemaHorarios.Dominio.MayasCurriculares;

public class MayaCurricular : BaseEntity
{
    private readonly List<Materia> _materias = new();

    public Grado Grado { get; init; }
    public IReadOnlyCollection<Materia> Materias => _materias.AsReadOnly();
    private MayaCurricular() { }
    public MayaCurricular(int id, Grado grado, List<Materia> materias)
    {
        Id = id;
        Grado = grado;
        _materias.AddRange(materias);
    }

    public void Update(List<Materia> materias)
    {
        _materias.Clear();
        _materias.AddRange(materias);
    }

    public static IReadOnlyCollection<MayaCurricular> All => new List<MayaCurricular> 
    {
        new MayaCurricular(1, Grado.Primero, new List<Materia>()),
        new MayaCurricular(2, Grado.Segundo, new List<Materia>()),
        new MayaCurricular(3, Grado.Tercero, new List<Materia>())
    }.AsReadOnly();
}
