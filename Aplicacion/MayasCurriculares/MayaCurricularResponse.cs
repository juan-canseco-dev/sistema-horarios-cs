using SistemaHorarios.Dominio.Enums;

namespace SistemaHorarios.Aplicacion.MayasCurriculares;

public class MayaCurricularResponse
{
    public int Id { get; set; }
    public Grado Grado { get; set; }
    public bool Asignada { get; set; }
    public List<MateriaResponse>? Materias { get; set; }
}
