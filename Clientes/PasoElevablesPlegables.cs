
namespace RotoGestionClientes
{
    public partial class PasoElevablesPlegables : UserControl
    {
        #region Private properties

        private readonly ClientWizardModel _model;
        private ApplicationDbContext _context;
        private BindingSource _bindingSourcePerfilTipo = new BindingSource();

        #endregion

        #region Constructors
        public PasoElevablesPlegables()
        {
            InitializeComponent();
        }
        public PasoElevablesPlegables(ClientWizardModel model, ApplicationDbContext context)
        {
            InitializeComponent();
            _model = model;
            _context = context;
        }
        #endregion

        #region Events
        private void PasoElevablesPlegables_Load(object sender, EventArgs e)
        {
            txt_ObservacionesPlegables.Text = _model.ObservacionesPlegables;
            txt_ObservacionesElevables.Text = _model.ObservacionesElevables;

            rb_DloSi.Checked = _model.Elevable_Dlo;
            rb_DloNo.Checked = !_model.Elevable_Dlo;

            rb_ConsumoSi.Checked = _model.Plegable_Consumen;
            rb_ConsumoNo.Checked = !_model.Plegable_Consumen;
        }
        private void txt_ObservacionesElevables_TextChanged(object sender, EventArgs e)
        {
            _model.ObservacionesElevables = txt_ObservacionesElevables.Text;
        }
        private void txt_ObservacionesPlegables_TextChanged(object sender, EventArgs e)
        {
            _model.ObservacionesPlegables = txt_ObservacionesPlegables.Text;
        }
        private void rb_DloSi_CheckedChanged(object sender, EventArgs e)
        {
            _model.Elevable_Dlo = rb_DloSi.Checked;
        }
        private void rb_DloNo_CheckedChanged(object sender, EventArgs e)
        {
            _model.Elevable_Dlo = !rb_DloNo.Checked;
        }
        private void rb_ConsumoSi_CheckedChanged(object sender, EventArgs e)
        {
            _model.Plegable_Consumen = rb_ConsumoSi.Checked;
        }
        private void rb_ConsumoNo_CheckedChanged(object sender, EventArgs e)
        {
            _model.Plegable_Consumen = !rb_ConsumoNo.Checked;
        }

        #endregion
        
    }
}
