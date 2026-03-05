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
        private BindingSource _bindingSourcePerfil = new BindingSource();

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
        private void txt_SapId_TextChanged(object sender, EventArgs e)
        {
            _model.SapId = txt_SapId.Text;
        }
        private void PasoDatosGenerales_Load(object sender, EventArgs e)
        {
            CrearGridPerfilTipo();
            CrearGridManillas();
            CrearGridSoporteCompas();
            CrearGridPerfil();
            RellenarGridPerFilTipo();
            RellenarSoftwareList();
            RellenarGridManillas();
            CargarSoporteComprasFiltrado();
            CargarPerfilesFiltrados();
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
                    DesmarcarPerfilesDeTipo(item.Id);
                }

                CargarPerfilesFiltrados();
                CargarSoporteComprasFiltrado();
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
        private void dgvPerfil_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            if (dgvPerfil.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                dgvPerfil.EndEdit();
                var item = (GridItem)dgvPerfil.Rows[e.RowIndex].DataBoundItem;

                if (item.Selected)
                {
                    _model.PerfilesList.Add(item.Id);
                }
                else
                {
                    _model.PerfilesList.Remove(item.Id);
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
            dgvPerfilTipo.ColumnHeadersVisible = false;

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
        private void CrearGridPerfil()
        {
            dgvPerfil.AutoGenerateColumns = false;
            dgvPerfil.AllowUserToAddRows = false;
            dgvPerfil.RowHeadersVisible = false;
            dgvPerfil.ColumnHeadersVisible = false;

            dgvPerfil.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Selected",
                HeaderText = "",
                Width = 30
            });

            dgvPerfil.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                ReadOnly = true,
                Width = 100,
                Name = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPerfil.ReadOnly = false;
            dgvPerfil.Enabled = true;
        }
        private void CrearGridManillas()
        {
            dgvManillas.AutoGenerateColumns = false;
            dgvManillas.AllowUserToAddRows = false;
            dgvManillas.RowHeadersVisible = false;
            dgvManillas.ColumnHeadersVisible = false;

            dgvManillas.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Selected",
                HeaderText = "",
                Width = 30
            });

            dgvManillas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
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
            dgvSoporteCompas.ColumnHeadersVisible = false;

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
        private void CargarPerfilesFiltrados()
        {
            var tiposSeleccionados = ((List<GridItem>)_bindingSourcePerfilTipo.DataSource)
                .Where(x => x.Selected)
                .Select(x => x.Id)
                .ToList();

            if (!tiposSeleccionados.Any())
            {
                dgvPerfil.DataSource = null;
                return;
            }

            var perfiles = _context.Perfiles
                .Where(p => tiposSeleccionados.Contains(p.PerfilTipoId))
                .Select(p => new GridItem
                {
                    Id = p.Id,
                    Nombre = p.Nombre + " (" + p.PerfilTipo.NombreAbreviado + ")",
                    Selected = _model.PerfilesList.Contains(p.Id)
                })
                .OrderBy(p => p.Nombre)
                .ToList();

            dgvPerfil.DataSource = perfiles;
        }
        private void DesmarcarPerfilesDeTipo(int perfilTipoId)
        {
            // Obtener IDs de perfiles que pertenecen a ese tipo
            var perfilesDelTipo = _context.Perfiles
                .Where(p => p.PerfilTipoId == perfilTipoId)
                .Select(p => p.Id)
                .ToList();

            // Eliminar del modelo
            _model.PerfilesList.RemoveAll(id => perfilesDelTipo.Contains(id));
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
        private void CargarSoporteComprasFiltrado()
        {
            var tiposSeleccionados = ((List<GridItem>)_bindingSourcePerfilTipo.DataSource)
                .Where(x => x.Selected)
                .Select(x => x.Id)
                .ToList();

            if (!tiposSeleccionados.Any())
            {
                dgvSoporteCompas.DataSource = null;
                return;
            }

            var soporteCompases = _context.SoporteCompases
                .Where(p => tiposSeleccionados.Contains(p.PerfilTipoId))
                .Select(p => new GridItem
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    Selected = _model.SoporteCompasList.Contains(p.Id)
                })
                .OrderBy(p => p.Nombre)
                .ToList();

            dgvSoporteCompas.DataSource = soporteCompases;
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
            txt_SapId.Text = _model.SapId;
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
    public class PerfilComboItem
    {
        public int Id { get; set; }

        public string Texto { get; set; } = null!;
    }

}
