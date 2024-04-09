namespace SistemaHorarios.Dominio.Shared;
public class Hora
{
    public int Id { get; init; }
    public TimeOnly Inicio { get; init; }
    public TimeOnly Fin { get; init; }
    public bool EsReceso { get; init; }
    private Hora() { }
    private Hora(int id, TimeOnly inicio, TimeOnly fin, bool esReceso)
    {
        Id = id;
        Inicio = inicio;
        Fin = fin;
        EsReceso = esReceso;
    }
    private static Hora NewHora(int id, TimeOnly inicio, TimeOnly fin)
    {
        return new Hora(id, inicio, fin, false);
    }

    private static Hora NewReceso(int id, TimeOnly inicio, TimeOnly fin)
    {
        return new Hora(id, inicio, fin, true);
    }

    public static Hora Hora1 = NewHora(1, new TimeOnly(7, 0), new TimeOnly(8, 0));
    public static Hora Hora2 = NewHora(2, new TimeOnly(8, 0), new TimeOnly(9, 0));
    public static Hora Hora3 = NewHora(3, new TimeOnly(9, 0), new TimeOnly(10, 0));
    public static Hora Receso1 = NewReceso(4, new TimeOnly(10, 0), new TimeOnly(10, 20));
    public static Hora Hora4 = NewHora(5, new TimeOnly(10, 20), new TimeOnly(11, 10));
    public static Hora Hora5 = NewHora(6, new TimeOnly(11, 10), new TimeOnly(12, 0));
    public static Hora Receso2 = NewReceso(7, new TimeOnly(12, 0), new TimeOnly(12, 20));
    public static Hora Hora6 = NewHora(8, new TimeOnly(12, 20), new TimeOnly(1, 10));
    public static Hora Hora7 = NewHora(9, new TimeOnly(1, 10), new TimeOnly(2, 10));

    public static IReadOnlyCollection<Hora> All => new List<Hora>()
    {
        Hora1,
        Hora2,
        Hora3,
        Receso1,
        Hora4,
        Hora5,
        Receso2,
        Hora6,
        Hora7
    }.AsReadOnly();
}
