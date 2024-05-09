using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Update;
using Microsoft.Extensions.DependencyInjection;
using Presentacion.Utils;
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

        private void MayasGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var asignada = (bool)MayasGrid.Rows[e.RowIndex].Cells["ColAsignada"].Value;
            if (MayasGrid.Columns[e.ColumnIndex].Name == "ColVer")
            {
                var buttonCell = (DataGridViewDisableButtonCell)MayasGrid.Rows[e.RowIndex].Cells["ColVer"];
                buttonCell.Enabled = asignada;
            }


            if (MayasGrid.Columns[e.ColumnIndex].Name == "ColEditar")
            {
                e.Value = asignada ? "Editar" : "Asignar";
            }
        }

        private void MayasGrid_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (MayasGrid.IsCurrentCellDirty)
            {
                MayasGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void MayasGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;

            var mayaId = (int)MayasGrid.Rows[e.RowIndex].Cells[0].Value;

            if (MayasGrid.Columns[e.ColumnIndex].Name == "ColVer")
            {
                var buttonCell = (DataGridViewDisableButtonCell)MayasGrid.Rows[e.RowIndex].Cells["ColVer"];
                if (buttonCell.Enabled)
                {
                    MessageBox.Show("Enabled");
                }
            }


            if (MayasGrid.Columns[e.ColumnIndex].Name == "ColEditar")
            {
                MessageBox.Show(mayaId.ToString());
                var form = Program.ServiceProvider.GetRequiredService<AsignarMateriasForm>();
                form.MayaId = mayaId;
                form.StartPosition = FormStartPosition.WindowsDefaultBounds;
                form.ShowDialog();
            }

            Action A()
        }
    }
}
