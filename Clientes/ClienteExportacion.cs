using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RotoGestionClientes
{
    public partial class ClienteExportacion : Form
    {
        #region Private properties

        private ApplicationDbContext _context;
        private List<ClienteExportGridItem> _clientes;
        private BindingSource _bindingSource = new();
        private ClienteExportService _clienteExportService;

        #endregion

        #region Constructors
        public ClienteExportacion()
        {
            InitializeComponent();
        }
        public ClienteExportacion(ApplicationDbContext context)
        {
            InitializeComponent();
            this._context = context;
            this._clienteExportService = new ClienteExportService(_context);
        }
        #endregion

        #region Events
        private void ClienteExportacion_Load(object sender, EventArgs e)
        {
            CrearGrid();
            LoadClientes();
        }
        private async void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            dgvClientes.EndEdit();

            var seleccionados = _clientes
                .Where(x => x.Seleccionado)
                .ToList();

            if (!seleccionados.Any())
            {
                MessageBox.Show(
                    "Seleccione al menos un cliente.");

                return;
            }

            using var folderDialog = new FolderBrowserDialog();

            folderDialog.Description = "Seleccione carpeta destino";

            if (folderDialog.ShowDialog() != DialogResult.OK)
                return;

            string carpetaDestino = folderDialog.SelectedPath;
            using var progressForm = new ExportProgressForm();
            progressForm.Inicializar(seleccionados.Count);
            progressForm.Show(this);

            btn_Aceptar.Enabled = false;

            try
            {
                var progress =
                    new Progress<ExportProgressInfo>(
                        info =>
                        {
                            progressForm.Actualizar(info);
                        });

                await Task.Run(() =>
                {
                    ExportarClientes(seleccionados, carpetaDestino, progress);
                });

                progressForm.Close();

                MessageBox.Show(
                    $"Se han exportado {seleccionados.Count} clientes.",
                    "Exportación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btn_Aceptar.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
        }
        private void txt_Filtro_TextChanged(object sender, EventArgs e)
        {
            var texto = txt_Filtro.Text.Trim().ToLower();

            var filtrados = _clientes
                .Where(x => string.IsNullOrEmpty(texto) || x.Nombre.ToLower().Contains(texto))
                .ToList();

            _bindingSource.DataSource = filtrados;

            ActualizarCheckSeleccionarTodos();
        }
        private void chkSeleccionarTodos_CheckedChanged(object sender, EventArgs e)
        {
            bool seleccionado = chkSeleccionarTodos.Checked;

            foreach (DataGridViewRow row in dgvClientes.Rows)
            {
                if (row.DataBoundItem is ClienteExportGridItem item)
                {
                    item.Seleccionado = seleccionado;
                }
            }

            dgvClientes.Refresh();

            ActualizarContador();
        }
        private void dgvClientes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ActualizarContador();

            chkSeleccionarTodos.CheckedChanged -= chkSeleccionarTodos_CheckedChanged;

            chkSeleccionarTodos.Checked = _clientes.All(x => x.Seleccionado);

            chkSeleccionarTodos.CheckedChanged += chkSeleccionarTodos_CheckedChanged;

            ActualizarCheckSeleccionarTodos();
        }
        private void dgvClientes_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvClientes.IsCurrentCellDirty)
            {
                dgvClientes.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        #endregion

        #region Private methods
        private void CrearGrid()
        {
            dgvClientes.AutoGenerateColumns = false;

            dgvClientes.Columns.Clear();

            dgvClientes.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "Seleccionado",
                HeaderText = "",
                DataPropertyName = "Seleccionado",
                Width = 40
            });

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = "Cliente",
                DataPropertyName = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }
        private void LoadClientes()
        {
            _clientes = _context.Clientes
                .AsNoTracking()
                .OrderBy(x => x.Nombre)
                .Select(x => new ClienteExportGridItem
                {
                    Id = x.Id,
                    Nombre = x.Nombre
                })
                .ToList();

            _bindingSource.DataSource = _clientes;

            dgvClientes.DataSource = _bindingSource;
        }
        private void ExportarClientes(List<ClienteExportGridItem> clientes, string carpetaDestino, IProgress<ExportProgressInfo> progress)
        {
            int total = clientes.Count;
            int actual = 0;

            foreach (var cliente in clientes)
            {
                actual++;

                progress.Report(
                    new ExportProgressInfo
                    {
                        Actual = actual,
                        Total = total,
                        ClienteNombre = cliente.Nombre
                    });

                _clienteExportService.ExportarClienteDeLista(cliente.Id, carpetaDestino);
            }
        }
        private void ActualizarContador()
        {
            int seleccionados = _clientes.Count(x => x.Seleccionado);

            lblSeleccionados.Text = $"Seleccionados: {seleccionados}";
        }
        private void ActualizarCheckSeleccionarTodos()
        {
            var visibles = dgvClientes.Rows
                .Cast<DataGridViewRow>()
                .Select(r => r.DataBoundItem as ClienteExportGridItem)
                .Where(x => x != null)
                .ToList();

            chkSeleccionarTodos.CheckedChanged -=
                chkSeleccionarTodos_CheckedChanged;

            chkSeleccionarTodos.Checked =
                visibles.Any() &&
                visibles.All(x => x!.Seleccionado);

            chkSeleccionarTodos.CheckedChanged +=
                chkSeleccionarTodos_CheckedChanged;
        }
        #endregion
    }

    public class ClienteExportGridItem
    {
        public bool Seleccionado { get; set; }

        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;
    }
}
