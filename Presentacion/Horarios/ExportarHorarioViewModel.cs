namespace Presentacion.Horarios
{
    public class ExportarHorarioViewModel
    {
        public string? NombreArchivo { get; set; }
        public string? NombreEscuela { get; set; }
        public string? Subtitulo { get; set; }
        public string? CicloEscolar { get; set; }
        public string? Grupo { get; set; }
        public List<ExportarHorarioItemViewModel>? Items { get; set; }

    }
}
