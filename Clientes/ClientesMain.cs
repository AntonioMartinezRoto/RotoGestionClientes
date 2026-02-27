using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class ClientesMain : Form
    {
        #region Private properties

        private readonly ApplicationDbContext _context;
        private List<ClienteGridItem> _allClientes = new();
        #endregion

        #region Constructors
        public ClientesMain()
        {
            InitializeComponent();
            _context = Program.AppServices.GetRequiredService<ApplicationDbContext>();
            ConfigureGrid();
        }

        #endregion

        #region Events

        private void ClientesMain_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadClientesFromDB();
            Cursor.Current = Cursors.Default;
        }
        private void txt_Filtro_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex < 0)
            //    return;

            //if (dgvClientes.Columns[e.ColumnIndex].Name == "Edit")
            //{
            //    int clienteId = (int)dgvClientes.Rows[e.RowIndex].Cells["Id"].Value;
            //    string clienteName = dgvClientes.Rows[e.RowIndex].Cells["Nombre"].ToString();

            //    ClientesEditForm clientesEditForm = new ClientesEditForm(clienteName, clienteId, _context);
            //    clientesEditForm.ShowDialog();

            //}
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var cliente = (ClienteGridItem)dgvClientes.Rows[e.RowIndex].DataBoundItem;

            if (dgvClientes.Columns[e.ColumnIndex].Name == "Edit")
            {
                //ClientesEditForm clientesEditForm = new ClientesEditForm(cliente, _context);
                ClienteWizard clienteWizard = new ClienteWizard(WizardMode.Edit, this._context, cliente.Id);
                clienteWizard.ShowDialog();
            }
            else if (dgvClientes.Columns[e.ColumnIndex].Name == "Delete")
            {

                //DeleteCliente(cliente.Id);
            }
            LoadClientesFromDB();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            ClienteWizard clienteWizard = new ClienteWizard(WizardMode.Create, this._context);
            clienteWizard.ShowDialog();
            LoadClientesFromDB();
        }
        #endregion

        #region Private methods

        private void ConfigureGrid()
        {
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.ReadOnly = true;

            dgvClientes.Columns.Clear();

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "Id",
                Width = 60,
                Visible = false
            });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            //dgvClientes.Columns.Add(new DataGridViewButtonColumn
            //{
            //    Name = "Edit",
            //    HeaderText = "",
            //    Text = "Editar",
            //    UseColumnTextForButtonValue = true,
            //    Width = 80,
            //    AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            //});
            //dgvClientes.Columns.Add(new DataGridViewButtonColumn
            //{
            //    Name = "Delete",
            //    HeaderText = "",
            //    Text = "Borrar",
            //    UseColumnTextForButtonValue = true,
            //    Width = 80,
            //    AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            //});

            dgvClientes.Columns.Add(new DataGridViewImageColumn
            {
                Name = "Edit",
                HeaderText = "",
                Image = Properties.Resources.edit,
                Width = 25,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            });

            dgvClientes.Columns.Add(new DataGridViewImageColumn
            {
                Name = "Delete",
                HeaderText = "",
                Image = Properties.Resources.delete,
                Width = 25,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            });
        }
        private void LoadClientesFromDB()
        {
            _allClientes = _context.Clientes
                .Select(f => new ClienteGridItem
                {
                    Id = f.Id,
                    Nombre = f.Nombre
                })
                .OrderBy(f => f.Nombre)
                .ToList();

            ApplyFilter();
        }
        private void ApplyFilter()
        {
            string filter = txt_Filtro.Text.Trim();

            if (string.IsNullOrWhiteSpace(filter))
            {
                lbl_Total.Text = "Total: " + _allClientes.Count().ToString();
                dgvClientes.DataSource = _allClientes;
                return;
            }

            var filtered = _allClientes
                .Where(f =>
                    (!string.IsNullOrEmpty(f.Nombre) &&
                     f.Nombre.Contains(filter, StringComparison.OrdinalIgnoreCase))
                )
                .ToList();

            lbl_Total.Text = "Total: " + filtered.Count().ToString();
            dgvClientes.DataSource = filtered;
        }
        #endregion



    }
}
