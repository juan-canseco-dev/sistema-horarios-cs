namespace SistemaHorarios.Aplicacion.Horarios;

public record CrearHorarioRequest(int GrupoId, List<HoraRequest> Horas);