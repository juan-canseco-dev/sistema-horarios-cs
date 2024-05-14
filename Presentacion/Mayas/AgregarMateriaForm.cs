using ReaLTaiizor.Forms;
using SistemaHorarios.Dominio.MayasCurriculares;

namespace Presentacion.Mayas
{
    public partial class AgregarMateriaForm : MaterialForm
    {
        public Action<Materia>? AddMateria { get; set; }
        public AgregarMateriaForm()
        {
            InitializeComponent();
        }

        private void AgregarMateriaButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CodigoEditText.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(NombreEditText.Text))
            {
                return;
            }
            if (HorasSlider.Value < 1)
            {
                return;
            }
            var materia = new Materia(NombreEditText.Text, CodigoEditText.Text, HorasSlider.Value);
            AddMateria!(materia);
            this.Close();
        }
    }
}
