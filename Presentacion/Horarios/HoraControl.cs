using SistemaHorarios.Aplicacion.Horarios;

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
            if (IsReceso) return;
        }
    }
}
