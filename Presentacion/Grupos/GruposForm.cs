using Microsoft.Extensions.DependencyInjection;
using SistemaHorarios.Aplicacion.Grupos;
using ReaLTaiizor.Forms;

namespace Presentacion.Grupos
{
    public partial class GruposForm : MaterialForm
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

        private async void GetGrupos()
        {
            GruposGrid.AutoGenerateColumns = false;
            var request = new GetGruposRequest();
            var result = await _service.GetAllAsync(request);
            GruposGrid.DataSource = result.Value;
            GruposGrid.Refresh();
        }
        private void CrearGrupoButton_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<NuevoGrupoForm>();
            form.Reload += GetGrupos;
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void GruposGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                switch (e.ColumnIndex)
                {
                    case 3:
                        DeleteGrupos_Event(senderGrid, e);
                    break;
                }
            }
        }

        private async void DeleteGrupos_Event(DataGridView senderGrid, DataGridViewCellEventArgs e)
        {
            var dialogResult = MessageBox.Show("¿Deseas eliminar al Grupo seleccionado?", "Eliminar Grupo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int grupoId = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;
                var result = await _service.DeleteAsync(new EliminarGrupoRequest(grupoId));
                if (result.IsSuccess)
                {
                    GetGrupos();
                    return;
                }
                MessageBox.Show(result.Error.Name, result.Error.Code, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
