using SistemaHorarios.Aplicacion.Grupos;

namespace Presentacion.Grupos
{
    public partial class GruposForm : Form
    {

        private readonly NuevoGrupoForm _nuevoGrupoForm;
        private readonly IGrupoService _service;

        public GruposForm(NuevoGrupoForm nuevoGrupoForm, IGrupoService service)
        {
            _nuevoGrupoForm = nuevoGrupoForm;
            _service = service;
            InitializeComponent();
        }

        private async void GruposForm_Load(object sender, EventArgs e)
        {
            var request = new GetGruposRequest();
            var result = await _service.GetAllAsync(request);
            GruposGrid.AutoGenerateColumns = false;
            GruposGrid.DataSource = result.Value;
            GruposGrid.Refresh();
        }

        private void NuevoGrupoButton_Click(object sender, EventArgs e)
        {
            _nuevoGrupoForm.Show();
        }
    }
}
