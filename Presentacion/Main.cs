using Presentacion.Grupos;

namespace Presentacion
{
    public partial class Main : Form
    {
        private readonly GruposForm _gruposForm;

        public Main(GruposForm gruposForm)
        {
            _gruposForm = gruposForm;
            InitializeComponent();
        }

        private void GroupsButton_Click(object sender, EventArgs e)
        {
            _gruposForm.Show();
        }
    }
}
