using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using SistemaHorarios.Aplicacion.MayasCurriculares;

namespace Presentacion.Mayas
{
    public partial class MayasForm : MaterialForm
    {
        private readonly IMayaCurricularService _service;
        public MayasForm(IMayaCurricularService service)
        {
            _service = service;
            InitializeComponent();
        }

        private async void GetMayas()
        {
            MayasGrid.AutoGenerateColumns = false;
            var result = await _service.GetAllAsync();
            MayasGrid.DataSource = result.Value;
            MayasGrid.Refresh();
        }

        private void MayasForm_Load(object sender, EventArgs e)
        {
            GetMayas();
        }


        private bool IsMayaAsignada(int rowIndex) => (bool)MayasGrid.Rows[rowIndex].Cells["ColAsignada"].Value;

        private void MayasGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (MayasGrid.Columns[e.ColumnIndex].Name == "ColVer")
            {

                if (!IsMayaAsignada(e.RowIndex))
                {
                    var cell  = (DataGridViewButtonCell)MayasGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    cell.FlatStyle = FlatStyle.Flat;
                }
            }


            if (MayasGrid.Columns[e.ColumnIndex].Name == "ColEditar")
            {
                e.Value = IsMayaAsignada(e.RowIndex) ? "Editar" : "Asignar";
            }
        }

        private void MayasGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;

            var mayaId = (int)MayasGrid.Rows[e.RowIndex].Cells[0].Value;

            if (MayasGrid.Columns[e.ColumnIndex].Name == "ColVer")
            {
                if (IsMayaAsignada(e.RowIndex))
                {
                    var form = Program.ServiceProvider.GetRequiredService<MayaDetalleForm>();
                    form.MayaId = mayaId;
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.ShowDialog();
                }
            }


            if (MayasGrid.Columns[e.ColumnIndex].Name == "ColEditar")
            {
                var form = Program.ServiceProvider.GetRequiredService<AsignarMateriasForm>();
                form.MayaId = mayaId;
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }

        }
    }
}
