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
            CargarMaquinasGrid();
            txt_ObservacionesMaquinas.Text = _model.ObservacionesMaquinas;
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
