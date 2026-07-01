using Microsoft.EntityFrameworkCore;
using System.Data;
using static RotoGestionClientes.Enums;

namespace RotoGestionClientes
{
    public partial class MaestroEditForm : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly MaestroTipo _tipo;
        private readonly int? _id;

        public bool Guardado { get; private set; }

        public MaestroEditForm(ApplicationDbContext context, MaestroTipo tipo, int? id = null)
        {
            InitializeComponent();

            _context = context;
            _tipo = tipo;
            _id = id;
        }
        private void MaestroEditForm_Load(object sender, EventArgs e)
        {
            CargarTextos();
            CargarDatos();
        }
        private void CargarTextos()
        {
            btn_Aceptar.Text = Lang.Guardar;
            btn_Cancelar.Text = Lang.Cancelar;
            lbl_Nombre.Text = Lang.Nombre;
            lbl_PerfilTipo.Text = Lang.Tipo;
            chk_Activo.Text = Lang.Activo;
            chk_EsDistribuidor.Text = Lang.EsDistribuidor;
        }
        private void CargarDatos()
        {
            txt_Nombre.Text = string.Empty;
            chk_Activo.Checked = true;

            if (_tipo == MaestroTipo.Perfil)
            {
                lbl_PerfilTipo.Visible = true;
                cmb_PerfilTipo.Visible = true;
                chk_EsDistribuidor.Visible = false;

                var perfilesTipos = _context.PerfilTipos
                                        .OrderBy(x => x.Nombre)
                                        .ToList();

                cmb_PerfilTipo.DataSource = perfilesTipos;
                cmb_PerfilTipo.DisplayMember = "Nombre";
                cmb_PerfilTipo.ValueMember = "Id";

                cmb_PerfilTipo.SelectedIndex = -1;
            }
            else if (_tipo == MaestroTipo.Usuario)
            {
                chk_EsDistribuidor.Visible = true;
            }
            else
            {
                lbl_PerfilTipo.Visible = false;
                cmb_PerfilTipo.Visible = false;
                chk_EsDistribuidor.Visible = false;
            }

            if (_id == null)
                return;

            switch (_tipo)
            {
                case MaestroTipo.Perfil:
                    {
                        var e = _context.Perfiles.First(x => x.Id == _id);
                        txt_Nombre.Text = e.Nombre;
                        chk_Activo.Checked = e.Activa;

                        cmb_PerfilTipo.SelectedValue = e.PerfilTipoId;
                    }
                    break;
                case MaestroTipo.PerfilTipo:
                    {
                        var e = _context.PerfilTipos.First(x => x.Id == _id);
                        txt_Nombre.Text = e.Nombre;
                    }
                    break;

                case MaestroTipo.Software:
                    {
                        var e = _context.Softwares.First(x => x.Id == _id);
                        txt_Nombre.Text = e.Nombre;
                        chk_Activo.Checked = e.Activa;
                    }
                    break;

                case MaestroTipo.Manilla:
                    {
                        var e = _context.Manillas.First(x => x.Id == _id);
                        txt_Nombre.Text = e.Nombre;
                        chk_Activo.Checked = e.Activa;
                    }
                    break;

                case MaestroTipo.CerraduraPuerta:
                    {
                        var e = _context.CerradurasPuerta.First(x => x.Id == _id);
                        txt_Nombre.Text = e.Nombre;
                        chk_Activo.Checked = e.Activa;
                    }
                    break;

                case MaestroTipo.BisagraPuerta:
                    {
                        var e = _context.Bisagras.First(x => x.Id == _id);
                        txt_Nombre.Text = e.Nombre;
                        chk_Activo.Checked = e.Activa;
                    }
                    break;

                case MaestroTipo.SoporteCompas:
                    {
                        var e = _context.SoporteCompases.First(x => x.Id == _id);
                        txt_Nombre.Text = e.Nombre;
                    }
                    break;

                case MaestroTipo.SeguridadVentana:
                    {
                        var e = _context.SeguridadVentanas.First(x => x.Id == _id);
                        txt_Nombre.Text = e.Nombre;
                        chk_Activo.Checked = e.Activa;
                    }
                    break;
                case MaestroTipo.CremonaPasivaVentana:
                    {
                        var e = _context.CremonaPasivaVentanaTipos.First(x => x.Id == _id);
                        txt_Nombre.Text = e.Nombre;
                        chk_Activo.Checked = e.Activa;
                    }
                    break;
                case MaestroTipo.CilindroTipo:
                    {
                        var e = _context.CilindroTipos.First(x => x.Id == _id);
                        txt_Nombre.Text = e.Nombre;
                        chk_Activo.Checked = e.Activa;
                    }
                    break;

                case MaestroTipo.MaquinaMantenimiento:
                    {
                        var e = _context.MaquinasMantenimiento.First(x => x.Id == _id);
                        txt_Nombre.Text = e.Nombre;
                        chk_Activo.Checked = e.Activa;
                    }
                    break;
                case MaestroTipo.MaquinaMarcas:
                    {
                        var e = _context.MaquinasMarcas.First(x => x.Id == _id);
                        txt_Nombre.Text = e.Nombre;
                        chk_Activo.Checked = e.Activa;
                    }
                    break;
                case MaestroTipo.MaquinaTipo:
                    {
                        var e = _context.MaquinasTipos.First(x => x.Id == _id);
                        txt_Nombre.Text = e.Descripcion;
                        chk_Activo.Checked = e.Activa;
                    }
                    break;
                case MaestroTipo.Usuario:
                    {
                        var e = _context.Usuarios.First(x => x.Id == _id);
                        txt_Nombre.Text = e.Nombre;
                        chk_Activo.Checked = e.Activa;
                        chk_EsDistribuidor.Checked = e.EsDistribuidor;
                    }
                    break;
            }
        }
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Nombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                return;
            }

            Guardar();
            _context.SaveChanges();

            Guardado = true;
            DialogResult = DialogResult.OK;
            Close();
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void Guardar()
        {
            switch (_tipo)
            {
                case MaestroTipo.Perfil:
                    GuardarPerfil();
                    break;

                case MaestroTipo.PerfilTipo:
                    GuardarPerfilTipo();
                    break;

                case MaestroTipo.Software:
                    GuardarSoftware();
                    break;

                case MaestroTipo.Manilla:
                    GuardarManilla();
                    break;

                case MaestroTipo.CerraduraPuerta:
                    GuardarCerraduraPuerta();
                    break;

                case MaestroTipo.BisagraPuerta:
                    GuardarBisagraPuerta();
                    break;

                case MaestroTipo.CilindroTipo:
                    GuardarCilindroTipo();
                    break;

                case MaestroTipo.MaquinaMantenimiento:
                    GuardarMaquinaMantenimiento();
                    break;

                case MaestroTipo.MaquinaMarcas:
                    GuardarMaquinaMarcas();
                    break;

                case MaestroTipo.MaquinaTipo:
                    GuardarMaquinaTipos();
                    break;

                case MaestroTipo.SeguridadVentana:
                    GuardarSeguridadVentana();
                    break;

                case MaestroTipo.CremonaPasivaVentana:
                    GuardarCremonaPasivaVentana();
                    break;

                case MaestroTipo.Usuario:
                    GuardarUsuario();
                    break;
            }
            
            IncrementarVersionDatos();
        }

        #region Guardados
        private void IncrementarVersionDatos()
        {
            var configuracion = _context.ConfiguracionAplicacion.First();
            var version = configuracion.VersionMaestros;

            var partes = version.Split('.');

            var mayor = int.Parse(partes[0]);
            var menor = int.Parse(partes[1]);

            menor++;

            if (menor > 99)
            {
                mayor++;
                menor = 0;
            }
            configuracion.VersionMaestros = $"{mayor}.{menor}";
        }
        private void GuardarPerfil()
        {
            var entity = _id == null
                ? new Perfil()
                : _context.Perfiles.First(x => x.Id == _id);

            if (_id == null)
            {
                entity.Id = NuevoId<Perfil>();
                _context.Perfiles.Add(entity);
            }

            entity.Nombre = txt_Nombre.Text.Trim();
            entity.Activa = chk_Activo.Checked;
            entity.PerfilTipoId = (int)cmb_PerfilTipo.SelectedValue;
        }
        private void GuardarPerfilTipo()
        {
            var entity = _id == null
                ? new PerfilTipo()
                : _context.PerfilTipos.First(x => x.Id == _id);

            if (_id == null)
            {
                entity.Id = NuevoId<PerfilTipo>();
                _context.PerfilTipos.Add(entity);
            }

            entity.Nombre = txt_Nombre.Text.Trim();
        }
        private void GuardarSoftware()
        {
            var entity = _id == null
                ? new Software()
                : _context.Softwares.First(x => x.Id == _id);

            if (_id == null)
            {
                entity.Id = NuevoId<Software>();
                _context.Softwares.Add(entity);
            }

            entity.Nombre = txt_Nombre.Text.Trim();
            entity.Activa = chk_Activo.Checked;
        }
        private void GuardarManilla()
        {
            var entity = _id == null
                ? new Manilla()
                : _context.Manillas.First(x => x.Id == _id);

            if (_id == null)
            {
                entity.Id = NuevoId<Manilla>();
                _context.Manillas.Add(entity);
            }

            entity.Nombre = txt_Nombre.Text.Trim();
            entity.Activa = chk_Activo.Checked;
        }
        private void GuardarCerraduraPuerta()
        {
            var entity = _id == null
                ? new CerraduraPuerta()
                : _context.CerradurasPuerta.First(x => x.Id == _id);

            if (_id == null)
            {
                entity.Id = NuevoId<CerraduraPuerta>();
                _context.CerradurasPuerta.Add(entity);
            }

            entity.Nombre = txt_Nombre.Text.Trim();
            entity.Activa = chk_Activo.Checked;
        }
        private void GuardarBisagraPuerta()
        {
            var entity = _id == null
                ? new Bisagra()
                : _context.Bisagras.First(x => x.Id == _id);

            if (_id == null)
            {
                entity.Id = NuevoId<Bisagra>();
                _context.Bisagras.Add(entity);
            }

            entity.Nombre = txt_Nombre.Text.Trim();
            entity.Activa = chk_Activo.Checked;
        }
        private void GuardarCilindroTipo()
        {
            var entity = _id == null
                ? new CilindroTipo()
                : _context.CilindroTipos.First(x => x.Id == _id);

            if (_id == null)
            {
                entity.Id = NuevoId<CilindroTipo>();
                _context.CilindroTipos.Add(entity);
            }

            entity.Nombre = txt_Nombre.Text.Trim();
            entity.Activa = chk_Activo.Checked;
        }
        private void GuardarMaquinaMantenimiento()
        {
            var entity = _id == null
                ? new MaquinaMantenimiento()
                : _context.MaquinasMantenimiento.First(x => x.Id == _id);

            if (_id == null)
            {
                entity.Id = NuevoId<MaquinaMantenimiento>();
                _context.MaquinasMantenimiento.Add(entity);
            }

            entity.Nombre = txt_Nombre.Text.Trim();
            entity.Activa = chk_Activo.Checked;
        }
        private void GuardarMaquinaMarcas()
        {
            var entity = _id == null
                ? new MaquinaMarca()
                : _context.MaquinasMarcas.First(x => x.Id == _id);

            if (_id == null)
            {
                entity.Id = NuevoId<MaquinaMarca>();
                _context.MaquinasMarcas.Add(entity);
            }

            entity.Nombre = txt_Nombre.Text.Trim();
            entity.Activa = chk_Activo.Checked;
        }
        private void GuardarMaquinaTipos()
        {
            var entity = _id == null
                ? new MaquinaTipo()
                : _context.MaquinasTipos.First(x => x.Id == _id);

            if (_id == null)
            {
                entity.Id = NuevoId<MaquinaTipo>();
                _context.MaquinasTipos.Add(entity);
            }

            entity.Descripcion = txt_Nombre.Text.Trim();
            entity.Activa = chk_Activo.Checked;
        }
        private void GuardarSeguridadVentana()
        {
            var entity = _id == null
                ? new SeguridadVentana()
                : _context.SeguridadVentanas.First(x => x.Id == _id);

            if (_id == null)
            {
                entity.Id = NuevoId<SeguridadVentana>();
                _context.SeguridadVentanas.Add(entity);
            }

            entity.Nombre = txt_Nombre.Text.Trim();
            entity.Activa = chk_Activo.Checked;
        }
        private void GuardarCremonaPasivaVentana()
        {
            var entity = _id == null
                ? new CremonaPasivaVentanaTipos()
                : _context.CremonaPasivaVentanaTipos.First(x => x.Id == _id);

            if (_id == null)
            {
                entity.Id = NuevoId<CremonaPasivaVentanaTipos>();
                _context.CremonaPasivaVentanaTipos.Add(entity);
            }

            entity.Nombre = txt_Nombre.Text.Trim();
            entity.Activa = chk_Activo.Checked;
        }
        private void GuardarUsuario()
        {
            var entity = _id == null
                ? new Usuario()
                : _context.Usuarios.First(x => x.Id == _id);

            if (_id == null)
            {
                entity.Id = NuevoId<Usuario>();
                _context.Usuarios.Add(entity);
            }

            entity.Nombre = txt_Nombre.Text.Trim();
            entity.Activa = chk_Activo.Checked;
            entity.EsDistribuidor = chk_EsDistribuidor.Checked;
        }
        private int NuevoId<T>() where T : class
        {
            var set = _context.Set<T>();

            var ids = set
                .Select(x => EF.Property<int>(x, "Id"))
                .ToList();

            return ids.Any() ? ids.Max() + 1 : 1;
        }

        #endregion
    }
}
