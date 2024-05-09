using ReaLTaiizor.Forms;
using SistemaHorarios.Aplicacion.MayasCurriculares;

namespace Presentacion.Mayas
{
    public partial class AsignarMateriasForm : MaterialForm
    {
        private readonly IMayaCurricularService _service;
        public int MayaId { get; set; }

        private MayaCurricularResponse? _maya;

        public AsignarMateriasForm(IMayaCurricularService service)
        {
            _service = service;
            InitializeComponent();
        }

        private void AsignarMateriasForm_Load(object sender, EventArgs e)
        {
            GetMaya();
        }

        private async void GetMaya()
        {
            var result = await _service.GetByIdAsync(MayaId);
            _maya = result.Value;
            GradoLabel.Text = $"Materias - {_maya.Grado} Grado";
            UpdateInfoLabels();
        }

        private void UpdateInfoLabels()
        {
            var numMaterias = _maya!.Materias == null ? 0 : _maya.Materias.Count();
            var numHoras = _maya!.Materias == null ? 0 : _maya.Materias.Sum(m => m.HorasSemanales);
            NumeroMateriasLabel.Text = $"{numMaterias} Materias";
            NumeroHorasLabel.Text = $"{numHoras} Horas Semanales";
        }

    }
}
