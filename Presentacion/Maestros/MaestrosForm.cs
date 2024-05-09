using SistemaHorarios.Aplicacion.Maestros;
using ReaLTaiizor.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace Presentacion.Maestros
{
    public partial class MaestrosForm : MaterialForm
    {
        private readonly IMaestroService _service;

        public MaestrosForm(IMaestroService service)
        {
            _service = service;
            InitializeComponent();
        }

        private void MaestrosForm_Load(object sender, EventArgs e)
        {
            GetMaestros();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            var senderTextBox = (TextBox)sender;
            GetMaestros(senderTextBox.Text);
        }

        private void Reload()
        {
            SearchTextBox.Clear();
            GetMaestros();
        }

        private async void GetMaestros(string? filtro = null)
        {
            MaestrosGrid.AutoGenerateColumns = false;
            var request = new GetMaestrosRequest { Filtro = filtro };
            var result = await _service.GetAllAsync(request);
            MaestrosGrid.DataSource = result.Value;
            MaestrosGrid.Refresh();
        }

        private void CrearMaestroButton_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<NuevoMaestroForm>();
            form.Reload += Reload;
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void MaestrosGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                switch (e.ColumnIndex)
                {
                    case 3:
                        DeleteMaestro_Event(senderGrid, e);
                        break;
                }
            }
        }

        private async void DeleteMaestro_Event(DataGridView senderGrid, DataGridViewCellEventArgs e)
        {
            var dialogResult = MessageBox.Show("¿Deseas eliminar al Maestro seleccionado?", "Eliminar Maestro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int maestroId = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;
                var result = await _service.DeleteAsync(new EliminarMaestroRequest(maestroId));
                if (result.IsSuccess)
                {
                    Reload();
                    return;
                }
                MessageBox.Show(result.Error.Name, result.Error.Code, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchTextBox_TrailingIconClick(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
        }
    }
}
