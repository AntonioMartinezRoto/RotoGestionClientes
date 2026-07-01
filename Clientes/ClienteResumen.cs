using Microsoft.EntityFrameworkCore;
using RotoGestionClientes.Models;
using System.Data;
using static RotoGestionClientes.Enums;

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
            CargarTextos();
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
        private void CargarTextos()
        {
            btn_Cerrar.Text = Lang.Cancelar;
            //btn_ExportarPdf.Text = Lang.ExportarPdf;
            lbl_Responsable.Text = Lang.Alias;
            lbl_Nombre.Text = Lang.Nombre;
            lbl_SapId.Text = Lang.SapId;
            lbl_Observaciones.Text = Lang.Comentarios;
            lbl_Software.Text = Lang.Software;
            groupBox_Documentos.Text = Lang.Documentos;
            groupBox_General.Text = Lang.General;
            groupBox_Manillas.Text = Lang.Manillas;
            groupBox_Perfiles.Text = Lang.Perfiles;
            groupBox_SeguridadVent.Text = Lang.SeguridadVentana;
            groupBox_PasivaOsc.Text = Lang.PasivaOscilo;
            groupBox_PasivaPrac.Text = Lang.PasivaPracticables;
            groupBox_AgujasBalc.Text = Lang.AgujaBalconera;
            groupBox_SeguridadBalc.Text = Lang.SeguridadBalconera;
            groupBox_PasivaBalc.Text = Lang.PasivaBalconera;
            groupbox_AgujasPuerta.Text = Lang.AgujaPuerta;
            groupbox_Bisagras.Text = Lang.Bisagras;
            groupBox_Cerraduras.Text = Lang.Cerraduras;
            groupMaquinas.Text = Lang.Maquinas;
        }
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
                HeaderText = Lang.Tipo,
                DataPropertyName = "Tipo",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvMaquinas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Marca",
                HeaderText = Lang.Marca,
                DataPropertyName = "Marca",
                Width = 200
            });

            dgvMaquinas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Mantenimiento",
                HeaderText = Lang.Mantenimiento,
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
                                    c.ResponsableId,

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

            lbl_NombreDato.Text = cliente.Nombre.Trim();
            lbl_SapIdDato.Text = cliente.SapId;
            lbl_ObservacionesDato.Text = cliente.Comentarios;

            SetResponsableAliasInfo(cliente.ResponsableId, cliente.Alias);

            if (cliente.ClienteConfiguracionElevablePlegable != null)
            {
                lbl_ElevableEstandar.Text = cliente.ClienteConfiguracionElevablePlegable.Elevable_Estandar ? Lang.ElevablesEstandar : Lang.NoUsaElevablesEstandar;
                lbl_UsaDlo.Text = cliente.ClienteConfiguracionElevablePlegable.Elevable_Dlo ? Lang.UsaElevablesDlo : Lang.NoUsaElevablesDlo;
                lbl_ConsumenPlegables.Text = cliente.ClienteConfiguracionElevablePlegable.Plegable_Consumen ? Lang.ConsumenPlegables : Lang.NoConsumenPlegables;
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

        private void SetResponsableAliasInfo(int? responsableId, string? alias)
        {

            var config = _context.ConfiguracionAplicacion.FirstOrDefault();

            // Si no hay configuración se dejarán por defecto
            if (config == null) return;

            // Intentamos parsear el string de la BBDD al Enum para trabajar de forma segura
            if (Enum.TryParse(config.AppEdition, out ApplicationEdition edition))
            {
                if (edition == ApplicationEdition.Internal || edition == ApplicationEdition.Debug)
                {
                    lbl_Responsable.Text = Lang.Responsable;
                    lbl_ResponsableDato.Text = responsableId != null && responsableId != 0
                                                ? _context.Usuarios
                                                    .AsNoTracking()
                                                    .Where(x => x.Id == responsableId)
                                                    .Select(x => x.Nombre)
                                                    .FirstOrDefault()
                                                : string.Empty;
                }
                else if (edition == ApplicationEdition.Distributor)
                {
                    lbl_Responsable.Text = Lang.Alias;
                    lbl_ResponsableDato.Text = alias;
                }
            }
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
                        : Lang.Desconocido;

                    var nombreAguja = agujas.ContainsKey(x.AgujaId)
                        ? agujas[x.AgujaId]
                        : Lang.Desconocido;

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
                        : Lang.Desconocido;

                    var nombreAguja = agujas.ContainsKey(x.AgujaId)
                        ? agujas[x.AgujaId]
                        : Lang.Desconocido;

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
