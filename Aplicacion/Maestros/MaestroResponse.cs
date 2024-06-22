
namespace SistemaHorarios.Aplicacion.Maestros;

public class MaestroResponse
{
    public int Id { get; set; }
    public string? Nombres { get; set; }
    public string? Apellidos { get; set; }

    public string? NombreCompleto { get; set; }

    public bool HorasAsignadas { get; set; } = false;
}
