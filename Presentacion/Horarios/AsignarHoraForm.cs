using ReaLTaiizor.Forms;
using SistemaHorarios.Aplicacion.Horarios;
using SistemaHorarios.Aplicacion.Maestros;
using SistemaHorarios.Aplicacion.MayasCurriculares;
using SistemaHorarios.Dominio.Enums;

namespace Presentacion.Horarios
{
    public partial class AsignarHoraForm : MaterialForm
    {
        private readonly IMaestroService _maestroService;
        private readonly IMayaCurricularService _mayaService;
        private readonly IHorarioService _horarioService;

        public AsignarHoraViewModel? Model { get; set; }

        private List<MaestroResponse>? Maestros { get; set; }

        public AsignarHoraForm(
            IMaestroService maestroService,
            IMayaCurricularService mayaService, 
            IHorarioService horarioService)
        {
            InitializeComponent();
            _maestroService = maestroService;
            _mayaService = mayaService;
            _horarioService = horarioService;
        }

        private void SetTitles()
        {
            var grupo = Model?.Grupo;
            Grado grado = grupo!.Grado ?? default;
            Text = $"Asignar Hora - {(int)grado}°{grupo.Nombre}";

            var hora = Model?.Models?.FirstOrDefault(h => h?.Hora?.Id == Model.HoraId)?.Hora;

            DiaTextBox.Text = $"{Model?.Dia}";
            DiaTextBox.Enabled = false;

            HoraTextBox.Text = $"{hora?.Inicio.ToString(@"h\:mm")} - {hora?.Fin.ToString(@"h\:mm")}";
            HoraTextBox.Enabled = false;
        }

        private async void GetMaestros()
        {
            var hora = Model?.Models?.FirstOrDefault(h => h?.Hora?.Id == Model.HoraId)?.Hora;
            var result = await _maestroService.GetAllUnassignedByHour(hora!.Id);
            Maestros = result.Value;
            MaestroComboBox.ValueMember = "Id";
            MaestroComboBox.DisplayMember = "NombreCompleto";
            MaestroComboBox.DataSource = Maestros;
        }

        // Necesito obtener los maestros que no esten asignados en esta hora 
        // Necesito obtener las materias y que me muestre el numero de materias disponibles para asignar


        private void AsignarHoraForm_Load(object sender, EventArgs e)
        {
            SetTitles();
            GetMaestros();
        }

        private void asignarHoraButton_Click(object sender, EventArgs e)
        {

        }
    }
}
