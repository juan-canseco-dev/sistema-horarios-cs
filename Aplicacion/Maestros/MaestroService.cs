

using Microsoft.EntityFrameworkCore;
using SistemaHorarios.Aplicacion.Abstractions;
using SistemaHorarios.Dominio.Entidades;

namespace SistemaHorarios.Aplicacion.Maestros;

public class MaestroService : IMaestroService
{
    private readonly IApplicationDbContext _context;

    public MaestroService(IApplicationDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task<int> CreateAsync(CrearMaestroRequest request, CancellationToken cancellationToken = default)
    {
        var maestro = new Maestro(request.Nombres, request.Apellidos);
        _context.Maestros.Add(maestro);
        await _context.SaveChangesAsync(cancellationToken);
        return maestro.Id;
    }

    public async Task<bool> DeleteAsync(EliminarMaestroRequest request, CancellationToken cancellationToken = default)
    {
        var maestro = await _context.Maestros.FindAsync(request.MaestroId);
        if (maestro is null)
        {
            return false;
        }
        _context.Maestros.Remove(maestro);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }

    public async Task<List<MaestroResponse>> GetAllAsync(GetMaestrosRequest request, CancellationToken cancellationToken = default)
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

    public async Task<MaestroResponse?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        var maestro = await _context.Maestros.FindAsync(id, cancellationToken);
        return maestro is null? null : EntityToResponse(maestro);
    }

    public async Task<bool> UpdateAsync(ActualizarMaestroRequest request, CancellationToken cancellationToken = default)
    {
        var maestro = await _context.Maestros.FindAsync(request.Id, cancellationToken);
        if (maestro is null) return false;
        maestro.Update(request.Nombres, request.Apellidos);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
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
