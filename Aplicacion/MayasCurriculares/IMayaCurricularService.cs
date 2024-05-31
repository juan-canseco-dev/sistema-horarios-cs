using SistemaHorarios.Dominio.Abstractions;
using SistemaHorarios.Dominio.Enums;

namespace SistemaHorarios.Aplicacion.MayasCurriculares;

public interface IMayaCurricularService
{
    Task<Result> UpdateAsync(ActualizarMayaCurricular request, CancellationToken cancellationToken = default);
    Task<Result<MayaCurricularResponse>> GetByIdAsync(int id,  CancellationToken cancellationToken = default);
    Task<Result<MayaCurricularResponse>> GetByGradoAsync(Grado? grado, CancellationToken cancellationToken = default);
    Task<Result<List<MayaCurricularResponse>>> GetAllAsync(CancellationToken cancellationToken = default);  
}
