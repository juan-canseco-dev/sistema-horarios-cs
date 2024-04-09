using SistemaHorarios.Aplicacion.Grupos;

namespace SistemaHorarios.Aplicacion.Horarios;

public class HorarioResponse
{
    public int Id { get; set; }
    public int MayaCurricularId { get; set; }
    public GrupoResponse? Grupo { get; set; }
    public List<HorarioItemResponse>? Items { get; set; }
}
