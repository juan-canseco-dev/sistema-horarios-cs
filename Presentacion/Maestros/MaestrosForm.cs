using SistemaHorarios.Aplicacion.Maestros;
using ReaLTaiizor.Forms;
using Microsoft.Extensions.DependencyInjection;
using SistemaHorarios.Dominio.Maestros;
using SistemaHorarios.Aplicacion.Abstractions;
using Microsoft.EntityFrameworkCore;
using SistemaHorarios.Dominio.Enums;
using SistemaHorarios.Dominio.Horarios;
using OfficeOpenXml;
using System.Diagnostics;
using SistemaHorarios.Dominio.MayasCurriculares;

namespace Presentacion.Maestros
{
    public partial class MaestrosForm : MaterialForm
    {
        private readonly IMaestroService _service;
        private readonly IApplicationDbContext _context;

        public MaestrosForm(IMaestroService service, IApplicationDbContext context)
        {
            _service = service;
            _context = context;
            InitializeComponent();
        }

        private void MaestrosForm_Load(object sender, EventArgs e)
        {
            GetMaestros();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            var senderTextBox = (TextBox)sender;
            GetMaestros(senderTextBox.Text);
        }

        private void Reload()
        {
            SearchTextBox.Clear();
            GetMaestros();
        }

        private async void GetMaestros(string? filtro = null)
        {
            MaestrosGrid.AutoGenerateColumns = false;
            var request = new GetMaestrosRequest { Filtro = filtro };
            var result = await _service.GetAllAsync(request);
            MaestrosGrid.DataSource = result.Value;
            MaestrosGrid.Refresh();
        }

        private void CrearMaestroButton_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<NuevoMaestroForm>();
            form.Reload += Reload;
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void MaestrosGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (MaestrosGrid.Columns[e.ColumnIndex].Name == "Exportar")
            {
                if (!HasHorasAsignadas(e.RowIndex))
                {
                    var cell = (DataGridViewButtonCell)MaestrosGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    cell.FlatStyle = FlatStyle.Flat;
                }
            }
        }

        private void MaestrosGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;

            var senderGrid = (DataGridView)sender;


            if (senderGrid.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DeleteMaestro_Event(senderGrid, e);
            }

            if (senderGrid.Columns[e.ColumnIndex].Name == "Exportar")
            {
                ExportHorario_Event(senderGrid, e);
            }
        }

        private async void DeleteMaestro_Event(DataGridView senderGrid, DataGridViewCellEventArgs e)
        {
            int maestroId = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;

            if (MaestrosEspecialesIds.All.Contains(maestroId))
            {
                return;
            }

            var dialogResult = MessageBox.Show("¿Deseas eliminar al Maestro seleccionado?", "Eliminar Maestro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                var result = await _service.DeleteAsync(new EliminarMaestroRequest(maestroId));
                if (result.IsSuccess)
                {
                    Reload();
                    return;
                }
                MessageBox.Show(result.Error.Name, result.Error.Code, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<HorarioMaestroViewModel> GetExportModel(int maestroId)
        {
            if (MaestrosEspecialesIds.All.Contains(maestroId))
            {
                return await GetExportModelByEsepecialMaterias(maestroId);
            }

            return await GetHorarioMaestro(maestroId);
        }

        private async void ExportHorario_Event(DataGridView senderGrid, DataGridViewCellEventArgs e)
        {
            if (!HasHorasAsignadas(e.RowIndex)) return;
            int maestroId = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;
            var exportModel = await GetExportModel(maestroId);
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
                fileStream.Write(Properties.Resources.Horario_Maestros, 0, Properties.Resources.Horario_Maestros.Length);
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
                workSheet.Cells["C4:F4"].Value = exportModel.Maestro;

                // Primera hora 
                var h1 = exportModel.Items?[1];
                workSheet.Cells["C6"].Value = h1?.Lunes;
                workSheet.Cells["D6"].Value = h1?.Martes;
                workSheet.Cells["E6"].Value = h1?.Miercoles;
                workSheet.Cells["F6"].Value = h1?.Jueves;
                workSheet.Cells["G6"].Value = h1?.Viernes;


                var h2 = exportModel.Items?[2];
                workSheet.Cells["C7"].Value = h2?.Lunes;
                workSheet.Cells["D7"].Value = h2?.Martes;
                workSheet.Cells["E7"].Value = h2?.Miercoles;
                workSheet.Cells["F7"].Value = h2?.Jueves;
                workSheet.Cells["G7"].Value = h2?.Viernes;


                var h3 = exportModel.Items?[3];
                workSheet.Cells["C8"].Value = h3?.Lunes;
                workSheet.Cells["D8"].Value = h3?.Martes;
                workSheet.Cells["E8"].Value = h3?.Miercoles;
                workSheet.Cells["F8"].Value = h3?.Jueves;
                workSheet.Cells["G8"].Value = h3?.Viernes;


                var h4 = exportModel.Items?[5];
                workSheet.Cells["C10"].Value = h4?.Lunes;
                workSheet.Cells["D10"].Value = h4?.Martes;
                workSheet.Cells["E10"].Value = h4?.Miercoles;
                workSheet.Cells["F10"].Value = h4?.Jueves;
                workSheet.Cells["G10"].Value = h4?.Viernes;

                var h5 = exportModel.Items?[6];
                workSheet.Cells["C11"].Value = h5?.Lunes;
                workSheet.Cells["D11"].Value = h5?.Martes;
                workSheet.Cells["E11"].Value = h5?.Miercoles;
                workSheet.Cells["F11"].Value = h5?.Jueves;
                workSheet.Cells["G11"].Value = h5?.Viernes;


                var h6 = exportModel.Items?[8];
                workSheet.Cells["C13"].Value = h6?.Lunes;
                workSheet.Cells["D13"].Value = h6?.Martes;
                workSheet.Cells["E13"].Value = h6?.Miercoles;
                workSheet.Cells["F13"].Value = h6?.Jueves;
                workSheet.Cells["G13"].Value = h6?.Viernes;

                var h7 = exportModel.Items?[9];
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

        private void SearchTextBox_TrailingIconClick(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
        }

        private bool HasHorasAsignadas(int rowIndex) => (bool)MaestrosGrid.Rows[rowIndex].Cells["HorasAsignadas"].Value;


        private Dictionary<int, HorarioItemMaestroViewModel> HorariosToItems(int maestroId, List<Horario> horarios)
        {
            var items = horarios
                .SelectMany(h => h.Items)
                .Where(h => h.MaestroId == maestroId)
                .ToList();


            var groupsDictionary = horarios
                .ToDictionary(k => k.Id, v => v.Grupo);


            var map = new Dictionary<int, HorarioItemMaestroViewModel>();

            SistemaHorarios.Dominio.Shared.Hora.All.Where(m => !m.EsReceso).OrderBy(h => h.Id).ToList().ForEach(h =>
            {
                var tempMap = items
                .Where(i => i.HoraId == h.Id)
                .ToDictionary(k => k.Dia, v => v);


                var model = new HorarioItemMaestroViewModel();

                // Lunes
                var i1 = tempMap.GetValueOrDefault(Dia.Lunes);
                var g1 = groupsDictionary.GetValueOrDefault(i1?.HorarioId == null? 0 : i1.HorarioId);
                var g1i = g1?.Grado is not null ? (int)g1.Grado : 0;
                var g1n = $"{g1i}°{g1?.Nombre}";
                model.Lunes = i1 is null ? null : $"{g1n} - {i1?.Materia?.Nombre}";


                // Martes 
                var i2 = tempMap.GetValueOrDefault(Dia.Martes);
                var g2 = groupsDictionary.GetValueOrDefault(i2?.HorarioId == null ? 0 : i2.HorarioId);
                var g2i = g2?.Grado is not null ? (int)g2.Grado : 0;
                var g2n =  $"{g2i}°{g2?.Nombre}";
                model.Martes = i2 is null ? null : $"{g2n} - {i2?.Materia?.Nombre}";


                // Miercoles
                var i3 = tempMap.GetValueOrDefault(Dia.Miercoles);
                var g3 = groupsDictionary.GetValueOrDefault(i3?.HorarioId == null ? 0 : i3.HorarioId);
                var g3i = g3?.Grado is not null ? (int)g3.Grado : 0;
                var g3n = $"{g3i}°{g3?.Nombre}";
                model.Miercoles = i3 is null ? null : $"{g3n} - {i3?.Materia?.Nombre}";

                // Jueves
                var i4 = tempMap.GetValueOrDefault(Dia.Jueves);
                var g4 = groupsDictionary.GetValueOrDefault(i4?.HorarioId == null ? 0 : i4.HorarioId);
                var g4i = g4?.Grado is not null ? (int)g4.Grado : 0;
                string? g4n = $"{g4i}°{g4?.Nombre}";
                model.Jueves = i4 is null ? null : $"{g4n} - {i4?.Materia?.Nombre}";


                // Viernes
                var i5 = tempMap.GetValueOrDefault(Dia.Viernes);
                var g5 = groupsDictionary.GetValueOrDefault(i5?.HorarioId == null ? 0 : i5.HorarioId);
                var g5i = g5?.Grado is not null ? (int)g5.Grado : 0;
                var g5n = $"{g5i}°{g5?.Nombre}";
                model.Viernes = i5 is null ? null : $"{g5n} - {i5?.Materia?.Nombre}";

                map[h.Id] = model;
            });
            return map;
        }

        public async Task<HorarioMaestroViewModel> GetHorarioMaestro(int maestroId)
        {
            var maestro = await _context.Maestros.FirstOrDefaultAsync(m => m.Id == maestroId);
            
            var maestroHorarios = await _context.Horarios
                .Include(h => h.Grupo)
                .Include(h => h.Items)
                .ThenInclude(i => i.Materia)
                .Include(h => h.Items)
                .ThenInclude(i => i.Maestro)
                .Include(h => h.Items)
                .ThenInclude(i => i.Hora)
                .Where(h => h.Items.Any(m => m.MaestroId == maestroId))
                .Distinct()
                .ToListAsync();



            var items = HorariosToItems(maestroId, maestroHorarios);

            var model = new HorarioMaestroViewModel();


            model.NombreArchivo = $"Horario-Maestro-{maestro?.Nombres}-{maestro?.Apellidos}-{DateTime.Now.ToFileTime()}.xlsx";
            model.NombreEscuela = "Secundaria Nuevos Horizontes";
            model.Subtitulo = "Horario de Clases";
            model.CicloEscolar = "Ciclo escolar 2024-2025";
            model.Maestro = $"Prof. {maestro?.Nombres} {maestro?.Apellidos}";
            model.Items = items;

            return model;
        }

        private MateriasEspecialesViewModel? GetMateriasEspecialesVM(int maestroId)
        {
            if (maestroId == MaestrosEspecialesIds.Ingles1 || maestroId == MaestrosEspecialesIds.Ingles2 || maestroId == MaestrosEspecialesIds.Ingles3)
            {
                Materia? materia = null;
                Maestro? maestro = null;
                Grado? grado = null;
                MateriaSpecialTipo? tipo = null; ;


                if (maestroId == MaestrosEspecialesIds.Ingles1)
                {
                    materia = MateriasEspeciales.Ingles1;
                    maestro = MaestrosEspeciales.Ingles1;
                    grado = Grado.Primero;
                    tipo = MateriaSpecialTipo.Ingles;
                }

                if (maestroId == MaestrosEspecialesIds.Ingles2)
                {
                    materia = MateriasEspeciales.Ingles2;
                    maestro = MaestrosEspeciales.Ingles2;
                    grado = Grado.Segundo;
                    tipo = MateriaSpecialTipo.Ingles;
                }

                if (maestroId == MaestrosEspecialesIds.Ingles3)
                {

                    materia = MateriasEspeciales.Ingles3;
                    maestro = MaestrosEspeciales.Ingles3;
                    grado = Grado.Tercero;
                    tipo = MateriaSpecialTipo.Ingles;
                }

                return new MateriasEspecialesViewModel
                {
                    Grado = grado,
                    Tipo = tipo,
                    Maestro = maestro,
                    Materia = materia
                };
            }

            if (maestroId == MaestrosEspecialesIds.Expertos1 || maestroId == MaestrosEspecialesIds.Expertos2 || maestroId == MaestrosEspecialesIds.Expertos3)
            {
                Materia? materia = null;
                Maestro? maestro = null;
                Grado? grado = null;
                MateriaSpecialTipo? tipo = null; ;


                if (maestroId == MaestrosEspecialesIds.Expertos1)
                {
                    materia = MateriasEspeciales.Expertos1;
                    maestro = MaestrosEspeciales.Expertos1;
                    grado = Grado.Primero;
                    tipo = MateriaSpecialTipo.Expertos;
                }

                if (maestroId == MaestrosEspecialesIds.Expertos2)
                {
                    materia = MateriasEspeciales.Expertos2;
                    maestro = MaestrosEspeciales.Expertos2;
                    grado = Grado.Segundo;
                    tipo = MateriaSpecialTipo.Expertos;
                }

                if (maestroId == MaestrosEspecialesIds.Expertos3)
                {

                    materia = MateriasEspeciales.Expertos3;
                    maestro = MaestrosEspeciales.Expertos3;
                    grado = Grado.Tercero;
                    tipo = MateriaSpecialTipo.Expertos;
                }

                return new MateriasEspecialesViewModel
                {
                    Grado = grado,
                    Tipo = tipo,
                    Maestro = maestro,
                    Materia = materia
                };
            }


            if (maestroId == MaestrosEspecialesIds.Arte1 || maestroId == MaestrosEspecialesIds.Arte2 || maestroId == MaestrosEspecialesIds.Arte3)
            {
                Materia? materia = null;
                Maestro? maestro = null;
                Grado? grado = null;
                MateriaSpecialTipo? tipo = null; ;


                if (maestroId == MaestrosEspecialesIds.Arte1)
                {
                    materia = MateriasEspeciales.Arte1;
                    maestro = MaestrosEspeciales.Arte1;
                    grado = Grado.Primero;
                    tipo = MateriaSpecialTipo.Artes;
                }

                if (maestroId == MaestrosEspecialesIds.Arte2)
                {
                    materia = MateriasEspeciales.Arte2;
                    maestro = MaestrosEspeciales.Arte2;
                    grado = Grado.Segundo;
                    tipo = MateriaSpecialTipo.Artes;
                }

                if (maestroId == MaestrosEspecialesIds.Arte3)
                {

                    materia = MateriasEspeciales.Arte3;
                    maestro = MaestrosEspeciales.Arte3;
                    grado = Grado.Tercero;
                    tipo = MateriaSpecialTipo.Artes;
                }

                return new MateriasEspecialesViewModel
                {
                    Grado = grado,
                    Tipo = tipo,
                    Maestro = maestro,
                    Materia = materia
                };
            }

            return null;
        }


        private async Task<Dictionary<int, HorarioItemMaestroViewModel>> ItemsForEspeciales(MateriasEspecialesViewModel vm)
        {
            Dictionary<int, HorarioItemMaestroViewModel> map = new();
            if (vm.Tipo == MateriaSpecialTipo.Ingles)
            {

                var message = $"{vm.Grado}s - {vm.Materia?.Nombre}";

                map[1] = new HorarioItemMaestroViewModel 
                {
                    Lunes = message,
                    Martes = message,
                    Miercoles = message,
                    Jueves = message,
                    Viernes = message
                };

                map[2] = new HorarioItemMaestroViewModel { };
                map[3] = new HorarioItemMaestroViewModel { };
                map[5] = new HorarioItemMaestroViewModel { };
                map[6] = new HorarioItemMaestroViewModel { };
                map[8] = new HorarioItemMaestroViewModel { };
                map[9] = new HorarioItemMaestroViewModel { };
            }
            else if (vm.Tipo == MateriaSpecialTipo.Expertos)
            {
                var message = $"{vm.Grado}s - {vm.Materia?.Nombre}";
                map[1] = new HorarioItemMaestroViewModel { };
                map[2] = new HorarioItemMaestroViewModel { };
                map[3] = new HorarioItemMaestroViewModel
                {
                    Lunes = message,
                    Martes = message,
                    Miercoles = message,
                    Jueves = message,
                    Viernes = message
                };
                map[5] = new HorarioItemMaestroViewModel { };
                map[6] = new HorarioItemMaestroViewModel { };
                map[8] = new HorarioItemMaestroViewModel { };
                map[9] = new HorarioItemMaestroViewModel { };
            }
            else if (vm.Tipo == MateriaSpecialTipo.Artes)
            {

                int maestroId = vm?.Maestro?.Id == null ? 0 : vm.Maestro.Id;
                
                var maestroHorarios = await _context.Horarios
                   .Include(h => h.Grupo)
                   .Include(h => h.Items)
                   .ThenInclude(i => i.Materia)
                   .Include(h => h.Items)
                   .ThenInclude(i => i.Maestro)
                   .Include(h => h.Items)
                   .ThenInclude(i => i.Hora)
                   .Where(h => h.Items.Any(m => m.MaestroId == maestroId))
                   .Distinct()
                   .ToListAsync();


                var gruposMap = maestroHorarios
                    .ToDictionary(k => k.Id, v => v.Grupo);

                var items = maestroHorarios
                    .SelectMany(m => m.Items)
                    .Where(i => i.MaestroId == maestroId)
                    .ToList();


                map[1] = new HorarioItemMaestroViewModel { };
                map[2] = new HorarioItemMaestroViewModel { };
                map[3] = new HorarioItemMaestroViewModel { };
                map[5] = new HorarioItemMaestroViewModel { };
                map[6] = new HorarioItemMaestroViewModel { };
                map[8] = new HorarioItemMaestroViewModel { };
                map[9] = new HorarioItemMaestroViewModel { };


                items.ForEach(i =>
                {
                    var item = map[i.HoraId];
                    var grupo = gruposMap[i.HorarioId];
                    int grado = grupo?.Grado == null ? 0 : (int)grupo.Grado;

                    var message = $"{grado}°{grupo?.Nombre} - {vm?.Materia?.Nombre}";
                    switch (i.Dia)
                    {
                        case Dia.Lunes:
                            item.Lunes = message;
                            break;
                        case Dia.Martes:
                            item.Martes = message;
                            break;
                        case Dia.Miercoles:
                            item.Miercoles = message;
                            break;
                        case Dia.Jueves:
                            item.Jueves = message;
                            break;
                        case Dia.Viernes:
                            item.Viernes = message;
                            break;
                    }
                });

            }
            return map;
        }

        private async Task<HorarioMaestroViewModel> GetExportModelByEsepecialMaterias(int maestroId)
        {

            var materialEspecialVm = GetMateriasEspecialesVM(maestroId);

            var maestro = materialEspecialVm?.Maestro;
            var model = new HorarioMaestroViewModel();

            model.NombreArchivo = $"Horario-Maestro-{maestro?.Nombres}-{maestro?.Apellidos}-{DateTime.Now.ToFileTime()}.xlsx";
            model.NombreEscuela = "Secundaria Nuevos Horizontes";
            model.Subtitulo = "Horario de Clases";
            model.CicloEscolar = "Ciclo escolar 2024-2025";
            model.Maestro = $"Prof. {maestro?.Nombres} {maestro?.Apellidos}";
            model.Items = await ItemsForEspeciales(materialEspecialVm!);

            return model;
        }


        private enum MateriaSpecialTipo
        {
            Ingles, Expertos, Artes
        }

        private class MateriasEspecialesViewModel
        {
            public Grado? Grado { get; set; }
            public Maestro? Maestro { get; set; }
            public Materia? Materia { get; set; }
            public MateriaSpecialTipo? Tipo { get; set; }
        }


    }
}
