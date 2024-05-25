using ReaLTaiizor.Forms;
using SistemaHorarios.Aplicacion.Grupos;
using SistemaHorarios.Aplicacion.Horarios;
using SistemaHorarios.Aplicacion.Maestros;
using SistemaHorarios.Aplicacion.MayasCurriculares;
namespace Presentacion.Horarios
{
    public partial class AsignarHorarioForm : MaterialForm
    {
        private readonly IHorarioService _horarioService;
        private readonly IMayaCurricularService _mayaService;
        private readonly IGrupoService _grupoService;
        private readonly IMaestroService _maestroService;

        public int GrupoId { get; set; }

        private HorarioResponse? Horario { get; set; }
        public AsignarHorarioForm(IHorarioService horarioService,
            IMayaCurricularService mayaService,
            IGrupoService grupoService,
            IMaestroService maestroService)
        {
            InitializeComponent();
            _horarioService = horarioService;
            _mayaService = mayaService;
            _grupoService = grupoService;
            _maestroService = maestroService;
        }

        private void AsignarHorarioForm_Load(object sender, EventArgs e)
        {
            GetHorario();
            SetTitle();
            BuildGrid();
        }

        private async void GetHorario()
        {
            PanelGrid.Controls.Clear();
            var result = await _horarioService.GetByGrupoAsync(GrupoId);
            Horario = result.Value;
        }

        private void BuildGrid()
        {
            var horas = SistemaHorarios.Dominio.Shared.Hora.All.ToList();

            for (int i = 0; i < horas.Count; i++)
            {
                var horaControl = new HoraControl(horas[i]);
                horaControl.Tag = i;
                horaControl.Dock = DockStyle.Bottom;
                PanelGrid.Controls.Add(horaControl);
            }
        }

        private void SetTitle()
        {
            Text = $"Asignar Horario - {Horario?.Grupo?.Grado} Grado";
        }

    }
}
