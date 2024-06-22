namespace SistemaHorarios.Dominio.MayasCurriculares;

public static class MateriasEspecialesIds
{
    public const int Ingles1 = 1000;
    public const int Ingles2 = 2000;
    public const int Ingles3 = 3000;
    public const int Expertos1 = 4000;
    public const int Expertos2 = 5000;
    public const int Expertos3 = 6000;
    public const int Arte1 = 7000;
    public const int Arte2 = 8000;
    public const int Arte3 = 9000;

    public static HashSet<int> All => new HashSet<int>
    {
        Ingles1,
        Ingles2,
        Ingles3,
        Expertos1,
        Expertos2,
        Expertos3,
        Arte1,
        Arte2,
        Arte3
    };
}
