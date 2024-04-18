using SistemaHorarios.Aplicacion.Grupos;
using SistemaHorarios.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Grupos
{
    public partial class EditarGrupoForm : Form
    {
        private readonly IGrupoService _service;

        public int? GrupoId { get; set; }
        public Action? Reload { get; set; }

        public EditarGrupoForm(IGrupoService service)
        {
            _service = service;
            InitializeComponent();
        }

        private async void GetGroup()
        {
            var result = await _service.GetByIdAsync(GrupoId ?? default);
            if (result.IsFailure)
            {
                MessageBox.Show(result.Error.Name, result.Error.Code, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Hide();
                return;
            }

            var grupo = result.Value;
            NombreTextBox.Text = grupo.Nombre;
            PrimeroRadioButton.Checked = grupo.Grado == Grado.Primero;
            SegundoRadioButton.Checked = grupo.Grado == Grado.Segundo;
            TerceroRadioButton.Checked = grupo.Grado == Grado.Tercero;

            PrimeroRadioButton.Enabled = false;
            SegundoRadioButton.Enabled = false;
            TerceroRadioButton.Enabled = false;
        }
        private void EditarGrupoForm_Load(object sender, EventArgs e)
        {
            GetGroup();
        }

        private async void GuardarGrupoButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NombreTextBox.Text))
            {
                return;
            }

            var request = new ActualizarGrupoRequest(
                GrupoId ?? default,
                NombreTextBox.Text
            );

            var result = await _service.UpdateAsync(request);

            if (result.IsSuccess)
            {
                Hide();
                Reload();
                return;
            }

            if (result.IsFailure)
            {
                MessageBox.Show(result.Error.Name, result.Error.Code, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Hide();
                return;
            }
        }
    }
}
