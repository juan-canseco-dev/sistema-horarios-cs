using SistemaHorarios.Aplicacion.Horarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Horarios
{
    public partial class HoraControl : UserControl
    {
        private bool IsReceso => Hora!.Hora!.EsReceso;
        private HorarioItemResponse? Hora { get; set; }
        public HoraControl()
        {
            InitializeComponent();
        }

        #region Asignar Horas Click Events
        private void AsignarLunesButton_Click(object sender, EventArgs e)
        {
            if (IsReceso) return;

        }

        private void AsignarMartesButton_Click(object sender, EventArgs e)
        {
            if (IsReceso) return;
        }

        private void AsignarHoraMiercolesButton_Click(object sender, EventArgs e)
        {
            if (IsReceso) return;
        }

        private void AsignarHoraJuevesButton_Click(object sender, EventArgs e)
        {
            if (IsReceso) return;
        }

        private void AsignarHoraViernesButton_Click(object sender, EventArgs e)
        {
            bool isSelected = false;
            if (IsReceso) return;

            if (isSelected)
            {
                return;
            }
        }
        #endregion

        public HorarioItemResponse GetHoraItem()
        {
            // R E C E S O
            return null;
        }
    }
}
