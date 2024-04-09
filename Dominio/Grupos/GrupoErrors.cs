using SistemaHorarios.Dominio.Abstractions;

namespace SistemaHorarios.Dominio.Grupos;

public static class GrupoErrors
{
    public static Error NotFound = new Error(
        "Grupo.NotFound",
        "El Grupo con el id especificado no fue encontrado."
    );
}
