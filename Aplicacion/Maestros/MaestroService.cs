using Microsoft.EntityFrameworkCore;
using SistemaHorarios.Aplicacion.Abstractions;
using SistemaHorarios.Dominio.Abstractions;
using SistemaHorarios.Dominio.Enums;
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
            var key = new object[] { request.MaestroId };
            var maestro = await _context.Maestros.FindAsync(key, cancellationToken);
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
            if (!string.IsNullOrEmpty(request.Filtro))
            {
                query = query.Where(m => EF.Functions.Like(m.Nombres, $"%{request.Filtro}%") || EF.Functions.Like(m.Apellidos, $"%{request.Filtro}%"));
            }
            var maestros = await query.ToListAsync(cancellationToken);
            return maestros.Select(m => EntityToResponse(m)).ToList();
        }
        catch(Exception e)
        {
            return Result.Failure<List<MaestroResponse>>(Error.FromException(e));
        }
    }

    public async Task<Result<List<MaestroResponse>>> GetAllUnassignedByHour(int HoraId, Dia Dia, int? RemovedTeacherId = null, CancellationToken cancellationToken = default)
    {
        try
        {
            int? assignedTeacherId = await _context.HorarioItems
            .Where(hi => hi.HoraId == HoraId && hi.Dia == Dia)
            .Select(m => m.MaestroId)
            .FirstOrDefaultAsync();

            var teachers = await _context.Maestros
                   .ToListAsync();

            if (assignedTeacherId == null)
            {
                return teachers.Select(m => EntityToResponse(m)).ToList();
            }

            if (assignedTeacherId != RemovedTeacherId)
            {
                var item = teachers.FirstOrDefault(m => m.Id == assignedTeacherId);
                if (item is not null) teachers.Remove(item);
            }

            return teachers.Select(m => EntityToResponse(m)).ToList();
        }
        catch (Exception e)
        {
            return Result.Failure<List<MaestroResponse>>(Error.FromException(e));
        }
    }

    public async Task<Result<MaestroResponse>> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        try
        {
            var key = new object[] { id };
            var maestro = await _context.Maestros.FindAsync(key, cancellationToken);
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
            var key = new object[] { request.Id };
            var maestro = await _context.Maestros.FindAsync(key, cancellationToken);
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
            NombreCompleto = $"{maestro.Nombres} {maestro.Apellidos}"
        };
    }
}
