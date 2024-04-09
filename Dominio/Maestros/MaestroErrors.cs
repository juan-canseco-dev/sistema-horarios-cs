using SistemaHorarios.Dominio.Abstractions;

namespace SistemaHorarios.Dominio.Maestros;

public static class MaestroErrors
{
    public static Error NotFound = new Error(
        "Maestro.NotFound",
        "El Maestro con el id especificado no fue encontrado."
    );
}
