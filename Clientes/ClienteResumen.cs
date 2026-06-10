using Microsoft.EntityFrameworkCore;
using RotoGestionClientes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RotoGestionClientes
{
    public partial class ClienteResumen : Form
    {
        #region Private properties
        private readonly ApplicationDbContext _context;
        private int _clienteId;
        #endregion

        #region Constructors
        public ClienteResumen()
        {
            InitializeComponent();
        }
        public ClienteResumen(ApplicationDbContext _context, int clienteId)
        {
            InitializeComponent();
            this._context = _context;
            this._clienteId = clienteId;
        }
        #endregion

        #region Events
        private void ClienteResumen_Load(object sender, EventArgs e)
        {
            ConfigurarFormulario();
            CargarDatos();
            pictureBox1.Focus();
        }
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_ExportarPdf_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Pendiente implementación PDF",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        #endregion

        #region Private methods
        private void ConfigurarFormulario()
        {
            StartPosition = FormStartPosition.CenterParent;
            WindowState = FormWindowState.Maximized;

            dgvMaquinas.AutoGenerateColumns = false;
            dgvMaquinas.AllowUserToAddRows = false;
            dgvMaquinas.AllowUserToDeleteRows = false;
            dgvMaquinas.ReadOnly = true;
            dgvMaquinas.SelectionMode =
                DataGridViewSelectionMode.CellSelect;

            dgvMaquinas.RowHeadersVisible = false;

            dgvMaquinas.Columns.Clear();

            dgvMaquinas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Tipo",
                HeaderText = "Tipo",
                DataPropertyName = "Tipo",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvMaquinas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Marca",
                HeaderText = "Marca",
                DataPropertyName = "Marca",
                Width = 200
            });

            dgvMaquinas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Mantenimiento",
                HeaderText = "Mantenimiento",
                DataPropertyName = "Mantenimiento",
                Width = 200
            });

            dgvMaquinas.EnableHeadersVisualStyles = false;

            dgvMaquinas.ColumnHeadersDefaultCellStyle.BackColor =
                Color.DimGray;

            dgvMaquinas.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvMaquinas.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);
        }
        private void CargarDatos()
        {
            #region Inicialización Cliente

            var cliente = _context.Clientes
                                .AsNoTracking()
                                .Where(x => x.Id == _clienteId)
                                .Select(c => new
                                {
                                    c.Nombre,
                                    c.SapId,
                                    c.Alias,
                                    c.Comentarios,

                                    Softwares = c.ClienteSoftwares
                                        .Select(x => x.Software.Nombre)
                                        .ToList(),

                                    Perfiles = c.ClientePerfiles
                                        .Select(x =>
                                            x.Perfil.Nombre + " (" +
                                            x.Perfil.PerfilTipo.NombreAbreviado + ")")
                                        .ToList(),

                                    SeguridadVentanas = c.ClienteSeguridadVentanas
                                        .Select(x => x.SeguridadVentana.Nombre)
                                        .ToList(),

                                    SeguridadBalconeras = c.ClienteSeguridadBalconeras
                                        .Select(x => x.SeguridadBalconera.Nombre)
                                        .ToList(),

                                    CremonasVentana = c.ClienteCremonaPasivaVentanas
                                        .Select(x => x.CremonaPasivaVentanaTipo.Nombre)
                                        .ToList(),

                                    CremonasVentanaPract = c.ClienteCremonaPasivaVentanasPract
                                        .Select(x => x.CremonaPasivaVentanaTipo.Nombre)
                                        .ToList(),

                                    CremonasBalconera = c.ClienteCremonaPasivaBalconeras
                                        .Select(x => x.CremonaPasivaBalconeraTipo.Nombre)
                                        .ToList(),

                                    ClienteAgujas = c.ClienteAgujases,
                                    ClienteAgustasModeloPerfil = c.ClienteAgujasModelos,
                                    ClienteConfiguracionElevablePlegable = c.ClienteConfiguracionElevablePlegable,

                                    Manillas = c.ClienteManillas
                                        .Select(x => x.Manilla.Nombre)
                                        .ToList(),

                                    Bisagras = c.ClienteBisagraPuertas
                                        .Select(x => x.Bisagra.Nombre)
                                        .ToList(),

                                    Cerraduras = c.ClienteCerradurasPuerta
                                        .Select(x => x.CerraduraPuerta.Nombre)
                                        .ToList(),

                                    Maquinas = c.ClienteMaquinas
                                        .Select(x => new ClienteResumenMaquinaItem
                                        {
                                            Tipo = x.MaquinaTipo.Descripcion,

                                            Marca = x.MaquinaMarca != null
                                                ? x.MaquinaMarca.Nombre
                                                : string.Empty,

                                            Mantenimiento =
                                                x.MaquinaMantenimiento.Nombre
                                        })
                                        .ToList(),

                                    Documentos = c.ClienteDocumentos
                                        .Select(x => x.Nombre)
                                        .ToList()
                                })
                                .First();

            var perfilesDict = _context.Perfiles
                .AsNoTracking()
                .ToDictionary(x => x.Id, x => x.Nombre);

            var agujasDict = _context.Agujas
                .AsNoTracking()
                .ToDictionary(x => x.Id, x => x.Nombre);

            #endregion

            #region Carga textboxes

            lbl_Nombre.Text = cliente.Nombre.Trim();
            lbl_SapId.Text = cliente.SapId;
            lbl_Alias.Text = cliente.Alias;
            lbl_Observaciones.Text = cliente.Comentarios;

            if (cliente.ClienteConfiguracionElevablePlegable != null)
            {
                lbl_ElevableEstandar.Text = cliente.ClienteConfiguracionElevablePlegable.Elevable_Estandar ? "Elevables estándar" : "No usa elevables estándar";
                lbl_UsaDlo.Text = cliente.ClienteConfiguracionElevablePlegable.Elevable_Dlo ? "Usa elevables DLO" : "No usa elevables DLO";
                lbl_ConsumenPlegables.Text = cliente.ClienteConfiguracionElevablePlegable.Plegable_Consumen ? "Consumen plegables" : "No consumen plegables";
            }
            else
            {
                lbl_ElevableEstandar.Text = "";
                lbl_UsaDlo.Text = "";
                lbl_ConsumenPlegables.Text = "";
            }


            lbl_Software.Text = cliente.Softwares.Any()
                ? string.Join(", ", cliente.Softwares)
                : "N/A";

            txt_Perfiles.Text = string.Join(
                Environment.NewLine,
                cliente.Perfiles
                    .Select(x =>
                        $"• {x} ")
                    .Distinct()
                    .OrderBy(x => x));

            txt_Manillas.Text = string.Join(
                Environment.NewLine,
                cliente.Manillas
                    .Select(x => "• " + x)
                    .Distinct()
                    .OrderBy(x => x));

            txt_SeguridadVentana.Text = string.Join(
                Environment.NewLine,
                cliente.SeguridadVentanas
                    .Select(x => "• " + x)
                    .Distinct()
                    .OrderBy(x => x));

            txt_SeguridadBalc.Text = string.Join(
                Environment.NewLine,
                cliente.SeguridadBalconeras
                    .Select(x => "• " + x)
                    .Distinct()
                    .OrderBy(x => x));

            txt_PasivasOsc.Text = string.Join(
                Environment.NewLine,
                cliente.CremonasVentana
                    .Select(x => "• " + x)
                    .Distinct()
                    .OrderBy(x => x));

            txt_PasivasPract.Text = string.Join(
                Environment.NewLine,
                cliente.CremonasVentanaPract
                    .Select(x => "• " + x)
                    .Distinct()
                    .OrderBy(x => x));

            txt_AgujasBalc.Text =
                            FormatearAgujasBalconera(
                                cliente.ClienteAgujas,
                                cliente.ClienteAgustasModeloPerfil.ToList(),
                                perfilesDict,
                                agujasDict);

            txt_AgujasPuerta.Text =
                FormatearAgujasPuerta(
                    cliente.ClienteAgujas,
                    cliente.ClienteAgustasModeloPerfil.ToList(),
                    perfilesDict,
                    agujasDict);

            txt_PasivaBalc.Text = string.Join(
                Environment.NewLine,
                cliente.CremonasBalconera
                    .Select(x => "• " + x)
                    .Distinct()
                    .OrderBy(x => x));

            txt_Cerraduras.Text = string.Join(
                Environment.NewLine,
                cliente.Cerraduras
                    .Select(x => "• " + x)
                    .Distinct()
                    .OrderBy(x => x));

            txt_Bisagras.Text = string.Join(
                Environment.NewLine,
                cliente.Bisagras
                    .Select(x => "• " + x)
                    .Distinct()
                    .OrderBy(x => x));

            txt_Documentos.Text = string.Join(
                Environment.NewLine,
                cliente.Documentos
                    .Select(x => "• " + x)
                    .Distinct()
                    .OrderBy(x => x));

            dgvMaquinas.DataSource =
                cliente.Maquinas
                    .Select(x => new ClienteResumenMaquinaItem
                    {
                        Tipo = x.Tipo,
                        Marca = x.Marca,
                        Mantenimiento = x.Mantenimiento
                    })
                    .OrderBy(x => x.Tipo)
                    .ToList();

            #endregion
        }
        private string FormatearAgujasBalconera(ClienteAgujas? clienteAgujas, List<ClienteAgujasModeloPerfil>? relacionesPerfil,
                                                Dictionary<int, string>? perfiles, Dictionary<int, string>? agujas)
        {
            if (clienteAgujas == null)
                return string.Empty;

            // CASO 1: TODOS
            if (clienteAgujas.AgujaBalconeraTipoId == 1)
            {
                if (clienteAgujas.AgujaBalconeraId == null)
                    return string.Empty;

                return $"• {agujas[clienteAgujas.AgujaBalconeraId.Value]}";
            }

            // CASO 2: POR PERFIL
            var lineas = relacionesPerfil
                .Where(x => x.AgujaModeloTipoId == 1) // balconera
                .Select(x =>
                {
                    var nombrePerfil = perfiles.ContainsKey(x.PerfilId)
                        ? perfiles[x.PerfilId]
                        : "Desconocido";

                    var nombreAguja = agujas.ContainsKey(x.AgujaId)
                        ? agujas[x.AgujaId]
                        : "Desconocido";

                    return $"• {nombrePerfil}: {nombreAguja}";
                })
                .ToList();

            return string.Join(Environment.NewLine, lineas);
        }
        private string FormatearAgujasPuerta(ClienteAgujas? clienteAgujas, List<ClienteAgujasModeloPerfil>? relacionesPerfil,
                                        Dictionary<int, string>? perfiles, Dictionary<int, string>? agujas)
        {
            if (clienteAgujas == null)
                return string.Empty;

            // CASO 1: TODOS
            if (clienteAgujas.AgujaPuertaTipoId == 1)
            {
                if (clienteAgujas.AgujaPuertaId == null)
                    return string.Empty;

                return $"• {agujas[clienteAgujas.AgujaPuertaId.Value]}";
            }

            // CASO 2: POR PERFIL
            var lineas = relacionesPerfil
                .Where(x => x.AgujaModeloTipoId == 3) // puerta
                .Select(x =>
                {
                    var nombrePerfil = perfiles.ContainsKey(x.PerfilId)
                        ? perfiles[x.PerfilId]
                        : "Desconocido";

                    var nombreAguja = agujas.ContainsKey(x.AgujaId)
                        ? agujas[x.AgujaId]
                        : "Desconocido";

                    return $"• {nombrePerfil}: {nombreAguja}";
                })
                .ToList();

            return string.Join(Environment.NewLine, lineas);
        }
        #endregion

        #region

        #endregion
    }
}
