using SistemaHorarios.Aplicacion.Maestros;
using SistemaHorarios.Aplicacion.MayasCurriculares;

namespace Presentacion.Horarios
{
    public class HorarioItemViewModel
    {
        public MaestroResponse? Maestro { get; set; }
        public MateriaResponse? Materia { get; set; }
    }
}
