using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RotoGestionClientes
{
    public partial class FiltroForm : Form
    {
        #region Private properties

        private readonly BindingList<FiltroItem> _items;

        #endregion

        #region Public properties
        public List<int> SelectedIds =>
                        _items
                            .Where(x => x.Selected)
                            .Select(x => x.Id)
                            .ToList();
        #endregion

        #region Constructors
        public FiltroForm()
        {
            InitializeComponent();
        }
        public FiltroForm(List<FiltroItem> items)
        {
            InitializeComponent();

            _items = new BindingList<FiltroItem>(items);

            CrearGrid();

            dgvItems.DataSource = _items;
        }
        #endregion

        #region Events
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        #endregion

        #region Private methods
        private void CrearGrid()
        {
            dgvItems.AutoGenerateColumns = false;

            dgvItems.Columns.Clear();

            dgvItems.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Selected",
                Width = 40
            });

            dgvItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }
        #endregion
    }
}
