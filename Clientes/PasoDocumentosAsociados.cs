using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RotoGestionClientes
{
    public partial class PasoDocumentosAsociados : UserControl
    {
        #region Private properties

        private readonly ClientWizardModel _model;
        private ApplicationDbContext _context;
        private BindingSource _bindingSourceDocumentosAsociados = new BindingSource();

        #endregion

        #region Constructors
        public PasoDocumentosAsociados()
        {
            InitializeComponent();
        }
        public PasoDocumentosAsociados(ClientWizardModel model, ApplicationDbContext context)
        {
            InitializeComponent();
            _model = model;
            _context = context;

        }
        #endregion

        #region Events


        #endregion

        #region Private methods



        #endregion
    }
}
