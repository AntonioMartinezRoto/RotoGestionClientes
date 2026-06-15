using Microsoft.EntityFrameworkCore;
using RotoGestionClientes.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace RotoGestionClientes
{
    public class ClienteExportService
    {
        private readonly ApplicationDbContext _context;

        public ClienteExportService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void ExportarCliente(int clienteId)
        {
            using var sfd = new SaveFileDialog();

            sfd.Filter = "Roto (*.roto)|*.roto";

            string? nombreCliente = _context.Clientes.Where(c => c.Id == clienteId).Select(c => c.Nombre).FirstOrDefault();
            sfd.FileName = $"{nombreCliente}.roto";

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            Cursor.Current = Cursors.WaitCursor;

            try
            {
                // =========================================================
                // CLIENTE PRINCIPAL
                // =========================================================

                var cliente = _context.Clientes
                    .AsNoTracking()
                    .AsSplitQuery()
                    .Where(x => x.Id == clienteId)
                    .Select(cliente => new ClienteDataExportDto
                    {
                        Nombre = cliente.Nombre,
                        Comentarios = cliente.Comentarios,
                        SapId = cliente.SapId,
                        Alias = cliente.Alias,

                        ObservacionesVentanas =
                            cliente.ObservacionesVentanas,

                        ObservacionesBalconeras =
                            cliente.ObservacionesBalconeras,

                        ObservacionesPuertas =
                            cliente.ObservacionesPuertas,

                        ObservacionesParalelas =
                            cliente.ObservacionesParalelas,

                        ObservacionesCorrederas =
                            cliente.ObservacionesCorrederas,

                        ObservacionesElevables =
                            cliente.ObservacionesElevables,

                        ObservacionesPlegables =
                            cliente.ObservacionesPlegables,

                        ObservacionesMaquinas =
                            cliente.ObservacionesMaquinas,

                        ObservacionesDocumentos =
                            cliente.ObservacionesDocumentos,

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

                        Plegable_Consumen =
                            cliente.ClienteConfiguracionElevablePlegable != null
                                && cliente.ClienteConfiguracionElevablePlegable.Plegable_Consumen,

                        BisagraEnSoldadora =
                            cliente.ClienteConfiguracionMaquinas != null
                                && cliente.ClienteConfiguracionMaquinas.BisagrasSoldadora,

                        TripleTaladroCentro =
                            cliente.ClienteConfiguracionMaquinas != null
                                && cliente.ClienteConfiguracionMaquinas.TripleTaladroCentro,

                        SoporteMarcoConfigId =
                            cliente.ClienteConfiguracionMaquinas != null
                                ? cliente.ClienteConfiguracionMaquinas.SoporteMarcoId
                                : 1,

                        // =====================================================
                        // MAESTROS
                        // =====================================================

                        Softwares =
                            cliente.ClienteSoftwares
                                .Select(x => new MaestroRefDto
                                {
                                    Id = x.Software.Id,
                                    Nombre = x.Software.Nombre
                                })
                                .ToList(),

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
                                    Nombre = x.Perfil.Nombre
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
                                : 1,

                        AgujaBalconera =
                            cliente.ClienteAgujases != null
                                ? cliente.ClienteAgujases.AgujaBalconeraId
                                : null,

                        AgujaPuertaSecTipo =
                            cliente.ClienteAgujases != null
                                ? cliente.ClienteAgujases.AgujaPuertaSecTipoId
                                : 1,

                        AgujaPuertaSec =
                            cliente.ClienteAgujases != null
                                ? cliente.ClienteAgujases.AgujaPuertaSecId
                                : null,

                        AgujaPuertaTipo =
                            cliente.ClienteAgujases != null
                                ? cliente.ClienteAgujases.AgujaPuertaTipoId
                                : 1,

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
                // AGUJAS POR PERFIL
                // =========================================================

                cliente.AgujasModeloPerfil =
                    _context.ClienteAgujasModeloPerfil
                        .AsNoTracking()
                        .Where(x => x.ClienteId == clienteId)
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

                // =========================================================
                // MAQUINAS
                // =========================================================

                cliente.Maquinas =
                    _context.ClienteMaquinas
                        .AsNoTracking()
                        .Where(x => x.ClienteId == clienteId)
                        .Select(x => new ClienteMaquinaExportDto
                        {
                            MaquinaTipoId =
                                x.MaquinaTipoId,

                            TipoNombre =
                                x.MaquinaTipo.Descripcion,

                            MaquinaMarcaId =
                                x.MaquinaMarcaId,

                            MarcaNombre =
                                x.MaquinaMarca != null
                                    ? x.MaquinaMarca.Nombre
                                    : null,

                            MaquinaMantenimientoId =
                                x.MaquinaMantenimientoId,

                            MantenimientoNombre =
                                x.MaquinaMantenimiento.Nombre,

                            Observaciones =
                                x.Observaciones
                        })
                        .ToList();

                // =========================================================
                // DOCUMENTOS
                // =========================================================

                cliente.Documentos =
                    _context.ClienteDocumentos
                        .AsNoTracking()
                        .Where(x => x.ClienteId == clienteId)
                        .Select(x => new ClienteDocumentoExportDto
                        {
                            Nombre = x.Nombre,
                            NombreFicheroOriginal =
                                x.NombreFicheroOriginal,

                            Extension = x.Extension,

                            Contenido = x.Contenido
                        })
                        .ToList();

                // =========================================================
                // DTO FINAL
                // =========================================================

                var dto = new ClienteExportDto
                {
                    Cliente = cliente
                };

                // =========================================================
                // GUARDAR
                // =========================================================

                var json = JsonSerializer.Serialize(
                    dto,
                    new JsonSerializerOptions
                    {
                        WriteIndented = true
                    });

                File.WriteAllText(
                    sfd.FileName,
                    json);

                MessageBox.Show(
                    "Cliente exportado correctamente.",
                    "Exportar cliente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al exportar:\n\n{ex.Message}",
                    "Exportar cliente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
