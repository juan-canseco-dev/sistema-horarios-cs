using SistemaHorarios.Dominio.Abstractions;

namespace SistemaHorarios.Dominio.Grupos;

public static class GrupoErrors
{
    public static Error NotFound = new Error(
        "Grupo.NotFound",
        "El Grupo con el id especificado no fue encontrado."
    );

    public static Error DuplicateGroup = new Error(
        "Grupo.Duplicate",
        "El Grupo especificado ya existe."
    );
}
