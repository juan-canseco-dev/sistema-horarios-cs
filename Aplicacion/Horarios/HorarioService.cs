
using Microsoft.EntityFrameworkCore;
using SistemaHorarios.Aplicacion.Abstractions;
using SistemaHorarios.Aplicacion.Grupos;
using SistemaHorarios.Dominio.Abstractions;
using SistemaHorarios.Dominio.Grupos;
using SistemaHorarios.Dominio.Horarios;
using SistemaHorarios.Dominio.MayasCurriculares;

namespace SistemaHorarios.Aplicacion.Horarios;

public class HorarioService : IHorarioService
{

    private readonly IApplicationDbContext _context;

    public HorarioService(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> HorasLibres(List<HoraRequest> horas, CancellationToken cancellationToken = default)
    {
        var tasks = horas
            .Select(r => _context.HorarioItems.AnyAsync(h => h.Dia == r.Dia && h.HoraId == r.HoraId, cancellationToken))
            .ToList();

        var result = await Task.WhenAll(tasks);

        return result.Any(r => r is true);
    }

    public async Task<Result<int>> CreateAsync(CrearHorarioRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var grupo = await _context.Grupos.FindAsync(request.GrupoId, cancellationToken);

            if (grupo is null)
            {
                return Result.Failure<int>(GrupoErrors.NotFound);
            }

            var mayaCurricular = await _context.MayasCurriculares.FirstOrDefaultAsync(m => m.Grado == grupo.Grado, cancellationToken);

            if (mayaCurricular is null)
            {
                return Result.Failure<int>(MayaCurricularErrores.NotFound);
            }

            if (!await HorasLibres(request.Horas, cancellationToken))
            {
                return Result.Failure<int>(HorarioErrors.Overlap);
            }

            var items = request.Horas
                .Select(h => new HorarioItem(h.HoraId, h.MateriaId, h.MaestroId, h.Dia))
                .ToList();

            var horario = new Horario(mayaCurricular.Id, grupo.Id, items);
            _context.Horarios.Add(horario);

            await _context.SaveChangesAsync(cancellationToken);

            return horario.Id;
        }
        catch(Exception e)
        {
            return Result.Failure<int>(Error.FromException(e));
        }
    }

    public async Task<Result> UpdateAsync(ActualizarHorarioRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var horario = await _context.Horarios.Include(h => h.Items).FirstOrDefaultAsync(h => h.Id == request.HorarioId, cancellationToken);

            if (horario is null)
            {
                return Result.Failure(HorarioErrors.NotFound);
            }

            if (!await HorasLibres(request.Horas, cancellationToken))
            {
                return Result.Failure(HorarioErrors.Overlap);
            }

            var items = request.Horas
                .Select(h => new HorarioItem(h.HoraId, h.MateriaId, h.MaestroId, h.Dia))
                .ToList();

            horario.Update(items);

            await _context.SaveChangesAsync(cancellationToken);

            return Result.Success();
        }
        catch (Exception e)
        {
            return Result.Failure(Error.FromException(e));
        }
    }

    public async Task<Result> DeleteAsync(EliminarHorarioRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var horario = await _context.Horarios.FindAsync(request.HorarioId, cancellationToken);
            if (horario is null)
            {
                return Result.Failure(HorarioErrors.NotFound);
            }

            _context.Horarios.Remove(horario);
            await _context.SaveChangesAsync(cancellationToken);

            return Result.Success();
        }
        catch (Exception e)
        {
            return Result.Failure(Error.FromException(e));
        }
    }

    public async Task<Result<HorarioResponse>> GetByIdAsync(int horarioId, CancellationToken cancellationToken = default)
    {
        try
        {
            var horario = await _context.Horarios
                .Include(h => h.Grupo)
                .Include(h => h.Items)
                .ThenInclude(i => i.Materia)
                .Include(h => h.Items)
                .ThenInclude(i => i.Maestro)
                .Include(h => h.Items)
                .ThenInclude(i => i.Hora)
                .FirstOrDefaultAsync(h => h.Id == horarioId, cancellationToken);

            if (horario is null)
            {
                return Result.Failure<HorarioResponse>(HorarioErrors.NotFound);
            }

            return HorarioToResponse(horario);
        }
        catch(Exception e)
        {
            return Result.Failure<HorarioResponse>(Error.FromException(e));
        }
    }

    private HorarioResponse HorarioToResponse(Horario horario)
    {
        return new HorarioResponse
        {
            Id = horario.Id,
            MayaCurricularId = horario.MayaCurricularId,
            Grupo = GrupoToResponse(horario.Grupo!),
            Items = ItemsToResponse(horario.Items)
        };
    }

    private GrupoResponse GrupoToResponse(Grupo grupo)
    {
        return new GrupoResponse
        {
            Id = grupo.Id,
            Nombre = grupo.Nombre,
            Grado = grupo.Grado
        };
    }

    private List<HorarioItemResponse> ItemsToResponse(IEnumerable<HorarioItem> items)
    {
        return items.Select(i => new HorarioItemResponse
        {
            Dia = i.Dia,
            Hora = new HoraResponse(i.Hora!.Id, i.Hora.Inicio, i.Hora.Fin, i.Hora.EsReceso),
            Maestro = new Maestros.MaestroResponse { Id = i.Maestro!.Id, Nombres = i.Maestro.Nombres, Apellidos = i.Maestro.Apellidos},
            Materia = new MayasCurriculares.MateriaResponse { Id = i.Materia!.Id, Nombre = i.Materia.Nombre, Codigo = i.Materia.Codigo, HorasSemanales = i.Materia.HorasSemanales}
        }).ToList();
    }

    public async Task<Result<List<HorarioResponse>>> GetAllAsync(GetHorariosRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _context.Horarios
               .Include(h => h.Grupo)
               .Include(h => h.Items)
               .ThenInclude(i => i.Materia)
               .Include(h => h.Items)
               .ThenInclude(i => i.Maestro)
               .Include(h => h.Items)
               .ThenInclude(i => i.Hora)
               .OrderBy(h => h.MayaCurricular!.Grado)
               .Select(h => HorarioToResponse(h))
               .ToListAsync(cancellationToken);
        }
        catch(Exception e)
        {
            return Result.Failure<List<HorarioResponse>>(Error.FromException(e));
        }
    }

    public async Task<Result<bool>> HoraDisponibleAsync(HoraDisponibleRequest request, CancellationToken cancellationToken)
    {
        try
        {
            return !await _context.HorarioItems.AnyAsync(h => h.Dia == request.Dia && h.HoraId == request.HoraId);
        }
        catch(Exception e)
        {
            return Result.Failure<bool>(Error.FromException(e));
        }
    }
}
