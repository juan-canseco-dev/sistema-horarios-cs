using Microsoft.Extensions.DependencyInjection;
using Presentacion.Grupos;
using Presentacion.Maestros;
using Presentacion.Mayas;
using ReaLTaiizor.Forms;

namespace Presentacion
{
    public partial class Main : MaterialForm
    {
        public Main()
        {
            InitializeComponent();
        }


        private void MaterialTabMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearFormTabs();
            switch (MaterialTabMenu.SelectedIndex)
            {
                case 0:
                    AddFormToTabPage(MaestrosTab, GetFormByTabIndex(0));
                    break;
                case 1:
                    AddFormToTabPage(GruposTab, GetFormByTabIndex(1));
                    break;
                case 2:
                    AddFormToTabPage(MayasTab, GetFormByTabIndex(2));
                    break;
            };
        }

        private void Main_Load(object sender, EventArgs e)
        {
            AddFormToTabPage(MaestrosTab, GetFormByTabIndex(0));
            MaterialTabMenu.BringToFront();
        }

        private void AddFormToTabPage(TabPage tabPage, Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            tabPage.Controls.Add(form);
            form.Show();
        }

        private Form GetFormByTabIndex(int index)
        {
            return index switch
            {
                0 => Program.ServiceProvider.GetRequiredService<MaestrosForm>(),
                1 => Program.ServiceProvider.GetRequiredService<GruposForm>(),
                2 => Program.ServiceProvider.GetRequiredService<MayasForm>(),
                _ => throw new ArgumentException("Invalid Tab Index")
            };
        }

        private void ClearFormTabs()
        {
            MaestrosTab.Controls.Clear();
            GruposTab.Controls.Clear();
            MayasTab.Controls.Clear();
        }

        private void MaterialTabMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click");
        }
    }
}
