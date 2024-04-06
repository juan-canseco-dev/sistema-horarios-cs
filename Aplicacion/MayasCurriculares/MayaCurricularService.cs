

using Microsoft.EntityFrameworkCore;
using SistemaHorarios.Aplicacion.Abstractions;
using SistemaHorarios.Dominio.Entidades;

namespace SistemaHorarios.Aplicacion.MayasCurriculares;


public class MayaCurricularService : IMayaCurricularService
{
    private readonly IApplicationDbContext _context;
    public MayaCurricularService(IApplicationDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task<int> CreateAsync(CrearMayaCurricularRequest request, CancellationToken cancellationToken = default)
    {
        var materias = request.Materias!.Select(m => MateriaRequestToEntity(m)).ToList();
        var mayaCurricular = new MayaCurricular(request.Grado, materias);
        _context.MayasCurriculares.Add(mayaCurricular);
        await _context.SaveChangesAsync(cancellationToken);
        return mayaCurricular.Id;
    }

    public async Task<bool> DeleteAsync(EliminarMayaCurricularRequest request, CancellationToken cancellationToken = default)
    {
        var mayaCurricular = await _context.MayasCurriculares.FindAsync(request.MayaCurricularId, cancellationToken);
        if (mayaCurricular is null) return false;
        _context.MayasCurriculares.Remove(mayaCurricular);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }

    public async Task<bool> UpdateAsync(ActualizarMayaCurricular request, CancellationToken cancellationToken = default)
    {
        var mayaCurricular = await _context.MayasCurriculares.FindAsync(request.MayaCurricularId, cancellationToken);
        if (mayaCurricular is null) return false;
        var materias = request.Materias!.Select(m => MateriaRequestToEntity(m)).ToList();
        mayaCurricular.Update(materias);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }


    public async Task<List<MayaCurricularResponse>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await _context.MayasCurriculares
            .Include(m => m.Materias)
            .OrderBy(m => m.Grado)
            .Select(m => EntidadToResponse(m))
            .ToListAsync();
    }

    public async Task<MayaCurricularResponse?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        var maya = await _context.MayasCurriculares
            .Include(m => m.Materias)
            .FirstOrDefaultAsync(m => m.Id == id, cancellationToken);
        if (maya is null) return null;
        return EntidadToResponse(maya); 
    }

    // Utils
    private Materia MateriaRequestToEntity(MateriaRequest request)
    {
        return new Materia(request.Nombre!, request.Codigo!, request.HorasSemanales);
    }

    private MateriaResponse MateriaEntityToResponse(Materia materia)
    {
        return new MateriaResponse
        {
            Id = materia.Id,
            Nombre = materia.Nombre,
            Codigo = materia.Codigo,
            HorasSemanales = materia.HorasSemanales
        };
    }

    private List<MateriaResponse> MateriasEntitdadesToResponses(IEnumerable<Materia> materias)
    {
        return materias.Select(m => MateriaEntityToResponse(m)).ToList();
    }

    private MayaCurricularResponse EntidadToResponse(MayaCurricular maya)
    {
        return new MayaCurricularResponse
        {
            Id = maya.Id,
            Grado = $"{(int)maya.Grado}º {maya.Grado.ToString().ToUpper()}",
            Materias = MateriasEntitdadesToResponses(maya.Materias)
        };
    }

}
