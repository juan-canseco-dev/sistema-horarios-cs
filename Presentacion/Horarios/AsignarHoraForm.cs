using ReaLTaiizor.Forms;
using SistemaHorarios.Aplicacion.Horarios;
using SistemaHorarios.Aplicacion.Maestros;
using SistemaHorarios.Aplicacion.MayasCurriculares;
using SistemaHorarios.Dominio.Enums;
using SistemaHorarios.Dominio.Horarios;

namespace Presentacion.Horarios
{
    public partial class AsignarHoraForm : MaterialForm
    {
        private readonly IMaestroService _maestroService;
        private readonly IMayaCurricularService _mayaService;
        private readonly IHorarioService _horarioService;

        public AsignarHoraViewModel? Model { get; set; }

        public AsignarHoraForm(IMaestroService maestroService, IMayaCurricularService mayaService, IHorarioService horarioService)
        {
            InitializeComponent();
            _maestroService = maestroService;
            _mayaService = mayaService;
            _horarioService = horarioService;
        }

        private void SetTitles()
        {
            var grupo = Model?.HoraModel?.Grupo;
            Grado grado = grupo!.Grado ?? default;
            Text = $"Asignar Hora - {(int)grado}°{grupo.Nombre}";

            DiaTextBox.Text = $"{Model?.Dia}";
            DiaTextBox.Enabled = false;

            HoraTextBox.Text = $"{Model?.HoraModel?.Hora?.Inicio.ToString(@"h\:mm")} - {Model?.HoraModel?.Hora?.Fin.ToString(@"h\:mm")}";
            HoraTextBox.Enabled = false;
        }


        // Necesito obtener los maestros que no esten asignados en esta hora 
        // Necesito obtener las materias y que me muestre el numero de materias disponibles para asignar


        private void AsignarHoraForm_Load(object sender, EventArgs e)
        {
            SetTitles();
        }

        private void asignarHoraButton_Click(object sender, EventArgs e)
        {

        }
    }
}
