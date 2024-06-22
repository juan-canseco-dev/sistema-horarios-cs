
namespace SistemaHorarios.Dominio.Maestros;

public static class MaestrosEspecialesIds
{
    public const int Ingles1 = 100;
    public const int Ingles2 = 200;
    public const int Ingles3 = 300;
    public const int Expertos1 = 400;
    public const int Expertos2 = 500;
    public const int Expertos3 = 600;
    public const int Arte1 = 700;
    public const int Arte2 = 800;
    public const int Arte3 = 900;

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
