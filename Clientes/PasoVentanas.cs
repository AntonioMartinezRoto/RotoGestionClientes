using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RotoGestionClientes
{
    public partial class PasoVentanas : UserControl
    {
        #region Private properties

        private readonly ClientWizardModel _model;
        private ApplicationDbContext _context;
        private BindingSource _bindingSourceSeguridadVentana = new BindingSource();
        private BindingSource _bindingSourceCremonaPasiva = new BindingSource();

        #endregion

        public PasoVentanas()
        {
            InitializeComponent();
        }

        #region Constructors
        public PasoVentanas(ClientWizardModel model, ApplicationDbContext context)
        {
            InitializeComponent();
            _model = model;
            _context = context;

        }
        #endregion

        #region Events
        private void PasoVentanas_Load(object sender, EventArgs e)
        {
            txt_Observaciones.Text = _model.ObservacionesVentanas;

            CrearGridSeguridadVentana();
            CrearGridCremonaPasivas();
            RellenarGridSeguridadVentana();
            RellenarGridCremonaPasivas();
        }

        private void dgvSeguridad_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            if (dgvSeguridad.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                dgvSeguridad.EndEdit();
                var item = (GridItem)dgvSeguridad.Rows[e.RowIndex].DataBoundItem;

                if (item.Selected)
                {
                    _model.SeguridadVentanaList.Add(item.Id);
                }
                else
                {
                    _model.SeguridadVentanaList.Remove(item.Id);
                }
            }
        }
        private void dgvPasivas_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            if (dgvPasivas.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                dgvPasivas.EndEdit();
                var item = (GridItem)dgvPasivas.Rows[e.RowIndex].DataBoundItem;

                if (item.Selected)
                {
                    _model.CremonaPasivaVentanaList.Add(item.Id);
                }
                else
                {
                    _model.CremonaPasivaVentanaList.Remove(item.Id);
                }
            }
        }
        private void txt_Observaciones_TextChanged(object sender, EventArgs e)
        {
            _model.ObservacionesVentanas = txt_Observaciones.Text;
        }
        #endregion

        #region Private methods

        private void CrearGridSeguridadVentana()
        {
            dgvSeguridad.AutoGenerateColumns = false;
            dgvSeguridad.AllowUserToAddRows = false;
            dgvSeguridad.RowHeadersVisible = false;

            dgvSeguridad.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Selected",
                HeaderText = "",
                Width = 30
            });

            dgvSeguridad.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Tipo",
                ReadOnly = true,
                Width = 100,
                Name = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvSeguridad.ReadOnly = false;
            dgvSeguridad.Enabled = true;
        }
        private void CrearGridCremonaPasivas()
        {
            dgvPasivas.AutoGenerateColumns = false;
            dgvPasivas.AllowUserToAddRows = false;
            dgvPasivas.RowHeadersVisible = false;

            dgvPasivas.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Selected",
                HeaderText = "",
                Width = 30
            });

            dgvPasivas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Tipo",
                ReadOnly = true,
                Width = 100,
                Name = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPasivas.ReadOnly = false;
            dgvPasivas.Enabled = true;
        }
        private void RellenarGridSeguridadVentana()
        {
            var lista = _context.SeguridadVentanas
                        .Select(f => new GridItem
                        {
                            Id = f.Id,
                            Nombre = f.Nombre,
                            Selected = _model.SeguridadVentanaList.Contains(f.Id)
                        })
                        .OrderBy(f => f.Id)
                        .ToList();

            _bindingSourceSeguridadVentana.DataSource = lista;
            dgvSeguridad.DataSource = _bindingSourceSeguridadVentana;
        }
        private void RellenarGridCremonaPasivas()
        {
            var lista = _context.CremonaPasivaVentanaTipos
                        .Select(f => new GridItem
                        {
                            Id = f.Id,
                            Nombre = f.Nombre,
                            Selected = _model.CremonaPasivaVentanaList.Contains(f.Id)
                        })
                        .OrderBy(f => f.Id)
                        .ToList();

            _bindingSourceCremonaPasiva.DataSource = lista;
            dgvPasivas.DataSource = _bindingSourceCremonaPasiva;
        }
        #endregion





    }
}
