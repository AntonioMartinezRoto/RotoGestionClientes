using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RotoGestionClientes
{
    public partial class AgujasModeloPerfil : Form
    {
        #region Private properties

        private ApplicationDbContext _context;
        private readonly ClientWizardModel _model;
        private readonly int _agujaModeloTipoId;

        private BindingSource _binding = new();

        #endregion

        #region Constructors

        public AgujasModeloPerfil()
        {
            InitializeComponent();
        }
        public AgujasModeloPerfil(ClientWizardModel model, ApplicationDbContext context, int agujaModeloTipoId)
        {
            InitializeComponent();
            _context = context;
            _model = model;
            _agujaModeloTipoId = agujaModeloTipoId;

            CrearGrid();
            CargarDatos();
        }
        #endregion

        #region Events
        private void dgvAgujas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == dgvAgujas.Columns["Aguja"].Index && e.RowIndex >= 0)
            //{
            //    dgvAgujas.BeginEdit(true);
            //}
        }
        private void dgvAgujas_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dgvAgujas.Columns["Aguja"].Index && e.RowIndex >= 0)
            {
                dgvAgujas.BeginEdit(true);
            }
        }

        private void dgvAgujas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //if (dgvAgujas.CurrentCell.ColumnIndex == dgvAgujas.Columns["Aguja"].Index)
            //{
            //    if (e.Control is ComboBox combo)
            //    {
            //        combo.DroppedDown = true;
            //    }
            //}
        }
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            dgvAgujas.EndEdit();

            var lista = (List<AgujaPerfilGridItem>)_binding.DataSource;

            // eliminar datos previos del tipo
            _model.AgujasModeloPerfilList.RemoveAll(a =>
                a.AgujaModeloTipoId == _agujaModeloTipoId);

            foreach (var item in lista)
            {
                if (item.AgujaId.HasValue)
                {
                    _model.AgujasModeloPerfilList.Add(new AgujaModeloPerfilItem
                    {
                        AgujaModeloTipoId = _agujaModeloTipoId,
                        PerfilId = item.PerfilId,
                        AgujaId = item.AgujaId.Value
                    });
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }
        #endregion

        #region Private methods
        private void CrearGrid()
        {
            dgvAgujas.AutoGenerateColumns = false;
            dgvAgujas.AllowUserToAddRows = false;
            dgvAgujas.RowHeadersVisible = false;

            dgvAgujas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PerfilNombre",
                HeaderText = "Perfil",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            var combo = new DataGridViewComboBoxColumn
            {
                DataPropertyName = "AgujaId",
                HeaderText = "Aguja",
                DisplayMember = "Nombre",
                ValueMember = "Id",
                Name = "Aguja",
                Width = 200,
                FlatStyle = FlatStyle.Flat
            };

            combo.DataSource = _context.Agujas
                .OrderBy(a => a.Id)
                .ToList();

            dgvAgujas.Columns.Add(combo);
        }
        private void CargarDatos()
        {
            var perfiles = _context.Perfiles
                .Where(p => _model.PerfilesList.Contains(p.Id))
                .Select(p => new
                {
                    p.Id,
                    Nombre = p.Nombre + " (" + p.PerfilTipo.NombreAbreviado + ")"
                })
                .ToList();

            var lista = new List<AgujaPerfilGridItem>();

            foreach (var perfil in perfiles)
            {
                var existente = _model.AgujasModeloPerfilList
                    .FirstOrDefault(a =>
                        a.PerfilId == perfil.Id &&
                        a.AgujaModeloTipoId == _agujaModeloTipoId);

                lista.Add(new AgujaPerfilGridItem
                {
                    PerfilId = perfil.Id,
                    PerfilNombre = perfil.Nombre,
                    AgujaId = existente?.AgujaId
                });
            }

            _binding.DataSource = lista;
            dgvAgujas.DataSource = _binding;
        }
        #endregion



    }
    public class AgujaPerfilGridItem
    {
        public int PerfilId { get; set; }

        public string PerfilNombre { get; set; } = "";

        public int? AgujaId { get; set; }
    }
}
