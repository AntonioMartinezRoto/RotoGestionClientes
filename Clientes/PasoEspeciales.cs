using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RotoGestionClientes
{
    public partial class PasoEspeciales : UserControl
    {
        #region Private properties

        private readonly ClientWizardModel _model;
        private ApplicationDbContext _context;
        private BindingSource _bindingSourcePerfilTipo = new BindingSource();

        #endregion

        public PasoEspeciales()
        {
            InitializeComponent();
        }

        #region Constructors
        public PasoEspeciales(ClientWizardModel model, ApplicationDbContext context)
        {
            InitializeComponent();
            _model = model;
            _context = context;

        }
        #endregion
    }
}
