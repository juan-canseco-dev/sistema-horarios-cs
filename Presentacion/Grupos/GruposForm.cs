using Microsoft.Extensions.DependencyInjection;
using SistemaHorarios.Aplicacion.Grupos;

namespace Presentacion.Grupos
{
    public partial class GruposForm : Form
    {
        private readonly IGrupoService _service;

        public GruposForm(IGrupoService service)
        {
            _service = service;
            InitializeComponent();
        }

        private void GruposForm_Load(object sender, EventArgs e)
        {
            GetGrupos();
        }

        private void NuevoGrupoButton_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<NuevoGrupoForm>();
            form.Reload += GetGrupos;
            form.Show();
        }

        private async void GetGrupos()
        {
            var request = new GetGruposRequest();
            var result = await _service.GetAllAsync(request);
            GruposGrid.AutoGenerateColumns = false;
            GruposGrid.DataSource = result.Value;
            GruposGrid.Refresh();
        }
    }
}
