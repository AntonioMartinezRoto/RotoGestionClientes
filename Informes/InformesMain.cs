using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class InformesMain : Form
    {
        #region Private properties

        private readonly ApplicationDbContext _context;
        private readonly Dictionary<InformeFiltroTipo, List<int>> _filtrosSeleccionados = new();
        private List<ClienteInformeItem> _resultadoActual = new();
        private readonly BindingSource _bindingResultados = new();
        #endregion

        #region Constructors
        public InformesMain(ApplicationDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        #endregion

        #region Events
        private void InformesMain_Load(object sender, EventArgs e)
        {
            panel_Sidebar.BackColor = Color.FromArgb(245, 247, 250);
        }
        private void txt_Filtro_TextChanged(object sender, EventArgs e)
        {
            var texto = txt_Filtro.Text.Trim().ToLower();

            IEnumerable<ClienteInformeItem> query = _resultadoActual;

            if (!string.IsNullOrWhiteSpace(texto))
            {
                query = query.Where(x =>
                    (x.Nombre ?? "").ToLower().Contains(texto)
                    || (x.Software ?? "").ToLower().Contains(texto));
            }

            var resultado = query.ToList();

            _bindingResultados.DataSource = resultado;
            dgvResultados.DataSource = _bindingResultados;

            lbl_Total.Text = $"Total registros: {resultado.Count}";
        }

        private void btn_ExportExcel_Click(object sender, EventArgs e)
        {

        }
        private void btn_Software_Click(object sender, EventArgs e)
        {
            AbrirFiltro(InformeFiltroTipo.Software);
        }
        private void btn_Manillas_Click(object sender, EventArgs e)
        {
            AbrirFiltro(InformeFiltroTipo.Manilla);
        }
        private void btn_Bisagras_Click(object sender, EventArgs e)
        {
            AbrirFiltro(InformeFiltroTipo.Bisagra);
        }
        private void btn_MaquinasTipo_Click(object sender, EventArgs e)
        {
            AbrirFiltro(InformeFiltroTipo.Maquina);
        }
        private void btn_Cerraduras_Click(object sender, EventArgs e)
        {
            AbrirFiltro(InformeFiltroTipo.Cerradura);
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            CargarResultados();
        }
        private void btn_LimpiarFiltros_Click(object sender, EventArgs e)
        {
            _filtrosSeleccionados.Clear();

            ActualizarTodosBotones();

            dgvResultados.DataSource = null;

            lbl_Total.Text = "Total registros: 0";
        }
        #endregion

        #region Private methods
        private void AbrirFiltro(InformeFiltroTipo tipo)
        {
            var items = ObtenerItemsFiltro(tipo);

            if (_filtrosSeleccionados.TryGetValue(tipo, out var ids))
            {
                foreach (var item in items)
                {
                    item.Selected = ids.Contains(item.Id);
                }
            }

            using var form = new FiltroForm(items);

            if (form.ShowDialog() != DialogResult.OK)
                return;

            _filtrosSeleccionados[tipo] = form.SelectedIds;

            ActualizarEstadoBoton(tipo);
        }
        private List<FiltroItem> ObtenerItemsFiltro(InformeFiltroTipo tipo)
        {
            switch (tipo)
            {
                case InformeFiltroTipo.Software:
                    return _context.Softwares
                        //.Where(x => x.Activa)
                        .OrderBy(x => x.Nombre)
                        .Select(x => new FiltroItem
                        {
                            Id = x.Id,
                            Nombre = x.Nombre
                        })
                        .ToList();

                case InformeFiltroTipo.Manilla:
                    return _context.Manillas
                        //.Where(x => x.Activa)
                        .OrderBy(x => x.Nombre)
                        .Select(x => new FiltroItem
                        {
                            Id = x.Id,
                            Nombre = x.Nombre
                        })
                        .ToList();

                case InformeFiltroTipo.Bisagra:
                    return _context.Bisagras
                        //.Where(x => x.Activa)
                        .OrderBy(x => x.Nombre)
                        .Select(x => new FiltroItem
                        {
                            Id = x.Id,
                            Nombre = x.Nombre
                        })
                        .ToList();
                case InformeFiltroTipo.Maquina:
                    return _context.MaquinasTipos
                        //.Where(x => x.Activa)
                        .OrderBy(x => x.Descripcion)
                        .Select(x => new FiltroItem
                        {
                            Id = x.Id,
                            Nombre = x.Descripcion
                        })
                        .ToList();
                case InformeFiltroTipo.Cerradura:
                    return _context.CerradurasPuerta
                        //.Where(x => x.Activa)
                        .OrderBy(x => x.Nombre)
                        .Select(x => new FiltroItem
                        {
                            Id = x.Id,
                            Nombre = x.Nombre
                        })
                        .ToList();
            }

            return new List<FiltroItem>();
        }
        private void ActualizarEstadoBoton(InformeFiltroTipo tipo)
        {
            var button = ObtenerBotonFiltro(tipo);

            bool tieneSeleccion =
                _filtrosSeleccionados.ContainsKey(tipo) &&
                _filtrosSeleccionados[tipo].Any();

            button.BackColor = tieneSeleccion
                ? Color.LightSteelBlue
                : Color.White;

            button.Font = new Font(
                button.Font,
                tieneSeleccion ? FontStyle.Bold : FontStyle.Regular);
        }
        private Button ObtenerBotonFiltro(InformeFiltroTipo tipo)
        {
            return tipo switch
            {
                InformeFiltroTipo.Software => btn_Software,
                InformeFiltroTipo.Manilla => btn_Manillas,
                InformeFiltroTipo.Bisagra => btn_Bisagras,
                InformeFiltroTipo.Maquina => btn_MaquinasTipo,
                InformeFiltroTipo.Cerradura => btn_Cerraduras,
                _ => throw new NotImplementedException()
            };
        }
        private void CargarResultados()
        {
            IQueryable<Cliente> query = _context.Clientes;

            if (_filtrosSeleccionados.TryGetValue(
                InformeFiltroTipo.Software,
                out var softwares)
                && softwares.Any())
            {
                query = query.Where(c =>
                    c.ClienteSoftwares.Any(cs =>
                        softwares.Contains(cs.SoftwareId)));
            }

            if (_filtrosSeleccionados.TryGetValue(
                InformeFiltroTipo.Manilla,
                out var manillas)
                && manillas.Any())
            {
                query = query.Where(c =>
                    c.ClienteManillas.Any(cm =>
                        manillas.Contains(cm.ManillaId)));
            }

            if (_filtrosSeleccionados.TryGetValue(
                InformeFiltroTipo.Bisagra,
                out var bisagras)
                && bisagras.Any())
            {
                query = query.Where(c =>
                    c.ClienteBisagraPuertas.Any(cm =>
                        bisagras.Contains(cm.BisagraPuertaId)));
            }

            if (_filtrosSeleccionados.TryGetValue(
                InformeFiltroTipo.Maquina,
                out var maquinas)
                && maquinas.Any())
            {
                query = query.Where(c =>
                    c.ClienteMaquinas.Any(cm =>
                        maquinas.Contains(cm.MaquinaTipoId)));
            }

            if (_filtrosSeleccionados.TryGetValue(
                InformeFiltroTipo.Cerradura,
                out var cerraduras)
                && cerraduras.Any())
            {
                query = query.Where(c =>
                    c.ClienteCerradurasPuerta.Any(cc =>
                        cerraduras.Contains(cc.CerraduraPuertaId)));
            }

            _resultadoActual = query
                .Select(c => new ClienteInformeItem
                {
                    Id = c.Id,
                    Nombre = c.Nombre,

                    Software = c.ClienteSoftwares
                                .Select(cs => cs.Software.Nombre)
                                .FirstOrDefault() ?? string.Empty
                })
                .ToList();

            _bindingResultados.DataSource = _resultadoActual;
            dgvResultados.DataSource = _bindingResultados;

            lbl_Total.Text = $"Total registros: {_resultadoActual.Count}";
        }
        private void ActualizarTodosBotones()
        {
            foreach (InformeFiltroTipo tipo in Enum.GetValues(typeof(InformeFiltroTipo)))
            {
                ActualizarEstadoBoton(tipo);
            }
        }

        #endregion

    }
}
