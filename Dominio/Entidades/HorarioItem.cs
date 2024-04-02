using SistemaHorarios.Dominio.Abstractions;
using SistemaHorarios.Dominio.Enums;

namespace SistemaHorarios.Dominio.Entidades;
public class HorarioItem : BaseEntity
{
    public int HorarioId { get; init; }
    public int HoraId { get; init; }
    public int MateriaId { get; init; }
    public int DocenteId { get; init; }
    public Dia Dia { get; private set; }

    private HorarioItem() { }

    public HorarioItem(int horaId, int materiaId, int docenteId, Dia dia)
    {
        HoraId = horaId;
        MateriaId = materiaId;
        DocenteId = docenteId;
        Dia = dia;
    }
}
