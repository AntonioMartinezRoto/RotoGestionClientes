using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace RotoGestionClientes
{
    public partial class Main : Form
    {
        #region Private properties

        private readonly ApplicationDbContext _context;
        private List<ClienteGridItem> _allClientes = new();
        #endregion

        #region Constructors

        public Main()
        {
            InitializeComponent();
            _context = Program.AppServices.GetRequiredService<ApplicationDbContext>();
        }

        #endregion

        #region Events
        private void Main_Load(object sender, EventArgs e)
        {            
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = $"RotoGestiónClientes v{version?.Major}.{version?.Minor}";
            panel_Sidebar.BackColor = Color.FromArgb(245, 247, 250);
            LoadClientesFromDB();
        }
        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            ClientesMain clientesMainForm = new(_allClientes, _context);
            clientesMainForm.ShowDialog();
            LoadClientesFromDB();
        }

        #endregion

        #region Private methods

        private void LoadClientesFromDB()
        {
            _allClientes = _context.Clientes
                .Select(f => new ClienteGridItem
                {
                    Id = f.Id,
                    Nombre = f.Nombre,
                    Alias = f.Alias,
                    Comentarios = f.Comentarios,
                    ObservacionesVentanas = f.ObservacionesVentanas
                })
                .OrderBy(f => f.Nombre)
                .ToList();
        }
        #endregion


    }
}
