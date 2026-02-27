using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RotoGestionClientes
{
    public partial class ClientesEditForm : Form
    {
        #region Private properties

        private int _clienteId;
        private List<SeguridadVentana> _seguridadVentanaList = new();
        private List<CremonaPasivaVentanaTipos> _cremonaPasivaTiposList = new();
        private ApplicationDbContext _context;
        private BindingSource _bindingSourceSeguridad = new BindingSource();
        private BindingSource _bindingSourcePasivas = new BindingSource();

        #endregion

        #region Constructors
        public ClientesEditForm()
        {
            InitializeComponent();
        }
        public ClientesEditForm(ClienteGridItem cliente, ApplicationDbContext context)
        {
            InitializeComponent();
            this.Text = cliente.Nombre;
            this._clienteId = cliente.Id;
            this._context = context;
        }
        #endregion

        #region Events
        private void ClientesEditForm_Load(object sender, EventArgs e)
        {
            CrearGridSeguridadVentana();
            CrearGridCremonaPasivaTipos();
            RellenarGridSeguridadVentana();
            RellenarGridCremonaPasivaTipos();
        }
        private void dgvSeguridad_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            if (dgvSeguridad.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                dgvSeguridad.EndEdit();
                var item = (SeguridadVentanaGridItem)dgvSeguridad.Rows[e.RowIndex].DataBoundItem;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveSeguridad(dgvSeguridad);
            SaveCremonaPasivas(dgvPasivas);
        }


        #endregion

        #region Private methods
        private void CrearGridSeguridadVentana()
        {
            dgvSeguridad.AutoGenerateColumns = false;
            dgvSeguridad.AllowUserToAddRows = false;
            dgvSeguridad.RowHeadersVisible = false;

            dgvSeguridad.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Selected",
                HeaderText = "",
                Width = 30
            });

            dgvSeguridad.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Tipo",
                ReadOnly = true,
                Width = 100,
                Name = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvSeguridad.ReadOnly = false;
            dgvSeguridad.Enabled = true;
        }
        private void CrearGridCremonaPasivaTipos()
        {
            dgvPasivas.AutoGenerateColumns = false;
            dgvPasivas.AllowUserToAddRows = false;
            dgvPasivas.RowHeadersVisible = false;

            dgvPasivas.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Selected",
                HeaderText = "",
                Width = 30
            });

            dgvPasivas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Tipo",
                ReadOnly = true,
                Width = 100,
                Name = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPasivas.ReadOnly = false;
            dgvPasivas.Enabled = true;
        }
        private void RellenarGridSeguridadVentana()
        {
            var seguridadAsignadas = _context.ClienteSeguridadVentanas
                                    .Where(x => x.ClienteId == _clienteId)
                                    .Select(x => x.SeguridadVentanaId)
                                    .ToHashSet();

            var lista = _context.SeguridadVentanas
                        .Select(f => new SeguridadVentanaGridItem
                        {
                            Id = f.Id,
                            Nombre = f.Nombre,
                            Selected = seguridadAsignadas.Contains(f.Id)
                        })
                        .OrderBy(f => f.Nombre)
                        .ToList();

            _bindingSourceSeguridad.DataSource = lista;
            dgvSeguridad.DataSource = _bindingSourceSeguridad;
        }
        private void RellenarGridCremonaPasivaTipos()
        {
            _cremonaPasivaTiposList = _context.CremonaPasivaVentanaTipos
                            .Select(f => new CremonaPasivaVentanaTipos
                            {
                                Id = f.Id,
                                Nombre = f.Nombre
                            })
                            .OrderBy(f => f.Id)
                            .ToList();

            _bindingSourcePasivas.DataSource = _cremonaPasivaTiposList;
            dgvPasivas.DataSource = _bindingSourcePasivas;
        }
        private void SaveCremonaPasivas(DataGridView dgvPasivas)
        {
        }
        private void SaveSeguridad(DataGridView dgvSeguridad)
        {
            foreach (DataGridViewRow row in dgvSeguridad.Rows)
            {
                var item = (SeguridadVentanaGridItem)row.DataBoundItem;
                var isChecked = Convert.ToBoolean(row.Cells[0].Value);
                if (isChecked)
                {
                    AgregarRelacionSeguridadVentana(item.Id);
                }
                else
                {
                    EliminarRelacionSeguridadVentana(item.Id);
                }
            }

            _context.SaveChanges();
        }

        private void EliminarRelacionSeguridadVentana(int seguridadVentanaId)
        {
            var relacion = _context.ClienteSeguridadVentanas
                            .FirstOrDefault(x =>
                                x.ClienteId == _clienteId &&
                                x.SeguridadVentanaId == seguridadVentanaId);

            if (relacion == null)
                return;

            _context.ClienteSeguridadVentanas.Remove(relacion);
        }

        private void AgregarRelacionSeguridadVentana(int seguridadVentanaId)
        {
            bool yaExiste = _context.ClienteSeguridadVentanas
                            .Any(x => x.ClienteId == _clienteId &&
                            x.SeguridadVentanaId == seguridadVentanaId);

            if (yaExiste)
                return;

            var relacion = new ClienteSeguridadVentana
            {
                ClienteId = _clienteId,
                SeguridadVentanaId = seguridadVentanaId
            };

            _context.ClienteSeguridadVentanas.Add(relacion);
            
        }
        #endregion


    }
    public class SeguridadVentanaGridItem
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public bool Selected { get; set; }
    }

}
