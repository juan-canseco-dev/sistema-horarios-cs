using Microsoft.Extensions.DependencyInjection;
using SistemaHorarios.Aplicacion.Grupos;
using ReaLTaiizor.Forms;
using Presentacion.Horarios;
using SistemaHorarios.Aplicacion.Horarios;
using SistemaHorarios.Dominio.Enums;
using OfficeOpenXml;
using System.Diagnostics;
using SistemaHorarios.Dominio.Maestros;

namespace Presentacion.Grupos
{
    public partial class GruposForm : MaterialForm
    {
        private readonly IGrupoService _grupoService;
        private readonly IHorarioService _horarioService;

        public GruposForm(IGrupoService grupoService, IHorarioService horarioService)
        {
            _grupoService = grupoService;
            _horarioService = horarioService;
            InitializeComponent();
        }

        private void GruposForm_Load(object sender, EventArgs e)
        {
            GetGrupos();
        }

        private async void GetGrupos()
        {
            GruposGrid.AutoGenerateColumns = false;
            var request = new GetGruposRequest();
            var result = await _grupoService.GetAllAsync(request);
            GruposGrid.DataSource = result.Value;
            GruposGrid.Refresh();
        }
        private void CrearGrupoButton_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<NuevoGrupoForm>();
            form.Reload += GetGrupos;
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void GruposGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;

            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DeleteGrupos_Event(senderGrid, e);
            }

            if (senderGrid.Columns[e.ColumnIndex].Name == "Exportar")
            {
                ExportarHorario_Event(senderGrid, e);
            }

            if (senderGrid.Columns[e.ColumnIndex].Name == "AsignarHorario")
            {
                AsignarHorario_Event(senderGrid, e);
            }
        }

        private async void DeleteGrupos_Event(DataGridView senderGrid, DataGridViewCellEventArgs e)
        {
            var dialogResult = MessageBox.Show("¿Deseas eliminar al Grupo seleccionado?", "Eliminar Grupo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int grupoId = (int)senderGrid.Rows[e.RowIndex].Cells["Id"].Value;
                var result = await _grupoService.DeleteAsync(new EliminarGrupoRequest(grupoId));
                if (result.IsSuccess)
                {
                    GetGrupos();
                    return;
                }
                MessageBox.Show(result.Error.Name, result.Error.Code, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ExportarHorario_Event(DataGridView senderGrid, DataGridViewCellEventArgs e)
        {
            if (!IsHorarioAsignado(e.RowIndex)) return;

            int grupoId = (int)senderGrid.Rows[e.RowIndex].Cells["Id"].Value;



            var exportModel = await GetHorarioByGroup(grupoId);

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Especificar el nombre de la carpeta
            string folderName = "Mis-Horarios";

            // Crear la ruta completa de la carpeta
            string folderPath = Path.Combine(desktopPath, folderName);

            // Verificar si la carpeta existe, y si no, crearla
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string fileName = exportModel.NombreArchivo!;

            // Combinar la ruta de la carpeta con el nombre del archivo
            string filePath = Path.Combine(folderPath, fileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                fileStream.Write(Properties.Resources.Horario_Grupos, 0, Properties.Resources.Horario_Grupos.Length);
            }


            var file = new FileInfo(filePath);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var excelPackage = new ExcelPackage(file))
            {

                var workBook = excelPackage.Workbook;
                var workSheet = workBook.Worksheets.First();



                workSheet.Cells["C1:F1"].Value = exportModel.NombreEscuela;
                workSheet.Cells["C2:F2"].Value = exportModel.Subtitulo;
                workSheet.Cells["C3:F3"].Value = exportModel.CicloEscolar;
                workSheet.Cells["C4:F4"].Value = exportModel.Grupo;

                // Primera hora 
                var h1 = exportModel.Items?[0];
                workSheet.Cells["C6"].Value = h1?.Lunes;
                workSheet.Cells["D6"].Value = h1?.Martes;
                workSheet.Cells["E6"].Value = h1?.Miercoles;
                workSheet.Cells["F6"].Value = h1?.Jueves;
                workSheet.Cells["G6"].Value = h1?.Viernes;


                var h2 = exportModel.Items?[1];
                workSheet.Cells["C7"].Value = h2?.Lunes;
                workSheet.Cells["D7"].Value = h2?.Martes;
                workSheet.Cells["E7"].Value = h2?.Miercoles;
                workSheet.Cells["F7"].Value = h2?.Jueves;
                workSheet.Cells["G7"].Value = h2?.Viernes;


                var h3 = exportModel.Items?[2];
                workSheet.Cells["C8"].Value = h3?.Lunes;
                workSheet.Cells["D8"].Value = h3?.Martes;
                workSheet.Cells["E8"].Value = h3?.Miercoles;
                workSheet.Cells["F8"].Value = h3?.Jueves;
                workSheet.Cells["G8"].Value = h3?.Viernes;


                var h4 = exportModel.Items?[3];
                workSheet.Cells["C10"].Value = h4?.Lunes;
                workSheet.Cells["D10"].Value = h4?.Martes;
                workSheet.Cells["E10"].Value = h4?.Miercoles;
                workSheet.Cells["F10"].Value = h4?.Jueves;
                workSheet.Cells["G10"].Value = h4?.Viernes;

                var h5 = exportModel.Items?[4];
                workSheet.Cells["C11"].Value = h5?.Lunes;
                workSheet.Cells["D11"].Value = h5?.Martes;
                workSheet.Cells["E11"].Value = h5?.Miercoles;
                workSheet.Cells["F11"].Value = h5?.Jueves;
                workSheet.Cells["G11"].Value = h5?.Viernes;


                var h6 = exportModel.Items?[5];
                workSheet.Cells["C13"].Value = h6?.Lunes;
                workSheet.Cells["D13"].Value = h6?.Martes;
                workSheet.Cells["E13"].Value = h6?.Miercoles;
                workSheet.Cells["F13"].Value = h6?.Jueves;
                workSheet.Cells["G13"].Value = h6?.Viernes;

                var h7 = exportModel.Items?[6];
                workSheet.Cells["C14"].Value = h7?.Lunes;
                workSheet.Cells["D14"].Value = h7?.Martes;
                workSheet.Cells["E14"].Value = h7?.Miercoles;
                workSheet.Cells["F14"].Value = h7?.Jueves;
                workSheet.Cells["G14"].Value = h7?.Viernes;

                excelPackage.Save();

                var proc = new Process();
                proc.StartInfo = new ProcessStartInfo(filePath)
                {
                    UseShellExecute = true
                };
                proc.Start();
            }
        }

        private void AsignarHorario_Event(DataGridView senderGrid, DataGridViewCellEventArgs e)
        {
            int grupoId = (int)senderGrid.Rows[e.RowIndex].Cells["Id"].Value;
            var form = Program.ServiceProvider.GetRequiredService<AsignarHorarioForm>();
            form.GrupoId = grupoId;
            form.Reload += GetGrupos;
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

  

        private void GruposGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (GruposGrid.Columns[e.ColumnIndex].Name == "Exportar")
            {
                if (!IsHorarioAsignado(e.RowIndex))
                {
                    var cell = (DataGridViewButtonCell)GruposGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    cell.FlatStyle = FlatStyle.Flat;
                }
            }

            if (GruposGrid.Columns[e.ColumnIndex].Name == "AsignarHorario")
            {
                e.Value = IsHorarioAsignado(e.RowIndex) ? "Editar Horario" : "Asignar Horario";
            }
        }

        private bool IsHorarioAsignado(int rowIndex) => (bool)GruposGrid.Rows[rowIndex].Cells["HorarioAsignado"].Value;


        private async Task<HorarioResponse> GetHorarioResponse(int grupoId)
        {
            var horario = await _horarioService.GetByGrupoAsync(grupoId);
            return horario.Value;
        }

        private async Task<GrupoResponse> GetGrupoResponse(int grupoId)
        {
            var grupo = await _grupoService.GetByIdAsync(grupoId);
            return grupo.Value;
        }
        
        private ExportarHorarioItemViewModel ItemResponseToExportarViewModel(SistemaHorarios.Dominio.Shared.Hora hora, List<HorarioItemResponse> items)
        {
            var model = new ExportarHorarioItemViewModel();
            model.Hora = $"{hora.Inicio.ToString(@"h\:mm")} - {hora.Fin.ToString(@"h\:mm")}";


            Dictionary<Dia, HorarioItemResponse?> itemsMap = new Dictionary<Dia, HorarioItemResponse?>();
            
            itemsMap[Dia.Lunes] = items?.FirstOrDefault(i => i.Dia == Dia.Lunes && i.Hora!.Id == hora.Id);
            itemsMap[Dia.Martes] = items?.FirstOrDefault(i => i.Dia == Dia.Martes && i.Hora!.Id == hora.Id);
            itemsMap[Dia.Miercoles] = items?.FirstOrDefault(i => i.Dia == Dia.Miercoles && i.Hora!.Id == hora.Id);
            itemsMap[Dia.Jueves] = items?.FirstOrDefault(i => i.Dia == Dia.Jueves && i.Hora!.Id == hora.Id);
            itemsMap[Dia.Viernes] = items?.FirstOrDefault(i => i.Dia == Dia.Viernes && i.Hora!.Id == hora.Id);

            model.Lunes = itemsMap[Dia.Lunes]?.Materia?.Nombre?.ToString();
            model.Martes = itemsMap[Dia.Martes]?.Materia?.Nombre?.ToString();
            model.Miercoles = itemsMap[Dia.Miercoles]?.Materia?.Nombre?.ToString();
            model.Jueves = itemsMap[Dia.Jueves]?.Materia?.Nombre?.ToString();
            model.Viernes = itemsMap[Dia.Viernes]?.Materia?.Nombre?.ToString();

            return model;
        }

        private  async Task<ExportarHorarioViewModel> GetHorarioByGroup(int grupoId)
        {

            var grupo = await GetGrupoResponse(grupoId);
            var horario = await GetHorarioResponse(grupoId);


            var horas = SistemaHorarios.Dominio.Shared.Hora.All.ToList();

            var items = horas
                .Where(h => !h.EsReceso)
                .OrderBy(h => h.Id)
                .Select(h => ItemResponseToExportarViewModel(h, horario.Items!)).ToList();

            var model = new ExportarHorarioViewModel();

            model.NombreArchivo = $"Horario-{grupo.Grado}-{grupo.Nombre}-{DateTime.Now.ToFileTime()}.xlsx";
            model.NombreEscuela = "Secundaria Nuevos Horizontes";
            model.Subtitulo = "Horario de Clases";
            model.CicloEscolar = "Ciclo escolar 2024-2025";
            model.Grupo = $"{grupo?.Grado} \"{grupo?.Nombre}\"";
            model.Items = items;

            return model;
        }
    }
}
