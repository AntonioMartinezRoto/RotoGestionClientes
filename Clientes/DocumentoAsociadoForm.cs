using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RotoGestionClientes
{
    public partial class DocumentoAsociadoForm : Form
    {
        #region Private properties
        #endregion

        #region Public properties
        public ClienteDocumentoItem Result { get; private set; }
        public string FilePath { get; private set; }
        #endregion

        #region Constructors
        public DocumentoAsociadoForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Events
        private void DocumentoAsociadoForm_Load(object sender, EventArgs e)
        {
            CargarTextos();
            lblFichero.Text = Lang.NingunFichero;
        }
        #endregion

        #region Private methods


        private void CargarTextos()
        {
            lbl_NombreDoc.Text = Lang.NombreDocumento;
            btn_Aceptar.Text = Lang.Guardar;
            btn_Cancelar.Text = Lang.Cancelar;
            btn_Seleccionar.Text = Lang.SeleccionarDocumento;
        }
        #endregion



        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Documentos|*.pdf;*.doc;*.docx;*.xls;*.xlsx;*.txt|Todos los archivos|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FilePath = ofd.FileName;
                    lblFichero.Text = Path.GetFileName(FilePath);
                }
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FilePath) || !File.Exists(FilePath))
            {
                MessageBox.Show(Lang.DocumentoObligatorio, Lang.Validacion,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_Nombre.Text))
            {
                MessageBox.Show(Lang.IndicarNombreDoc, Lang.Validacion,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            byte[] bytes = File.ReadAllBytes(FilePath);

            Result = new ClienteDocumentoItem
            {
                Nombre = txt_Nombre.Text,
                NombreFicheroOriginal = Path.GetFileName(FilePath),
                Extension = Path.GetExtension(FilePath),
                Contenido = bytes,
                TamañoBytes = bytes.Length
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
