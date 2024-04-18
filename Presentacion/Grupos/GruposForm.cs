using Microsoft.Extensions.DependencyInjection;
using SistemaHorarios.Aplicacion.Grupos;

namespace Presentacion.Grupos
{
    public partial class GruposForm : Form
    {
        private readonly IGrupoService _service;
        private int _selectedRowIndex = -1;

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

        private async void DeleteGrupo()
        {
            var dialogResult = MessageBox.Show("¿Deseas eliminar al Grupo seleccionado?", "Eliminar Grupo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int grupoId = (int)GruposGrid.Rows[_selectedRowIndex].Cells["Id"].Value;
                var result = await _service.DeleteAsync(new EliminarGrupoRequest(grupoId));
                if (result.IsSuccess)
                {
                    GetGrupos();
                    return;
                }
                MessageBox.Show(result.Error.Name, result.Error.Code, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GruposGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GruposGrid.CurrentRow.Selected = true;
            if (e.RowIndex >= 0)
            {
                _selectedRowIndex = e.RowIndex;
                EliminarGrupoButton.Enabled = true;
                ActualizaeGrupoButton.Enabled = true;
            }
        }

        private void EliminarGrupoButton_Click(object sender, EventArgs e)
        {
            DeleteGrupo();
        }

        private void ActualizaeGrupoButton_Click(object sender, EventArgs e)
        {
            int grupoId = (int)GruposGrid.Rows[_selectedRowIndex].Cells["Id"].Value;
            var form = Program.ServiceProvider.GetRequiredService<EditarGrupoForm>();
            form.Reload += GetGrupos;
            form.GrupoId = grupoId;
            form.Show();
        }
    }
}
