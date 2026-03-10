using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RotoGestionClientes
{
    public partial class Cilindros : Form
    {
        #region Private properties

        private ApplicationDbContext _context;
        private readonly ClientWizardModel _model;
        private readonly int _agujaModeloTipoId;

        private BindingSource _binding = new();

        #endregion

        #region Constructors

        public Cilindros()
        {
            InitializeComponent();
        }
        public Cilindros(ClientWizardModel model, ApplicationDbContext context)
        {
            InitializeComponent();
            _context = context;
            _model = model;

            CrearGridCilindros();
            CargarCilindros();
        }
        #endregion

        #region Events
        private void dgvCilindros_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            if (dgvCilindros.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                dgvCilindros.EndEdit();
            }
        }
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            dgvCilindros.EndEdit();

            var lista = (List<CilindroGridItem>)_binding.DataSource;

            _model.CilindroList = lista
                .Where(x => x.Selected)
                .Select(x => x.Id)
                .ToList();

            DialogResult = DialogResult.OK;
            Close();
        }
        #endregion

        #region Private methods
        private void CrearGridCilindros()
        {
            dgvCilindros.AutoGenerateColumns = false;
            dgvCilindros.AllowUserToAddRows = false;
            dgvCilindros.RowHeadersVisible = false;

            dgvCilindros.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Selected",
                HeaderText = "",
                Width = 30
            });

            dgvCilindros.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CilindroTipoNombre",
                HeaderText = "Tipo",
                ReadOnly = true,
                Width = 90
            });

            dgvCilindros.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MedidaInterior",
                HeaderText = "Interior",
                ReadOnly = true,
                Width = 60
            });

            dgvCilindros.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MedidaExterior",
                HeaderText = "Exterior",
                ReadOnly = true,
                Width = 60
            });

            dgvCilindros.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nomenclatura",
                HeaderText = "Nomenclatura",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvCilindros.ReadOnly = false;
        }
        private void CargarCilindros()
        {
            var lista = _context.Cilindros
                .Where(c => c.Activa)
                .Select(c => new CilindroGridItem
                {
                    Id = c.Id,
                    Selected = _model.CilindroList.Contains(c.Id),
                    CilindroTipoNombre = c.CilindroTipo.Nombre,
                    MedidaInterior = c.MedidaInterior,
                    MedidaExterior = c.MedidaExterior,
                    Nomenclatura = c.Nomenclatura
                })
                .OrderBy(c => c.CilindroTipoNombre)
                .ThenBy(c => c.MedidaInterior)
                .ThenBy(c => c.MedidaExterior)
                .ToList();

            _binding.DataSource = lista;
            dgvCilindros.DataSource = _binding;
        }
        #endregion


    }
    public class CilindroGridItem
    {
        public int Id { get; set; }

        public bool Selected { get; set; }

        public string CilindroTipoNombre { get; set; } = "";

        public int MedidaInterior { get; set; }

        public int MedidaExterior { get; set; }

        public string Nomenclatura { get; set; } = "";
    }
}
