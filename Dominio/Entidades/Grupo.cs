using SistemaHorarios.Dominio.Abstractions;
using SistemaHorarios.Dominio.Enums;

namespace SistemaHorarios.Dominio.Entidades;

public class Grupo : BaseEntity
{
    public string? Nombre { get; set; }
    public Grado Grado { get; set; }
}
