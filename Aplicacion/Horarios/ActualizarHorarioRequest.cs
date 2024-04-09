
namespace SistemaHorarios.Aplicacion.Horarios;

public record ActualizarHorarioRequest(int HorarioId, List<HoraRequest> Horas);
