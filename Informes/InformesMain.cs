using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static RotoGestionClientes.Enums;
using static System.Net.Mime.MediaTypeNames;

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
            CrearGrid();

            //CargarResultados();
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
            ExportarExcel();
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

            button.Font = new System.Drawing.Font(
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

                    Software = string.Join(
                        " - ",
                        c.ClienteSoftwares
                         .Select(cs => cs.Software.Nombre)),

                    Perfiles = string.Join(
                        " - ",
                        c.ClientePerfiles
                         .Select(cp =>
                            cp.Perfil.Nombre +
                            " (" +
                            cp.Perfil.PerfilTipo.NombreAbreviado +
                            ")"))
                })
                .OrderBy(c => c.Nombre)
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
        private void CrearGrid()
        {
            dgvResultados.AutoGenerateColumns = false;

            dgvResultados.Columns.Clear();

            dgvResultados.AllowUserToAddRows = false;
            dgvResultados.ReadOnly = true;
            dgvResultados.RowHeadersVisible = false;
            
            dgvResultados.DefaultCellStyle.WrapMode =
                DataGridViewTriState.True;

            dgvResultados.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;

            // =========================
            // HEADER
            // =========================

            //dgvResultados.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            //dgvResultados.ColumnHeadersDefaultCellStyle.ForeColor = Color.LightSteelBlue;
            dgvResultados.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold);

            dgvResultados.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            dgvResultados.ColumnHeadersHeight = 38;

            dgvResultados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = "Cliente",
                DataPropertyName = "Nombre",
                //AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                Width = 250
            });

            dgvResultados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Software",
                HeaderText = "Software",
                DataPropertyName = "Software",

                Width = 180
            });

            dgvResultados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Perfiles",
                HeaderText = "Perfiles",
                DataPropertyName = "Perfiles",

                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }
        private void ExportarExcel()
        {
            var data = _bindingResultados.DataSource as List<ClienteInformeItem>;

            if (data == null || data.Count == 0)
            {
                MessageBox.Show(
                    "No hay datos para exportar.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            using SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Excel (*.xlsx)|*.xlsx",
                FileName = $"Clientes_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            IWorkbook workbook = new XSSFWorkbook();

            ISheet sheet = workbook.CreateSheet("Clientes");

            // =========================
            // CABECERA
            // =========================

            ICellStyle headerStyle = workbook.CreateCellStyle();

            var headerFont = workbook.CreateFont();
            headerFont.IsBold = true;

            headerStyle.SetFont(headerFont);
            headerStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;

            IRow header = sheet.CreateRow(0);

            header.CreateCell(0).SetCellValue("Nombre");
            header.CreateCell(1).SetCellValue("Software");
            header.CreateCell(2).SetCellValue("Perfiles");

            for (int i = 0; i < 3; i++)
            {
                header.Cells[i].CellStyle = headerStyle;
            }

            // =========================
            // DATOS
            // =========================

            int rowIndex = 1;

            foreach (var item in data)
            {
                IRow row = sheet.CreateRow(rowIndex++);

                row.CreateCell(0).SetCellValue(item.Nombre ?? string.Empty);
                row.CreateCell(1).SetCellValue(item.Software ?? string.Empty);
                row.CreateCell(2).SetCellValue(item.Perfiles ?? string.Empty);
            }

            // =========================
            // TABLA EXCEL
            // =========================

            int totalRows = data.Count + 1;

            var area = new AreaReference(
                new CellReference(0, 0),
                new CellReference(totalRows - 1, 2),
                SpreadsheetVersion.EXCEL2007);

            var xssfSheet = (XSSFSheet)sheet;

            var table = xssfSheet.CreateTable();

            CT_Table ctTable = table.GetCTTable();

            ctTable.id = 1;
            ctTable.name = "TablaClientes";
            ctTable.displayName = "TablaClientes";

            // Rango tabla
            ctTable.@ref = area.FormatAsString();

            // Columnas
            ctTable.tableColumns = new CT_TableColumns();
            ctTable.tableColumns.count = 3;

            string[] columnas =
            {
                "Nombre",
                "Software",
                "Perfiles"
            };

            for (int i = 0; i < columnas.Length; i++)
            {
                var column = ctTable.tableColumns.AddNewTableColumn();

                column.id = (uint)(i + 1);
                column.name = columnas[i];
            }

            // Estilo
            var style = ctTable.AddNewTableStyleInfo();

            style.name = "TableStyleMedium2";
            style.showRowStripes = true;
            style.showColumnStripes = false;

            table.Name = "TablaClientes";
            table.DisplayName = "TablaClientes";

            table.GetCTTable().id = 1;
            table.GetCTTable().name = "TablaClientes";
            table.GetCTTable().displayName = "TablaClientes";

            var styleInfo = table.GetCTTable().AddNewTableStyleInfo();

            styleInfo.name = "TableStyleMedium2";
            styleInfo.showRowStripes = true;
            styleInfo.showColumnStripes = false;

            // =========================
            // ANCHOS COLUMNAS
            // =========================

            sheet.SetColumnWidth(0, 9000);
            sheet.SetColumnWidth(1, 12000);
            sheet.SetColumnWidth(2, 25000);

            // =========================
            // GUARDAR
            // =========================

            using FileStream fs = new FileStream(
                sfd.FileName,
                FileMode.Create,
                FileAccess.Write);

            workbook.Write(fs);

            MessageBox.Show(
                "Excel exportado correctamente.",
                "Exportación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        #endregion

    }
}
