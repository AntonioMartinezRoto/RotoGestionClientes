using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RotoGestionClientes
{
    public partial class PasoParalelas : UserControl
    {
        #region Private properties

        private readonly ClientWizardModel _model;
        private ApplicationDbContext _context;
        private BindingSource _bindingSource = new BindingSource();

        #endregion

        #region Constructors
        public PasoParalelas()
        {
            InitializeComponent();
        }
        public PasoParalelas(ClientWizardModel model, ApplicationDbContext context)
        {
            InitializeComponent();
            _model = model;
            _context = context;

        }
        #endregion

        #region Events
        private void PasoParalelas_Load(object sender, EventArgs e)
        {
            txt_ObservacionesParalelas.Text = _model.ObservacionesParalelas;
            rb_PSCV.Checked = true;
            rb_PSAirCV.Checked = true;
        }
        private void txt_ObservacionesParalelas_TextChanged(object sender, EventArgs e)
        {
            _model.ObservacionesParalelas = txt_ObservacionesParalelas.Text;
        }


        #endregion

        #region Private methods



        #endregion


    }
}
