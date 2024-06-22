namespace SistemaHorarios.Dominio.Maestros
{
    public static class MaestrosEspeciales
    {
        public static Maestro Ingles1 = new Maestro(MaestrosEspecialesIds.Ingles1, "Maestros", "Ingles I");
        public static Maestro Ingles2 = new Maestro(MaestrosEspecialesIds.Ingles2, "Maestros", "Ingles II");
        public static Maestro Ingles3 = new Maestro(MaestrosEspecialesIds.Ingles3, "Maestros", "Ingles III");

        public static Maestro Expertos1 = new Maestro(MaestrosEspecialesIds.Expertos1, "Maestros", "Expertos I");
        public static Maestro Expertos2 = new Maestro(MaestrosEspecialesIds.Expertos2, "Maestros", "Expertos II");
        public static Maestro Expertos3 = new Maestro(MaestrosEspecialesIds.Expertos3, "Maestros", "Expertos III");

        public static Maestro Arte1 = new Maestro(MaestrosEspecialesIds.Arte1, "Maestros", "Arte I");
        public static Maestro Arte2 = new Maestro(MaestrosEspecialesIds.Arte2, "Maestros", "Arte II");
        public static Maestro Arte3 = new Maestro(MaestrosEspecialesIds.Arte3, "Maestros", "Arte III");

        public static IReadOnlyCollection<Maestro> All => new List<Maestro>
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
}
