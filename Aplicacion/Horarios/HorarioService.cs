
using Microsoft.EntityFrameworkCore;
using SistemaHorarios.Aplicacion.Abstractions;
using SistemaHorarios.Aplicacion.Grupos;
using SistemaHorarios.Dominio.Abstractions;
using SistemaHorarios.Dominio.Grupos;
using SistemaHorarios.Dominio.Horarios;

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
            .Select(r => _context.HorarioItems.AnyAsync(h => h.Dia == r.Dia && h.HoraId == r.HoraId && h.MaestroId == r.MaestroId, cancellationToken))
            .ToList();

        var result = await Task.WhenAll(tasks);

        return result.Count(r => r is false) == result.Count();
    }

    private List<HoraRequest> GetNewItems(Horario horario, List<HoraRequest> horas)
    {
        List<HoraRequest> response = new List<HoraRequest>();
        horas.ForEach(h =>
        {
            if (!horario.Items.Any(i => i.Dia == h.Dia && i.HoraId == h.HoraId))
            {
                response.Add(h);
            }
        });
        return response;
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

            var newItems = GetNewItems(horario, request.Horas);


            if (!await HorasLibres(newItems, cancellationToken))
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
            var horario = await _context.Horarios.Include(h => h.Items).FirstOrDefaultAsync(h => h.Id == request.HorarioId, cancellationToken);
            if (horario is null)
            {
                return Result.Failure(HorarioErrors.NotFound);
            }
            horario.DeleteHoras();
            await _context.SaveChangesAsync(cancellationToken);

            return Result.Success();
        }
        catch (Exception e)
        {
            return Result.Failure(Error.FromException(e));
        }
    }

    public async Task<Result<HorarioResponse>> GetByGrupoAsync(int grupoId, CancellationToken cancellationToken = default)
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
                .FirstOrDefaultAsync(h => h.GrupoId == grupoId, cancellationToken);


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
