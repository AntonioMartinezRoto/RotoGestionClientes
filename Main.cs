using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using System.Text.Json;

namespace RotoGestionClientes
{
    public partial class Main : Form
    {
        #region Private properties
        private readonly ApplicationInfo _applicationInfo;
        private readonly ApplicationDbContext _context;
        private List<ClienteGridItem> _allClientes = new();
        #endregion

        #region Constructors

        public Main()
        {
            InitializeComponent();
            _context = Program.AppServices.GetRequiredService<ApplicationDbContext>();
            _applicationInfo = Program.AppServices.GetRequiredService<ApplicationInfo>();
        }

        #endregion

        #region Events

        private void Main_Load(object sender, EventArgs e)
        {
            this.Text = $"v{_applicationInfo.Version}";
            panel_Sidebar.BackColor = Color.FromArgb(245, 247, 250);
            SetVisibilidadModoAplicacion();
            SetVersionDatosInfo();
            LoadClientesFromDB();
        }

        private void SetVisibilidadModoAplicacion()
        {
            if (_applicationInfo.IsDistributor)
            {
                btn_Mantenimiento.Visible = false;
                btn_GenerarActualizacion.Visible = false;
            }
            else if (_applicationInfo.IsInternal)
            {
                btn_Mantenimiento.Visible = true;
                btn_GenerarActualizacion.Visible = true;

                btn_UpdateRotoData.Visible = false;
            }
            else if (_applicationInfo.IsDebug)
            {
                btn_Mantenimiento.Visible = true;
                btn_GenerarActualizacion.Visible = true;
                btn_UpdateRotoData.Visible = true;
            }
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            ClientesMain clientesMainForm = new(_allClientes, _context);
            clientesMainForm.ShowDialog();
            LoadClientesFromDB();
        }
        private void btn_Mantenimiento_Click(object sender, EventArgs e)
        {
            MantenimientoMain mantenimientoMainForm = new(_context);
            mantenimientoMainForm.ShowDialog();
            SetVersionDatosInfo();
        }
        private void btn_Informes_Click(object sender, EventArgs e)
        {
            InformesMain informesMainForm = new(_context);
            informesMainForm.ShowDialog();
        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_GenerarActualizacion_Click(object sender, EventArgs e)
        {
            ExportarDatosMaestros();
        }
        private void btn_UpdateRotoData_Click(object sender, EventArgs e)
        {
            ImportarDatosMaestros();
        }

        #endregion

        #region Private methods
        private void SetVersionDatosInfo()
        {
            var versionLocal = _context.ConfiguracionAplicacion.First().VersionMaestros;
            toolStripStatusLabel_dataVersion.Text = $"Versión de los datos: {versionLocal}";
        }
        private void LoadClientesFromDB()
        {
            _allClientes = _context.Clientes
                .Select(f => new ClienteGridItem
                {
                    Id = f.Id,
                    Nombre = f.Nombre,
                    SapId = f.SapId,
                    Alias = f.Alias,
                    Responsable = f.Responsable != null ? f.Responsable.Nombre : String.Empty,
                    Comentarios = f.Comentarios,
                    ObservacionesVentanas = f.ObservacionesVentanas,
                    ObservacionesBalconeras = f.ObservacionesBalconeras
                })
                .OrderBy(f => f.Nombre)
                .ToList();
        }
        public void ExportarDatosMaestros()
        {
            try
            {
                var version = _context.ConfiguracionAplicacion.First().VersionMaestros;

                var dto = new MaestrosExportDto
                {
                    VersionMaestros = version,

                    Softwares = _context.Softwares
                        .Select(x => new MaestroDto
                        {
                            Id = x.Id,
                            Nombre = x.Nombre,
                            Activa = x.Activa
                        })
                        .ToList(),

                    PerfilTipos = _context.PerfilTipos
                        .Select(x => new PerfilTipoDto
                        {
                            Id = x.Id,
                            Nombre = x.Nombre,
                            NombreAbreviado = x.NombreAbreviado
                        })
                        .ToList(),

                    Perfiles = _context.Perfiles
                        .Select(x => new PerfilDto
                        {
                            Id = x.Id,
                            Nombre = x.Nombre,
                            Activa = x.Activa,
                            PerfilTipoId = x.PerfilTipoId
                        })
                        .ToList(),

                    Manillas = _context.Manillas
                        .Select(x => new MaestroDto
                        {
                            Id = x.Id,
                            Nombre = x.Nombre,
                            Activa = x.Activa
                        })
                        .ToList(),

                    SoporteCompases = _context.SoporteCompases
                        .Select(x => new MaestroDto
                        {
                            Id = x.Id,
                            Nombre = x.Nombre
                        })
                        .ToList(),

                    SeguridadVentanas = _context.SeguridadVentanas
                        .Select(x => new MaestroDto
                        {
                            Id = x.Id,
                            Nombre = x.Nombre,
                            Activa = x.Activa
                        })
                        .ToList(),

                    CremonaPasivaVentanas = _context.CremonaPasivaVentanaTipos
                        .Select(x => new MaestroDto
                        {
                            Id = x.Id,
                            Nombre = x.Nombre,
                            Activa = x.Activa
                        })
                        .ToList(),

                    Bisagras = _context.Bisagras
                        .Select(x => new MaestroDto
                        {
                            Id = x.Id,
                            Nombre = x.Nombre,
                            Activa = x.Activa
                        })
                        .ToList(),

                    CerradurasPuerta = _context.CerradurasPuerta
                        .Select(x => new MaestroDto
                        {
                            Id = x.Id,
                            Nombre = x.Nombre,
                            Activa = x.Activa
                        })
                        .ToList(),

                    CerradurasPuertaSec = _context.CerradurasPuertaSec
                        .Select(x => new MaestroDto
                        {
                            Id = x.Id,
                            Nombre = x.Nombre,
                            Activa = x.Activa
                        })
                        .ToList(),

                    Agujas = _context.Agujas
                        .Select(x => new MaestroDto
                        {
                            Id = x.Id,
                            Nombre = x.Nombre,
                            Activa = x.Activa
                        })
                        .ToList(),

                    MaquinasTipo = _context.MaquinasTipos
                        .Select(x => new MaquinaTipoDto
                        {
                            Id = x.Id,
                            Descripcion = x.Descripcion,
                            Activa = x.Activa
                        })
                        .ToList(),

                    MaquinasMarca = _context.MaquinasMarcas
                        .Select(x => new MaestroDto
                        {
                            Id = x.Id,
                            Nombre = x.Nombre,
                            Activa = x.Activa
                        })
                        .ToList(),

                    MaquinasMantenimiento = _context.MaquinasMantenimiento
                        .Select(x => new MaestroDto
                        {
                            Id = x.Id,
                            Nombre = x.Nombre,
                            Activa = x.Activa
                        })
                        .ToList()
                };

                using var sfd = new SaveFileDialog();

                sfd.Filter = "Roto Data (*.rotodata)|*.rotodata";

                sfd.FileName = $"Maestros_v{version}.rotodata";

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                var json =
                    JsonSerializer.Serialize(
                        dto,
                        new JsonSerializerOptions
                        {
                            WriteIndented = true
                        });

                File.WriteAllText(
                    sfd.FileName,
                    json);


                MessageBox.Show(
                    "Datos exportados correctamente.",
                    "Exportar datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos maestros.");
            }

        }
        public void ImportarDatosMaestros()
        {
            try
            {
                using var ofd = new OpenFileDialog();
                ofd.Filter = "Roto Data (*.rotodata)|*.rotodata";

                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                var json = File.ReadAllText(ofd.FileName);
                var dto = JsonSerializer.Deserialize<MaestrosExportDto>(json);

                if (dto == null)
                    return;

                UpsertMaestro(dto.Softwares, _context.Softwares);
                UpsertPerfilTipos(dto.PerfilTipos);
                UpsertPerfiles(dto.Perfiles);
                UpsertMaestro(dto.Manillas, _context.Manillas);
                UpsertMaestro(dto.SoporteCompases, _context.SoporteCompases);
                UpsertMaestro(dto.SeguridadVentanas, _context.SeguridadVentanas);
                UpsertMaestro(dto.CremonaPasivaVentanas, _context.CremonaPasivaVentanaTipos);
                UpsertMaestro(dto.Bisagras, _context.Bisagras);
                UpsertMaestro(dto.CerradurasPuerta, _context.CerradurasPuerta);
                UpsertMaestro(dto.CerradurasPuertaSec, _context.CerradurasPuertaSec);
                UpsertMaestro(dto.Agujas, _context.Agujas);
                UpsertMaquinaTipos(dto.MaquinasTipo);
                UpsertMaestro(dto.MaquinasMarca, _context.MaquinasMarcas);
                UpsertMaestro(dto.MaquinasMantenimiento, _context.MaquinasMantenimiento);

                var config = _context.ConfiguracionAplicacion.First();
                config.VersionMaestros = dto.VersionMaestros;

                _context.SaveChanges();

                MessageBox.Show($"Datos maestros actualizados a la versión {dto.VersionMaestros}");

                SetVersionDatosInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al importar los datos maestros.");
                SetVersionDatosInfo();
            }            
        }
        private void UpsertMaestro<TEntity>(IEnumerable<MaestroDto> origen, DbSet<TEntity> tabla) where TEntity : class, new()
        {
            foreach (var item in origen)
            {
                dynamic? entidad =
                    tabla.Find(item.Id);

                if (entidad == null)
                {
                    entidad = new TEntity();

                    entidad.Id = item.Id;

                    tabla.Add(entidad);
                }

                entidad.Nombre = item.Nombre;
                entidad.Activa = item.Activa;
            }
        }
        private void UpsertMaquinaTipos(List<MaquinaTipoDto> dto)
        {
            foreach (var item in dto)
            {
                var entidad = _context.MaquinasTipos
                    .FirstOrDefault(x => x.Id == item.Id);

                if (entidad == null)
                {
                    entidad = new MaquinaTipo
                    {
                        Id = item.Id
                    };

                    _context.MaquinasTipos.Add(entidad);
                }

                entidad.Descripcion = item.Descripcion;
                entidad.Activa = item.Activa;
            }
        }
        private void UpsertPerfilTipos(List<PerfilTipoDto> dto)
        {
            foreach (var item in dto)
            {
                var entidad = _context.PerfilTipos
                    .FirstOrDefault(x => x.Id == item.Id);

                if (entidad == null)
                {
                    entidad = new PerfilTipo
                    {
                        Id = item.Id
                    };

                    _context.PerfilTipos.Add(entidad);
                }

                entidad.Nombre = item.Nombre;
                entidad.NombreAbreviado = item.NombreAbreviado;
            }
        }
        private void UpsertPerfiles(List<PerfilDto> dto)
        {
            foreach (var item in dto)
            {
                var entidad = _context.Perfiles
                    .FirstOrDefault(x => x.Id == item.Id);

                if (entidad == null)
                {
                    entidad = new Perfil
                    {
                        Id = item.Id
                    };

                    _context.Perfiles.Add(entidad);
                }

                entidad.Nombre = item.Nombre;
                entidad.Activa = item.Activa;
                entidad.PerfilTipoId = item.PerfilTipoId;
            }
        }

        #endregion
    }
}
