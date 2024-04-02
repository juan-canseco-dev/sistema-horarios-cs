using SistemaHorarios.Dominio.Abstractions;

namespace SistemaHorarios.Dominio.Entidades;

public class Horario : BaseEntity
{
    private readonly List<HorarioItem> _items = new();
    public int MayaCurricularId { get; init; }
    public int GrupoId { get; init; }
    public IReadOnlyCollection<HorarioItem> Items => _items.AsReadOnly();
    public virtual MayaCurricular? MayaCurricular { get; }
    public virtual Grupo? Grupo { get;}

    private Horario() { }

    public Horario(int mayaCurricularId, int grupoId, List<HorarioItem> items)
    {
        MayaCurricularId = mayaCurricularId;
        GrupoId = grupoId;
        _items.AddRange(items);
    }

    public void Update(List<HorarioItem> items)
    {
        _items.Clear();
        _items.AddRange(items);
    }
}
