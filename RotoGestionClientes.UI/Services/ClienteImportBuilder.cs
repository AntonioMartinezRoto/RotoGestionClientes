using Microsoft.EntityFrameworkCore;
using RotoGestionClientes;

namespace RotoGestionClientes.UI.Services;

/// <summary>
/// Réplica moderna de Services/ClienteImportService.cs (WinForms): inserta un
/// cliente completo (relaciones, maestros, agujas por perfil, máquinas y
/// documentos) a partir del mismo ClienteDataExportDto que produce la
/// exportación, dentro de una única transacción, con el mismo control de
/// nombres duplicados (sufijo "_IMPn"). Usado tanto para importar un único
/// .roto como, en un bucle, cada entrada .roto de un .zip.
/// </summary>
public static class ClienteImportBuilder
{
    public sealed class ResultadoImportacion
    {
        public bool Exito { get; set; }
        public string? NombreFinal { get; set; }
        public bool NombreDuplicado { get; set; }
        public string? Error { get; set; }
    }

    public static async Task<ResultadoImportacion> ImportarAsync(ApplicationDbContext db, ClienteDataExportDto data)
    {
        var resultado = new ResultadoImportacion();

        // Control de nombre duplicado (mismo criterio "_IMPn" que la app legacy),
        // resuelto antes de abrir la transacción, igual que ClienteImportService.
        var nombreOriginal = data.Nombre.Trim();
        var nombreFinal = await ComprobarNombreDuplicadoAsync(db, nombreOriginal);

        resultado.NombreFinal = nombreFinal;
        resultado.NombreDuplicado = !string.Equals(nombreFinal, nombreOriginal, StringComparison.Ordinal);

        await using var transaction = await db.Database.BeginTransactionAsync();

        try
        {
            var cliente = new Cliente
            {
                Nombre = nombreFinal,
                Comentarios = data.Comentarios,
                SapId = data.SapId,
                Alias = data.Alias,
                ResponsableId = data.ResponsableId,
                ObservacionesVentanas = data.ObservacionesVentanas,
                ObservacionesBalconeras = data.ObservacionesBalconeras,
                ObservacionesPuertas = data.ObservacionesPuertas,
                ObservacionesParalelas = data.ObservacionesParalelas,
                ObservacionesCorrederas = data.ObservacionesCorrederas,
                ObservacionesElevables = data.ObservacionesElevables,
                ObservacionesPlegables = data.ObservacionesPlegables,
                ObservacionesMaquinas = data.ObservacionesMaquinas,
                ObservacionesDocumentos = data.ObservacionesDocumentos,
            };

            db.Clientes.Add(cliente);
            await db.SaveChangesAsync();

            AddRelations(data.Softwares, id => db.Softwares.Any(x => x.Id == id),
                id => db.ClienteSoftwares.Add(new ClienteSoftware { ClienteId = cliente.Id, SoftwareId = id }));

            AddRelations(data.Manillas, id => db.Manillas.Any(x => x.Id == id),
                id => db.ClienteManillas.Add(new ClienteManilla { ClienteId = cliente.Id, ManillaId = id }));

            AddRelations(data.PerfilTipos, id => db.PerfilTipos.Any(x => x.Id == id),
                id => db.ClientePerfilTipos.Add(new ClientePerfilTipo { ClienteId = cliente.Id, PerfilTipoId = id }));

            AddRelations(data.Perfiles, id => db.Perfiles.Any(x => x.Id == id),
                id => db.ClientePerfiles.Add(new ClientePerfil { ClienteId = cliente.Id, PerfilId = id }));

            AddRelations(data.SoporteCompas, id => db.SoporteCompases.Any(x => x.Id == id),
                id => db.ClienteSoporteCompases.Add(new ClienteSoporteCompas { ClienteId = cliente.Id, SoporteCompasId = id }));

            AddRelations(data.SeguridadVentanas, id => db.SeguridadVentanas.Any(x => x.Id == id),
                id => db.ClienteSeguridadVentanas.Add(new ClienteSeguridadVentana { ClienteId = cliente.Id, SeguridadVentanaId = id }));

            // NOTA: igual que en la app legacy, "seguridad balconera" no tiene
            // maestro propio: reutiliza y comprueba contra SeguridadVentanas.
            AddRelations(data.SeguridadBalconeras, id => db.SeguridadVentanas.Any(x => x.Id == id),
                id => db.ClienteSeguridadBalconeras.Add(new ClienteSeguridadBalconera { ClienteId = cliente.Id, SeguridadBalconeraId = id }));

            AddRelations(data.CremonaPasivaVentanas, id => db.CremonaPasivaVentanaTipos.Any(x => x.Id == id),
                id => db.ClienteCremonaPasivaVentanas.Add(new ClienteCremonaPasivaVentana { ClienteId = cliente.Id, CremonaPasivaVentanaId = id }));

            AddRelations(data.CremonaPasivaVentanasPract, id => db.CremonaPasivaVentanaTipos.Any(x => x.Id == id),
                id => db.ClienteCremonaPasivaVentanasPract.Add(new ClienteCremonaPasivaVentanaPract { ClienteId = cliente.Id, CremonaPasivaVentanaId = id }));

            AddRelations(data.CremonaPasivaBalconeras, id => db.CremonaPasivaVentanaTipos.Any(x => x.Id == id),
                id => db.ClienteCremonaPasivaBalconeras.Add(new ClienteCremonaPasivaBalconera { ClienteId = cliente.Id, CremonaPasivaBalconeraId = id }));

            AddRelations(data.BisagrasPuerta, id => db.Bisagras.Any(x => x.Id == id),
                id => db.ClienteBisagraPuertas.Add(new ClienteBisagraPuerta { ClienteId = cliente.Id, BisagraPuertaId = id }));

            AddRelations(data.BisagrasPuertaSec, id => db.Bisagras.Any(x => x.Id == id),
                id => db.ClienteBisagraPuertasSec.Add(new ClienteBisagraPuertaSec { ClienteId = cliente.Id, BisagraPuertaId = id }));

            AddRelations(data.CerradurasPuerta, id => db.CerradurasPuerta.Any(x => x.Id == id),
                id => db.ClienteCerradurasPuerta.Add(new ClienteCerraduraPuerta { ClienteId = cliente.Id, CerraduraPuertaId = id }));

            AddRelations(data.CerradurasPuertaSec, id => db.CerradurasPuertaSec.Any(x => x.Id == id),
                id => db.ClienteCerradurasPuertaSec.Add(new ClienteCerraduraPuertaSec { ClienteId = cliente.Id, CerraduraPuertaSecId = id }));

            AddRelations(data.Cilindros, id => db.Cilindros.Any(x => x.Id == id),
                id => db.ClienteCilindros.Add(new ClienteCilindro { ClienteId = cliente.Id, CilindroId = id }));

            AddRelations(data.AgujasCorredera, id => db.Agujas.Any(x => x.Id == id),
                id => db.ClienteAgujasCorrederas.Add(new ClienteAgujasCorredera { ClienteId = cliente.Id, AgujaCorrederaId = id }));

            db.ClienteConfiguracionPuerta.Add(new ClienteConfiguracionPuerta
            {
                ClienteId = cliente.Id,
                PorteroElectrico = data.PorteroElectrico,
                Cilindro = data.Cilindro,
            });

            db.ClienteCilindrosCorredera.Add(new ClienteCilindroCorredera
            {
                ClienteId = cliente.Id,
                Cilindro = data.CilindroCorredera,
            });

            db.ClienteConfiguracionElevablePlegables.Add(new ClienteConfiguracionElevablePlegable
            {
                ClienteId = cliente.Id,
                Elevable_Estandar = data.Elevable_Estandar,
                Elevable_Dlo = data.Elevable_Dlo,
                Plegable_Consumen = data.Plegable_Consumen,
            });

            db.ClienteConfiguracionMaquinas.Add(new ClienteConfiguracionMaquinas
            {
                ClienteId = cliente.Id,
                BisagrasSoldadora = data.BisagraEnSoldadora,
                TripleTaladroCentro = data.TripleTaladroCentro,
                SoporteMarcoId = data.SoporteMarcoConfigId,
            });

            db.ClienteAgujases.Add(new ClienteAgujas
            {
                ClienteId = cliente.Id,
                AgujaBalconeraTipoId = data.AgujaBalconeraTipo,
                AgujaBalconeraId = data.AgujaBalconera,
                AgujaPuertaSecTipoId = data.AgujaPuertaSecTipo,
                AgujaPuertaSecId = data.AgujaPuertaSec,
                AgujaPuertaTipoId = data.AgujaPuertaTipo,
                AgujaPuertaId = data.AgujaPuerta,
            });

            foreach (var item in data.AgujasModeloPerfil)
            {
                if (!db.AgujasModelo.Any(x => x.Id == item.ModeloId))
                    continue;

                if (!db.Perfiles.Any(x => x.Id == item.PerfilId))
                    continue;

                if (!db.Agujas.Any(x => x.Id == item.AgujaId))
                    continue;

                db.ClienteAgujasModeloPerfil.Add(new ClienteAgujasModeloPerfil
                {
                    ClienteId = cliente.Id,
                    AgujaModeloTipoId = item.ModeloId,
                    PerfilId = item.PerfilId,
                    AgujaId = item.AgujaId,
                });
            }

            foreach (var item in data.Maquinas)
            {
                db.ClienteMaquinas.Add(new ClienteMaquina
                {
                    ClienteId = cliente.Id,
                    MaquinaTipoId = item.MaquinaTipoId,
                    MaquinaMarcaId = item.MaquinaMarcaId,
                    MaquinaMantenimientoId = item.MaquinaMantenimientoId,
                    Observaciones = item.Observaciones,
                });
            }

            foreach (var item in data.Documentos)
            {
                db.ClienteDocumentos.Add(new ClienteDocumento
                {
                    ClienteId = cliente.Id,
                    Nombre = item.Nombre,
                    NombreFicheroOriginal = item.NombreFicheroOriginal,
                    Extension = item.Extension,
                    Contenido = item.Contenido,
                    FechaAlta = DateTime.Now,
                    TamañoBytes = item.Contenido?.Length ?? 0,
                });
            }

            await db.SaveChangesAsync();
            await transaction.CommitAsync();

            resultado.Exito = true;
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync();
            resultado.Exito = false;
            resultado.Error = ex.Message;
        }

        return resultado;
    }

    private static async Task<string> ComprobarNombreDuplicadoAsync(ApplicationDbContext db, string nombre)
    {
        const int maxLength = 50;

        var nombreBase = nombre.Trim();
        var nombreFinal = nombreBase;
        var contador = 0;
        var existe = true;

        while (existe)
        {
            if (contador > 0)
            {
                var sufijo = $"_IMP{contador}";

                nombreFinal = nombreBase.Length + sufijo.Length > maxLength
                    ? nombreBase.Substring(0, maxLength - sufijo.Length) + sufijo
                    : nombreBase + sufijo;
            }

            var nombreBuscar = nombreFinal.ToUpper();
            existe = await db.Clientes.AnyAsync(c => c.Nombre.ToUpper() == nombreBuscar);

            if (existe)
                contador++;
        }

        return nombreFinal;
    }

    private static void AddRelations(IEnumerable<MaestroRefDto>? items, Func<int, bool> existsFunc, Action<int> addAction)
    {
        if (items is null)
            return;

        foreach (var item in items)
        {
            if (!existsFunc(item.Id))
                continue;

            addAction(item.Id);
        }
    }
}
