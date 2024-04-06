
using SistemaHorarios.Dominio.Enums;
namespace SistemaHorarios.Aplicacion.MayasCurriculares;


public class CrearMayaCurricularRequest
{
    public Grado Grado { get; set; }
    public List<MateriaRequest>? Materias { get; set; }
}


