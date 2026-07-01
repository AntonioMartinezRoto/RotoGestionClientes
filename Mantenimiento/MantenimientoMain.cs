using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RotoGestionClientes;
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
    public partial class MantenimientoMain : Form
    {
        #region Private properties

        private readonly ApplicationDbContext _context;
        private MaestroTipo? _tablaActual = null;
        #endregion

        #region Constructors
        public MantenimientoMain(ApplicationDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        #endregion

        #region Events
        private void MantenimientoMain_Load(object sender, EventArgs e)
        {
            panel_Sidebar.BackColor = Color.FromArgb(245, 247, 250);
            CargarTextos();
            CrearGrid();
        }
        private void btn_Perfiles_Click(object sender, EventArgs e)
        {
            LoadMaestro(MaestroTipo.Perfil);
        }
        private void btn_Software_Click(object sender, EventArgs e)
        {
            LoadMaestro(MaestroTipo.Software);
        }
        private void btn_MaquinaMarcas_Click(object sender, EventArgs e)
        {
            LoadMaestro(MaestroTipo.MaquinaMarcas);
        }
        private void btn_MaquinaMantenimiento_Click(object sender, EventArgs e)
        {
            LoadMaestro(MaestroTipo.MaquinaMantenimiento);
        }
        private void btn_MaquinaTipo_Click(object sender, EventArgs e)
        {
            LoadMaestro(MaestroTipo.MaquinaTipo);
        }
        private void btn_TipoSeguridad_Click(object sender, EventArgs e)
        {
            LoadMaestro(MaestroTipo.SeguridadVentana);
        }
        private void btn_Pasivas_Click(object sender, EventArgs e)
        {
            LoadMaestro(MaestroTipo.CremonaPasivaVentana);
        }
        private void btn_Manillas_Click(object sender, EventArgs e)
        {
            LoadMaestro(MaestroTipo.Manilla);
        }
        private void btn_Bisagras_Click(object sender, EventArgs e)
        {
            LoadMaestro(MaestroTipo.BisagraPuerta);
        }

        private void btn_Cerraduras_Click(object sender, EventArgs e)
        {
            LoadMaestro(MaestroTipo.CerraduraPuerta);
        }
        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            LoadMaestro(MaestroTipo.Usuario);
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!_tablaActual.HasValue)
                return;

            using var form = new MaestroEditForm(_context, _tablaActual.Value);

            if (form.ShowDialog() != DialogResult.OK)
                return;

            RecargarGridActual();
        }
        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dgvMaestros_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            if (dgvMaestros.Columns[e.ColumnIndex].Name != "Edit")
                return;

            if (!_tablaActual.HasValue)
                return;

            var item = (MaestroGridItem)dgvMaestros.Rows[e.RowIndex].DataBoundItem;

            if(item == null)
                return;

            using var form = new MaestroEditForm(
                _context,
                _tablaActual.Value,
                item.Id);

            if (form.ShowDialog() != DialogResult.OK)
                return;

            RecargarGridActual();
        }
        #endregion

        #region Private methods
        private void CargarTextos()
        {
            btn_Usuarios.Text = Lang.Usuarios;
            btn_Perfiles.Text = Lang.Perfiles;
            btn_Software.Text = Lang.Software;
            btn_MaquinaMarcas.Text = Lang.MarcasMaquinas;
            btn_MaquinaMantenimiento.Text = Lang.MantenimientoMaquinas;
            btn_MaquinaTipo.Text = Lang.TipoMaquinas;
            btn_TipoSeguridad.Text = Lang.SeguridadVentana;
            btn_Pasivas.Text = Lang.Pasivas;
            btn_Manillas.Text = Lang.Manillas;
            btn_Bisagras.Text = Lang.Bisagras;
            btn_Cerraduras.Text = Lang.Cerraduras;
            btn_Volver.Text = Lang.VolverMenu;
        }
        private void CrearGrid()
        {
            dgvMaestros.AutoGenerateColumns = false;
            dgvMaestros.AllowUserToAddRows = false;
            dgvMaestros.ReadOnly = true;

            dgvMaestros.Columns.Clear();

            dgvMaestros.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = Lang.Nombre,
                DataPropertyName = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvMaestros.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "Activa",
                HeaderText = Lang.Activo,
                DataPropertyName = "Activa",
                Width = 80
            });

            dgvMaestros.Columns.Add(new DataGridViewImageColumn
            {
                Name = "Edit",
                HeaderText = "",
                Image = Properties.Resources.edit,
                Width = 30
            });
        }
        private void LoadMaestro(MaestroTipo tipo)
        {
            _tablaActual = tipo;
            RecargarGridActual();
        }
        private void RecargarGridActual()
        {
            dgvMaestros.Columns.Clear();
            dgvMaestros.AutoGenerateColumns = false;

            dgvMaestros.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = Lang.Nombre,
                DataPropertyName = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            if (_tablaActual == MaestroTipo.Perfil)
            {
                dgvMaestros.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Tipo",
                    HeaderText = Lang.Tipo,
                    DataPropertyName = "Tipo",
                    Width = 200
                });
            }
            
            if (_tablaActual == MaestroTipo.Usuario)
            {
                dgvMaestros.Columns.Add(new DataGridViewCheckBoxColumn
                {
                    Name = "EsDistribuidor",
                    HeaderText = Lang.EsDistribuidor,
                    DataPropertyName = "EsDistribuidor",
                    Width = 120,
                    ReadOnly = true
                });
            }

            dgvMaestros.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "Activa",
                HeaderText = Lang.Activo,
                DataPropertyName = "Activa",
                Width = 80,
                ReadOnly = true
            });

            dgvMaestros.Columns.Add(new DataGridViewImageColumn
            {
                Name = "Edit",
                HeaderText = "",
                Image = Properties.Resources.edit,
                Width = 30
            });

            switch (_tablaActual)
            {
                case MaestroTipo.Perfil:
                    dgvMaestros.DataSource = _context.Perfiles
                        .OrderBy(x => x.Nombre)
                        .Select(x => new MaestroGridItem
                        {
                            Id = x.Id,
                            Nombre = x.Nombre,
                            Tipo = x.PerfilTipo.Nombre,
                            Activa = x.Activa
                        })
                        .ToList();
                    break;

                case MaestroTipo.PerfilTipo:
                    dgvMaestros.DataSource = _context.PerfilTipos
                        .OrderBy(x => x.Nombre)
                        .Select(x => new MaestroGridItem
                        {
                            Id = x.Id,
                            Nombre = x.Nombre,
                            Activa = true
                        })
                        .ToList();
                    break;

                case MaestroTipo.Software:
                    dgvMaestros.DataSource = _context.Softwares
                        .OrderBy(x => x.Nombre)
                        .Select(x => new MaestroGridItem
                        {
                            Id = x.Id,
                            Nombre = x.Nombre,
                            Activa = x.Activa
                        })
                        .ToList();
                    break;

                case MaestroTipo.Manilla:
                    dgvMaestros.DataSource = _context.Manillas
                        .OrderBy(x => x.Nombre)
                        .Select(x => new MaestroGridItem
                        {
                            Id = x.Id,
                            Nombre = x.Nombre,
                            Activa = x.Activa
                        })
                        .ToList();
                    break;

                case MaestroTipo.CerraduraPuerta:
                    dgvMaestros.DataSource = _context.CerradurasPuerta
                        .OrderBy(x => x.Nombre)
                        .Select(x => new MaestroGridItem
                        {
                            Id = x.Id,
                            Nombre = x.Nombre,
                            Activa = x.Activa
                        })
                        .ToList();
                    break;

                case MaestroTipo.SoporteCompas:
                    dgvMaestros.DataSource = _context.SoporteCompases
                        .OrderBy(x => x.Nombre)
                        .Select(x => new MaestroGridItem
                        {
                            Id = x.Id,
                            Nombre = x.Nombre,
                            Activa = true
                        })
                        .ToList();
                    break;

                case MaestroTipo.SeguridadVentana:
                    dgvMaestros.DataSource = _context.SeguridadVentanas
                        .OrderBy(x => x.Nombre)
                        .Select(x => new MaestroGridItem
                        {
                            Id = x.Id,
                            Nombre = x.Nombre,
                            Activa = x.Activa
                        })
                        .ToList();
                    break;

                case MaestroTipo.CremonaPasivaVentana:
                    dgvMaestros.DataSource = _context.CremonaPasivaVentanaTipos
                        .OrderBy(x => x.Nombre)
                        .Select(x => new MaestroGridItem
                        {
                            Id = x.Id,
                            Nombre = x.Nombre,
                            Activa = x.Activa
                        })
                        .ToList();
                    break;

                case MaestroTipo.BisagraPuerta:
                    dgvMaestros.DataSource = _context.Bisagras
                        .OrderBy(x => x.Nombre)
                        .Select(x => new MaestroGridItem
                        {
                            Id = x.Id,
                            Nombre = x.Nombre,
                            Activa = x.Activa
                        })
                        .ToList();
                    break;

                case MaestroTipo.CilindroTipo:
                    dgvMaestros.DataSource = _context.CilindroTipos
                        .OrderBy(x => x.Nombre)
                        .Select(x => new MaestroGridItem
                        {
                            Id = x.Id,
                            Nombre = x.Nombre,
                            Activa = x.Activa
                        })
                        .ToList();
                    break;

                case MaestroTipo.MaquinaMantenimiento:
                    dgvMaestros.DataSource = _context.MaquinasMantenimiento
                        .OrderBy(x => x.Nombre)
                        .Select(x => new MaestroGridItem
                        {
                            Id = x.Id,
                            Nombre = x.Nombre,
                            Activa = x.Activa
                        })
                        .ToList();
                    break;

                case MaestroTipo.MaquinaMarcas:
                    dgvMaestros.DataSource = _context.MaquinasMarcas
                        .OrderBy(x => x.Nombre)
                        .Select(x => new MaestroGridItem
                        {
                            Id = x.Id,
                            Nombre = x.Nombre,
                            Activa = x.Activa
                        })
                        .ToList();
                    break;

                case MaestroTipo.MaquinaTipo:
                    dgvMaestros.DataSource = _context.MaquinasTipos
                        .OrderBy(x => x.Descripcion)
                        .Select(x => new MaestroGridItem
                        {
                            Id = x.Id,
                            Nombre = x.Descripcion,
                            Activa = x.Activa
                        })
                        .ToList();
                    break;

                case MaestroTipo.Usuario:
                    dgvMaestros.DataSource = _context.Usuarios
                        .OrderBy(x => x.Nombre)
                        .Select(x => new MaestroGridItem
                        {
                            Id = x.Id,
                            Nombre = x.Nombre,
                            EsDistribuidor = x.EsDistribuidor,
                            Activa = x.Activa
                        })
                        .ToList();
                    break;
            }

            dgvMaestros.Refresh();
        }
        #endregion

    }
}
