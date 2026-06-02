using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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
            CargarDatos();
        }
        private void CargarDatos()
        {
            txt_Nombre.Text = string.Empty;
            chk_Activo.Checked = true;

            if (_id == null)
                return;

            switch (_tipo)
            {
                case MaestroTipo.Perfil:
                    {
                        var e = _context.Perfiles.First(x => x.Id == _id);
                        txt_Nombre.Text = e.Nombre;
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

                case MaestroTipo.CilindroTipo:
                    GuardarCilindroTipo();
                    break;

                case MaestroTipo.MaquinaMantenimiento:
                    GuardarMaquinaMantenimiento();
                    break;
            }
        }

        #region Guardados
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
