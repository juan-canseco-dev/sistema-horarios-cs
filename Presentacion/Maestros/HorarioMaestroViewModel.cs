namespace Presentacion.Maestros
{
    public class HorarioMaestroViewModel
    {
        public string? NombreArchivo { get; set; }
        public string? NombreEscuela { get; set; }
        public string? Subtitulo { get; set; }
        public string? CicloEscolar { get; set; }
        public string? Maestro { get; set; }
        public Dictionary<int, HorarioItemMaestroViewModel> Items { get; set; }
    }
}
