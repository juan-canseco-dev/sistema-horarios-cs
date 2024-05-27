using SistemaHorarios.Aplicacion.Grupos;
using SistemaHorarios.Dominio.Enums;

namespace Presentacion.Horarios;

public class AsignarHoraViewModel
{
    public Dia Dia { get; set; }
    public HoraControlViewModel? HoraModel { get; set; }
}
