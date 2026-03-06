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
    public partial class PasoBalconeras : UserControl
    {
        #region Private properties

        private readonly ClientWizardModel _model;
        private ApplicationDbContext _context;
        private BindingSource _bindingSourceSeguridadVentana = new BindingSource();
        private BindingSource _bindingSourceCremonaPasiva = new BindingSource();
        private BindingSource _bindingSourceBisagras = new BindingSource();

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

            RellenarAgujasBalconeras();
            CrearGridCremonaPasivas();
            CrearGridSeguridadBalconera();
            RellenarGridSeguridadBalconera();
            RellenarGridCremonaPasivas();

            rb_AgujaBalcGenerica.CheckedChanged -= rb_AgujaBalcGenerica_CheckedChanged;
            rb_AgujaBalcPerfil.CheckedChanged -= rb_AgujaBalcPerfil_CheckedChanged;

            InitializeAgujaBalconera(_model.AgujaBalconeraTipo);

            rb_AgujaBalcGenerica.CheckedChanged += rb_AgujaBalcGenerica_CheckedChanged;
            rb_AgujaBalcPerfil.CheckedChanged += rb_AgujaBalcPerfil_CheckedChanged;




            CrearGridBisagras();
            RellenarGridBisagras();

            RellenarAgujasPuertaSec();
            InitializeAgujaPuertaSec(_model.AgujaPuertaSecTipo);

            rb_AgujaPuertaSecGenerica.CheckedChanged += rb_AgujaPuertaSecGenerica_CheckedChanged;
            rb_AgujaPuertaSecPerfil.CheckedChanged += rb_AgujaPuertaSecPerfil_CheckedChanged;

        }

        private void txt_ObservacionesBalconeras_TextChanged(object sender, EventArgs e)
        {
            _model.ObservacionesBalconeras = txt_ObservacionesBalconeras.Text;
        }
        private void cmb_AgujaBalconeras_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_AgujaBalconeras.SelectedIndex != -1 && cmb_AgujaBalconeras.SelectedValue != null)
            {
                if (int.TryParse(cmb_AgujaBalconeras.SelectedValue.ToString(), out int id))
                {
                    this._model.AgujaBalconera = id;
                }
            }
        }
        private void cmb_AgujaPuertaSec_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_AgujaPuertaSec.SelectedIndex != -1 && cmb_AgujaPuertaSec.SelectedValue != null)
            {
                if (int.TryParse(cmb_AgujaPuertaSec.SelectedValue.ToString(), out int id))
                {
                    this._model.AgujaPuertaSec = id;
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
        private void dgvBisagras_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            if (dgvBisagras.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                dgvBisagras.EndEdit();
                var item = (GridItem)dgvBisagras.Rows[e.RowIndex].DataBoundItem;

                if (item.Selected)
                {
                    _model.BisagrasPuertaSecList.Add(item.Id);
                }
                else
                {
                    _model.BisagrasPuertaSecList.Remove(item.Id);
                }
            }
        }
        private void rb_AgujaBalcGenerica_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_AgujaBalcGenerica.Checked)
            {
                InitializeAgujaBalconera((int)AgujaMode.Todos);
                _model.AgujaBalconeraTipo = (int)AgujaMode.Todos;
            }
        }
        private void rb_AgujaBalcPerfil_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_AgujaBalcPerfil.Checked)
            {
                InitializeAgujaBalconera((int)AgujaMode.PorPerfil);
                _model.AgujaBalconeraTipo = (int)AgujaMode.PorPerfil;
            }
        }
        private void btn_DefinitAgujaBalPerfil_Click(object sender, EventArgs e)
        {
            var form = new AgujasModeloPerfil(_model, _context, (int)AgujasTipoModelo.Balconera);
            form.ShowDialog();
        }
        private void rb_AgujaPuertaSecGenerica_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_AgujaPuertaSecGenerica.Checked)
            {
                InitializeAgujaPuertaSec((int)AgujaMode.Todos);
                _model.AgujaPuertaSecTipo = (int)AgujaMode.Todos;
            }
        }
        private void rb_AgujaPuertaSecPerfil_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_AgujaPuertaSecPerfil.Checked)
            {
                InitializeAgujaPuertaSec((int)AgujaMode.PorPerfil);
                _model.AgujaPuertaSecTipo = (int)AgujaMode.PorPerfil;
            }
        }

        private void btn_DefinirAgujaPuertaSecPerfil_Click(object sender, EventArgs e)
        {
            var form = new AgujasModeloPerfil(_model, _context, (int)AgujasTipoModelo.PuertaSecundaria);
            form.ShowDialog();
        }
        #endregion

        #region Private methods
        private void RellenarAgujasBalconeras()
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
        private void RellenarAgujasPuertaSec()
        {
            List<Aguja> agujaList = new List<Aguja>();
            agujaList = _context.Agujas.OrderBy(s => s.Id).ToList();

            cmb_AgujaPuertaSec.SelectedValueChanged -= cmb_AgujaPuertaSec_SelectedValueChanged;

            cmb_AgujaPuertaSec.DataSource = null;
            cmb_AgujaPuertaSec.DataSource = agujaList;
            cmb_AgujaPuertaSec.DisplayMember = "Nombre";
            cmb_AgujaPuertaSec.ValueMember = "Id";

            cmb_AgujaPuertaSec.SelectedIndex = -1;

            cmb_AgujaPuertaSec.SelectedValueChanged += cmb_AgujaPuertaSec_SelectedValueChanged;
        }
        private void CrearGridSeguridadBalconera()
        {
            dgvSeguridad.AutoGenerateColumns = false;
            dgvSeguridad.AllowUserToAddRows = false;
            dgvSeguridad.RowHeadersVisible = false;
            dgvSeguridad.ColumnHeadersVisible = false;

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
            dgvPasivas.ColumnHeadersVisible = false;

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
        private void RellenarGridSeguridadBalconera()
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
        private void RellenarGridBisagras()
        {
            var lista = _context.Bisagras
                        .Select(f => new GridItem
                        {
                            Id = f.Id,
                            Nombre = f.Nombre,
                            Selected = _model.BisagrasPuertaSecList.Contains(f.Id)
                        })
                        .OrderBy(f => f.Id)
                        .ToList();

            _bindingSourceBisagras.DataSource = lista;
            dgvBisagras.DataSource = _bindingSourceBisagras;
        }
        private void InitializeAgujaBalconera(int agujaBalconeraTipo)
        {
            switch (agujaBalconeraTipo)
            {
                case (int)AgujaMode.Todos:
                    rb_AgujaBalcGenerica.Checked = true;
                    cmb_AgujaBalconeras.Enabled = true;
                    cmb_AgujaBalconeras.SelectedValue = _model.AgujaBalconera != null ? _model.AgujaBalconera : -1;
                    btn_DefinitAgujaBalPerfil.Enabled = false;
                    break;
                case (int)AgujaMode.PorPerfil:
                    rb_AgujaBalcPerfil.Checked = true;
                    cmb_AgujaBalconeras.SelectedValue = -1;
                    cmb_AgujaBalconeras.Enabled = false;
                    btn_DefinitAgujaBalPerfil.Enabled = true;
                    break;
                default:
                    rb_AgujaBalcGenerica.Checked = true;
                    cmb_AgujaBalconeras.Enabled = true;
                    cmb_AgujaBalconeras.SelectedValue = _model.AgujaBalconera != null ? _model.AgujaBalconera : -1;
                    btn_DefinitAgujaBalPerfil.Enabled = false;
                    break;
            }

        }
        private void InitializeAgujaPuertaSec(int agujaPuertaSecTipo)
        {
            switch (agujaPuertaSecTipo)
            {
                case (int)AgujaMode.Todos:
                    rb_AgujaPuertaSecGenerica.Checked = true;
                    cmb_AgujaPuertaSec.Enabled = true;
                    cmb_AgujaPuertaSec.SelectedValue = _model.AgujaPuertaSec != null ? _model.AgujaPuertaSec : -1;
                    btn_DefinirAgujaPuertaSecPerfil.Enabled = false;
                    break;
                case (int)AgujaMode.PorPerfil:
                    rb_AgujaPuertaSecPerfil.Checked = true;
                    cmb_AgujaPuertaSec.SelectedValue = -1;
                    cmb_AgujaPuertaSec.Enabled = false;
                    btn_DefinirAgujaPuertaSecPerfil.Enabled = true;
                    break;
                default:
                    rb_AgujaPuertaSecGenerica.Checked = true;
                    cmb_AgujaPuertaSec.Enabled = true;
                    cmb_AgujaPuertaSec.SelectedValue = _model.AgujaPuertaSec != null ? _model.AgujaPuertaSec : -1;
                    btn_DefinirAgujaPuertaSecPerfil.Enabled = false;
                    break;
            }

        }
        #endregion






    }
}
