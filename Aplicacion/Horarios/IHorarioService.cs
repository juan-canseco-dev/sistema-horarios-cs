using SistemaHorarios.Dominio.Abstractions;

namespace SistemaHorarios.Aplicacion.Horarios;

public interface IHorarioService
{
    Task<Result> UpdateAsync(ActualizarHorarioRequest request, CancellationToken cancellationToken = default);
    Task<Result> DeleteAsync(EliminarHorarioRequest request, CancellationToken cancellationToken = default);
    Task<Result<bool>> HoraDisponibleAsync(HoraDisponibleRequest request, CancellationToken cancellationToken);
    Task<Result<HorarioResponse>> GetByGrupoAsync(int grupoId, CancellationToken cancellationToken = default);
}
