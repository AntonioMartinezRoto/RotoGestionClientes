using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RotoGestionClientes
{
    public partial class PasoDocumentosAsociados : UserControl
    {
        #region Private properties

        private readonly ClientWizardModel _model;
        private ApplicationDbContext _context;
        private BindingSource _bindingSourceDocumentosAsociados = new BindingSource();

        #endregion

        #region Constructors
        public PasoDocumentosAsociados()
        {
            InitializeComponent();
        }
        public PasoDocumentosAsociados(ClientWizardModel model, ApplicationDbContext context)
        {
            InitializeComponent();
            _model = model;
            _context = context;
            CrearGrid();
            CargarDocumentosAsociados();
            txt_ObservacionesDocumentos.Text = _model.ObservacionesMaquinas;

        }
        #endregion

        #region Events
        private void btn_AddDocument_Click(object sender, EventArgs e)
        {
            using var form = new DocumentoAsociadoForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                var item = form.Result;
                //var filePath = form.FilePath;

                _model.DocumentosList.Add(item);

                //AddDocumento(_model.Id, item, filePath);

                CargarDocumentosAsociados();
            }
        }
        private void dgvDocumentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var item = (ClienteDocumentoItem)dgvDocumentos.Rows[e.RowIndex].DataBoundItem;

            if (item == null)
                return;

            string columnName = dgvDocumentos.Columns[e.ColumnIndex].Name;

            if (columnName == "Delete")
            {
                var result = MessageBox.Show(
                    "¿Desea eliminar el documento?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _model.DocumentosList.Remove(item);
                    CargarDocumentosAsociados();
                }
            }
            else if (columnName == "Download")
            {
                // Aún no guardado en BD
                if (!item.Id.HasValue || item.Id.Value <= 0)
                {
                    MessageBox.Show(
                        "Debe guardar el cliente antes de descargar el documento.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                DescargarDocumento(item);
            }
        }
        private void txt_ObservacionesDocumentos_TextChanged(object sender, EventArgs e)
        {
            _model.ObservacionesDocumentos = txt_ObservacionesDocumentos.Text;
        }
        #endregion

        #region Private methods
        private void CrearGrid()
        {
            dgvDocumentos.AutoGenerateColumns = false;
            dgvDocumentos.AllowUserToAddRows = false;
            dgvDocumentos.RowHeadersVisible = false;
            dgvDocumentos.ReadOnly = true;

            dgvDocumentos.Columns.Clear();

            dgvDocumentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = "Documento",
                DataPropertyName = "Nombre",
                Width = 250,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvDocumentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombreFicheroOriginal",
                HeaderText = "Fichero",
                DataPropertyName = "NombreFicheroOriginal",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvDocumentos.Columns.Add(new DataGridViewImageColumn
            {
                Name = "Download",
                HeaderText = "",
                Image = Properties.Resources.download,
                Width = 25,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            });

            dgvDocumentos.Columns.Add(new DataGridViewImageColumn
            {
                Name = "Delete",
                HeaderText = "",
                Image = Properties.Resources.delete,
                Width = 25,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            });
        }
        private void CargarDocumentosAsociados()
        {
            _bindingSourceDocumentosAsociados.DataSource = _model.DocumentosList;
            dgvDocumentos.DataSource = _bindingSourceDocumentosAsociados;
        }
        private byte[] CargarFichero(string path)
        {
            return File.ReadAllBytes(path);
        }
        private void AddDocumento(int clienteId, ClienteDocumentoItem item, string filePath)
        {
            var bytes = File.ReadAllBytes(filePath);

            _context.ClienteDocumentos.Add(new ClienteDocumento
            {
                ClienteId = clienteId,
                Nombre = item.Nombre,
                NombreFicheroOriginal = Path.GetFileName(filePath),
                Extension = Path.GetExtension(filePath),
                Contenido = bytes,
                TamañoBytes = bytes.Length,
                FechaAlta = DateTime.Now
            });
        }
        private void AbrirDocumento(int documentoId)
        {
            var doc = _context.ClienteDocumentos
                .Where(d => d.Id == documentoId)
                .Select(d => new { d.Contenido, d.NombreFicheroOriginal, d.Extension })
                .First();

            string tempPath = Path.Combine(
                Path.GetTempPath(),
                $"{Guid.NewGuid()}{doc.Extension}");

            File.WriteAllBytes(tempPath, doc.Contenido);

            Process.Start(new ProcessStartInfo
            {
                FileName = tempPath,
                UseShellExecute = true
            });
        }
        private void DescargarDocumento(ClienteDocumentoItem item)
        {
            var documento = _context.ClienteDocumentos
                .FirstOrDefault(d => d.Id == item.Id);

            if (documento == null)
            {
                MessageBox.Show(
                    "No se ha encontrado el documento.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            using SaveFileDialog sfd = new SaveFileDialog();

            sfd.FileName = documento.NombreFicheroOriginal;

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            File.WriteAllBytes(sfd.FileName, documento.Contenido);

            MessageBox.Show(
                "Documento descargado correctamente.",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        #endregion

    }
}
