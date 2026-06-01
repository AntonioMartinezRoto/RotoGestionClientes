using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RotoGestionClientes
{
    public partial class DefinicionMaquinas : Form
    {
        #region Private properties

        private readonly ApplicationDbContext _context;
        private readonly ClienteMaquinaItem? _item;

        #endregion

        #region Public properties

        public ClienteMaquinaItem Result { get; private set; } = new();

        #endregion

        #region Constructors
        public DefinicionMaquinas()
        {
            InitializeComponent();
        }

        public DefinicionMaquinas(ApplicationDbContext context, ClienteMaquinaItem? item = null)
        {
            InitializeComponent();
            _context = context;
            _item = item;
        }
        #endregion

        #region Events
        private void DefinicionMaquinas_Load(object sender, EventArgs e)
        {
            cmb_TipoMaquina.DataSource = _context.MaquinasTipos
                                        .Where(x => x.Activa)
                                        .OrderBy(x => x.Descripcion)
                                        .ToList();

            cmb_TipoMaquina.DisplayMember = "Descripcion";
            cmb_TipoMaquina.ValueMember = "Id";


            var marcas = _context.MaquinasMarcas.OrderBy(x => x.Nombre).ToList();
            marcas.Insert(0, new MaquinaMarca
            {
                Id = 0,
                Nombre = ""
            });
            cmb_MarcaMaquina.DataSource = marcas;
            cmb_MarcaMaquina.DisplayMember = "Nombre";
            cmb_MarcaMaquina.ValueMember = "Id";

            cmb_MantenimientoMaquina.DataSource = _context.MaquinasMantenimiento.OrderBy(x => x.Nombre).ToList();
            cmb_MantenimientoMaquina.DisplayMember = "Nombre";
            cmb_MantenimientoMaquina.ValueMember = "Id";

            // Modo edición
            if (_item != null)
            {
                cmb_TipoMaquina.SelectedValue = _item.MaquinaTipoId;
                if (_item.MaquinaMarcaId != null)
                {
                    cmb_MarcaMaquina.SelectedValue = _item.MaquinaMarcaId;
                }
                cmb_MantenimientoMaquina.SelectedValue = _item.MaquinaMantenimientoId;
                txt_Observaciones.Text = _item.Observaciones;
            }
            else
            {
                // Modo alta
                cmb_TipoMaquina.SelectedIndex = -1;
                cmb_MarcaMaquina.SelectedIndex = -1;
                cmb_MantenimientoMaquina.SelectedIndex = -1;
            }
        }
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            var tipo = cmb_TipoMaquina.SelectedItem as MaquinaTipo;
            var mantenimiento = cmb_MantenimientoMaquina.SelectedItem as MaquinaMantenimiento;
            var marca = cmb_MarcaMaquina.SelectedItem as MaquinaMarca;

            if (tipo == null)
            {
                MessageBox.Show(
                    "Debe seleccionar un tipo de máquina.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (mantenimiento == null)
            {
                MessageBox.Show(
                    "Debe seleccionar un mantenimiento.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Result = new ClienteMaquinaItem
            {
                Id = _item?.Id,

                MaquinaTipoId = tipo.Id,
                Descripcion = tipo.Descripcion,

                MaquinaMarcaId = marca?.Id,
                MarcaNombre = marca?.Nombre,

                MaquinaMantenimientoId = mantenimiento.Id,
                MantenimientoNombre = mantenimiento.Nombre,

                Observaciones = string.IsNullOrWhiteSpace(txt_Observaciones.Text)
                    ? null
                    : txt_Observaciones.Text.Trim()
            };

            DialogResult = DialogResult.OK;
            Close();
        }
        #endregion

        #region Private methods

        #endregion




    }
}
