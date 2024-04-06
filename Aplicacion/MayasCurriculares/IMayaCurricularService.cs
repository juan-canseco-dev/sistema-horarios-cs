namespace SistemaHorarios.Aplicacion.MayasCurriculares;

public interface IMayaCurricularService
{
    Task<int> CreateAsync(CrearMayaCurricularRequest request, CancellationToken cancellationToken = default);
    Task<bool> UpdateAsync(ActualizarMayaCurricular request, CancellationToken cancellationToken = default);
    Task<bool> DeleteAsync(EliminarMayaCurricularRequest request, CancellationToken cancellationToken = default);
    Task<MayaCurricularResponse?> GetByIdAsync(int id,  CancellationToken cancellationToken = default);  
    Task<List<MayaCurricularResponse>> GetAllAsync(CancellationToken cancellationToken = default);  
}
