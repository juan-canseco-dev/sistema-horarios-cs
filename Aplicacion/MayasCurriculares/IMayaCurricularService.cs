using SistemaHorarios.Dominio.Abstractions;

namespace SistemaHorarios.Aplicacion.MayasCurriculares;

public interface IMayaCurricularService
{
    Task<Result<int>> CreateAsync(CrearMayaCurricularRequest request, CancellationToken cancellationToken = default);
    Task<Result> UpdateAsync(ActualizarMayaCurricular request, CancellationToken cancellationToken = default);
    Task<Result> DeleteAsync(EliminarMayaCurricularRequest request, CancellationToken cancellationToken = default);
    Task<Result<MayaCurricularResponse>> GetByIdAsync(int id,  CancellationToken cancellationToken = default);  
    Task<Result<List<MayaCurricularResponse>>> GetAllAsync(CancellationToken cancellationToken = default);  
}
