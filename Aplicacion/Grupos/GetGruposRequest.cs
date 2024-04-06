
using SistemaHorarios.Dominio.Enums;

namespace SistemaHorarios.Aplicacion.Grupos;

public class GetGruposRequest
{
    public string? Nombre { get; set; }
    public Grado? Grado { get; set; }
}
