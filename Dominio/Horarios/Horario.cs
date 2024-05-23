using SistemaHorarios.Dominio.Abstractions;
using SistemaHorarios.Dominio.Grupos;

namespace SistemaHorarios.Dominio.Horarios;

public class Horario : BaseEntity
{
    private readonly List<HorarioItem> _items = new();
    public int GrupoId { get; init; }
    public IReadOnlyCollection<HorarioItem> Items => _items.AsReadOnly();
    public virtual Grupo? Grupo { get; }

    public Horario()
    {
        Grupo = default!;
    }

    public void Update(List<HorarioItem> items)
    {
        _items.Clear();
        _items.AddRange(items);
    }
}
