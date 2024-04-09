
namespace SistemaHorarios.Aplicacion.Horarios;

public record HoraResponse(int Id, TimeOnly Inicio, TimeOnly Fin, bool EsReceso);

