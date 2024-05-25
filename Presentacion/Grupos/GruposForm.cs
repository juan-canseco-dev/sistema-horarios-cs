using Microsoft.Extensions.DependencyInjection;
using SistemaHorarios.Aplicacion.Grupos;
using ReaLTaiizor.Forms;
using Presentacion.Horarios;

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
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;

            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DeleteGrupos_Event(senderGrid, e);
            }

            if (senderGrid.Columns[e.ColumnIndex].Name == "VerHorario")
            {
                VerHorario_Event(senderGrid, e);
            }

            if (senderGrid.Columns[e.ColumnIndex].Name == "AsignarHorario")
            {
                AsignarHorario_Event(senderGrid, e);
            }
        }

        private bool IsHorarioAsignado(int rowIndex) => (bool)GruposGrid.Rows[rowIndex].Cells["HorarioAsignado"].Value;

        private async void DeleteGrupos_Event(DataGridView senderGrid, DataGridViewCellEventArgs e)
        {
            var dialogResult = MessageBox.Show("¿Deseas eliminar al Grupo seleccionado?", "Eliminar Grupo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int grupoId = (int)senderGrid.Rows[e.RowIndex].Cells["Id"].Value;
                var result = await _service.DeleteAsync(new EliminarGrupoRequest(grupoId));
                if (result.IsSuccess)
                {
                    GetGrupos();
                    return;
                }
                MessageBox.Show(result.Error.Name, result.Error.Code, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerHorario_Event(DataGridView senderGrid, DataGridViewCellEventArgs e)
        {
            int grupoId = (int)senderGrid.Rows[e.RowIndex].Cells["Id"].Value;
        }

        private void AsignarHorario_Event(DataGridView senderGrid, DataGridViewCellEventArgs e)
        {
            int grupoId = (int)senderGrid.Rows[e.RowIndex].Cells["Id"].Value;
            var form = Program.ServiceProvider.GetRequiredService<AsignarHorarioForm>();
            form.GrupoId = grupoId;
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

  

        private void GruposGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (GruposGrid.Columns[e.ColumnIndex].Name == "VerHorario")
            {
                if (!IsHorarioAsignado(e.RowIndex))
                {
                    var cell = (DataGridViewButtonCell)GruposGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    cell.FlatStyle = FlatStyle.Flat;
                }
            }

            if (GruposGrid.Columns[e.ColumnIndex].Name == "AsignarHorario")
            {
                e.Value = IsHorarioAsignado(e.RowIndex) ? "Editar Horario" : "Asignar Horario";
            }
        }
    }
}
