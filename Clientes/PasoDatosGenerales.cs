using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RotoGestionClientes
{
    public partial class PasoDatosGenerales : UserControl
    {
        #region Private properties

        private readonly ClientWizardModel _model;
        private ApplicationDbContext _context;
        private BindingSource _bindingSourcePerfilTipo = new BindingSource();
        private BindingSource _bindingSourceManillas = new BindingSource();
        private BindingSource _bindingSourceSoporteCompas = new BindingSource();

        #endregion

        #region Constructors
        public PasoDatosGenerales(ClientWizardModel model, ApplicationDbContext context)
        {
            InitializeComponent();
            _model = model;
            _context = context;
        }

        #endregion

        #region Events
        private void txt_NombreCliente_TextChanged(object sender, EventArgs e)
        {
            _model.Nombre = txt_NombreCliente.Text;
        }
        private void txt_Comentarios_TextChanged(object sender, EventArgs e)
        {
            _model.Comentarios = txt_Comentarios.Text;
        }
        private void txt_Alias_TextChanged(object sender, EventArgs e)
        {
            _model.Alias = txt_Alias.Text;
        }
        private void PasoDatosGenerales_Load(object sender, EventArgs e)
        {
            CrearGridPerfilTipo();
            CrearGridManillas();
            CrearGridSoporteCompas();
            RellenarGridPerFilTipo();
            RellenarSoftwareList();
            RellenarGridManillas();
            RellenarGridSoporteCompas();

            InitializeData();
        }
        private void dgvPerfilTipo_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            if (dgvPerfilTipo.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                dgvPerfilTipo.EndEdit();
                var item = (GridItem)dgvPerfilTipo.Rows[e.RowIndex].DataBoundItem;

                if (item.Selected)
                {
                    _model.PerfilTipoList.Add(item.Id);
                }
                else
                {
                    _model.PerfilTipoList.Remove(item.Id);
                }
            }
        }
        private void cmb_Software_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_Software.SelectedIndex != -1 && cmb_Software.SelectedValue != null)
            {
                // Si ValueMember es "Id", SelectedValue será el entero
                if (int.TryParse(cmb_Software.SelectedValue.ToString(), out int id))
                {
                    this._model.SoftwareList.Clear();
                    this._model.SoftwareList.Add(id);
                }
            }


        }
        private void dgvManillas_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            if (dgvManillas.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                dgvManillas.EndEdit();
                var item = (GridItem)dgvManillas.Rows[e.RowIndex].DataBoundItem;

                if (item.Selected)
                {
                    _model.ManillasList.Add(item.Id);
                }
                else
                {
                    _model.ManillasList.Remove(item.Id);
                }
            }
        }
        private void dgvSoporteCompas_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            if (dgvSoporteCompas.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                dgvSoporteCompas.EndEdit();
                var item = (GridItem)dgvSoporteCompas.Rows[e.RowIndex].DataBoundItem;

                if (item.Selected)
                {
                    _model.SoporteCompasList.Add(item.Id);
                }
                else
                {
                    _model.SoporteCompasList.Remove(item.Id);
                }
            }
        }
        #endregion

        #region Private methods

        private void CrearGridPerfilTipo()
        {
            dgvPerfilTipo.AutoGenerateColumns = false;
            dgvPerfilTipo.AllowUserToAddRows = false;
            dgvPerfilTipo.RowHeadersVisible = false;

            dgvPerfilTipo.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Selected",
                HeaderText = "",
                Width = 30
            });

            dgvPerfilTipo.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Tipo",
                ReadOnly = true,
                Width = 100,
                Name = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPerfilTipo.ReadOnly = false;
            dgvPerfilTipo.Enabled = true;
        }
        private void CrearGridManillas()
        {
            dgvManillas.AutoGenerateColumns = false;
            dgvManillas.AllowUserToAddRows = false;
            dgvManillas.RowHeadersVisible = false;

            dgvManillas.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Selected",
                HeaderText = "",
                Width = 30
            });

            dgvManillas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Tipo",
                ReadOnly = true,
                Width = 100,
                Name = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvManillas.ReadOnly = false;
            dgvManillas.Enabled = true;
        }
        private void CrearGridSoporteCompas()
        {
            dgvSoporteCompas.AutoGenerateColumns = false;
            dgvSoporteCompas.AllowUserToAddRows = false;
            dgvSoporteCompas.RowHeadersVisible = false;

            dgvSoporteCompas.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Selected",
                HeaderText = "",
                Width = 30
            });

            dgvSoporteCompas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Tipo",
                ReadOnly = true,
                Width = 100,
                Name = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvSoporteCompas.ReadOnly = false;
            dgvSoporteCompas.Enabled = true;
        }
        private void RellenarGridPerFilTipo()
        {
            var lista = _context.PerfilTipos
                        .Select(f => new GridItem
                        {
                            Id = f.Id,
                            Nombre = f.Nombre,
                            NombreAbreviado = f.NombreAbreviado,
                            Selected = _model.PerfilTipoList.Contains(f.Id)
                        })
                        .OrderBy(f => f.Id)
                        .ToList();

            _bindingSourcePerfilTipo.DataSource = lista;
            dgvPerfilTipo.DataSource = _bindingSourcePerfilTipo;
        }
        private void RellenarGridManillas()
        {
            var lista = _context.Manillas
                        .Select(f => new GridItem
                        {
                            Id = f.Id,
                            Nombre = f.Nombre,
                            Selected = _model.ManillasList.Contains(f.Id)
                        })
                        .OrderBy(f => f.Id)
                        .ToList();

            _bindingSourceManillas.DataSource = lista;
            dgvManillas.DataSource = _bindingSourceManillas;
        }
        private void RellenarGridSoporteCompas()
        {
            var lista = _context.SoporteCompases
                        .Select(f => new GridItem
                        {
                            Id = f.Id,
                            Nombre = f.Nombre,
                            Selected = _model.SoporteCompasList.Contains(f.Id)
                        })
                        .OrderBy(f => f.Id)
                        .ToList();
            _bindingSourceSoporteCompas.DataSource = lista;
            dgvSoporteCompas.DataSource = _bindingSourceSoporteCompas;
        }
        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(_model.Nombre);
        }
        private void RellenarSoftwareList()
        {
            cmb_Software.SelectedValueChanged -= cmb_Software_SelectedValueChanged;

            List<Software> softwareList = new List<Software>();
            softwareList = _context.Softwares.OrderBy(s => s.Id).ToList();

            cmb_Software.DataSource = null;
            cmb_Software.DataSource = softwareList;
            cmb_Software.DisplayMember = "Nombre";
            cmb_Software.ValueMember = "Id";

            cmb_Software.SelectedIndex = -1;

            cmb_Software.SelectedValueChanged += cmb_Software_SelectedValueChanged;
        }
        private void InitializeData()
        {
            txt_NombreCliente.Text = _model.Nombre;
            txt_Alias.Text = _model.Alias;
            txt_Comentarios.Text = _model.Comentarios;
            cmb_Software.SelectedValue = _model.SoftwareList.FirstOrDefault();
        }

        #endregion
    }
    public class GridItem
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string NombreAbreviado { get; set; } = string.Empty;
        public bool Selected { get; set; }
    }

}
