using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RotoGestionClientes
{
    public partial class PasoBalconeras : UserControl
    {
        #region Private properties

        private readonly ClientWizardModel _model;
        private ApplicationDbContext _context;
        private BindingSource _bindingSourcePerfilTipo = new BindingSource();

        #endregion

        #region Constructors
        public PasoBalconeras()
        {
            InitializeComponent();
        }
        public PasoBalconeras(ClientWizardModel model, ApplicationDbContext context)
        {
            InitializeComponent();
            _model = model;
            _context = context;

        }
        #endregion

        #region Events
        private void PasoBalconeras_Load(object sender, EventArgs e)
        {
            txt_ObservacionesBalconeras.Text = _model.ObservacionesBalconeras;
            RellenarAgujasList();

            cmb_AgujaBalconeras.SelectedValue = _model.AgujaBalconera != null ? _model.AgujaBalconera : -1;
        }
        private void txt_ObservacionesBalconeras_TextChanged(object sender, EventArgs e)
        {
            _model.ObservacionesBalconeras = txt_ObservacionesBalconeras.Text;
        }
        private void cmb_AgujaBalconeras_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_AgujaBalconeras.SelectedIndex != -1 && cmb_AgujaBalconeras.SelectedValue != null)
            {
                // Si ValueMember es "Id", SelectedValue será el entero
                if (int.TryParse(cmb_AgujaBalconeras.SelectedValue.ToString(), out int id))
                {
                    this._model.AgujaBalconera = id;
                }
            }
        }
        #endregion

        #region Private methods
        private void RellenarAgujasList()
        {
            cmb_AgujaBalconeras.SelectedValueChanged -= cmb_AgujaBalconeras_SelectedValueChanged;

            List<Aguja> agujaList = new List<Aguja>();
            agujaList = _context.Agujas.OrderBy(s => s.Id).ToList();

            cmb_AgujaBalconeras.DataSource = null;
            cmb_AgujaBalconeras.DataSource = agujaList;
            cmb_AgujaBalconeras.DisplayMember = "Nombre";
            cmb_AgujaBalconeras.ValueMember = "Id";

            cmb_AgujaBalconeras.SelectedIndex = -1;

            cmb_AgujaBalconeras.SelectedValueChanged += cmb_AgujaBalconeras_SelectedValueChanged;
        }
        #endregion


        
    }
}
