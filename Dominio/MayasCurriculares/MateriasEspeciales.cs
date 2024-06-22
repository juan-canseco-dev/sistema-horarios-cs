namespace SistemaHorarios.Dominio.MayasCurriculares;

public static class MateriasEspeciales
{

    public static Materia Ingles1 = new Materia(MateriasEspecialesIds.Ingles1,1, "Ingles I", "ING-I", 5);
    public static Materia Ingles2 = new Materia(MateriasEspecialesIds.Ingles2,2, "Ingles II", "ING-II", 5);
    public static Materia Ingles3 = new Materia(MateriasEspecialesIds.Ingles3, 3,"Ingles III", "ING-III", 5);

    public static Materia Expertos1 = new Materia(MateriasEspecialesIds.Expertos1,1, "Expertos I", "EXP-I", 5);
    public static Materia Expertos2 = new Materia(MateriasEspecialesIds.Expertos2, 2,"Expertos II", "EXP-II", 5);
    public static Materia Expertos3 = new Materia(MateriasEspecialesIds.Expertos3, 3,"Expertos III", "EXP-III", 5);

    public static Materia Arte1 = new Materia(MateriasEspecialesIds.Arte1,1, "Arte I", "ART-I", 2);
    public static Materia Arte2 = new Materia(MateriasEspecialesIds.Arte2, 2,"Arte II", "ART-II", 2);
    public static Materia Arte3 = new Materia(MateriasEspecialesIds.Arte3, 3, "Arte III", "ART-III", 2);

    public static IReadOnlyCollection<Materia> All => new List<Materia>
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

    }.AsReadOnly();

}
