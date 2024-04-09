using SistemaHorarios.Dominio.Abstractions;

namespace SistemaHorarios.Dominio.MayasCurriculares;

public static class MayaCurricularErrores
{
    public static Error NotFound = new Error(
        "MayaCurricular.NotFound",
        "La Maya Curricular con el id especificado no fue encontrado."
    );
}
