using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using SistemaHorarios.Aplicacion.Horarios;
using SistemaHorarios.Dominio.Enums;


namespace Presentacion.Horarios
{
    public partial class AsignarHorarioForm : MaterialForm
    {
        private readonly IHorarioService _horarioService;
        private readonly List<HoraControlViewModel> _viewModels = new();

        public int GrupoId { get; set; }

        private HorarioResponse? Horario { get; set; }

        public Action? Reload { get; set; }

        public AsignarHorarioForm(IHorarioService horarioService)
        {
            InitializeComponent();
            _horarioService = horarioService;
        }

        private void AsignarHorarioForm_Load(object sender, EventArgs e)
        {
            GetHorario();
            SetTitle();
        }

        private List<HoraControlViewModel> GetViewModelsListFromHorario(HorarioResponse? horario)
        {
            var horas = SistemaHorarios.Dominio.Shared.Hora.All.ToList();
            return horas.Select(h => new HoraControlViewModel
            {
                Grupo = horario!.Grupo,
                Hora = new HoraResponse(h.Id, h.Inicio, h.Fin, h.EsReceso),
                Items = new Dictionary<Dia, HorarioItemViewModel?>
                {
                    {Dia.Lunes,  GetItemViewModelFromItems(Dia.Lunes, h.Id, horario!.Items)},
                    {Dia.Martes,  GetItemViewModelFromItems(Dia.Martes, h.Id, horario!.Items)},
                    {Dia.Miercoles,  GetItemViewModelFromItems(Dia.Miercoles, h.Id, horario!.Items)},
                    {Dia.Jueves,  GetItemViewModelFromItems(Dia.Jueves, h.Id, horario!.Items)},
                    {Dia.Viernes,  GetItemViewModelFromItems(Dia.Viernes, h.Id, horario!.Items)}
                }
            }).ToList();
        }


        private HorarioItemViewModel? GetItemViewModelFromItems(Dia dia, int horaId, List<HorarioItemResponse>? items)
        {
            var item = items?.FirstOrDefault(i => i.Dia == dia && i.Hora!.Id == horaId);
            if (item is null) return null;
            return new HorarioItemViewModel
            {
                Maestro = item!.Maestro,
                Materia = item!.Materia
            };
        }

        private async void GetHorario()
        {
            PanelGrid.Controls.Clear();
            _viewModels.Clear();

            var result = await _horarioService.GetByGrupoAsync(GrupoId);
            Horario = result.Value;

            _viewModels.AddRange(GetViewModelsListFromHorario(Horario));

            for (int i = 0; i < _viewModels.Count; i++)
            {
                var viewModel = _viewModels[i];
                var horaControl = new HoraControl(viewModel);
                horaControl.OpenAsignarHora += OpenAsignarHora;
                horaControl.Tag = viewModel?.Hora?.Id;
                horaControl.Dock = DockStyle.Bottom;
                PanelGrid.Controls.Add(horaControl);
            }
        }

        private void SetTitle()
        {
            var grupo = Horario?.Grupo;
            Grado grado = grupo!.Grado ?? default;
            Text = $"Asignar Horario - {(int)grado}°{grupo.Nombre}";
        }

        private void DescatarButton_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("¿Deseas descartar los cambios realizados en el horario actual?", "Descartar Cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
                return;
            }
        }

        private void EliminarHorarioButton_Click(object sender, EventArgs e)
        {
            var grupo = Horario?.Grupo;
            Grado grado = grupo!.Grado ?? default;
            var message = $"Deseas eliminar la asignación de horarios para el grupo {(int)grado}°{grupo.Nombre}";
            var dialog = MessageBox.Show(message, "Eliminar Horario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Reload();
                return;
            }
        }

        private void AsignarHorarioButton_Click(object sender, EventArgs e)
        {
            List<HoraRequest> items = new List<HoraRequest>();
            foreach(var vm in _viewModels)
            {
                var r = vm?.Items?.Select(m =>
                {
                    return new HoraRequest(m.Key, vm!.Hora!.Id, m!.Value!.Materia!.Id, m!.Value!.Maestro!.Id);
                }).ToList();
            }
        }

        private void RefreshHora(HoraControlViewModel model)
        {
            var control = PanelGrid.Controls
                .Cast<HoraControl>()
                .FirstOrDefault(control => Equals(control.Tag, model?.Hora?.Id));

            control!.Model = model;
        }
        private void OpenAsignarHora(Dia dia, int horaId)
        {
            var form = Program.ServiceProvider.GetRequiredService<AsignarHoraForm>();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.RefreshHora += RefreshHora;
            form.Model = new AsignarHoraViewModel
            {
                Dia = dia,
                HoraId = horaId,
                Models = _viewModels,
                Grupo = Horario?.Grupo
            };
            form.ShowDialog();
        }
    }
}
