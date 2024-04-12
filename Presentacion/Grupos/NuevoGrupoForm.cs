using SistemaHorarios.Aplicacion.Grupos;
using SistemaHorarios.Dominio.Enums;

namespace Presentacion.Grupos
{
    public partial class NuevoGrupoForm : Form
    {
        private readonly IGrupoService _service;
        public Action? Reload { get; set; }
        public NuevoGrupoForm(IGrupoService service)
        {
            _service = service;
            InitializeComponent();
        }

        private async void GuardarGrupoButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NombreTextBox.Text) || GetGrado() is null)
            {
                return;
            }

            var request = new CrearGrupoRequest(
                NombreTextBox.Text,
                GetGrado() ?? default
            );

            var result = await _service.CreateAsync(request);

            if (result.IsSuccess)
            {
                this.Hide();
                Reload();
                Clear();
                return;
            }

            if (result.IsFailure)
            {
                MessageBox.Show(result.Error.Name, result.Error.Code, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                return;
            }
        }

        private Grado? GetGrado()
        {
            if (PrimeroRadioButton.Checked)
                return Grado.Primero;
            if (SegundoRadioButton.Checked)
                return Grado.Segundo;
            if (TerceroRadioButton.Checked)
                return Grado.Tercero;
            return null;
        }

        public void Clear()
        {
            NombreTextBox.Clear();
            PrimeroRadioButton.Checked = false;
            SegundoRadioButton.Checked = false;
            TerceroRadioButton.Checked = false;
        }
    }
}
