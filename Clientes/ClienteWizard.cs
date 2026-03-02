using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static RotoGestionClientes.Enums;

namespace RotoGestionClientes
{
    public partial class ClienteWizard : Form
    {
        #region Private properties

        private readonly ApplicationDbContext _context;
        private int _currentStep = 0;
        private readonly ClientWizardModel _model = new();
        private List<UserControl> _steps;
        private List<WizardStepItem> _sidebarItems;
        private readonly WizardMode _mode;
        private int _clienteId;

        #endregion

        #region Constructors
        public ClienteWizard(ApplicationDbContext _context)
        {
            this._context = _context;
            InitializeComponent();
            InitializeWizard();
        }
        public ClienteWizard(WizardMode mode, ApplicationDbContext _context, int? clienteId = null)
        {
            InitializeComponent();

            this._context = _context;
            _mode = mode;

            if (mode == WizardMode.Edit && clienteId != null)
            {
                _model = MapClienteToModel(clienteId);
                _clienteId = clienteId.Value;
                btn_Siguiente.Visible = false;
                btn_Atras.Visible = false;
            }
            else
            {
                _model = new ClientWizardModel();
            }

            InitializeTitulo();
            InitializeWizard();
        }

        #endregion

        #region Events
        private void ClienteWizard_Load(object sender, EventArgs e)
        {
            panel_Sidebar.BackColor = Color.FromArgb(245, 247, 250);
        }
        private void btn_Siguiente_Click(object sender, EventArgs e)
        {
            _currentStep++;
            ShowStep();
        }
        private void btn_Atras_Click(object sender, EventArgs e)
        {
            _currentStep--;
            ShowStep();
        }
        private void btn_Finalizar_Click(object sender, EventArgs e)
        {
            //var pasoActual = _steps[_currentStep];

            //if (!pasoActual.IsValid())
            //{
            //    MessageBox.Show("Complete los datos obligatorios");
            //    return;

            //}
            SaveCliente();
            DialogResult = DialogResult.OK;
            Close();
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Private methods
        private void InitializeWizard()
        {
            _steps = new List<UserControl>
                {
                    new PasoDatosGenerales(_model, _context),
                    new PasoVentanas(_model, _context),
                    new PasoBalconeras(_model, _context),
                    new PasoPuertas(_model, _context),
                    new PasoParalelas(_model, _context),
                    new PasoCorrederas(_model, _context),
                    new PasoElevables(_model, _context),
                    new PasoEspeciales(_model, _context),
                    new PasoMaquinas(_model, _context)
                };

            CreateSidebar();
            ShowStep();
        }
        private void CreateSidebar()
        {
            flowLayoutPanel_Sidebar.Controls.Clear();
            _sidebarItems = new List<WizardStepItem>();

            string[] titles =
                            {
                                "Datos Generales",
                                "Ventanas OB-PRAC",
                                "Balconeras",
                                "Puertas",
                                "Paralelas",
                                "Inline",
                                "Elevables",
                                "Especiales",
                                "Máquinas",
                            };

            for (int i = 0; i < titles.Length; i++)
            {
                var item = new WizardStepItem((i + 1).ToString(), titles[i], _mode);

                flowLayoutPanel_Sidebar.Controls.Add(item);

                _sidebarItems.Add(item);

                item.StepClicked += (s, e) =>
                {
                    if (_mode == WizardMode.Edit)
                    {
                        _currentStep = _sidebarItems.IndexOf(item);
                        ShowStep();
                    }
                };
            }
        }
        private void ShowStep()
        {
            panel_Content.Controls.Clear();

            var step = _steps[_currentStep];
            step.Dock = DockStyle.Fill;
            panel_Content.Controls.Add(step);

            if (_mode == WizardMode.Create)
            {
                UpdateSidebar();
                UpdateButtons();
            }
            if (_mode == WizardMode.Edit)
            {
                for (int i = 0; i < _sidebarItems.Count; i++)
                {
                    if (i == _currentStep)
                        _sidebarItems[i].SetActive();
                    else
                        _sidebarItems[i].SetPending();
                }
            }
        }
        private void UpdateSidebar()
        {
            for (int i = 0; i < _sidebarItems.Count; i++)
            {
                if (i < _currentStep)
                    _sidebarItems[i].SetCompleted();
                else if (i == _currentStep)
                    _sidebarItems[i].SetActive();
                else
                    _sidebarItems[i].SetPending();
            }
        }
        private void UpdateButtons()
        {
            btn_Atras.Enabled = _currentStep > 0;
            btn_Siguiente.Visible = _currentStep < _steps.Count - 1;
            btn_Finalizar.Visible = _currentStep == _steps.Count - 1;
        }
        private void SaveCliente()
        {
            if (_mode == WizardMode.Create)
            {
                CrearCliente();
            }
            else
            {
                UpdateCliente();
            }
        }
        private void UpdateCliente()
        {
            Cliente cliente = _context.Clientes
                .Include(c => c.ClientePerfilTipos)
                .Include(c => c.ClienteSoftwares)
                .Include(c => c.ClienteManillas)
                .Include(c => c.ClienteSoporteCompases)
                .First(c => c.Id == _clienteId);

            //Guardar el nombre
            cliente.Nombre = _model.Nombre;
            cliente.Alias = _model.Alias;
            cliente.Comentarios = _model.Comentarios;

            //Guardar tipo de perfil
            UpdateClientePerfil(cliente);

            //Guardar software
            UpdateSoftware(cliente);

            //Guardar manillas
            UpdateManillas(cliente);

            //Guardar soporte compas
            UpdateSoporteCompas(cliente);

            _context.SaveChanges();
        }
        private void UpdateSoporteCompas(Cliente cliente)
        {
            var soporteCompasesActuales = cliente.ClienteSoporteCompases
                .Select(cp => cp.SoporteCompasId)
                .ToList();

            var soporteCompasSeleccionadas = _model.SoporteCompasList;

            //1. Eliminar los que ya no están seleccionados
            var soporteCompasAEliminar = cliente.ClienteSoporteCompases
                .Where(cp => !soporteCompasSeleccionadas.Contains(cp.SoporteCompasId))
                .ToList();

            foreach (var soporteCompas in soporteCompasAEliminar)
            {
                _context.Remove(soporteCompas);
            }

            //2. Agregar los nuevos
            var soporteCompasAAgregar = soporteCompasSeleccionadas
                .Where(id => !soporteCompasesActuales.Contains(id))
                .ToList();

            foreach (var soporteCompasId in soporteCompasAAgregar)
            {
                cliente.ClienteSoporteCompases.Add(new ClienteSoporteCompas
                {
                    ClienteId = cliente.Id,
                    SoporteCompasId = soporteCompasId
                });
            }
        }
        private void UpdateManillas(Cliente cliente)
        {
            var manillasActuales = cliente.ClienteManillas
                .Select(cp => cp.ManillaId)
                .ToList();

            var manillasSeleccionadas = _model.ManillasList;

            //1. Eliminar los que ya no están seleccionados
            var manillasAEliminar = cliente.ClienteManillas
                .Where(cp => !manillasSeleccionadas.Contains(cp.ManillaId))
                .ToList();

            foreach (var manilla in manillasAEliminar)
            {
                _context.Remove(manilla);
            }

            //2. Agregar los nuevos
            var manillasAAgregar = manillasSeleccionadas
                .Where(id => !manillasActuales.Contains(id))
                .ToList();

            foreach (var manillaId in manillasAAgregar)
            {
                cliente.ClienteManillas.Add(new ClienteManilla
                {
                    ClienteId = cliente.Id,
                    ManillaId = manillaId
                });
            }
        }
        private void UpdateSoftware(Cliente cliente)
        {
            var softwareActuales = cliente.ClienteSoftwares
                .Select(cp => cp.SoftwareId)
                .ToList();

            var softwareSeleccionados = _model.SoftwareList;

            //1. Eliminar los que ya no están seleccionados
            var softwareAEliminar = cliente.ClienteSoftwares
                .Where(cp => !softwareSeleccionados.Contains(cp.SoftwareId))
                .ToList();

            foreach (var software in softwareAEliminar)
            {
                _context.Remove(software);
            }

            //2. Agregar los nuevos
            var softwareAAgregar = softwareSeleccionados
                .Where(id => !softwareActuales.Contains(id))
                .ToList();

            foreach (var softwareId in softwareAAgregar)
            {
                cliente.ClienteSoftwares.Add(new ClienteSoftware
                {
                    ClienteId = cliente.Id,
                    SoftwareId = softwareId
                });
            }
        }
        private void UpdateClientePerfil(Cliente cliente)
        {
            var perfilesActuales = cliente.ClientePerfilTipos
                            .Select(cp => cp.PerfilTipoId)
                            .ToList();

            var perfilesSeleccionados = _model.PerfilTipoList;

            //1. Eliminar los que ya no están seleccionados
            var perfilesAEliminar = cliente.ClientePerfilTipos
                .Where(cp => !perfilesSeleccionados.Contains(cp.PerfilTipoId))
                .ToList();

            foreach (var perfil in perfilesAEliminar)
            {
                _context.Remove(perfil);
            }

            //2. Agregar los nuevos
            var perfilesAAgregar = perfilesSeleccionados
                .Where(id => !perfilesActuales.Contains(id))
                .ToList();

            foreach (var perfilId in perfilesAAgregar)
            {
                cliente.ClientePerfilTipos.Add(new ClientePerfilTipo
                {
                    ClienteId = cliente.Id,
                    PerfilTipoId = perfilId
                });
            }
        }
        private void CrearCliente()
        {
            var cliente = new Cliente
            {
                Nombre = _model.Nombre,
                Alias = _model.Alias,
                Comentarios = _model.Comentarios
            };

            _context.Clientes.Add(cliente);
            _context.SaveChanges();

            foreach (var perfilTipoId in _model.PerfilTipoList)
            {
                _context.ClientePerfilTipos.Add(new ClientePerfilTipo
                {
                    ClienteId = cliente.Id,
                    PerfilTipoId = perfilTipoId
                });

            }

            _context.SaveChanges();


            if (_model.SoftwareList.Any())
            {
                _context.ClienteSoftwares.Add(new ClienteSoftware
                {
                    ClienteId = cliente.Id,
                    SoftwareId = _model.SoftwareList.FirstOrDefault()
                });

            }

            _context.SaveChanges();

            foreach (var manillaId in _model.ManillasList)
            {
                _context.ClienteManillas.Add(new ClienteManilla
                {
                    ClienteId = cliente.Id,
                    ManillaId = manillaId
                });

            }
            _context.SaveChanges();

            foreach (var soporteCompasId in _model.SoporteCompasList)
            {
                _context.ClienteSoporteCompases.Add(new ClienteSoporteCompas
                {
                    ClienteId = cliente.Id,
                    SoporteCompasId = soporteCompasId
                });

            }
            _context.SaveChanges();
        }

        private ClientWizardModel MapClienteToModel(int? clienteId)
        {
            ClientWizardModel model = new();
            Cliente cliente = _context.Clientes.Where(c => c.Id == clienteId).FirstOrDefault();
            model.Nombre = cliente.Nombre;
            model.Alias = cliente.Alias;
            model.Comentarios= cliente.Comentarios;
            model.SoftwareList = _context.ClienteSoftwares.Where(cs => cs.ClienteId == clienteId).Select(cs => cs.SoftwareId).ToList();
            model.PerfilTipoList = _context.ClientePerfilTipos.Where(cp => cp.ClienteId == clienteId).Select(cp => cp.PerfilTipoId).ToList();
            model.ManillasList = _context.ClienteManillas.Where(cp => cp.ClienteId == clienteId).Select(cp => cp.ManillaId).ToList();
            model.SoporteCompasList = _context.ClienteSoporteCompases.Where(cp => cp.ClienteId == clienteId).Select(cp => cp.SoporteCompasId).ToList();
            return model;
        }
        private void InitializeTitulo()
        {
            if (_mode == WizardMode.Edit)
            {
                lbl_Titulo.Text = _model.Nombre;
                lbl_Subtitulo.Text = "Editando cliente";
            }
            else
            {
                lbl_Titulo.Text = "Nuevo Cliente";
                lbl_Subtitulo.Text = "Completa los datos para crear el cliente";
            }

        }

        #endregion
    }
}
