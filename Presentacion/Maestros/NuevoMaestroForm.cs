using ReaLTaiizor.Forms;
using SistemaHorarios.Aplicacion.Maestros;

namespace Presentacion.Maestros
{
    public partial class NuevoMaestroForm : MaterialForm
    {
        private readonly IMaestroService _service;
        public Action? Reload { get; set; }

        public NuevoMaestroForm(IMaestroService service)
        {
            _service = service;
            InitializeComponent();
        }

        private async void GuardarMaestroButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NombresEditText.Text) || 
                string.IsNullOrEmpty(ApellidosEditText.Text))
            {
                return;
            }

            var request = new CrearMaestroRequest(NombresEditText.Text, ApellidosEditText.Text);
            var result = await _service.CreateAsync(request);

            if (result.IsSuccess)
            {
                Reload();
                Clear();
                this.Close();
                return;
            }

            if (result.IsFailure)
            {
                MessageBox.Show(result.Error.Name, result.Error.Code, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
            }


        }

        private void Clear()
        {
            NombresEditText.Clear();
            ApellidosEditText.Clear();
        }
    }
}
