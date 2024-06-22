using SistemaHorarios.Dominio.Abstractions;
using SistemaHorarios.Dominio.Grupos;
using SistemaHorarios.Dominio.Maestros;
using SistemaHorarios.Dominio.MayasCurriculares;
using System.Xml.Linq;

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


    public Horario(Grupo grupo)
    {
        switch(grupo.Grado)
        {
            case Enums.Grado.Primero:
                _items.AddRange(
                    new List<HorarioItem> 
                    {
                        new HorarioItem(1, MateriasEspecialesIds.Ingles1, MaestrosEspecialesIds.Ingles1, Enums.Dia.Lunes),
                        new HorarioItem(1, MateriasEspecialesIds.Ingles1, MaestrosEspecialesIds.Ingles1, Enums.Dia.Martes),
                        new HorarioItem(1, MateriasEspecialesIds.Ingles1, MaestrosEspecialesIds.Ingles1, Enums.Dia.Miercoles),
                        new HorarioItem(1, MateriasEspecialesIds.Ingles1, MaestrosEspecialesIds.Ingles1, Enums.Dia.Jueves),
                        new HorarioItem(1, MateriasEspecialesIds.Ingles1, MaestrosEspecialesIds.Ingles1, Enums.Dia.Viernes),

                        new HorarioItem(3, MateriasEspecialesIds.Expertos1, MaestrosEspecialesIds.Expertos1, Enums.Dia.Lunes),
                        new HorarioItem(3, MateriasEspecialesIds.Expertos1, MaestrosEspecialesIds.Expertos1, Enums.Dia.Martes),
                        new HorarioItem(3, MateriasEspecialesIds.Expertos1, MaestrosEspecialesIds.Expertos1, Enums.Dia.Miercoles),
                        new HorarioItem(3, MateriasEspecialesIds.Expertos1, MaestrosEspecialesIds.Expertos1, Enums.Dia.Jueves),
                        new HorarioItem(3, MateriasEspecialesIds.Expertos1, MaestrosEspecialesIds.Expertos1, Enums.Dia.Viernes),

                    }
                 );
                break;
            case Enums.Grado.Segundo:
                _items.AddRange(
                    new List<HorarioItem>
                    {
                        new HorarioItem(1, MateriasEspecialesIds.Ingles2, MaestrosEspecialesIds.Ingles2, Enums.Dia.Lunes),
                        new HorarioItem(1, MateriasEspecialesIds.Ingles2, MaestrosEspecialesIds.Ingles2, Enums.Dia.Martes),
                        new HorarioItem(1, MateriasEspecialesIds.Ingles2, MaestrosEspecialesIds.Ingles2, Enums.Dia.Miercoles),
                        new HorarioItem(1, MateriasEspecialesIds.Ingles2, MaestrosEspecialesIds.Ingles2, Enums.Dia.Jueves),
                        new HorarioItem(1, MateriasEspecialesIds.Ingles2, MaestrosEspecialesIds.Ingles2, Enums.Dia.Viernes),

                        new HorarioItem(3, MateriasEspecialesIds.Expertos2, MaestrosEspecialesIds.Expertos2, Enums.Dia.Lunes),
                        new HorarioItem(3, MateriasEspecialesIds.Expertos2, MaestrosEspecialesIds.Expertos2, Enums.Dia.Martes),
                        new HorarioItem(3, MateriasEspecialesIds.Expertos2, MaestrosEspecialesIds.Expertos2, Enums.Dia.Miercoles),
                        new HorarioItem(3, MateriasEspecialesIds.Expertos2, MaestrosEspecialesIds.Expertos2, Enums.Dia.Jueves),
                        new HorarioItem(3, MateriasEspecialesIds.Expertos2, MaestrosEspecialesIds.Expertos2, Enums.Dia.Viernes),
                    }
                 );
                break;
            case Enums.Grado.Tercero:
                _items.AddRange(
                new List<HorarioItem>
                {
                        new HorarioItem(1, MateriasEspecialesIds.Ingles3, MaestrosEspecialesIds.Ingles3, Enums.Dia.Lunes),
                        new HorarioItem(1, MateriasEspecialesIds.Ingles3, MaestrosEspecialesIds.Ingles3, Enums.Dia.Martes),
                        new HorarioItem(1, MateriasEspecialesIds.Ingles3, MaestrosEspecialesIds.Ingles3, Enums.Dia.Miercoles),
                        new HorarioItem(1, MateriasEspecialesIds.Ingles3, MaestrosEspecialesIds.Ingles3, Enums.Dia.Jueves),
                        new HorarioItem(1, MateriasEspecialesIds.Ingles3, MaestrosEspecialesIds.Ingles3, Enums.Dia.Viernes),

                        new HorarioItem(3, MateriasEspecialesIds.Expertos3, MaestrosEspecialesIds.Expertos3, Enums.Dia.Lunes),
                        new HorarioItem(3, MateriasEspecialesIds.Expertos3, MaestrosEspecialesIds.Expertos3, Enums.Dia.Martes),
                        new HorarioItem(3, MateriasEspecialesIds.Expertos3, MaestrosEspecialesIds.Expertos3, Enums.Dia.Miercoles),
                        new HorarioItem(3, MateriasEspecialesIds.Expertos3, MaestrosEspecialesIds.Expertos3, Enums.Dia.Jueves),
                        new HorarioItem(3, MateriasEspecialesIds.Expertos3, MaestrosEspecialesIds.Expertos3, Enums.Dia.Viernes),
                }
             );
                break;
        }
    }

    public void Update(List<HorarioItem> items)
    {
        _items.Clear();
        _items.AddRange(items);
    }

    public void DeleteHoras()
    {
        var itemsToBeDeleted = _items
            .Where(i => i.HoraId != 1 && i.HoraId != 3)
            .ToList();

        foreach (var item in itemsToBeDeleted)
        {
            _items.Remove(item);
        }
    }
}
