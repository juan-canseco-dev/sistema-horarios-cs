namespace SistemaHorarios.Aplicacion.Grupos;

public interface IGrupoService
{
    Task<int> CreateAsync(CrearGrupoRequest request, CancellationToken cancellationToken = default);
    Task<bool> DeleteAsync(EliminarGrupoRequest request, CancellationToken cancellationToken = default);
    Task<bool> UpdateAsync(ActualizarGrupoRequest request, CancellationToken cancellationToken = default);
    Task<List<GrupoResponse>> GetAllAsync(GetGruposRequest request, CancellationToken cancellationToken = default);
    Task<GrupoResponse?> GetByIdAsync(int id, CancellationToken cancellationToken = default); 
}
