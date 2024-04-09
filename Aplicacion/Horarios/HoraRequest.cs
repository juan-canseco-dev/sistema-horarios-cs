using SistemaHorarios.Dominio.Enums;

namespace SistemaHorarios.Aplicacion.Horarios;

public record HoraRequest(Dia Dia, int HoraId, int MateriaId, int MaestroId);
