using Microsoft.EntityFrameworkCore;
using RotoGestionClientes;
using System.Xml.Linq;
using static RotoGestionClientes.Enums;

namespace RotoGestionClientes.UI.Services;

/// <summary>
/// Réplica moderna de Services/ClienteConfigService.cs (WinForms): genera el
/// mismo XML .rotoconfig con la configuración de un cliente (perfiles,
/// maestros asociados y agujas), usado por el icono "Config" de cada fila en
/// Pages/Clientes.razor. A diferencia de ClienteExportBuilder (que genera el
/// .roto completo para hacer copia/traspaso de un cliente), este fichero es
/// un resumen de solo lectura pensado para configuradores externos, con
/// forma de XML en vez de JSON — se mantiene como servicio independiente
/// porque construye un DTO parcial distinto (p.ej. incluye el "Tipo" del
/// perfil, que el export no necesita).
/// </summary>
public static class ClienteConfigBuilder
{
    public static async Task<XDocument?> ConstruirAsync(ApplicationDbContext db, int clienteId)
    {
        var cliente = await db.Clientes
            .AsNoTracking()
            .AsSplitQuery()
            .Where(x => x.Id == clienteId)
            .Select(cliente => new ClienteDataExportDto
            {
                Nombre = cliente.Nombre,

                PorteroElectrico = cliente.ClienteConfiguracionPuerta != null && cliente.ClienteConfiguracionPuerta.PorteroElectrico,
                Cilindro = cliente.ClienteConfiguracionPuerta != null && cliente.ClienteConfiguracionPuerta.Cilindro,
                CilindroCorredera = cliente.ClienteCilindrosCorredera != null && cliente.ClienteCilindrosCorredera.Cilindro,
                Elevable_Estandar = cliente.ClienteConfiguracionElevablePlegable != null && cliente.ClienteConfiguracionElevablePlegable.Elevable_Estandar,
                Elevable_Dlo = cliente.ClienteConfiguracionElevablePlegable != null && cliente.ClienteConfiguracionElevablePlegable.Elevable_Dlo,

                Manillas = cliente.ClienteManillas.Select(x => new MaestroRefDto { Id = x.Manilla.Id, Nombre = x.Manilla.Nombre }).ToList(),
                Perfiles = cliente.ClientePerfiles.Select(x => new MaestroRefDto { Id = x.Perfil.Id, Nombre = x.Perfil.Nombre, Tipo = x.Perfil.PerfilTipo.Nombre }).ToList(),
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

        // Nombre de la aguja "suelta" (modo Todos) para Balconera/PuertaSec/Puerta.
        if (cliente.AgujaBalconeraTipo == (int)AgujaMode.Todos && cliente.AgujaBalconera != null)
        {
            cliente.AgujaBalconeraNombre = await db.Agujas
                .Where(x => x.Id == cliente.AgujaBalconera)
                .Select(x => x.Nombre)
                .FirstOrDefaultAsync();
        }

        if (cliente.AgujaPuertaSecTipo == (int)AgujaMode.Todos && cliente.AgujaPuertaSec != null)
        {
            cliente.AgujaPuertaSecNombre = await db.Agujas
                .Where(x => x.Id == cliente.AgujaPuertaSec)
                .Select(x => x.Nombre)
                .FirstOrDefaultAsync();
        }

        if (cliente.AgujaPuertaTipo == (int)AgujaMode.Todos && cliente.AgujaPuerta != null)
        {
            cliente.AgujaPuertaNombre = await db.Agujas
                .Where(x => x.Id == cliente.AgujaPuerta)
                .Select(x => x.Nombre)
                .FirstOrDefaultAsync();
        }

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

        return GenerarXml(clienteId, cliente);
    }

    private static XDocument GenerarXml(int clienteId, ClienteDataExportDto data)
    {
        return new XDocument(
            new XElement("RotoConfig",
                new XAttribute("Version", "1.0"),
                new XElement("Cliente",
                    new XAttribute("Codigo", clienteId),
                    new XAttribute("Nombre", data.Nombre),
                    new XAttribute("ElevableEstandar", data.Elevable_Estandar),
                    new XAttribute("ElevableDLO", data.Elevable_Dlo),
                    CrearSeccionPerfiles("Perfiles", "Perfil", data.Perfiles),
                    CrearSeccion("TiposPerfil", "TipoPerfil", data.PerfilTipos),
                    CrearSeccion("SoporteCompas", "Soporte", data.SoporteCompas),
                    CrearSeccion("SeguridadVentana", "Seguridad", data.SeguridadVentanas),
                    CrearSeccion("SeguridadBalconera", "Seguridad", data.SeguridadBalconeras),
                    CrearSeccion("PasivaVentanas", "Pasiva", data.CremonaPasivaVentanas),
                    CrearSeccion("PasivaVentanasPract", "Pasiva", data.CremonaPasivaVentanasPract),
                    CrearSeccion("PasivaBalconeras", "Pasiva", data.CremonaPasivaBalconeras),
                    CrearSeccion("Manillas", "Manilla", data.Manillas),
                    CrearSeccion("BisagrasPuerta", "Bisagra", data.BisagrasPuerta),
                    CrearSeccion("BisagrasPuertaSec", "Bisagra", data.BisagrasPuertaSec),
                    CrearSeccion("CerradurasPuerta", "Cerradura", data.CerradurasPuerta),
                    CrearSeccion("CerradurasPuertaSec", "Cerradura", data.CerradurasPuertaSec),
                    CrearSeccion("AgujasCorredera", "Aguja", data.AgujasCorredera),
                    CrearSeccionAgujaSimple("AgujaBalconera", "Aguja", data.AgujaBalconeraNombre),
                    CrearSeccionAgujaSimple("AgujaPuertaSec", "Aguja", data.AgujaPuertaSecNombre),
                    CrearSeccionAgujaSimple("AgujaPuerta", "Aguja", data.AgujaPuertaNombre),
                    CrearSeccionAgujasModeloPerfil("AgujasModeloPerfil", "Aguja", data.AgujasModeloPerfil))));
    }

    private static XElement CrearSeccion(string nombreNodo, string nombreElemento, List<MaestroRefDto> datos)
    {
        return new XElement(nombreNodo,
            datos.OrderBy(x => x.Nombre)
                .Select(x => new XElement(nombreElemento,
                    new XAttribute("Id", x.Id),
                    new XAttribute("Nombre", x.Nombre))));
    }

    private static XElement CrearSeccionPerfiles(string nombreNodo, string nombreElemento, List<MaestroRefDto> datos)
    {
        return new XElement(nombreNodo,
            datos.OrderBy(x => x.Nombre)
                .Select(x => new XElement(nombreElemento,
                    new XAttribute("Id", x.Id),
                    new XAttribute("Nombre", x.Nombre),
                    new XAttribute("Tipo", x.Tipo))));
    }

    private static XElement CrearSeccionAgujaSimple(string nombreNodo, string nombreElemento, string? nombre)
    {
        return new XElement(nombreNodo,
            new XElement(nombreElemento,
                new XAttribute("Nombre", nombre ?? string.Empty)));
    }

    private static XElement CrearSeccionAgujasModeloPerfil(string nombreNodo, string nombreElemento, List<AgujaModeloPerfilExportDto> agujasModeloPerfil)
    {
        return new XElement(nombreNodo,
            agujasModeloPerfil.OrderBy(x => x.ModeloName)
                .Select(x => new XElement(nombreElemento,
                    new XAttribute("TipoModelo", x.ModeloName),
                    new XAttribute("Perfil", x.PerfilNombre),
                    new XAttribute("Nombre", x.AgujaNombre))));
    }
}
