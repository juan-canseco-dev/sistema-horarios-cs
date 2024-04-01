using SistemaHorarios.Dominio.Enums;
using SistemaHorarios.Dominio.Shared;

namespace SistemaHorarios.Dominio.Entidades;

public class Grupo : BaseEntity
{
    public string? Nombre { get; set; }
    public Grado Grado { get; set; }
}
