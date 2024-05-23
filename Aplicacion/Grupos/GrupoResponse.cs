
using SistemaHorarios.Dominio.Enums;

namespace SistemaHorarios.Aplicacion.Grupos;

public class GrupoResponse
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public Grado? Grado { get; set; }
    public bool HorarioAsignado { get; set; }
}
