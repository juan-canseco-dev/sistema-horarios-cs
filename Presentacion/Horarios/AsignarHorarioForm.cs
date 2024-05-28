using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using SistemaHorarios.Aplicacion.Grupos;
using SistemaHorarios.Aplicacion.Horarios;
using SistemaHorarios.Aplicacion.Maestros;
using SistemaHorarios.Aplicacion.MayasCurriculares;
using SistemaHorarios.Dominio.Enums;
using SistemaHorarios.Dominio.Grupos;

namespace Presentacion.Horarios
{
    public partial class AsignarHorarioForm : MaterialForm
    {
        private readonly IHorarioService _horarioService;
        private readonly List<HoraControlViewModel> _viewModels = new();

        public int GrupoId { get; set; }

        private HorarioResponse? Horario { get; set; }
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
                horaControl.Tag = i;
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

        }

        private void EliminarHorarioButton_Click(object sender, EventArgs e)
        {

        }

        private void AsignarHorarioButton_Click(object sender, EventArgs e)
        {
            GetHorario();
        }


        private void OpenAsignarHora(Dia dia, int horaId)
        {
            var form = Program.ServiceProvider.GetRequiredService<AsignarHoraForm>();
            form.StartPosition = FormStartPosition.CenterScreen;
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
