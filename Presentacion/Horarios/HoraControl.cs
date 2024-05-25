using SistemaHorarios.Dominio.Shared;

namespace Presentacion.Horarios
{
    public partial class HoraControl : UserControl
    {
        private Hora? _hora;

        public Hora? Hora
        {
            get
            {
                return _hora;
            }
            set
            {
                _hora = value;
                HoraLabel.Text = $"{Hora!.Inicio.ToString(@"h\:mm")} - {Hora.Fin.ToString(@"h\:mm")}";
                if (_hora!.EsReceso)
                {
                    AsignarLunesButton.Enabled = false;
                    AsignarLunesButton.Text = "Receso";

                    AsignarMartesButton.Enabled = false;
                    AsignarMartesButton.Text = "Receso";

                    AsignarHoraMiercolesButton.Enabled = false;
                    AsignarHoraMiercolesButton.Text = "Receso";

                    AsignarHoraJuevesButton.Enabled = false;
                    AsignarHoraJuevesButton.Text = "Receso";

                    AsignarHoraViernesButton.Enabled = false;
                    AsignarHoraViernesButton.Text = "Receso";

                }
            }
        }

        public HoraControl(Hora hora)
        {
            InitializeComponent();
            Hora = hora;
        }

        private void AsignarLunesButton_Click(object sender, EventArgs e)
        {

        }

        private void AsignarMartesButton_Click(object sender, EventArgs e)
        {
        }

        private void AsignarHoraMiercolesButton_Click(object sender, EventArgs e)
        {

        }

        private void AsignarHoraJuevesButton_Click(object sender, EventArgs e)
        {

        }

        private void AsignarHoraViernesButton_Click(object sender, EventArgs e)
        {

        }
    }
}
