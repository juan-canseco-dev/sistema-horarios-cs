using SistemaHorarios.Aplicacion.Grupos;
using SistemaHorarios.Aplicacion.Horarios;
using SistemaHorarios.Dominio.Enums;

namespace Presentacion.Horarios
{
    public class HoraControlViewModel
    {
        public GrupoResponse? Grupo { get; set; }
        public HoraResponse? Hora { get; set; }
        public Dictionary<Dia, HorarioItemViewModel?>? Items { get; set; }
    }
}
