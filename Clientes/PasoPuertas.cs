using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static RotoGestionClientes.Enums;

namespace RotoGestionClientes
{
    public partial class PasoPuertas : UserControl
    {
        #region Private properties

        private readonly ClientWizardModel _model;
        private ApplicationDbContext _context;
        private BindingSource _bindingSourceBisagras = new BindingSource();
        private BindingSource _bindingSourceCerraduras = new BindingSource();

        #endregion


        #region Constructors
        public PasoPuertas()
        {
            InitializeComponent();
        }
        public PasoPuertas(ClientWizardModel model, ApplicationDbContext context)
        {
            InitializeComponent();
            _model = model;
            _context = context;

        }
        #endregion

        #region Events
        private void PasoPuertas_Load(object sender, EventArgs e)
        {
            txt_ObservacionesPuertas.Text = _model.ObservacionesPuertas;
            CrearGridBisagras();
            RellenarGridBisagras();

            CrearGridCerraduraPuerta();
            RellenarGridCerraduraPuerta();

            RellenarAgujasPuerta();

            rb_AgujaPuertaGenerica.CheckedChanged -= rb_AgujaPuertaGenerica_CheckedChanged;
            rb_AgujaPuertaPerfil.CheckedChanged -= rb_AgujaPuertaPerfil_CheckedChanged;

            InitializeAgujaPuerta(_model.AgujaPuertaTipo);

            rb_AgujaPuertaGenerica.CheckedChanged += rb_AgujaPuertaGenerica_CheckedChanged;
            rb_AgujaPuertaPerfil.CheckedChanged += rb_AgujaPuertaPerfil_CheckedChanged;

            if (_model.AgujaPuertaTipo == 0)
                _model.AgujaPuertaTipo = (int)AgujaMode.Todos;

            if (_model.PorteroElectrico)
            {
                rb_PorteroSi.Checked = true;
            }
            else
            {
                rb_PorteroNo.Checked = true;
            }


            if (_model.Cilindro)
            {
                rb_CilindrosSi.Checked = true;
            }
            else
            {
                rb_CilindrosNo.Checked = true;
            }

            txt_CilindroMedida.Text = _model.CilindroMedida.ToString();
        }
        private void dgvBisagras_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            if (dgvBisagras.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                dgvBisagras.EndEdit();
                var item = (GridItem)dgvBisagras.Rows[e.RowIndex].DataBoundItem;

                if (item.Selected)
                {
                    _model.BisagrasPuertaList.Add(item.Id);
                }
                else
                {
                    _model.BisagrasPuertaList.Remove(item.Id);
                }
            }
        }
        private void dgvCerraduras_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            if (dgvCerraduras.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                dgvCerraduras.EndEdit();
                var item = (GridItem)dgvCerraduras.Rows[e.RowIndex].DataBoundItem;

                if (item.Selected)
                {
                    _model.CerradurasPuertaList.Add(item.Id);
                }
                else
                {
                    _model.CerradurasPuertaList.Remove(item.Id);
                }
            }
        }
        private void rb_AgujaPuertaGenerica_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_AgujaPuertaGenerica.Checked)
            {
                InitializeAgujaPuerta((int)AgujaMode.Todos);
                _model.AgujaPuertaTipo = (int)AgujaMode.Todos;
            }
        }
        private void rb_AgujaPuertaPerfil_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_AgujaPuertaPerfil.Checked)
            {
                InitializeAgujaPuerta((int)AgujaMode.PorPerfil);
                _model.AgujaPuertaTipo = (int)AgujaMode.PorPerfil;
            }
        }
        private void btn_DefinirAgujaPuertaPerfil_Click(object sender, EventArgs e)
        {
            var form = new AgujasModeloPerfil(_model, _context, (int)AgujasTipoModelo.Puerta);
            form.ShowDialog();
        }
        private void txt_ObservacionesPuertas_TextChanged(object sender, EventArgs e)
        {
            _model.ObservacionesPuertas = txt_ObservacionesPuertas.Text;
        }

        private void rb_PorteroSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_PorteroSi.Checked)
                _model.PorteroElectrico = true;
        }

        private void rb_PorteroNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_PorteroNo.Checked)
                _model.PorteroElectrico = false;
        }

        private void rb_CilindrosSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_CilindrosSi.Checked)
            {
                _model.Cilindro = true;
                txt_CilindroMedida.Enabled = true;
            }
        }

        private void rb_CilindrosNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_CilindrosNo.Checked)
            {
                _model.Cilindro = false;
                _model.CilindroMedida = null;

                txt_CilindroMedida.Text = string.Empty;
                txt_CilindroMedida.Enabled = false;
            }
        }

        private void txt_CilindroMedida_TextChanged(object sender, EventArgs e)
        {
            _model.CilindroMedida = int.TryParse(txt_CilindroMedida.Text, out int medida) ? medida : (int?)null;
        }
        #endregion

        #region Private methods
        private void RellenarAgujasPuerta()
        {
            List<Aguja> agujaList = new List<Aguja>();
            agujaList = _context.Agujas.OrderBy(s => s.Id).ToList();

            cmb_AgujaPuerta.SelectedValueChanged -= cmb_AgujaPuerta_SelectedValueChanged;

            cmb_AgujaPuerta.DataSource = null;
            cmb_AgujaPuerta.DataSource = agujaList;
            cmb_AgujaPuerta.DisplayMember = "Nombre";
            cmb_AgujaPuerta.ValueMember = "Id";

            cmb_AgujaPuerta.SelectedIndex = -1;

            cmb_AgujaPuerta.SelectedValueChanged += cmb_AgujaPuerta_SelectedValueChanged;
        }
        private void cmb_AgujaPuerta_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_AgujaPuerta.SelectedIndex != -1 && cmb_AgujaPuerta.SelectedValue != null)
            {
                if (int.TryParse(cmb_AgujaPuerta.SelectedValue.ToString(), out int id))
                {
                    this._model.AgujaPuerta = id;
                }
            }
        }
        private void CrearGridBisagras()
        {
            dgvBisagras.AutoGenerateColumns = false;
            dgvBisagras.AllowUserToAddRows = false;
            dgvBisagras.RowHeadersVisible = false;
            dgvBisagras.ColumnHeadersVisible = false;

            dgvBisagras.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Selected",
                HeaderText = "",
                Width = 30
            });

            dgvBisagras.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Tipo",
                ReadOnly = true,
                Width = 100,
                Name = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvBisagras.ReadOnly = false;
            dgvBisagras.Enabled = true;
        }
        private void CrearGridCerraduraPuerta()
        {
            dgvCerraduras.AutoGenerateColumns = false;
            dgvCerraduras.AllowUserToAddRows = false;
            dgvCerraduras.RowHeadersVisible = false;
            dgvCerraduras.ColumnHeadersVisible = false;

            dgvCerraduras.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Selected",
                HeaderText = "",
                Width = 30
            });

            dgvCerraduras.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Tipo",
                ReadOnly = true,
                Width = 100,
                Name = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvCerraduras.ReadOnly = false;
            dgvCerraduras.Enabled = true;
        }
        private void RellenarGridBisagras()
        {
            var lista = _context.Bisagras
                        .Where(f => f.Activa)
                        .Select(f => new GridItem
                        {
                            Id = f.Id,
                            Nombre = f.Nombre,
                            Selected = _model.BisagrasPuertaList.Contains(f.Id)
                        })
                        .OrderBy(f => f.Id)
                        .ToList();

            _bindingSourceBisagras.DataSource = lista;
            dgvBisagras.DataSource = _bindingSourceBisagras;
        }
        private void RellenarGridCerraduraPuerta()
        {
            var lista = _context.CerradurasPuerta
                        .Where(f => f.Activa)
                        .Select(f => new GridItem
                        {
                            Id = f.Id,
                            Nombre = f.Nombre,
                            Selected = _model.CerradurasPuertaList.Contains(f.Id)
                        })
                        .OrderBy(f => f.Id)
                        .ToList();

            _bindingSourceCerraduras.DataSource = lista;
            dgvCerraduras.DataSource = _bindingSourceCerraduras;
        }
        private void InitializeAgujaPuerta(int agujaPuertaSecTipo)
        {
            switch (agujaPuertaSecTipo)
            {
                case (int)AgujaMode.Todos:
                    rb_AgujaPuertaGenerica.Checked = true;
                    cmb_AgujaPuerta.Enabled = true;
                    cmb_AgujaPuerta.SelectedValue = _model.AgujaPuerta != null ? _model.AgujaPuerta : -1;
                    btn_DefinirAgujaPuertaPerfil.Enabled = false;
                    break;
                case (int)AgujaMode.PorPerfil:
                    rb_AgujaPuertaPerfil.Checked = true;
                    cmb_AgujaPuerta.SelectedValue = -1;
                    cmb_AgujaPuerta.Enabled = false;
                    btn_DefinirAgujaPuertaPerfil.Enabled = true;
                    break;
                default:
                    rb_AgujaPuertaGenerica.Checked = true;
                    cmb_AgujaPuerta.Enabled = true;
                    cmb_AgujaPuerta.SelectedValue = _model.AgujaPuerta != null ? _model.AgujaPuerta : -1;
                    btn_DefinirAgujaPuertaPerfil.Enabled = false;
                    break;
            }

        }
        #endregion

    }
}
