using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using SistemaHorarios.Aplicacion.MayasCurriculares;
using SistemaHorarios.Dominio.MayasCurriculares;

namespace Presentacion.Mayas
{
    public partial class AsignarMateriasForm : MaterialForm
    {

        private readonly IMayaCurricularService _service;
        public int MayaId { get; set; }

        private MayaCurricularResponse? _maya;
        private List<Materia>? _materias;

        public AsignarMateriasForm(IMayaCurricularService service)
        {
            _service = service;
            InitializeComponent();
        }

        private void AsignarMateriasForm_Load(object sender, EventArgs e)
        {
            GetMaya();
        }

        private async void GetMaya()
        {
            var result = await _service.GetByIdAsync(MayaId);
            _maya = result.Value;
            _materias = _maya.Materias!.Select(m => new Materia(m.Nombre!, m.Codigo!, m.HorasSemanales)).ToList();
            GradoLabel.Text = $"Materias - {_maya.Grado} Grado";
            UpdateInfoLabels();
        }

        private bool HasDuplicateName(Materia materia)
        {
            return _materias!.Any(m => m.Nombre.ToLower().Equals(materia.Nombre.ToLower()));
        }

        private bool HasDuplicateCode(Materia materia)
        {
            return _materias!.Any(m => m.Codigo.ToLower().Equals(materia.Codigo.ToLower()));
        }

        private bool IsHoursLimitExceeded(Materia materia)
        {
            var totalHours = _materias!.Sum(m => m.HorasSemanales) + materia.HorasSemanales;
            return totalHours > 35;
        }

        private void AddMateria(Materia materia)
        {
            if (HasDuplicateName(materia))
            {
                var message = $"Ya existe una materia con el nombre : {materia.Nombre}.";
                var caption = "Nombre Duplicado";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (HasDuplicateCode(materia))
            {

                var message = $"Ya existe una materia con el codigo : {materia.Nombre}.";
                var caption = "Codigo Duplicado";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsHoursLimitExceeded(materia))
            {
                var message = $"El máximo de horas semanales que puede tener una malla curricular es 35.";
                var caption = "Máximo de Horas Semanales Excedidas";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _materias!.Add(materia);
            UpdateMateriasGrid();
            UpdateInfoLabels();
        }



        private void UpdateMateriasGrid()
        {
            MateriasGridView.AutoGenerateColumns = false;
            MateriasGridView.DataSource = null;
            MateriasGridView.DataSource = _materias;
            MateriasGridView.Refresh();
        }

        private void UpdateInfoLabels()
        {
            var numMaterias = _materias == null ? 0 : _materias.Count();
            var numHoras = _materias == null ? 0 : _materias.Sum(m => m.HorasSemanales);
            NumeroMateriasLabel.Text = $"{numMaterias} Materias";
            NumeroHorasLabel.Text = $"{numHoras} Horas Semanales";
        }

        private void AgregarMateriaButton_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<AgregarMateriaForm>();
            form.AddMateria += AddMateria;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void MateriasGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                switch (e.ColumnIndex)
                {
                    case 4:
                        DeleteMateria_Event(senderGrid, e);
                        break;
                }
            }
        }

        private void DeleteMateria_Event(DataGridView senderGrid, DataGridViewCellEventArgs e)
        {
            var dialogResult = MessageBox.Show("¿Deseas eliminar la Materia seleccionada?", "Eliminar Materia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                var codigo = (string)senderGrid.Rows[e.RowIndex].Cells[1].Value;
                var materia = _materias!.FirstOrDefault(m => m.Codigo.Equals(codigo));
                _materias!.Remove(materia!);
                UpdateInfoLabels();
                UpdateMateriasGrid();
            }
        }
    }
}
