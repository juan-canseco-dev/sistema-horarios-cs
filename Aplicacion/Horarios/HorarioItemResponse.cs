using SistemaHorarios.Aplicacion.Maestros;
using SistemaHorarios.Aplicacion.MayasCurriculares;
using SistemaHorarios.Dominio.Enums;

namespace SistemaHorarios.Aplicacion.Horarios;

public class HorarioItemResponse
{
    public Dia Dia { get; set; }
    public HoraResponse? Hora { get; set; }
    public MateriaResponse? Materia { get; set; }
    public MaestroResponse? Maestro { get; set; }
}
