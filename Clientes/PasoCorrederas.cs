using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace RotoGestionClientes
{
    public partial class PasoCorrederas : UserControl
    {
        #region Private properties

        private readonly ClientWizardModel _model;
        private ApplicationDbContext _context;
        private BindingSource _bindingSource = new BindingSource();

        #endregion

        #region Constructors
        public PasoCorrederas()
        {
            InitializeComponent();
        }
        public PasoCorrederas(ClientWizardModel model, ApplicationDbContext context)
        {
            InitializeComponent();
            _model = model;
            _context = context;

        }

        #endregion

        #region Events
        private void PasoCorrederas_Load(object sender, EventArgs e)
        {
            txt_ObservacionesCorrederas.Text = _model.ObservacionesCorrederas;

            //Vigilar id = 2. Si se añade otro tipo de aguja que también active el bombillo, habrá que cambiar esta lógica.
            if (_model.AgujasCorrederaList.Contains(2))
            {
                groupBombillo.Visible = true;
            }
            CrearGridAgujasCorredera();
            RellenarGridAgujasCorredera();
        }
        private void dgvAgujas_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            if (dgvAgujas.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                dgvAgujas.EndEdit();
                var item = (GridItem)dgvAgujas.Rows[e.RowIndex].DataBoundItem;

                if (item.Selected)
                {
                    _model.AgujasCorrederaList.Add(item.Id);
                    if (item.Nombre.Contains("17", StringComparison.OrdinalIgnoreCase))
                    {
                        groupBombillo.Visible = true;
                    }
                }
                else
                {
                    _model.AgujasCorrederaList.Remove(item.Id);
                    if (item.Nombre.Contains("17", StringComparison.OrdinalIgnoreCase))
                    {
                        groupBombillo.Visible = false;
                    }
                }
            }
        }
        private void txt_ObservacionesCorrederas_TextChanged(object sender, EventArgs e)
        {
            _model.ObservacionesCorrederas = txt_ObservacionesCorrederas.Text;
        }

        #endregion
        #region Private methods

        private void CrearGridAgujasCorredera()
        {
            dgvAgujas.AutoGenerateColumns = false;
            dgvAgujas.AllowUserToAddRows = false;
            dgvAgujas.RowHeadersVisible = false;
            dgvAgujas.ColumnHeadersVisible = false;

            dgvAgujas.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Selected",
                HeaderText = "",
                Width = 30
            });

            dgvAgujas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Tipo",
                ReadOnly = true,
                Width = 100,
                Name = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvAgujas.ReadOnly = false;
            dgvAgujas.Enabled = true;
        }
        private void RellenarGridAgujasCorredera()
        {
            var lista = _context.AgujasCorredera
                        .Where(f => f.Activa)
                        .Select(f => new GridItem
                        {
                            Id = f.Id,
                            Nombre = f.Nombre,
                            Selected = _model.AgujasCorrederaList.Contains(f.Id)
                        })
                        .OrderBy(f => f.Id)
                        .ToList();

            _bindingSource.DataSource = lista;
            dgvAgujas.DataSource = _bindingSource;
        }
        #endregion

    }
}
