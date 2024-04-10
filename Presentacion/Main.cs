using SistemaHorarios.Aplicacion.Abstractions;

namespace Presentacion
{
    public partial class Main : Form
    {
        private IApplicationDbContext _context;

        public Main(IApplicationDbContext context)
        {
            InitializeComponent();
            _context = context;
        }
    }
}
