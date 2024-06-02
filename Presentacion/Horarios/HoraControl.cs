using ReaLTaiizor.Controls;
using SistemaHorarios.Dominio.Enums;

namespace Presentacion.Horarios
{
    public partial class HoraControl : UserControl
    {

        private HoraControlViewModel? _model;

        public HoraControlViewModel? Model
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

        public Action<Dia,int>? OpenAsignarHora { get; set; }
        public Action<HoraControlViewModel>? RefreshModel { get; set; }

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
                SetButtons(Dia.Lunes, AsignarLunesButton);
                SetButtons(Dia.Martes, AsignarMartesButton);
                SetButtons(Dia.Miercoles, AsignarHoraMiercolesButton);
                SetButtons(Dia.Jueves, AsignarHoraJuevesButton);
                SetButtons(Dia.Viernes, AsignarHoraViernesButton);
            }
        }


        private void SetButtons(Dia dia, MaterialButton button)
        {
            var item = Model?.Items?[dia];

            if (item is null)
            {
                button.Text = $"ASIGNAR HORA {dia.ToString().ToUpper()}";
                button.Type = MaterialButton.MaterialButtonType.Outlined;
                return;
            }

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

        private void QuitarHora(Dia dia)
        {
            var dialog = MessageBox.Show("¿Deseas quitar la hora seleccionada?", "Quitar Hora", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Model!.Items![dia] = null;
                RefreshModel!(Model);
            }
        }

        private void AsignarLunesButton_Click(object sender, EventArgs e)
        {
            if (Model?.Hora?.EsReceso == true)
                return;

            var item = Model?.Items?[Dia.Lunes];
            if (item is null)
            {
                OpenAsignarHora!(Dia.Lunes, Model!.Hora!.Id);
                return;
            }

            if (item is not null)
            {
                QuitarHora(Dia.Lunes);
                return;
            }
        }

        private void AsignarMartesButton_Click(object sender, EventArgs e)
        {

            if (Model?.Hora?.EsReceso == true)
                return;

            var item = Model?.Items?[Dia.Martes];

            if (item is null)
            {
                OpenAsignarHora!(Dia.Martes, Model!.Hora!.Id);
                return;
            }

            if (item is not null)
            {
                QuitarHora(Dia.Martes);
                return;
            }
        }

        private void AsignarHoraMiercolesButton_Click(object sender, EventArgs e)
        {

            if (Model?.Hora?.EsReceso == true)
                return;

            var item = Model?.Items?[Dia.Miercoles];

            if (item is null)
            {
                OpenAsignarHora!(Dia.Miercoles, Model!.Hora!.Id);
                return;
            }

            if (item is not null)
            {
                QuitarHora(Dia.Miercoles);
                return;
            }
        }

        private void AsignarHoraJuevesButton_Click(object sender, EventArgs e)
        {

            if (Model?.Hora?.EsReceso == true)
                return;

            var item = Model?.Items?[Dia.Jueves];

            if (item is null)
            {
                OpenAsignarHora!(Dia.Jueves, Model!.Hora!.Id);
                return;
            }

            if (item is not null)
            {
                QuitarHora(Dia.Jueves);
                return;
            }
        }

        private void AsignarHoraViernesButton_Click(object sender, EventArgs e)
        {

            if (Model?.Hora?.EsReceso == true)
                return;

            var item = Model?.Items?[Dia.Viernes];

            if (item is null)
            {
                OpenAsignarHora!(Dia.Viernes, Model!.Hora!.Id);
                return;
            }

            if (item is not null)
            {
                QuitarHora(Dia.Viernes);
                return;
            }
        }

    }
}
