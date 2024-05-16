using ReaLTaiizor.Forms;
using SistemaHorarios.Aplicacion.MayasCurriculares;

namespace Presentacion.Mayas
{
    public partial class MayaDetalleForm : MaterialForm
    {

        private readonly IMayaCurricularService _service;
        public int MayaId { get; set; }

        private MayaCurricularResponse? _maya;

        public Action? ReloadMayas { get; set; }

        public MayaDetalleForm(IMayaCurricularService service)
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
            Text = $"Maya Curricular - {_maya.Grado} Grado";
            GradoLabel.Text = $"Materias - {_maya.Grado} Grado";
            UpdateInfoLabels();
            UpdateMateriasGrid();
        }


        private void UpdateMateriasGrid()
        {
            MateriasGridView.AutoGenerateColumns = false;
            MateriasGridView.DataSource = null;
            MateriasGridView.DataSource = _maya!.Materias;
            MateriasGridView.Refresh();
        }

        private void UpdateInfoLabels()
        {
            var numMaterias = _maya!.Materias == null ? 0 : _maya!.Materias.Count();
            var numHoras = _maya.Materias == null ? 0 : _maya.Materias.Sum(m => m.HorasSemanales);
            NumeroMateriasLabel.Text = $"{numMaterias} Materias";
            NumeroHorasLabel.Text = $"{numHoras} Horas Semanales";
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pronto Joven :)");
        }
    }
}
