
using Microsoft.EntityFrameworkCore;
using SistemaHorarios.Aplicacion.Abstractions;
using SistemaHorarios.Dominio.Entidades;

namespace SistemaHorarios.Aplicacion.Grupos;

public class GrupoService : IGrupoService
{
    private readonly IApplicationDbContext _context;

    public GrupoService(IApplicationDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task<int> CreateAsync(CrearGrupoRequest request, CancellationToken cancellationToken = default)
    {
        var grupo = new Grupo(request.Nombre, request.Grado);
        _context.Grupos.Add(grupo);
        await _context.SaveChangesAsync(cancellationToken);
        return grupo.Id;
    }

    public async Task<bool> UpdateAsync(ActualizarGrupoRequest request, CancellationToken cancellationToken = default)
    {
        var grupo = await _context.Grupos.FindAsync(request.GrupoId, cancellationToken);
        if (grupo is null) return false;
        grupo.Update(request.Nombre);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }

    public async Task<bool> DeleteAsync(EliminarGrupoRequest request, CancellationToken cancellationToken = default)
    {
        var grupo = await _context.Grupos.FindAsync(request.GrupoId, cancellationToken);
        if (grupo is null) return false;
        _context.Grupos.Remove(grupo);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }

    public async Task<GrupoResponse?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        var grupo = await _context.Grupos.FindAsync(id, cancellationToken);
        if (grupo is null) return null;
        return EntityToResponse(grupo);
    }

    public async Task<List<GrupoResponse>> GetAllAsync(GetGruposRequest request, CancellationToken cancellationToken = default)
    {
        var query = _context.Grupos.AsQueryable();

        if (string.IsNullOrEmpty(request.Nombre))
        {
            query = query.Where(m => EF.Functions.Like(m.Nombre, $"%{request.Nombre}%"));
        }

        if (request.Grado is not null)
        {
            query = query.Where(m => m.Grado == request.Grado);
        }

        var grupos = await query.ToListAsync();
        return grupos.Select(m => EntityToResponse(m)).ToList();
    }



    private GrupoResponse EntityToResponse(Grupo grupo)
    {
        return new GrupoResponse
        {
            Id = grupo.Id,
            Nombre = grupo.Nombre,
            Grado =$"{(int)grupo.Grado}º {grupo.Grado.ToString().ToUpper()}"
        };
    }
}
