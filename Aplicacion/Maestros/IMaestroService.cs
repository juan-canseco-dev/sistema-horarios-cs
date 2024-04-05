namespace SistemaHorarios.Aplicacion.Maestros;

public interface IMaestroService
{
    Task<int> CreateAsync(CrearMaestroRequest request, CancellationToken cancellationToken = default);
    Task<bool> UpdateAsync(ActualizarMaestroRequest request, CancellationToken cancellationToken = default);
    Task<bool> DeleteAsync(EliminarMaestroRequest request, CancellationToken cancellationToken = default);
    Task<MaestroResponse?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    Task<List<MaestroResponse>> GetAllAsync(GetMaestrosRequest request, CancellationToken cancellationToken = default);
}
