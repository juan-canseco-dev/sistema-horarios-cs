using ReaLTaiizor.Forms;
using SistemaHorarios.Aplicacion.Maestros;
using SistemaHorarios.Aplicacion.MayasCurriculares;
using SistemaHorarios.Dominio.Enums;

namespace Presentacion.Horarios
{
    public partial class AsignarHoraForm : MaterialForm
    {
        private readonly IMaestroService _maestroService;
        private readonly IMayaCurricularService _mayaService;
        public AsignarHoraViewModel? Model { get; set; }

        private List<MaestroResponse>? Maestros { get; set; }

        private List<MateriaResponse>? Materias { get; set; }

        public Action<HoraControlViewModel>? RefreshHora { get; set; } 

        public AsignarHoraForm(
            IMaestroService maestroService,
            IMayaCurricularService mayaService)
        {
            InitializeComponent();
            _maestroService = maestroService;
            _mayaService = mayaService;
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

        private async void GetMaterias()
        {
            var grupo = Model?.Grupo;
            var result = await _mayaService.GetByGradoAsync(grupo?.Grado);
            var materias = result.Value.Materias;

            var materiasDictionary = materias?.ToDictionary(k => k.Id, v => v.HorasSemanales);

            var selectedMaterias = Model!.Models!
                .SelectMany(m => m.Items!.Values.ToList())
                .Where(m => m != null)
                .Select(m => m?.Materia)
                .ToList();

            selectedMaterias.ForEach(m =>
            {
                int numHoras = materiasDictionary![m!.Id] - 1;
                materiasDictionary![m!.Id] = numHoras;
            });

            Materias = materias!
                .Where(m => materiasDictionary![m.Id] > 0)
                .ToList();

            Materias.ForEach(m => m.Descripcion = $"{m.Codigo} | {m.Nombre} | {materiasDictionary![m.Id]} Horas Disponibles");

            MateriasComboBox.ValueMember = "Id";
            MateriasComboBox.DisplayMember = "Descripcion";
            MateriasComboBox.DataSource = Materias;

        }

        private void AsignarHoraForm_Load(object sender, EventArgs e)
        {
            SetTitles();
            GetMaestros();
            GetMaterias();
        }

        private void asignarHoraButton_Click(object sender, EventArgs e)
        {
            if (MaestroComboBox.SelectedIndex < 0 || MateriasComboBox.SelectedIndex < 0)
                return;

            var maestro = (MaestroResponse)MaestroComboBox.SelectedItem;
            var materia = (MateriaResponse)MateriasComboBox.SelectedItem;

            var hora = Model?.Models?.FirstOrDefault(h => h?.Hora?.Id == Model.HoraId);
            hora!.Items![Model!.Dia] = new HorarioItemViewModel
            {
                Maestro = maestro,
                Materia = materia
            };
            RefreshHora(hora);
            this.Close();
        }
    }
}
