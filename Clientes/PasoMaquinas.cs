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
        private BindingSource _bindingSource = new BindingSource();

        #endregion

        #region Constructors
        public PasoMaquinas()
        {
            InitializeComponent();
        }
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
            CargarTextos();
            CrearGrid();
            CargarMaquinasGrid();

            rb_BisagraSoldadoraSi.Checked = _model.BisagraEnSoldadora;
            rb_BisagraSoldadoraNo.Checked = !_model.BisagraEnSoldadora;

            rb_TripleTaladroCentroSi.Checked = _model.TripleTaladroCentro;
            rb_TripleTaladroCentroNo.Checked = !_model.TripleTaladroCentro;

            switch (_model.SoporteMarcoConfigId)
            {
                case (int)Enums.SoporteMarcoConfig.CentroMecanizado:
                    rb_SoporteCentro.Checked = true;
                    break;
                case (int)Enums.SoporteMarcoConfig.Plantilla:
                    rb_SoportePlantilla.Checked = true;
                    break;
                case (int)Enums.SoporteMarcoConfig.BancoMarcos:
                    rb_SoporteBanco.Checked = true;
                    break;
                default:
                    rb_SoporteCentro.Checked = true; // Default to config 1 if not set
                    break;
            }

            txt_ObservacionesMaquinas.Text = _model.ObservacionesMaquinas;
        }

        private void CargarTextos()
        {
            group_Maquinas.Text = Lang.Maquinas;
            groupCentroTripleTaladro.Text = Lang.TripleTaladroCentro;
            groupSoldadoraBisagras.Text = Lang.BisagrasSoldadora;
            groupSoporteMarco.Text = Lang.SoporteMarco;
            rb_BisagraSoldadoraNo.Text = Lang.No;
            rb_BisagraSoldadoraSi.Text = Lang.Si;
            rb_SoporteBanco.Text = Lang.BancoMarcos;
            rb_SoporteCentro.Text = Lang.CentroMecanizado;
            rb_SoportePlantilla.Text = Lang.Plantilla;
            rb_TripleTaladroCentroNo.Text = Lang.No;
            rb_TripleTaladroCentroSi.Text = Lang.Si;
            group_Comentarios.Text = Lang.Comentarios;
        }

        private void txt_ObservacionesMaquinas_TextChanged(object sender, EventArgs e)
        {
            _model.ObservacionesMaquinas = txt_ObservacionesMaquinas.Text;
        }
        private void btn_AddMaquina_Click(object sender, EventArgs e)
        {
            var maquinasForm = new DefinicionMaquinas(_context);

            if (maquinasForm.ShowDialog() == DialogResult.OK)
            {
                _model.MaquinasList.Add(maquinasForm.Result);
                CargarMaquinasGrid();
            }
        }
        private void dgvMaquinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var item = (ClienteMaquinaItem)dgvMaquinas.Rows[e.RowIndex].DataBoundItem;
            if (item == null) return;

            if (dgvMaquinas.Columns[e.ColumnIndex].Name == "Edit")
            {
                var form = new DefinicionMaquinas(_context, item);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    _model.MaquinasList[e.RowIndex] = form.Result;
                    CargarMaquinasGrid();
                }
            }

            if (dgvMaquinas.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Se va a eliminar la máquina seleccionada. ¿Desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _model.MaquinasList.RemoveAt(e.RowIndex);
                    CargarMaquinasGrid();
                }
            }
        }
        private void rb_BisagraSoldadoraSi_CheckedChanged(object sender, EventArgs e)
        {
            _model.BisagraEnSoldadora = rb_BisagraSoldadoraSi.Checked;
        }
        private void rb_BisagraSoldadoraNo_CheckedChanged(object sender, EventArgs e)
        {
            _model.BisagraEnSoldadora = !rb_BisagraSoldadoraNo.Checked;
        }
        private void rb_TripleTaladroCentroSi_CheckedChanged(object sender, EventArgs e)
        {
            _model.TripleTaladroCentro = rb_TripleTaladroCentroSi.Checked;
        }
        private void rb_TripleTaladroCentroNo_CheckedChanged(object sender, EventArgs e)
        {
            _model.TripleTaladroCentro = !rb_TripleTaladroCentroNo.Checked;
        }
        private void rb_SoporteCentro_CheckedChanged(object sender, EventArgs e)
        {
            _model.SoporteMarcoConfigId = (int)Enums.SoporteMarcoConfig.CentroMecanizado;
        }
        private void rb_SoportePlantilla_CheckedChanged(object sender, EventArgs e)
        {
            _model.SoporteMarcoConfigId = (int)Enums.SoporteMarcoConfig.Plantilla;
        }
        private void rb_SoporteBanco_CheckedChanged(object sender, EventArgs e)
        {
            _model.SoporteMarcoConfigId = (int)Enums.SoporteMarcoConfig.BancoMarcos;
        }
        #endregion

        #region Private methods
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
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvMaquinas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MarcaNombre",
                HeaderText = "Marca",
                DataPropertyName = "MarcaNombre",
                Width = 200
            });
            dgvMaquinas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MantenimientoNombre",
                HeaderText = "Mantenimiento",
                DataPropertyName = "MantenimientoNombre",
                Width = 200
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
        private void CargarMaquinasGrid()
        {
            _bindingSource.DataSource = _model.MaquinasList;
            dgvMaquinas.DataSource = _bindingSource;
        }
        #endregion
    }

    public class ClienteMaquinaItem
    {
        public int? Id { get; set; } // null = nuevo

        public int MaquinaTipoId { get; set; }
        public string Descripcion { get; set; } = null!;

        public int? MaquinaMarcaId { get; set; }
        public string? MarcaNombre { get; set; }

        public int MaquinaMantenimientoId { get; set; }
        public string MantenimientoNombre { get; set; } = null!;

        public string? Observaciones { get; set; }
    }
}
