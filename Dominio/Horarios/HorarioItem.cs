using SistemaHorarios.Dominio.Abstractions;
using SistemaHorarios.Dominio.Enums;
using SistemaHorarios.Dominio.Maestros;
using SistemaHorarios.Dominio.MayasCurriculares;
using SistemaHorarios.Dominio.Shared;

namespace SistemaHorarios.Dominio.Horarios;
public class HorarioItem : BaseEntity
{
    public int HorarioId { get; init; }
    public int HoraId { get; init; }
    public int MateriaId { get; init; }
    public int MaestroId { get; init; }
    public Dia Dia { get; private set; }
    public virtual Hora? Hora { get; private set; }
    public virtual Materia? Materia { get; private set; }
    public virtual Maestro? Maestro { get; private set; }

    private HorarioItem() { }

    public HorarioItem(int horaId, int materiaId, int maestroId, Dia dia)
    {
        HoraId = horaId;
        MateriaId = materiaId;
        MaestroId = maestroId;
        Dia = dia;
    }
}
