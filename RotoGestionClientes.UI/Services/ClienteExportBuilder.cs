using Microsoft.EntityFrameworkCore;
using RotoGestionClientes;
using static RotoGestionClientes.Enums;

namespace RotoGestionClientes.UI.Services;

/// <summary>
/// Construye el mismo paquete de exportación de un cliente (.roto, JSON) que
/// Services/ClienteExportService.cs en la app legacy — usado tanto por el
/// icono "Exportar" de una fila individual (Pages/Clientes.razor) como por
/// el diálogo de exportación múltiple (Pages/ClienteExportDialog.razor), que
/// antes eran ExportarCliente() y ExportarClienteDeLista() por separado en
/// el WinForms actual pero comparten exactamente la misma consulta.
/// </summary>
public static class ClienteExportBuilder
{
    public static async Task<ClienteExportDto?> ConstruirAsync(ApplicationDbContext db, int clienteId)
    {
        var cliente = await db.Clientes
            .AsNoTracking()
            .AsSplitQuery()
            .Where(x => x.Id == clienteId)
            .Select(cliente => new ClienteDataExportDto
            {
                Nombre = cliente.Nombre.Trim(),
                Comentarios = cliente.Comentarios,
                SapId = cliente.SapId,
                Alias = cliente.Alias,
                ResponsableId = cliente.ResponsableId,

                ObservacionesVentanas = cliente.ObservacionesVentanas,
                ObservacionesBalconeras = cliente.ObservacionesBalconeras,
                ObservacionesPuertas = cliente.ObservacionesPuertas,
                ObservacionesParalelas = cliente.ObservacionesParalelas,
                ObservacionesCorrederas = cliente.ObservacionesCorrederas,
                ObservacionesElevables = cliente.ObservacionesElevables,
                ObservacionesPlegables = cliente.ObservacionesPlegables,
                ObservacionesMaquinas = cliente.ObservacionesMaquinas,
                ObservacionesDocumentos = cliente.ObservacionesDocumentos,

                // Configuraciones
                PorteroElectrico = cliente.ClienteConfiguracionPuerta != null && cliente.ClienteConfiguracionPuerta.PorteroElectrico,
                Cilindro = cliente.ClienteConfiguracionPuerta != null && cliente.ClienteConfiguracionPuerta.Cilindro,
                CilindroCorredera = cliente.ClienteCilindrosCorredera != null && cliente.ClienteCilindrosCorredera.Cilindro,
                Elevable_Estandar = cliente.ClienteConfiguracionElevablePlegable != null && cliente.ClienteConfiguracionElevablePlegable.Elevable_Estandar,
                Elevable_Dlo = cliente.ClienteConfiguracionElevablePlegable != null && cliente.ClienteConfiguracionElevablePlegable.Elevable_Dlo,
                Plegable_Consumen = cliente.ClienteConfiguracionElevablePlegable != null && cliente.ClienteConfiguracionElevablePlegable.Plegable_Consumen,
                BisagraEnSoldadora = cliente.ClienteConfiguracionMaquinas != null && cliente.ClienteConfiguracionMaquinas.BisagrasSoldadora,
                TripleTaladroCentro = cliente.ClienteConfiguracionMaquinas != null && cliente.ClienteConfiguracionMaquinas.TripleTaladroCentro,
                SoporteMarcoConfigId = cliente.ClienteConfiguracionMaquinas != null ? cliente.ClienteConfiguracionMaquinas.SoporteMarcoId : 1,

                // Maestros
                Softwares = cliente.ClienteSoftwares.Select(x => new MaestroRefDto { Id = x.Software.Id, Nombre = x.Software.Nombre }).ToList(),
                Manillas = cliente.ClienteManillas.Select(x => new MaestroRefDto { Id = x.Manilla.Id, Nombre = x.Manilla.Nombre }).ToList(),
                Perfiles = cliente.ClientePerfiles.Select(x => new MaestroRefDto { Id = x.Perfil.Id, Nombre = x.Perfil.Nombre }).ToList(),
                PerfilTipos = cliente.ClientePerfilTipos.Select(x => new MaestroRefDto { Id = x.PerfilTipo.Id, Nombre = x.PerfilTipo.Nombre }).ToList(),
                SoporteCompas = cliente.ClienteSoporteCompases.Select(x => new MaestroRefDto { Id = x.SoporteCompas.Id, Nombre = x.SoporteCompas.Nombre }).ToList(),
                SeguridadVentanas = cliente.ClienteSeguridadVentanas.Select(x => new MaestroRefDto { Id = x.SeguridadVentana.Id, Nombre = x.SeguridadVentana.Nombre }).ToList(),
                SeguridadBalconeras = cliente.ClienteSeguridadBalconeras.Select(x => new MaestroRefDto { Id = x.SeguridadBalconera.Id, Nombre = x.SeguridadBalconera.Nombre }).ToList(),
                CremonaPasivaVentanas = cliente.ClienteCremonaPasivaVentanas.Select(x => new MaestroRefDto { Id = x.CremonaPasivaVentanaTipo.Id, Nombre = x.CremonaPasivaVentanaTipo.Nombre }).ToList(),
                CremonaPasivaVentanasPract = cliente.ClienteCremonaPasivaVentanasPract.Select(x => new MaestroRefDto { Id = x.CremonaPasivaVentanaTipo.Id, Nombre = x.CremonaPasivaVentanaTipo.Nombre }).ToList(),
                CremonaPasivaBalconeras = cliente.ClienteCremonaPasivaBalconeras.Select(x => new MaestroRefDto { Id = x.CremonaPasivaBalconeraTipo.Id, Nombre = x.CremonaPasivaBalconeraTipo.Nombre }).ToList(),
                BisagrasPuerta = cliente.ClienteBisagraPuertas.Select(x => new MaestroRefDto { Id = x.Bisagra.Id, Nombre = x.Bisagra.Nombre }).ToList(),
                BisagrasPuertaSec = cliente.ClienteBisagraPuertasSec.Select(x => new MaestroRefDto { Id = x.Bisagra.Id, Nombre = x.Bisagra.Nombre }).ToList(),
                CerradurasPuerta = cliente.ClienteCerradurasPuerta.Select(x => new MaestroRefDto { Id = x.CerraduraPuerta.Id, Nombre = x.CerraduraPuerta.Nombre }).ToList(),
                CerradurasPuertaSec = cliente.ClienteCerradurasPuertaSec.Select(x => new MaestroRefDto { Id = x.CerraduraPuertaSec.Id, Nombre = x.CerraduraPuertaSec.Nombre }).ToList(),
                Cilindros = cliente.ClienteCilindros.Select(x => new MaestroRefDto { Id = x.Cilindro.Id, Nombre = x.Cilindro.Nomenclatura }).ToList(),
                AgujasCorredera = cliente.ClienteAgujasCorredera.Select(x => new MaestroRefDto { Id = x.AgujasCorredera.Id, Nombre = x.AgujasCorredera.Nombre }).ToList(),

                // Agujas
                AgujaBalconeraTipo = cliente.ClienteAgujases != null ? cliente.ClienteAgujases.AgujaBalconeraTipoId : (int)AgujaMode.Todos,
                AgujaBalconera = cliente.ClienteAgujases != null ? cliente.ClienteAgujases.AgujaBalconeraId : null,
                AgujaPuertaSecTipo = cliente.ClienteAgujases != null ? cliente.ClienteAgujases.AgujaPuertaSecTipoId : (int)AgujaMode.Todos,
                AgujaPuertaSec = cliente.ClienteAgujases != null ? cliente.ClienteAgujases.AgujaPuertaSecId : null,
                AgujaPuertaTipo = cliente.ClienteAgujases != null ? cliente.ClienteAgujases.AgujaPuertaTipoId : (int)AgujaMode.Todos,
                AgujaPuerta = cliente.ClienteAgujases != null ? cliente.ClienteAgujases.AgujaPuertaId : null,
            })
            .FirstOrDefaultAsync();

        if (cliente is null)
            return null;

        cliente.AgujasModeloPerfil = await db.ClienteAgujasModeloPerfil
            .AsNoTracking()
            .Where(x => x.ClienteId == clienteId)
            .Select(x => new AgujaModeloPerfilExportDto
            {
                ModeloId = x.AgujaModeloTipoId,
                ModeloName = x.AgujasModelo.Nombre,
                PerfilId = x.PerfilId,
                PerfilNombre = x.Perfil.Nombre,
                AgujaId = x.AgujaId,
                AgujaNombre = x.Aguja.Nombre,
            })
            .ToListAsync();

        cliente.Maquinas = await db.ClienteMaquinas
            .AsNoTracking()
            .Where(x => x.ClienteId == clienteId)
            .Select(x => new ClienteMaquinaExportDto
            {
                MaquinaTipoId = x.MaquinaTipoId,
                TipoNombre = x.MaquinaTipo.Descripcion,
                MaquinaMarcaId = x.MaquinaMarcaId,
                MarcaNombre = x.MaquinaMarca != null ? x.MaquinaMarca.Nombre : null,
                MaquinaMantenimientoId = x.MaquinaMantenimientoId,
                MantenimientoNombre = x.MaquinaMantenimiento.Nombre,
                Observaciones = x.Observaciones,
            })
            .ToListAsync();

        cliente.Documentos = await db.ClienteDocumentos
            .AsNoTracking()
            .Where(x => x.ClienteId == clienteId)
            .Select(x => new ClienteDocumentoExportDto
            {
                Nombre = x.Nombre,
                NombreFicheroOriginal = x.NombreFicheroOriginal,
                Extension = x.Extension,
                Contenido = x.Contenido,
            })
            .ToListAsync();

        return new ClienteExportDto { Cliente = cliente };
    }

    /// <summary>Mismo saneo de nombre de fichero que ClienteExportService.LimpiarNombreFichero().</summary>
    public static string LimpiarNombreFichero(string nombre)
    {
        foreach (var c in Path.GetInvalidFileNameChars())
        {
            nombre = nombre.Replace(c, '_');
        }

        return nombre.Trim();
    }
}
