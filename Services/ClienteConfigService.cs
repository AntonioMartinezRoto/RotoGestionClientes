using MathNet.Numerics.LinearAlgebra.Factorization;
using Microsoft.EntityFrameworkCore;
using RotoGestionClientes.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Xml.Linq;
using static RotoGestionClientes.Enums;

namespace RotoGestionClientes
{
    public class ClienteConfigService
    {
        #region Private properties
        private readonly ApplicationDbContext _context;
        private Cliente? _cliente;
        private ClienteDataExportDto _clienteDataConfig { get; set; } = new();
        #endregion

        #region Constructor

        public ClienteConfigService(ApplicationDbContext context, int clienteId)
        {
            _context = context;
            _cliente = _context.Clientes.FirstOrDefault(c => c.Id == clienteId);
        }

        #endregion

        #region Private methods
        private void SetDataConfig()
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                // =========================================================
                // CLIENTE PRINCIPAL
                // =========================================================

                var cliente = _context.Clientes
                    .AsNoTracking()
                    .AsSplitQuery()
                    .Where(x => x.Id == _cliente.Id)
                    .Select(cliente => new ClienteDataExportDto
                    {
                        Nombre = cliente.Nombre,

                        // =====================================================
                        // CONFIGURACIONES
                        // =====================================================

                        PorteroElectrico =
                            cliente.ClienteConfiguracionPuerta != null
                                && cliente.ClienteConfiguracionPuerta.PorteroElectrico,

                        Cilindro =
                            cliente.ClienteConfiguracionPuerta != null
                                && cliente.ClienteConfiguracionPuerta.Cilindro,

                        CilindroCorredera =
                            cliente.ClienteCilindrosCorredera != null
                                && cliente.ClienteCilindrosCorredera.Cilindro,

                        Elevable_Estandar =
                            cliente.ClienteConfiguracionElevablePlegable != null
                                && cliente.ClienteConfiguracionElevablePlegable.Elevable_Estandar,

                        Elevable_Dlo =
                            cliente.ClienteConfiguracionElevablePlegable != null
                                && cliente.ClienteConfiguracionElevablePlegable.Elevable_Dlo,

                        // =====================================================
                        // MAESTROS
                        // =====================================================

                        Manillas =
                            cliente.ClienteManillas
                                .Select(x => new MaestroRefDto
                                {
                                    Id = x.Manilla.Id,
                                    Nombre = x.Manilla.Nombre
                                })
                                .ToList(),

                        Perfiles =
                            cliente.ClientePerfiles
                                .Select(x => new MaestroRefDto
                                {
                                    Id = x.Perfil.Id,
                                    Nombre = x.Perfil.Nombre,
                                    Tipo = x.Perfil.PerfilTipo.Nombre
                                })
                                .ToList(),

                        PerfilTipos =
                            cliente.ClientePerfilTipos
                                .Select(x => new MaestroRefDto
                                {
                                    Id = x.PerfilTipo.Id,
                                    Nombre = x.PerfilTipo.Nombre
                                })
                                .ToList(),

                        SoporteCompas =
                            cliente.ClienteSoporteCompases
                                .Select(x => new MaestroRefDto
                                {
                                    Id = x.SoporteCompas.Id,
                                    Nombre = x.SoporteCompas.Nombre
                                })
                                .ToList(),

                        SeguridadVentanas =
                            cliente.ClienteSeguridadVentanas
                                .Select(x => new MaestroRefDto
                                {
                                    Id = x.SeguridadVentana.Id,
                                    Nombre = x.SeguridadVentana.Nombre
                                })
                                .ToList(),

                        SeguridadBalconeras =
                            cliente.ClienteSeguridadBalconeras
                                .Select(x => new MaestroRefDto
                                {
                                    Id = x.SeguridadBalconera.Id,
                                    Nombre = x.SeguridadBalconera.Nombre
                                })
                                .ToList(),

                        CremonaPasivaVentanas =
                            cliente.ClienteCremonaPasivaVentanas
                                .Select(x => new MaestroRefDto
                                {
                                    Id = x.CremonaPasivaVentanaTipo.Id,
                                    Nombre = x.CremonaPasivaVentanaTipo.Nombre
                                })
                                .ToList(),

                        CremonaPasivaVentanasPract =
                            cliente.ClienteCremonaPasivaVentanasPract
                                .Select(x => new MaestroRefDto
                                {
                                    Id = x.CremonaPasivaVentanaTipo.Id,
                                    Nombre = x.CremonaPasivaVentanaTipo.Nombre
                                })
                                .ToList(),

                        CremonaPasivaBalconeras =
                            cliente.ClienteCremonaPasivaBalconeras
                                .Select(x => new MaestroRefDto
                                {
                                    Id = x.CremonaPasivaBalconeraTipo.Id,
                                    Nombre = x.CremonaPasivaBalconeraTipo.Nombre
                                })
                                .ToList(),

                        BisagrasPuerta =
                            cliente.ClienteBisagraPuertas
                                .Select(x => new MaestroRefDto
                                {
                                    Id = x.Bisagra.Id,
                                    Nombre = x.Bisagra.Nombre
                                })
                                .ToList(),

                        BisagrasPuertaSec =
                            cliente.ClienteBisagraPuertasSec
                                .Select(x => new MaestroRefDto
                                {
                                    Id = x.Bisagra.Id,
                                    Nombre = x.Bisagra.Nombre
                                })
                                .ToList(),

                        CerradurasPuerta =
                            cliente.ClienteCerradurasPuerta
                                .Select(x => new MaestroRefDto
                                {
                                    Id = x.CerraduraPuerta.Id,
                                    Nombre = x.CerraduraPuerta.Nombre
                                })
                                .ToList(),

                        CerradurasPuertaSec =
                            cliente.ClienteCerradurasPuertaSec
                                .Select(x => new MaestroRefDto
                                {
                                    Id = x.CerraduraPuertaSec.Id,
                                    Nombre = x.CerraduraPuertaSec.Nombre
                                })
                                .ToList(),

                        Cilindros =
                            cliente.ClienteCilindros
                                .Select(x => new MaestroRefDto
                                {
                                    Id = x.Cilindro.Id,
                                    Nombre = x.Cilindro.Nomenclatura
                                })
                                .ToList(),

                        AgujasCorredera =
                            cliente.ClienteAgujasCorredera
                                .Select(x => new MaestroRefDto
                                {
                                    Id = x.AgujasCorredera.Id,
                                    Nombre = x.AgujasCorredera.Nombre
                                })
                                .ToList(),

                        // =====================================================
                        // AGUJAS
                        // =====================================================

                        AgujaBalconeraTipo =
                            cliente.ClienteAgujases != null
                                ? cliente.ClienteAgujases.AgujaBalconeraTipoId
                                : (int)AgujaMode.Todos,

                        AgujaBalconera =
                            cliente.ClienteAgujases != null
                                ? cliente.ClienteAgujases.AgujaBalconeraId
                                : null,

                        AgujaPuertaSecTipo =
                            cliente.ClienteAgujases != null
                                ? cliente.ClienteAgujases.AgujaPuertaSecTipoId
                                : (int)AgujaMode.Todos,

                        AgujaPuertaSec =
                            cliente.ClienteAgujases != null
                                ? cliente.ClienteAgujases.AgujaPuertaSecId
                                : null,

                        AgujaPuertaTipo =
                            cliente.ClienteAgujases != null
                                ? cliente.ClienteAgujases.AgujaPuertaTipoId
                                : (int)AgujaMode.Todos,

                        AgujaPuerta =
                            cliente.ClienteAgujases != null
                                ? cliente.ClienteAgujases.AgujaPuertaId
                                : null
                    })
                    .FirstOrDefault();

                if (cliente == null)
                {
                    MessageBox.Show(
                        "No se ha encontrado el cliente.",
                        "Exportar cliente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // =========================================================
                // AGUJAS NOMBRE
                // =========================================================

                if (cliente.AgujaBalconeraTipo == (int)AgujaMode.Todos && cliente.AgujaBalconera != null)
                {
                    cliente.AgujaBalconeraNombre = _context.Agujas
                        .Where(x => x.Id == cliente.AgujaBalconera)
                        .Select(x => x.Nombre)
                        .FirstOrDefault();
                }

                if (cliente.AgujaPuertaSecTipo == (int)AgujaMode.Todos && cliente.AgujaPuertaSec != null)
                {
                    cliente.AgujaPuertaSecNombre = _context.Agujas
                        .Where(x => x.Id == cliente.AgujaPuertaSec)
                        .Select(x => x.Nombre)
                        .FirstOrDefault();
                }

                if (cliente.AgujaPuertaTipo == (int)AgujaMode.Todos && cliente.AgujaPuerta != null)
                {
                    cliente.AgujaPuertaNombre = _context.Agujas
                        .Where(x => x.Id == cliente.AgujaPuerta)
                        .Select(x => x.Nombre)
                        .FirstOrDefault();
                }

                // =========================================================
                // AGUJAS POR PERFIL
                // =========================================================

                cliente.AgujasModeloPerfil =
                    _context.ClienteAgujasModeloPerfil
                        .AsNoTracking()
                        .Where(x => x.ClienteId == _cliente.Id)
                        .Select(x => new AgujaModeloPerfilExportDto
                        {
                            ModeloId = x.AgujaModeloTipoId,
                            ModeloName = x.AgujasModelo.Nombre,

                            PerfilId = x.PerfilId,
                            PerfilNombre = x.Perfil.Nombre,

                            AgujaId = x.AgujaId,
                            AgujaNombre = x.Aguja.Nombre
                        })
                        .ToList();

                _clienteDataConfig = cliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al generar config:\n\n{ex.Message}",
                    "Config cliente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private XDocument GenerateConfig(Cliente cliente)
        {
            var xml = new XDocument(
            new XElement("RotoConfig",
                new XAttribute("Version", "1.0"),
                new XElement("Cliente",
                    new XAttribute("Codigo", cliente.Id),
                    new XAttribute("Nombre", cliente.Nombre),
                    new XAttribute("ElevableEstandar", _clienteDataConfig.Elevable_Estandar),
                    new XAttribute("ElevableDLO", _clienteDataConfig.Elevable_Dlo),
                    CrearSeccionPerfiles("Perfiles", "Perfil", _clienteDataConfig.Perfiles),
                    CrearSeccion("TiposPerfil", "TipoPerfil", _clienteDataConfig.PerfilTipos),
                    CrearSeccion("SoporteCompas", "Soporte", _clienteDataConfig.SoporteCompas),
                    CrearSeccion("SeguridadVentana", "Seguridad", _clienteDataConfig.SeguridadVentanas),
                    CrearSeccion("SeguridadBalconera", "Seguridad", _clienteDataConfig.SeguridadBalconeras),
                    CrearSeccion("PasivaVentanas", "Pasiva", _clienteDataConfig.CremonaPasivaVentanas),
                    CrearSeccion("PasivaVentanasPract", "Pasiva", _clienteDataConfig.CremonaPasivaVentanasPract),
                    CrearSeccion("PasivaBalconeras", "Pasiva", _clienteDataConfig.CremonaPasivaBalconeras),
                    CrearSeccion("Manillas", "Manilla", _clienteDataConfig.Manillas),
                    CrearSeccion("BisagrasPuerta", "Bisagra", _clienteDataConfig.BisagrasPuerta),
                    CrearSeccion("BisagrasPuertaSec", "Bisagra", _clienteDataConfig.BisagrasPuertaSec),
                    CrearSeccion("CerradurasPuerta", "Cerradura", _clienteDataConfig.CerradurasPuerta),
                    CrearSeccion("CerradurasPuertaSec", "Cerradura", _clienteDataConfig.CerradurasPuertaSec),
                    CrearSeccion("AgujasCorredera", "Aguja", _clienteDataConfig.AgujasCorredera),
                    CrearSeccionAgujaBalconera("AgujaBalconera", "Aguja"),
                    CrearSeccionAgujaPuertaSec("AgujaPuertaSec", "Aguja"),
                    CrearSeccionAgujaPuerta("AgujaPuerta", "Aguja"),
                    CrearSeccionAgujasModeloPerfil("AgujasModeloPerfil","Aguja", _clienteDataConfig.AgujasModeloPerfil)
                    )
                )
            );

            return xml;
        }

        private object CrearSeccionAgujasModeloPerfil(string nombreNodo, string nombreElemento, List<AgujaModeloPerfilExportDto> agujasModeloPerfil)
        {
            return new XElement(nombreNodo,
                agujasModeloPerfil
                    .OrderBy(x => x.ModeloName)
                    .Select(x =>
                        new XElement(nombreElemento,
                            new XAttribute("TipoModelo", x.ModeloName),
                            new XAttribute("Perfil", x.PerfilNombre),
                            new XAttribute("Nombre", x.AgujaNombre))));
        }
        private XElement CrearSeccion(string nombreNodo, string nombreElemento, List<MaestroRefDto> datos)
        {
            return new XElement(nombreNodo,
                datos
                    .OrderBy(x => x.Nombre)
                    .Select(x =>
                        new XElement(nombreElemento,
                            new XAttribute("Id", x.Id),
                            new XAttribute("Nombre", x.Nombre))));
        }
        private XElement CrearSeccionPerfiles(string nombreNodo, string nombreElemento, List<MaestroRefDto> datos)
        {
            return new XElement(nombreNodo,
                datos
                    .OrderBy(x => x.Nombre)
                    .Select(x =>
                        new XElement(nombreElemento,
                            new XAttribute("Id", x.Id),
                            new XAttribute("Nombre", x.Nombre),
                            new XAttribute("Tipo", x.Tipo))));
        }
        private XElement CrearSeccionAgujaBalconera(string nombreNodo, string nombreElemento)
        {
            return new XElement(nombreNodo,
                new XElement(nombreElemento,
                    new XAttribute("Nombre", _clienteDataConfig.AgujaBalconeraNombre != null ? _clienteDataConfig.AgujaBalconeraNombre : "")));
        }
        private XElement CrearSeccionAgujaPuerta(string nombreNodo, string nombreElemento)
        {
            return new XElement(nombreNodo,
                new XElement(nombreElemento,
                    new XAttribute("Nombre", _clienteDataConfig.AgujaPuertaNombre != null ? _clienteDataConfig.AgujaPuertaNombre : "")));
        }
        private XElement CrearSeccionAgujaPuertaSec(string nombreNodo, string nombreElemento)
        {
            return new XElement(nombreNodo,
                new XElement(nombreElemento,
                    new XAttribute("Nombre", _clienteDataConfig.AgujaPuertaSecNombre != null ? _clienteDataConfig.AgujaPuertaSecNombre : "")));
        }
        #endregion

        #region Public methods
        public void GenerarFicheroConfiguracion()
        {
            if (_cliente == null)
                return;

            using var sfd = new SaveFileDialog();

            sfd.Filter = "Rotoconfig (*.rotoconfig)|*.rotoconfig";

            string? nombreCliente = _context.Clientes.Where(c => c.Id == _cliente.Id).Select(c => c.Nombre.Trim()).FirstOrDefault();
            sfd.FileName = $"{nombreCliente}.rotoconfig";

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            Cursor.Current = Cursors.WaitCursor;
            SetDataConfig();
            GenerateConfig(_cliente).Save(sfd.FileName);

            MessageBox.Show(
                "Archivo generado correctamente.",
                "Configuración cliente",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        #endregion
    }
}
