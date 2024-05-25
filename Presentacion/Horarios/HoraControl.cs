using ReaLTaiizor.Controls;
using SistemaHorarios.Dominio.Enums;

namespace Presentacion.Horarios
{
    public partial class HoraControl : UserControl
    {

        private HoraControlViewModel? _model;

        private HoraControlViewModel? Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
                SetHoraText();
                SetReceso();
                InitButtonsText();
            }
        }

        private void SetHoraText()
        {
            HoraLabel.Text = $"{Model!.Hora!.Inicio.ToString(@"h\:mm")} - {Model.Hora.Fin.ToString(@"h\:mm")}";
        }

        private void SetReceso()
        {
            if (_model?.Hora?.EsReceso == true)
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

        private void InitButtonsText()
        {
            if (Model?.Hora?.EsReceso == true)
            {
                return;
            }

            if (Model?.Items?.Count > 0)
            {
                SetButtonToAsignado(Dia.Lunes, AsignarLunesButton);
                SetButtonToAsignado(Dia.Martes, AsignarMartesButton);
                SetButtonToAsignado(Dia.Miercoles, AsignarHoraMiercolesButton);
                SetButtonToAsignado(Dia.Jueves, AsignarHoraJuevesButton);
                SetButtonToAsignado(Dia.Viernes, AsignarHoraViernesButton);
            }
        }


        private void SetButtonToAsignado(Dia dia, MaterialButton button)
        {
            var item = Model?.Items?[dia];

            if (item is null)
                return;

            var materia = item?.Materia;
            var maestro = item?.Maestro;

            var message = $"{materia?.Nombre} ({materia?.Codigo}) - {maestro?.Nombres} {maestro?.Apellidos}";
            button.Text = message;
            button.Type = MaterialButton.MaterialButtonType.Contained;
        }

        public HoraControl(HoraControlViewModel vm)
        {
            InitializeComponent();
            Model = vm;
        }

        private void AsignarLunesButton_Click(object sender, EventArgs e)
        {
            if (Model?.Hora?.EsReceso == true)
                return;

            var item = Model?.Items?[Dia.Lunes];

            if (item is null) return;
        }

        private void AsignarMartesButton_Click(object sender, EventArgs e)
        {

            if (Model?.Hora?.EsReceso == true)
                return;

            var item = Model?.Items?[Dia.Martes];

            if (item is null) return;
        }

        private void AsignarHoraMiercolesButton_Click(object sender, EventArgs e)
        {

            if (Model?.Hora?.EsReceso == true)
                return;

            var item = Model?.Items?[Dia.Miercoles];

            if (item is null) return;
        }

        private void AsignarHoraJuevesButton_Click(object sender, EventArgs e)
        {

            if (Model?.Hora?.EsReceso == true)
                return;

            var item = Model?.Items?[Dia.Jueves];

            if (item is null) return;
        }

        private void AsignarHoraViernesButton_Click(object sender, EventArgs e)
        {

            if (Model?.Hora?.EsReceso == true)
                return;

            var item = Model?.Items?[Dia.Viernes];

            if (item is null)
            {
                return;
            }

            if (item is not null)
            {
                return;
            }
        }

    }
}
