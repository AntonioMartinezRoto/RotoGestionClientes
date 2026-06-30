using Microsoft.Extensions.DependencyInjection;
using System.Data;
using static RotoGestionClientes.Enums;

namespace RotoGestionClientes
{
    public partial class PasoDatosGenerales : UserControl
    {
        #region Private properties

        private readonly ClientWizardModel _model;
        private ApplicationDbContext _context;
        private BindingSource _bindingSourcePerfilTipo = new BindingSource();
        private BindingSource _bindingSourceManillas = new BindingSource();
        #endregion

        #region Constructors
        public PasoDatosGenerales(ClientWizardModel model, ApplicationDbContext context)
        {
            InitializeComponent();
            _model = model;
            _context = context;
        }

        #endregion

        #region Events
        private void txt_NombreCliente_TextChanged(object sender, EventArgs e)
        {
            _model.Nombre = txt_NombreCliente.Text;
        }
        private void txt_Comentarios_TextChanged(object sender, EventArgs e)
        {
            _model.Comentarios = txt_Comentarios.Text;
        }
        private void txt_Alias_TextChanged(object sender, EventArgs e)
        {
            _model.Alias = txt_Alias.Text;
        }
        private void txt_SapId_TextChanged(object sender, EventArgs e)
        {
            _model.SapId = txt_SapId.Text;
        }
        private void PasoDatosGenerales_Load(object sender, EventArgs e)
        {
            CargarTextos();
            CrearGridPerfilTipo();
            CrearGridManillas();
            CrearGridSoporteCompas();
            CrearGridPerfil();
            RellenarGridPerFilTipo();
            RellenarSoftwareList();
            RellenarResponsablesList();
            RellenarGridManillas();
            CargarSoporteComprasFiltrado();
            CargarPerfilesFiltrados();
            InitializeData();
            SetVisibilidadModoAplicacion();
        }

        private void dgvPerfilTipo_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            if (dgvPerfilTipo.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                dgvPerfilTipo.EndEdit();
                var item = (GridItem)dgvPerfilTipo.Rows[e.RowIndex].DataBoundItem;

                if (item.Selected)
                {
                    _model.PerfilTipoList.Add(item.Id);
                }
                else
                {
                    _model.PerfilTipoList.Remove(item.Id);
                    DesmarcarPerfilesDeTipo(item.Id);
                    DesmarcarSoporteCompasTipo(item.Id);
                }

                CargarPerfilesFiltrados();
                CargarSoporteComprasFiltrado();
            }
        }
        private void cmb_Software_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_Software.SelectedIndex != -1 && cmb_Software.SelectedValue != null)
            {
                // Si ValueMember es "Id", SelectedValue será el entero
                if (int.TryParse(cmb_Software.SelectedValue.ToString(), out int id))
                {
                    this._model.SoftwareList.Clear();
                    this._model.SoftwareList.Add(id);
                }
            }
        }
        private void cmb_Responsable_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_Responsable.SelectedIndex != -1 && cmb_Responsable.SelectedValue != null)
            {
                // Si ValueMember es "Id", SelectedValue será el entero
                if (int.TryParse(cmb_Responsable.SelectedValue.ToString(), out int id))
                {
                    this._model.ResponsableId = id;
                }
            }
        }
        private void dgvManillas_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            if (dgvManillas.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                dgvManillas.EndEdit();
                var item = (GridItem)dgvManillas.Rows[e.RowIndex].DataBoundItem;

                if (item.Selected)
                {
                    _model.ManillasList.Add(item.Id);
                }
                else
                {
                    _model.ManillasList.Remove(item.Id);
                }
            }
        }
        private void dgvSoporteCompas_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            if (dgvSoporteCompas.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                dgvSoporteCompas.EndEdit();
                var item = (GridItem)dgvSoporteCompas.Rows[e.RowIndex].DataBoundItem;

                if (item.Selected)
                {
                    _model.SoporteCompasList.Add(item.Id);
                }
                else
                {
                    _model.SoporteCompasList.Remove(item.Id);
                }
            }
        }
        private void dgvPerfil_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            if (dgvPerfil.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                dgvPerfil.EndEdit();
                var item = (GridItem)dgvPerfil.Rows[e.RowIndex].DataBoundItem;

                if (item.Selected)
                {
                    _model.PerfilesList.Add(item.Id);
                }
                else
                {
                    _model.PerfilesList.Remove(item.Id);
                }
            }
        }
        #endregion

        #region Private methods

        private void CargarTextos()
        {
            lbl_NombreCliente.Text = Lang.Nombre;
            lbl_Alias.Text = Lang.Alias;
            lbl_SapId.Text = Lang.SapId;
            lbl_Responsable.Text = Lang.Responsable;
            group_Software.Text = Lang.Software;
            group_SoporteCompas.Text = Lang.SoporteCompas;
            group_Manillas.Text = Lang.Manillas;
            group_PerfilTipo.Text = Lang.TipoPerfil;
            group_Perfil.Text = Lang.Perfil;
            group_Comentarios.Text = Lang.Comentarios;
        }

        private void SetVisibilidadModoAplicacion()
        {
            var config = _context.ConfiguracionAplicacion.FirstOrDefault();

            // Si no hay configuración se dejarán por defecto
            if (config == null) return;

            // Intentamos parsear el string de la BBDD al Enum para trabajar de forma segura
            if (Enum.TryParse(config.AppEdition, out ApplicationEdition edition))
            {
                // El bloque es visible SIEMPRE QUE NO SEA Distributor (es decir, Internal o Debug)
                bool esVisible = edition != ApplicationEdition.Distributor;

                lbl_Responsable.Visible = esVisible;
                cmb_Responsable.Visible = esVisible;
            }
        }
        private void CrearGridPerfilTipo()
        {
            dgvPerfilTipo.AutoGenerateColumns = false;
            dgvPerfilTipo.AllowUserToAddRows = false;
            dgvPerfilTipo.RowHeadersVisible = false;
            dgvPerfilTipo.ColumnHeadersVisible = false;

            dgvPerfilTipo.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Selected",
                HeaderText = "",
                Width = 30
            });

            dgvPerfilTipo.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Tipo",
                ReadOnly = true,
                Width = 100,
                Name = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPerfilTipo.ReadOnly = false;
            dgvPerfilTipo.Enabled = true;
        }
        private void CrearGridPerfil()
        {
            dgvPerfil.AutoGenerateColumns = false;
            dgvPerfil.AllowUserToAddRows = false;
            dgvPerfil.RowHeadersVisible = false;
            dgvPerfil.ColumnHeadersVisible = false;

            dgvPerfil.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Selected",
                HeaderText = "",
                Width = 30
            });

            dgvPerfil.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                ReadOnly = true,
                Width = 100,
                Name = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPerfil.ReadOnly = false;
            dgvPerfil.Enabled = true;
        }
        private void CrearGridManillas()
        {
            dgvManillas.AutoGenerateColumns = false;
            dgvManillas.AllowUserToAddRows = false;
            dgvManillas.RowHeadersVisible = false;
            dgvManillas.ColumnHeadersVisible = false;

            dgvManillas.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Selected",
                HeaderText = "",
                Width = 30
            });

            dgvManillas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                ReadOnly = true,
                Width = 100,
                Name = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvManillas.ReadOnly = false;
            dgvManillas.Enabled = true;
        }
        private void CrearGridSoporteCompas()
        {
            dgvSoporteCompas.AutoGenerateColumns = false;
            dgvSoporteCompas.AllowUserToAddRows = false;
            dgvSoporteCompas.RowHeadersVisible = false;
            dgvSoporteCompas.ColumnHeadersVisible = false;

            dgvSoporteCompas.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Selected",
                HeaderText = "",
                Width = 30
            });

            dgvSoporteCompas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Tipo",
                ReadOnly = true,
                Width = 100,
                Name = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvSoporteCompas.ReadOnly = false;
            dgvSoporteCompas.Enabled = true;
        }
        private void RellenarGridPerFilTipo()
        {
            var lista = _context.PerfilTipos
                        .Where(f => f.Activa)
                        .Select(f => new GridItem
                        {
                            Id = f.Id,
                            Nombre = f.Nombre,
                            NombreAbreviado = f.NombreAbreviado,
                            Selected = _model.PerfilTipoList.Contains(f.Id)
                        })
                        .OrderBy(f => f.Id)
                        .ToList();

            _bindingSourcePerfilTipo.DataSource = lista;
            dgvPerfilTipo.DataSource = _bindingSourcePerfilTipo;
        }
        private void CargarPerfilesFiltrados()
        {
            var tiposSeleccionados = ((List<GridItem>)_bindingSourcePerfilTipo.DataSource)
                .Where(x => x.Selected)
                .Select(x => x.Id)
                .ToList();

            if (!tiposSeleccionados.Any())
            {
                dgvPerfil.DataSource = null;
                return;
            }

            var perfiles = _context.Perfiles
                .Where(p => tiposSeleccionados.Contains(p.PerfilTipoId))
                .Select(p => new GridItem
                {
                    Id = p.Id,
                    Nombre = p.Nombre + " (" + p.PerfilTipo.NombreAbreviado + ")",
                    Selected = _model.PerfilesList.Contains(p.Id)
                })
                .OrderBy(p => p.Nombre)
                .ToList();

            dgvPerfil.DataSource = perfiles;
        }
        private void DesmarcarPerfilesDeTipo(int perfilTipoId)
        {
            // Obtener IDs de perfiles que pertenecen a ese tipo
            var perfilesDelTipo = _context.Perfiles
                .Where(p => p.PerfilTipoId == perfilTipoId)
                .Select(p => p.Id)
                .ToList();

            // Eliminar del modelo
            _model.PerfilesList.RemoveAll(id => perfilesDelTipo.Contains(id));
        }
        private void DesmarcarSoporteCompasTipo(int perfilTipoId)
        {
            // Obtener IDs de soporte compas que pertenecen a ese tipo
            var soporteCompasDelTipo = _context.SoporteCompases
                .Where(p => p.PerfilTipoId == perfilTipoId)
                .Select(p => p.Id)
                .ToList();

            // Eliminar del modelo
            _model.SoporteCompasList.RemoveAll(id => soporteCompasDelTipo.Contains(id));
        }
        private void RellenarGridManillas()
        {
            var lista = _context.Manillas
                        .Where(f => f.Activa)
                        .Select(f => new GridItem
                        {
                            Id = f.Id,
                            Nombre = f.Nombre,
                            Selected = _model.ManillasList.Contains(f.Id)
                        })
                        .OrderBy(f => f.Id)
                        .ToList();

            _bindingSourceManillas.DataSource = lista;
            dgvManillas.DataSource = _bindingSourceManillas;
        }
        private void CargarSoporteComprasFiltrado()
        {
            var tiposSeleccionados = ((List<GridItem>)_bindingSourcePerfilTipo.DataSource)
                .Where(x => x.Selected)
                .Select(x => x.Id)
                .ToList();

            if (!tiposSeleccionados.Any())
            {
                dgvSoporteCompas.DataSource = null;
                return;
            }

            var soporteCompases = _context.SoporteCompases
                .Where(p => tiposSeleccionados.Contains(p.PerfilTipoId))
                .Select(p => new GridItem
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    Selected = _model.SoporteCompasList.Contains(p.Id)
                })
                .OrderBy(p => p.Nombre)
                .ToList();

            dgvSoporteCompas.DataSource = soporteCompases;
        }
        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(_model.Nombre);
        }
        private void RellenarSoftwareList()
        {
            cmb_Software.SelectedValueChanged -= cmb_Software_SelectedValueChanged;

            List<Software> softwareList = new List<Software>();
            softwareList = _context.Softwares.Where(f => f.Activa).OrderBy(s => s.Id).ToList();

            cmb_Software.DataSource = null;
            cmb_Software.DataSource = softwareList;
            cmb_Software.DisplayMember = "Nombre";
            cmb_Software.ValueMember = "Id";

            cmb_Software.SelectedIndex = -1;

            cmb_Software.SelectedValueChanged += cmb_Software_SelectedValueChanged;
        }
        private void RellenarResponsablesList()
        {
            cmb_Responsable.SelectedValueChanged -= cmb_Responsable_SelectedValueChanged;

            List<Usuario> softwareList = new List<Usuario>();
            softwareList = _context.Usuarios.Where(f => f.Activa).OrderBy(s => s.Nombre).ToList();

            cmb_Responsable.DataSource = null;
            cmb_Responsable.DataSource = softwareList;
            cmb_Responsable.DisplayMember = "Nombre";
            cmb_Responsable.ValueMember = "Id";

            cmb_Responsable.SelectedIndex = -1;

            cmb_Responsable.SelectedValueChanged += cmb_Responsable_SelectedValueChanged;
        }
        private void InitializeData()
        {
            txt_NombreCliente.Text = _model.Nombre;
            txt_SapId.Text = _model.SapId;
            txt_Alias.Text = _model.Alias;
            txt_Comentarios.Text = _model.Comentarios;
            cmb_Software.SelectedValue = _model.SoftwareList.FirstOrDefault();

            var config = _context.ConfiguracionAplicacion.FirstOrDefault();

            // Si no hay configuración se dejarán por defecto
            if (config == null) return;

            // Intentamos parsear el string de la BBDD al Enum para trabajar de forma segura
            if (Enum.TryParse(config.AppEdition, out ApplicationEdition edition))
            {
                if (edition == ApplicationEdition.Distributor)
                {
                    _model.ResponsableId = config.DistribuidorId;
                }
            }

            if (_model.ResponsableId != null && _model.ResponsableId != 0)
            {
                cmb_Responsable.SelectedValue = _model.ResponsableId;
            }
        }

        #endregion
    }
    public class GridItem
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string NombreAbreviado { get; set; } = string.Empty;
        public bool Selected { get; set; }
    }
    public class PerfilComboItem
    {
        public int Id { get; set; }

        public string Texto { get; set; } = null!;
    }

}
