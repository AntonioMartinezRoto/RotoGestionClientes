using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RotoGestionClientes
{
    public partial class PasoMaquinas : UserControl
    {
        #region Private properties

        private readonly ClientWizardModel _model;
        private ApplicationDbContext _context;
        private BindingSource _bindingSourcePerfilTipo = new BindingSource();

        #endregion

        public PasoMaquinas()
        {
            InitializeComponent();
        }

        #region Constructors
        public PasoMaquinas(ClientWizardModel model, ApplicationDbContext context)
        {
            InitializeComponent();
            _model = model;
            _context = context;
        }
        #endregion

        #region Events
        private void PasoMaquinas_Load(object sender, EventArgs e)
        {
            CrearGrid();
        }
        private void txt_ObservacionesMaquinas_TextChanged(object sender, EventArgs e)
        {
            _model.ObservacionesMaquinas = txt_ObservacionesMaquinas.Text;
        }

        private void CrearGrid()
        {
            dgvMaquinas.AutoGenerateColumns = false;
            dgvMaquinas.AllowUserToAddRows = false;
            dgvMaquinas.ReadOnly = true;

            dgvMaquinas.Columns.Clear();

            dgvMaquinas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Descripcion",
                HeaderText = "Tipo",
                DataPropertyName = "Descripcion",
                //Width = 250,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvMaquinas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = "Marca",
                DataPropertyName = "Nombre",
                Width = 200
            });
            dgvMaquinas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MantenimientoNombre",
                HeaderText = "Mantenimiento",
                DataPropertyName = "MantenimientNombre",
                Width = 200
                //AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvMaquinas.Columns.Add(new DataGridViewImageColumn
            {
                Name = "Edit",
                HeaderText = "",
                Image = Properties.Resources.edit,
                Width = 25,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            });

            dgvMaquinas.Columns.Add(new DataGridViewImageColumn
            {
                Name = "Delete",
                HeaderText = "",
                Image = Properties.Resources.delete,
                Width = 25,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            });
        }
        #endregion



    }
}
