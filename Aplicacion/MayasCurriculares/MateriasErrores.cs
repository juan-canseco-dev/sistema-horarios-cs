using SistemaHorarios.Dominio.Abstractions;

namespace SistemaHorarios.Aplicacion.MayasCurriculares
{
    public static class MateriasErrores
    {
        public static Error Duplicate = new Error(
            "MayaCurricular.Materia.Duplicate",
            "El código u/o el Nombre especificado ya esta en uso por otra materia."
        );
    }
}
