using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace RotoGestionClientes.Services
{
    public class ClienteImportService
    {
        private readonly ApplicationDbContext _context;

        public ClienteImportService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void ImportarCliente()
        {
            using var ofd = new OpenFileDialog();

            ofd.Filter = "Roto (*.roto)|*.roto";

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            var json = File.ReadAllText(ofd.FileName);

            var dto = JsonSerializer.Deserialize<ClienteExportDto>(json);

            if (dto?.Cliente == null)
            {
                MessageBox.Show(
                    "El fichero no es válido.",
                    "Importar cliente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            var data = dto.Cliente;

            // Control duplicado
            data.Nombre = CheckNameDuplicates(data.Nombre.Trim());

            Cursor.Current = Cursors.WaitCursor;

            using var transaction = _context.Database.BeginTransaction();

            try
            {
                var cliente = new Cliente
                {
                    Nombre = data.Nombre,
                    Comentarios = data.Comentarios,
                    SapId = data.SapId,
                    Alias = data.Alias,

                    ObservacionesVentanas =
                        data.ObservacionesVentanas,

                    ObservacionesBalconeras =
                        data.ObservacionesBalconeras,

                    ObservacionesPuertas =
                        data.ObservacionesPuertas,

                    ObservacionesParalelas =
                        data.ObservacionesParalelas,

                    ObservacionesCorrederas =
                        data.ObservacionesCorrederas,

                    ObservacionesElevables =
                        data.ObservacionesElevables,

                    ObservacionesPlegables =
                        data.ObservacionesPlegables,

                    ObservacionesMaquinas =
                        data.ObservacionesMaquinas,

                    ObservacionesDocumentos =
                        data.ObservacionesDocumentos
                };

                _context.Clientes.Add(cliente);

                _context.SaveChanges();

                // ======================================================
                // SOFTWARES
                // ======================================================

                AddRelations(
                    data.Softwares,
                    id => _context.Softwares.Any(x => x.Id == id),
                    id =>
                    {
                        _context.ClienteSoftwares.Add(
                            new ClienteSoftware
                            {
                                ClienteId = cliente.Id,
                                SoftwareId = id
                            });
                    });

                // ======================================================
                // MANILLAS
                // ======================================================

                AddRelations(
                    data.Manillas,
                    id => _context.Manillas.Any(x => x.Id == id),
                    id =>
                    {
                        _context.ClienteManillas.Add(
                            new ClienteManilla
                            {
                                ClienteId = cliente.Id,
                                ManillaId = id
                            });
                    });

                // ======================================================
                // PERFILES
                // ======================================================

                AddRelations(
                    data.Perfiles,
                    id => _context.Perfiles.Any(x => x.Id == id),
                    id =>
                    {
                        _context.ClientePerfiles.Add(
                            new ClientePerfil
                            {
                                ClienteId = cliente.Id,
                                PerfilId = id
                            });
                    });

                // ======================================================
                // SOPORTE COMPAS
                // ======================================================

                AddRelations(
                    data.SoporteCompas,
                    id => _context.SoporteCompases.Any(x => x.Id == id),
                    id =>
                    {
                        _context.ClienteSoporteCompases.Add(
                            new ClienteSoporteCompas
                            {
                                ClienteId = cliente.Id,
                                SoporteCompasId = id
                            });
                    });

                // ======================================================
                // SEGURIDAD VENTANA
                // ======================================================

                AddRelations(
                    data.SeguridadVentanas,
                    id => _context.SeguridadVentanas.Any(x => x.Id == id),
                    id =>
                    {
                        _context.ClienteSeguridadVentanas.Add(
                            new ClienteSeguridadVentana
                            {
                                ClienteId = cliente.Id,
                                SeguridadVentanaId = id
                            });
                    });

                // ======================================================
                // SEGURIDAD BALCONERA
                // ======================================================

                AddRelations(
                    data.SeguridadBalconeras,
                    id => _context.SeguridadVentanas.Any(x => x.Id == id),
                    id =>
                    {
                        _context.ClienteSeguridadBalconeras.Add(
                            new ClienteSeguridadBalconera
                            {
                                ClienteId = cliente.Id,
                                SeguridadBalconeraId = id
                            });
                    });

                // ======================================================
                // CREMONAS
                // ======================================================

                AddRelations(
                    data.CremonaPasivaVentanas,
                    id => _context.CremonaPasivaVentanaTipos.Any(x => x.Id == id),
                    id =>
                    {
                        _context.ClienteCremonaPasivaVentanas.Add(
                            new ClienteCremonaPasivaVentana
                            {
                                ClienteId = cliente.Id,
                                CremonaPasivaVentanaId = id
                            });
                    });

                AddRelations(
                    data.CremonaPasivaVentanasPract,
                    id => _context.CremonaPasivaVentanaTipos.Any(x => x.Id == id),
                    id =>
                    {
                        _context.ClienteCremonaPasivaVentanasPract.Add(
                            new ClienteCremonaPasivaVentanaPract
                            {
                                ClienteId = cliente.Id,
                                CremonaPasivaVentanaId = id
                            });
                    });

                AddRelations(
                    data.CremonaPasivaBalconeras,
                    id => _context.CremonaPasivaVentanaTipos.Any(x => x.Id == id),
                    id =>
                    {
                        _context.ClienteCremonaPasivaBalconeras.Add(
                            new ClienteCremonaPasivaBalconera
                            {
                                ClienteId = cliente.Id,
                                CremonaPasivaBalconeraId = id
                            });
                    });

                // ======================================================
                // BISAGRAS
                // ======================================================

                AddRelations(
                    data.BisagrasPuerta,
                    id => _context.Bisagras.Any(x => x.Id == id),
                    id =>
                    {
                        _context.ClienteBisagraPuertas.Add(
                            new ClienteBisagraPuerta
                            {
                                ClienteId = cliente.Id,
                                BisagraPuertaId = id
                            });
                    });

                AddRelations(
                    data.BisagrasPuertaSec,
                    id => _context.Bisagras.Any(x => x.Id == id),
                    id =>
                    {
                        _context.ClienteBisagraPuertasSec.Add(
                            new ClienteBisagraPuertaSec
                            {
                                ClienteId = cliente.Id,
                                BisagraPuertaId = id
                            });
                    });

                // ======================================================
                // CERRADURAS
                // ======================================================

                AddRelations(
                    data.CerradurasPuerta,
                    id => _context.CerradurasPuerta.Any(x => x.Id == id),
                    id =>
                    {
                        _context.ClienteCerradurasPuerta.Add(
                            new ClienteCerraduraPuerta
                            {
                                ClienteId = cliente.Id,
                                CerraduraPuertaId = id
                            });
                    });

                AddRelations(
                    data.CerradurasPuertaSec,
                    id => _context.CerradurasPuertaSec.Any(x => x.Id == id),
                    id =>
                    {
                        _context.ClienteCerradurasPuertaSec.Add(
                            new ClienteCerraduraPuertaSec
                            {
                                ClienteId = cliente.Id,
                                CerraduraPuertaSecId = id
                            });
                    });

                // ======================================================
                // CILINDROS
                // ======================================================

                AddRelations(
                    data.Cilindros,
                    id => _context.Cilindros.Any(x => x.Id == id),
                    id =>
                    {
                        _context.ClienteCilindros.Add(
                            new ClienteCilindro
                            {
                                ClienteId = cliente.Id,
                                CilindroId = id
                            });
                    });

                // ======================================================
                // AGUJAS CORREDERA
                // ======================================================

                AddRelations(
                    data.AgujasCorredera,
                    id => _context.Agujas.Any(x => x.Id == id),
                    id =>
                    {
                        _context.ClienteAgujasCorrederas.Add(
                            new ClienteAgujasCorredera
                            {
                                ClienteId = cliente.Id,
                                AgujaCorrederaId = id
                            });
                    });

                // ======================================================
                // CONFIGURACION PUERTA
                // ======================================================

                _context.ClienteConfiguracionPuerta.Add(
                    new ClienteConfiguracionPuerta
                    {
                        ClienteId = cliente.Id,
                        PorteroElectrico = data.PorteroElectrico,
                        Cilindro = data.Cilindro
                    });

                // ======================================================
                // CONFIGURACION CORREDERA
                // ======================================================

                _context.ClienteCilindrosCorredera.Add(
                    new ClienteCilindroCorredera
                    {
                        ClienteId = cliente.Id,
                        Cilindro = data.CilindroCorredera
                    });

                // ======================================================
                // CONFIGURACION ELEVABLE / PLEGABLE
                // ======================================================

                _context.ClienteConfiguracionElevablePlegables.Add(
                    new ClienteConfiguracionElevablePlegable
                    {
                        ClienteId = cliente.Id,
                        Elevable_Estandar = data.Elevable_Estandar,
                        Elevable_Dlo = data.Elevable_Dlo,
                        Plegable_Consumen = data.Plegable_Consumen
                    });

                // ======================================================
                // CONFIGURACION MAQUINAS
                // ======================================================

                _context.ClienteConfiguracionMaquinas.Add(
                    new ClienteConfiguracionMaquinas
                    {
                        ClienteId = cliente.Id,
                        BisagrasSoldadora = data.BisagraEnSoldadora,
                        TripleTaladroCentro = data.TripleTaladroCentro,
                        SoporteMarcoId = data.SoporteMarcoConfigId
                    });

                // ======================================================
                // AGUJAS
                // ======================================================

                _context.ClienteAgujases.Add(
                    new ClienteAgujas
                    {
                        ClienteId = cliente.Id,

                        AgujaBalconeraTipoId =
                            data.AgujaBalconeraTipo,

                        AgujaBalconeraId =
                            data.AgujaBalconera,

                        AgujaPuertaSecTipoId =
                            data.AgujaPuertaSecTipo,

                        AgujaPuertaSecId =
                            data.AgujaPuertaSec,

                        AgujaPuertaTipoId =
                            data.AgujaPuertaTipo,

                        AgujaPuertaId =
                            data.AgujaPuerta
                    });

                // ======================================================
                // AGUJAS MODELO PERFIL
                // ======================================================

                foreach (var item in data.AgujasModeloPerfil)
                {
                    if (!_context.AgujasModelo.Any(x => x.Id == item.ModeloId))
                        continue;

                    if (!_context.Perfiles.Any(x => x.Id == item.PerfilId))
                        continue;

                    if (!_context.Agujas.Any(x => x.Id == item.AgujaId))
                        continue;

                    _context.ClienteAgujasModeloPerfil.Add(
                        new ClienteAgujasModeloPerfil
                        {
                            ClienteId = cliente.Id,
                            AgujaModeloTipoId = item.ModeloId,
                            PerfilId = item.PerfilId,
                            AgujaId = item.AgujaId
                        });
                }

                // ======================================================
                // MAQUINAS
                // ======================================================

                foreach (var item in data.Maquinas)
                {
                    _context.ClienteMaquinas.Add(
                        new ClienteMaquina
                        {
                            ClienteId = cliente.Id,
                            MaquinaTipoId =
                                item.MaquinaTipoId,

                            MaquinaMarcaId =
                                item.MaquinaMarcaId,

                            MaquinaMantenimientoId =
                                item.MaquinaMantenimientoId,

                            Observaciones =
                                item.Observaciones
                        });
                }

                // ======================================================
                // DOCUMENTOS
                // ======================================================

                foreach (var item in data.Documentos)
                {
                    _context.ClienteDocumentos.Add(
                        new ClienteDocumento
                        {
                            ClienteId = cliente.Id,
                            Nombre = item.Nombre,
                            NombreFicheroOriginal =
                                item.NombreFicheroOriginal,
                            Extension = item.Extension,
                            Contenido = item.Contenido,
                            FechaAlta = DateTime.Now,
                            TamañoBytes =
                                item.Contenido?.Length ?? 0
                        });
                }

                _context.SaveChanges();

                transaction.Commit();

                Cursor.Current = Cursors.Default;

                MessageBox.Show(
                    "Cliente importado correctamente.",
                    "Importar cliente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                transaction.Rollback();

                MessageBox.Show(
                    $"Error al importar cliente:\n\n{ex.Message}",
                    "Importar cliente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private string CheckNameDuplicates(string nombre)
        {
            Cliente cliente = _context.Clientes.Where(c => c.Nombre.ToUpper().Trim() == nombre.ToUpper().Trim()).FirstOrDefault();
            if (cliente != null)
            {
                MessageBox.Show(
                    "Ya existe un cliente con ese nombre. Cliente importado con un nombre modificado (_IMP)",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return nombre + "_IMP";
            }
            return nombre;
        }

        private void AddRelations(IEnumerable<MaestroRefDto> items, Func<int, bool> existsFunc, Action<int> addAction)
        {
            if (items == null)
                return;

            foreach (var item in items)
            {
                if (!existsFunc(item.Id))
                    continue;

                addAction(item.Id);
            }
        }
    }
}
