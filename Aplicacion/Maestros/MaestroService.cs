

using Microsoft.EntityFrameworkCore;
using SistemaHorarios.Aplicacion.Abstractions;
using SistemaHorarios.Dominio.Abstractions;
using SistemaHorarios.Dominio.Maestros;

namespace SistemaHorarios.Aplicacion.Maestros;

public class MaestroService : IMaestroService
{
    private readonly IApplicationDbContext _context;

    public MaestroService(IApplicationDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task<Result<int>> CreateAsync(CrearMaestroRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var maestro = new Maestro(request.Nombres, request.Apellidos);
            _context.Maestros.Add(maestro);
            await _context.SaveChangesAsync(cancellationToken);
            return maestro.Id;
        }
        catch(Exception e)
        {
            return Result.Failure<int>(Error.FromException(e));
        }
    }

    public async Task<Result> DeleteAsync(EliminarMaestroRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var maestro = await _context.Maestros.FindAsync(request.MaestroId);
            if (maestro is null) return Result.Failure(MaestroErrors.NotFound);
            _context.Maestros.Remove(maestro);
            await _context.SaveChangesAsync(cancellationToken);
            return Result.Success();
        }
        catch(Exception e)
        {
            return Result.Failure(Error.FromException(e));
        }
    }

    public async Task<Result<List<MaestroResponse>>> GetAllAsync(GetMaestrosRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var query = _context.Maestros.AsQueryable();
            if (string.IsNullOrEmpty(request.Nombres))
            {
                query = query.Where(m => EF.Functions.Like(m.Nombres, $"%{request.Nombres}%"));
            }
            if (string.IsNullOrEmpty(request.Apellidos))
            {
                query = query.Where(m => EF.Functions.Like(m.Apellidos, $"%{request.Apellidos}%"));
            }
            var maestros = await query.ToListAsync(cancellationToken);
            return maestros.Select(m => EntityToResponse(m)).ToList();
        }
        catch(Exception e)
        {
            return Result.Failure<List<MaestroResponse>>(Error.FromException(e));
        }
    }

    public async Task<Result<MaestroResponse>> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        try
        {
            var maestro = await _context.Maestros.FindAsync(id, cancellationToken);
            if (maestro is null) return Result.Failure<MaestroResponse>(MaestroErrors.NotFound);
            return EntityToResponse(maestro);
        }
        catch(Exception e)
        {
            return Result.Failure<MaestroResponse>(Error.FromException(e));
        }
    }

    public async Task<Result> UpdateAsync(ActualizarMaestroRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var maestro = await _context.Maestros.FindAsync(request.Id, cancellationToken);
            if (maestro is null) return Result.Failure(MaestroErrors.NotFound);
            maestro.Update(request.Nombres, request.Apellidos);
            await _context.SaveChangesAsync(cancellationToken);
            return Result.Success();

        }
        catch (Exception e)
        {
            return Result.Failure(Error.FromException(e));
        }
    }

    // Helper methods

    private MaestroResponse EntityToResponse(Maestro maestro)
    {
        return new MaestroResponse
        {
            Id = maestro.Id,
            Nombres = maestro.Nombres,
            Apellidos = maestro.Apellidos,
        };
    }
}
