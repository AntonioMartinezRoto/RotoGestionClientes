using Microsoft.EntityFrameworkCore;
using RotoGestionClientes;
using static RotoGestionClientes.Enums;

namespace RotoGestionClientes.UI.Services;

/// <summary>
/// Construye los datos para la pantalla "Ver resumen" de un cliente
/// (Pages/ClienteResumen.razor). Réplica moderna de Clientes/ClienteResumen.cs
/// (WinForms), pero con dos diferencias deliberadas pedidas explícitamente:
/// 1) Se resuelve TODO lo que muestra la app legacy, tal cual (mismos bullets
///    ordenados/deduplicados, mismo formateo Todos/Por-perfil de agujas).
/// 2) Se añade además la información del cliente que existe en BBDD pero que
///    la app legacy nunca llegó a mostrar en su resumen: Alias siempre
///    visible (legacy solo lo muestra reutilizando la etiqueta "Responsable"
///    en la edición Distribuidor), tipos de perfil, soporte compás, la
///    sección completa de "Puerta secundaria" (bisagras/cerraduras/aguja —
///    legacy no la mostraba en absoluto), cilindros de puerta y de
///    corredera, agujas de corredera, los interruptores de "Portero
///    eléctrico" / "Bisagras en soldadora" / "Triple taladro" / "Soporte de
///    marco", las observaciones específicas de cada sección (legacy solo
///    mostraba el comentario general del cliente) y el fichero real de cada
///    documento adjunto (legacy solo mostraba el nombre).
/// A diferencia de ClienteExportBuilder/ClienteConfigBuilder (pensados para
/// generar ficheros con forma de intercambio de datos), este builder resuelve
/// todos los nombres a texto ya listo para pintar en pantalla.
/// </summary>
public static class ClienteResumenBuilder
{
    public static async Task<ClienteResumenDto?> ConstruirAsync(ApplicationDbContext db, int clienteId)
    {
        var cliente = await db.Clientes
            .AsNoTracking()
            .AsSplitQuery()
            .Where(x => x.Id == clienteId)
            .Select(x => new ClienteResumenDto
            {
                Id = x.Id,
                Nombre = x.Nombre.Trim(),
                SapId = x.SapId,
                Alias = x.Alias,
                Comentarios = x.Comentarios,
                ResponsableId = x.ResponsableId,
                ResponsableNombre = x.Responsable != null ? x.Responsable.Nombre : null,

                ObservacionesVentanas = x.ObservacionesVentanas,
                ObservacionesBalconeras = x.ObservacionesBalconeras,
                ObservacionesPuertas = x.ObservacionesPuertas,
                ObservacionesParalelas = x.ObservacionesParalelas,
                ObservacionesCorrederas = x.ObservacionesCorrederas,
                ObservacionesElevables = x.ObservacionesElevables,
                ObservacionesPlegables = x.ObservacionesPlegables,
                ObservacionesMaquinas = x.ObservacionesMaquinas,
                ObservacionesDocumentos = x.ObservacionesDocumentos,

                PorteroElectrico = x.ClienteConfiguracionPuerta != null && x.ClienteConfiguracionPuerta.PorteroElectrico,
                Cilindro = x.ClienteConfiguracionPuerta != null && x.ClienteConfiguracionPuerta.Cilindro,
                CilindroCorredera = x.ClienteCilindrosCorredera != null && x.ClienteCilindrosCorredera.Cilindro,
                Elevable_Estandar = x.ClienteConfiguracionElevablePlegable != null && x.ClienteConfiguracionElevablePlegable.Elevable_Estandar,
                Elevable_Dlo = x.ClienteConfiguracionElevablePlegable != null && x.ClienteConfiguracionElevablePlegable.Elevable_Dlo,
                Plegable_Consumen = x.ClienteConfiguracionElevablePlegable != null && x.ClienteConfiguracionElevablePlegable.Plegable_Consumen,
                TieneConfigElevablePlegable = x.ClienteConfiguracionElevablePlegable != null,
                BisagraEnSoldadora = x.ClienteConfiguracionMaquinas != null && x.ClienteConfiguracionMaquinas.BisagrasSoldadora,
                TripleTaladroCentro = x.ClienteConfiguracionMaquinas != null && x.ClienteConfiguracionMaquinas.TripleTaladroCentro,
                SoporteMarcoConfigId = x.ClienteConfiguracionMaquinas != null ? x.ClienteConfiguracionMaquinas.SoporteMarcoId : 1,

                Softwares = x.ClienteSoftwares.Select(s => s.Software.Nombre).ToList(),

                PerfilTipos = x.ClientePerfilTipos.Select(p => p.PerfilTipo.Nombre).ToList(),
                Perfiles = x.ClientePerfiles.Select(p => p.Perfil.Nombre + " (" + p.Perfil.PerfilTipo.NombreAbreviado + ")").ToList(),
                Manillas = x.ClienteManillas.Select(m => m.Manilla.Nombre).ToList(),
                SoporteCompas = x.ClienteSoporteCompases.Select(s => s.SoporteCompas.Nombre).ToList(),

                SeguridadVentanas = x.ClienteSeguridadVentanas.Select(s => s.SeguridadVentana.Nombre).ToList(),
                CremonaPasivaVentanas = x.ClienteCremonaPasivaVentanas.Select(c => c.CremonaPasivaVentanaTipo.Nombre).ToList(),
                CremonaPasivaVentanasPract = x.ClienteCremonaPasivaVentanasPract.Select(c => c.CremonaPasivaVentanaTipo.Nombre).ToList(),

                SeguridadBalconeras = x.ClienteSeguridadBalconeras.Select(s => s.SeguridadBalconera.Nombre).ToList(),
                CremonaPasivaBalconeras = x.ClienteCremonaPasivaBalconeras.Select(c => c.CremonaPasivaBalconeraTipo.Nombre).ToList(),

                BisagrasPuerta = x.ClienteBisagraPuertas.Select(b => b.Bisagra.Nombre).ToList(),
                CerradurasPuerta = x.ClienteCerradurasPuerta.Select(c => c.CerraduraPuerta.Nombre).ToList(),

                BisagrasPuertaSec = x.ClienteBisagraPuertasSec.Select(b => b.Bisagra.Nombre).ToList(),
                CerradurasPuertaSec = x.ClienteCerradurasPuertaSec.Select(c => c.CerraduraPuertaSec.Nombre).ToList(),

                // Se añade el tipo de cilindro (p.ej. "Europeo", "Suizo"...)
                // además de la nomenclatura, que por sí sola no deja claro de
                // qué tipo de cilindro se trata (a petición del usuario).
                Cilindros = x.ClienteCilindros.Select(c => c.Cilindro.Nomenclatura + " (" + c.Cilindro.CilindroTipo.Nombre + ")").ToList(),
                AgujasCorredera = x.ClienteAgujasCorredera.Select(a => a.AgujasCorredera.Nombre).ToList(),

                AgujaBalconeraTipo = x.ClienteAgujases != null ? x.ClienteAgujases.AgujaBalconeraTipoId : (int)AgujaMode.Todos,
                AgujaBalconeraId = x.ClienteAgujases != null ? x.ClienteAgujases.AgujaBalconeraId : null,
                AgujaPuertaSecTipo = x.ClienteAgujases != null ? x.ClienteAgujases.AgujaPuertaSecTipoId : (int)AgujaMode.Todos,
                AgujaPuertaSecId = x.ClienteAgujases != null ? x.ClienteAgujases.AgujaPuertaSecId : null,
                AgujaPuertaTipo = x.ClienteAgujases != null ? x.ClienteAgujases.AgujaPuertaTipoId : (int)AgujaMode.Todos,
                AgujaPuertaId = x.ClienteAgujases != null ? x.ClienteAgujases.AgujaPuertaId : null,

                Maquinas = x.ClienteMaquinas.Select(m => new ClienteResumenMaquinaDto
                {
                    Tipo = m.MaquinaTipo.Descripcion,
                    Marca = m.MaquinaMarca != null ? m.MaquinaMarca.Nombre : null,
                    Mantenimiento = m.MaquinaMantenimiento.Nombre,
                    Observaciones = m.Observaciones,
                }).ToList(),

                Documentos = x.ClienteDocumentos.Select(d => new ClienteResumenDocumentoDto
                {
                    Id = d.Id,
                    Nombre = d.Nombre,
                    NombreFicheroOriginal = d.NombreFicheroOriginal,
                }).ToList(),
            })
            .FirstOrDefaultAsync();

        if (cliente is null)
            return null;

        // Deduplicamos y ordenamos aquí, sobre las listas ya materializadas en
        // memoria, en vez de con .Distinct() dentro de la propia consulta EF
        // (que SQL Server no consigue traducir cuando hay varias subconsultas
        // de colección en la misma proyección: "Unable to translate a
        // collection subquery in a projection..."). Es exactamente lo mismo
        // que hace ClienteResumen.cs en la app legacy, que también aplica
        // Distinct().OrderBy(x => x) en C#, después de traer los datos.
        static List<string> Depurar(List<string> valores) => valores
            .Distinct(StringComparer.CurrentCultureIgnoreCase)
            .OrderBy(v => v, StringComparer.CurrentCultureIgnoreCase)
            .ToList();

        cliente.Softwares = Depurar(cliente.Softwares);
        cliente.PerfilTipos = Depurar(cliente.PerfilTipos);
        cliente.Perfiles = Depurar(cliente.Perfiles);
        cliente.Manillas = Depurar(cliente.Manillas);
        cliente.SoporteCompas = Depurar(cliente.SoporteCompas);
        cliente.SeguridadVentanas = Depurar(cliente.SeguridadVentanas);
        cliente.CremonaPasivaVentanas = Depurar(cliente.CremonaPasivaVentanas);
        cliente.CremonaPasivaVentanasPract = Depurar(cliente.CremonaPasivaVentanasPract);
        cliente.SeguridadBalconeras = Depurar(cliente.SeguridadBalconeras);
        cliente.CremonaPasivaBalconeras = Depurar(cliente.CremonaPasivaBalconeras);
        cliente.BisagrasPuerta = Depurar(cliente.BisagrasPuerta);
        cliente.CerradurasPuerta = Depurar(cliente.CerradurasPuerta);
        cliente.BisagrasPuertaSec = Depurar(cliente.BisagrasPuertaSec);
        cliente.CerradurasPuertaSec = Depurar(cliente.CerradurasPuertaSec);
        cliente.Cilindros = Depurar(cliente.Cilindros);
        cliente.AgujasCorredera = Depurar(cliente.AgujasCorredera);
        cliente.Maquinas = cliente.Maquinas.OrderBy(m => m.Tipo, StringComparer.CurrentCultureIgnoreCase).ToList();
        cliente.Documentos = cliente.Documentos.OrderBy(d => d.Nombre, StringComparer.CurrentCultureIgnoreCase).ToList();

        // Nombre de la aguja "suelta" (modo Todos), igual que en ClienteConfigBuilder.
        string? agujaBalconeraNombre = null;
        if (cliente.AgujaBalconeraTipo == (int)AgujaMode.Todos && cliente.AgujaBalconeraId != null)
        {
            agujaBalconeraNombre = await db.Agujas.Where(a => a.Id == cliente.AgujaBalconeraId).Select(a => a.Nombre).FirstOrDefaultAsync();
        }

        string? agujaPuertaSecNombre = null;
        if (cliente.AgujaPuertaSecTipo == (int)AgujaMode.Todos && cliente.AgujaPuertaSecId != null)
        {
            agujaPuertaSecNombre = await db.Agujas.Where(a => a.Id == cliente.AgujaPuertaSecId).Select(a => a.Nombre).FirstOrDefaultAsync();
        }

        string? agujaPuertaNombre = null;
        if (cliente.AgujaPuertaTipo == (int)AgujaMode.Todos && cliente.AgujaPuertaId != null)
        {
            agujaPuertaNombre = await db.Agujas.Where(a => a.Id == cliente.AgujaPuertaId).Select(a => a.Nombre).FirstOrDefaultAsync();
        }

        // Relaciones "por perfil" de las tres agujas, igual que
        // FormatearAgujasBalconera/FormatearAgujasPuerta en la app legacy
        // (que solo resolvía Balconera y Puerta; aquí resolvemos también
        // Puerta secundaria, que legacy nunca mostraba).
        var relacionesPerfil = await db.ClienteAgujasModeloPerfil
            .AsNoTracking()
            .Where(x => x.ClienteId == clienteId)
            .Select(x => new { x.AgujaModeloTipoId, Perfil = x.Perfil.Nombre, Aguja = x.Aguja.Nombre })
            .ToListAsync();

        List<AgujaPerfilLineaDto> LineasPorPerfil(int agujaModeloTipoId) => relacionesPerfil
            .Where(r => r.AgujaModeloTipoId == agujaModeloTipoId)
            .Select(r => new AgujaPerfilLineaDto { Perfil = r.Perfil, Aguja = r.Aguja })
            .OrderBy(r => r.Perfil, StringComparer.CurrentCultureIgnoreCase)
            .ToList();

        cliente.AgujaBalconera = new AgujaResumenDto
        {
            Tipo = cliente.AgujaBalconeraTipo,
            NombreTodos = agujaBalconeraNombre,
            PorPerfil = LineasPorPerfil((int)AgujasTipoModelo.Balconera),
        };

        cliente.AgujaPuertaSec = new AgujaResumenDto
        {
            Tipo = cliente.AgujaPuertaSecTipo,
            NombreTodos = agujaPuertaSecNombre,
            PorPerfil = LineasPorPerfil((int)AgujasTipoModelo.PuertaSecundaria),
        };

        cliente.AgujaPuerta = new AgujaResumenDto
        {
            Tipo = cliente.AgujaPuertaTipo,
            NombreTodos = agujaPuertaNombre,
            PorPerfil = LineasPorPerfil((int)AgujasTipoModelo.Puerta),
        };

        return cliente;
    }
}

/// <summary>DTO de solo lectura con todos los datos de un cliente ya resueltos a texto, listo para Pages/ClienteResumen.razor.</summary>
public class ClienteResumenDto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string? SapId { get; set; }
    public string? Alias { get; set; }
    public string? Comentarios { get; set; }
    public int? ResponsableId { get; set; }
    public string? ResponsableNombre { get; set; }

    public string? ObservacionesVentanas { get; set; }
    public string? ObservacionesBalconeras { get; set; }
    public string? ObservacionesPuertas { get; set; }
    public string? ObservacionesParalelas { get; set; }
    public string? ObservacionesCorrederas { get; set; }
    public string? ObservacionesElevables { get; set; }
    public string? ObservacionesPlegables { get; set; }
    public string? ObservacionesMaquinas { get; set; }
    public string? ObservacionesDocumentos { get; set; }

    public bool PorteroElectrico { get; set; }
    public bool Cilindro { get; set; }
    public bool CilindroCorredera { get; set; }
    public bool Elevable_Estandar { get; set; }
    public bool Elevable_Dlo { get; set; }
    public bool Plegable_Consumen { get; set; }
    public bool TieneConfigElevablePlegable { get; set; }
    public bool BisagraEnSoldadora { get; set; }
    public bool TripleTaladroCentro { get; set; }
    public int SoporteMarcoConfigId { get; set; }

    public List<string> Softwares { get; set; } = new();
    public List<string> PerfilTipos { get; set; } = new();
    public List<string> Perfiles { get; set; } = new();
    public List<string> Manillas { get; set; } = new();
    public List<string> SoporteCompas { get; set; } = new();

    public List<string> SeguridadVentanas { get; set; } = new();
    public List<string> CremonaPasivaVentanas { get; set; } = new();
    public List<string> CremonaPasivaVentanasPract { get; set; } = new();

    public List<string> SeguridadBalconeras { get; set; } = new();
    public List<string> CremonaPasivaBalconeras { get; set; } = new();

    public List<string> BisagrasPuerta { get; set; } = new();
    public List<string> CerradurasPuerta { get; set; } = new();

    public List<string> BisagrasPuertaSec { get; set; } = new();
    public List<string> CerradurasPuertaSec { get; set; } = new();

    public List<string> Cilindros { get; set; } = new();
    public List<string> AgujasCorredera { get; set; } = new();

    public int AgujaBalconeraTipo { get; set; }
    public int? AgujaBalconeraId { get; set; }
    public int AgujaPuertaSecTipo { get; set; }
    public int? AgujaPuertaSecId { get; set; }
    public int AgujaPuertaTipo { get; set; }
    public int? AgujaPuertaId { get; set; }

    public AgujaResumenDto AgujaBalconera { get; set; } = new();
    public AgujaResumenDto AgujaPuertaSec { get; set; } = new();
    public AgujaResumenDto AgujaPuerta { get; set; } = new();

    public List<ClienteResumenMaquinaDto> Maquinas { get; set; } = new();
    public List<ClienteResumenDocumentoDto> Documentos { get; set; } = new();
}

public class AgujaResumenDto
{
    public int Tipo { get; set; }
    public string? NombreTodos { get; set; }
    public List<AgujaPerfilLineaDto> PorPerfil { get; set; } = new();
}

public class AgujaPerfilLineaDto
{
    public string Perfil { get; set; } = string.Empty;
    public string Aguja { get; set; } = string.Empty;
}

public class ClienteResumenMaquinaDto
{
    public string Tipo { get; set; } = string.Empty;
    public string? Marca { get; set; }
    public string Mantenimiento { get; set; } = string.Empty;
    public string? Observaciones { get; set; }
}

public class ClienteResumenDocumentoDto
{
    public int? Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string NombreFicheroOriginal { get; set; } = string.Empty;
}
