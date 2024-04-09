
using SistemaHorarios.Dominio.Abstractions;

namespace SistemaHorarios.Dominio.Horarios;

public static class HorarioErrors
{
    public static Error NotFound = new Error(
        "Horario.NotFound",
        "El Horario con el id especificado no fue encontrado."
    );

    public static Error Overlap = new Error(
        "Horario.Overlap",
        "Un Profesor ya esta asignado a otro horario en la misma hora y en el mismo dia."
    );
}
