using Microsoft.Extensions.DependencyInjection;
using Presentacion.Grupos;

namespace Presentacion
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void GroupsButton_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<GruposForm>();
            form.Show();
        }
    }
}
