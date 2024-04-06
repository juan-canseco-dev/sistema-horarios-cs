namespace SistemaHorarios.Aplicacion.MayasCurriculares;

public class MayaCurricularResponse
{
    public int Id { get; set; }
    public string? Grado { get; set; }
    public List<MateriaResponse>? Materias { get; set; }
}
