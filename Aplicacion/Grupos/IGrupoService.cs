using SistemaHorarios.Dominio.Abstractions;

namespace SistemaHorarios.Aplicacion.Grupos;

public interface IGrupoService
{
    Task<Result<int>> CreateAsync(CrearGrupoRequest request, CancellationToken cancellationToken = default);
    Task<Result> DeleteAsync(EliminarGrupoRequest request, CancellationToken cancellationToken = default);
    Task<Result> UpdateAsync(ActualizarGrupoRequest request, CancellationToken cancellationToken = default);
    Task<Result<List<GrupoResponse>>> GetAllAsync(GetGruposRequest request, CancellationToken cancellationToken = default);
    Task<Result<GrupoResponse>> GetByIdAsync(int id, CancellationToken cancellationToken = default); 
}
