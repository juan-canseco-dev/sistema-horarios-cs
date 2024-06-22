using SistemaHorarios.Dominio.Abstractions;
using SistemaHorarios.Dominio.Enums;

namespace SistemaHorarios.Aplicacion.Maestros;

public interface IMaestroService
{
    Task<Result<int>> CreateAsync(CrearMaestroRequest request, CancellationToken cancellationToken = default);
    Task<Result> UpdateAsync(ActualizarMaestroRequest request, CancellationToken cancellationToken = default);
    Task<Result> DeleteAsync(EliminarMaestroRequest request, CancellationToken cancellationToken = default);
    Task<Result<MaestroResponse>> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    Task<Result<List<MaestroResponse>>> GetAllAsync(GetMaestrosRequest request, CancellationToken cancellationToken = default);
    Task<Result<List<MaestroResponse>>> GetAllUnassignedByHour(int HoraId, Dia Dia, Grado grado, int? RemovedTeacherId = null, CancellationToken cancellationToken = default);
}
