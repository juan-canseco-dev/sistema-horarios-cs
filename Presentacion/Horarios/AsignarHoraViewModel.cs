using SistemaHorarios.Aplicacion.Grupos;
using SistemaHorarios.Aplicacion.Horarios;
using SistemaHorarios.Dominio.Enums;

namespace Presentacion.Horarios;

public class AsignarHoraViewModel
{
    public Dia Dia { get; set; }
    public int HoraId { get; set; }
    public GrupoResponse? Grupo { get; set; }
    public List<HorarioItemResponse>? HorasAsignadas { get; set; }
    public List<HoraControlViewModel>? Models { get; set; }
}
