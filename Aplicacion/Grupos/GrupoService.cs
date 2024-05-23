
using Microsoft.EntityFrameworkCore;
using SistemaHorarios.Aplicacion.Abstractions;
using SistemaHorarios.Dominio.Abstractions;
using SistemaHorarios.Dominio.Grupos;
namespace SistemaHorarios.Aplicacion.Grupos;

public class GrupoService : IGrupoService
{
    private readonly IApplicationDbContext _context;

    public GrupoService(IApplicationDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task<Result<int>> CreateAsync(CrearGrupoRequest request, CancellationToken cancellationToken = default)
    {
        try 
        {
            if (await _context.Grupos.AnyAsync(g => g.Grado == request.Grado && g.Nombre.ToLower() == request.Nombre.ToLower(), cancellationToken))
            {
                return Result.Failure<int>(GrupoErrors.DuplicateGroup);
            }
            var grupo = new Grupo(request.Nombre, request.Grado);
            _context.Grupos.Add(grupo);
            await _context.SaveChangesAsync(cancellationToken);
            return grupo.Id;
        }
        catch(Exception e)
        {
            return Result.Failure<int>(Error.FromException(e));
        }
    }

    public async Task<Result> UpdateAsync(ActualizarGrupoRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var key = new object[] { request.GrupoId };
            var grupo = await _context.Grupos.FindAsync(key, cancellationToken);
            if (grupo is null) return Result.Failure(GrupoErrors.NotFound);
            if (await _context.Grupos.AnyAsync(g => g.Grado == grupo.Grado && g.Nombre.ToLower() == request.Nombre.ToLower(), cancellationToken))
            {
                return Result.Failure<int>(GrupoErrors.DuplicateGroup);
            }
            grupo.Update(request.Nombre);
            await _context.SaveChangesAsync(cancellationToken);
            return Result.Success();
        }
        catch(Exception e)
        {
            return Result.Failure(Error.FromException(e));
        }
    }

    public async Task<Result> DeleteAsync(EliminarGrupoRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var key = new object[] { request.GrupoId };
            var grupo = await _context.Grupos.FindAsync(key, cancellationToken);
            if (grupo is null) return Result.Failure(GrupoErrors.NotFound);

            _context.Grupos.Remove(grupo);
            await _context.SaveChangesAsync(cancellationToken);
            return Result.Success();
        }
        catch(Exception e) 
        {
            return Result.Failure(Error.FromException(e));
        }
    }

    public async Task<Result<GrupoResponse>> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        try
        {
            var key = new object[] { id };
            var grupo = await _context.Grupos.FindAsync(key, cancellationToken);

            if (grupo is null) return Result.Failure<GrupoResponse>(GrupoErrors.NotFound);
            return EntityToResponse(grupo);
        }
        catch(Exception e)
        {
            return Result.Failure<GrupoResponse>(Error.FromException(e));
        }
    }

    public async Task<Result<List<GrupoResponse>>> GetAllAsync(GetGruposRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var query = _context.Grupos
                .Include(g => g.Horario)
                .ThenInclude(h => h!.Items)
                .AsQueryable();

            if (string.IsNullOrEmpty(request.Nombre))
            {
                query = query.Where(m => EF.Functions.Like(m.Nombre, $"%{request.Nombre}%"));
            }

            if (request.Grado is not null)
            {
                query = query.Where(m => m.Grado == request.Grado);
            }

            query = query.OrderBy(g => g.Grado);
            var grupos = await query.ToListAsync();
            return grupos.Select(m => EntityToResponse(m)).ToList();
        }
        catch(Exception e)
        {
            return Result.Failure<List<GrupoResponse>>(Error.FromException(e));
        }
    }



    private GrupoResponse EntityToResponse(Grupo grupo)
    {
        return new GrupoResponse
        {
            Id = grupo.Id,
            Nombre = grupo.Nombre,
            Grado = grupo.Grado, 
            HorarioAsignado = grupo!.Horario!.Items.Count > 0
        };
    }
}
