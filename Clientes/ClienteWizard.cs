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
                btn_Finalizar.Text = "Guardar";
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
                    //new PasoParalelas(_model, _context),
                    new PasoCorrederas(_model, _context),
                    new PasoElevablesPlegables(_model, _context),
                    //new PasoEspeciales(_model, _context),
                    new PasoMaquinas(_model, _context),
                    new PasoDocumentosAsociados(_model, _context)
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
                                "Datos generales",
                                "Ventanas OB-PRAC",
                                "Balconeras",
                                "Puertas",
                                "Paralelas",
                                "Inline",
                                "Elevables",
                                "Especiales",
                                "Máquinas",
                                "Documentos asociados"
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
        private ClientWizardModel? MapClienteToModel(int? clienteId)
        {
            if (clienteId == null)
                return null;

            Cliente? cliente = _context.Clientes
                .FirstOrDefault(c => c.Id == clienteId);

            if (cliente == null)
                return null;

            ClientWizardModel model = new()
            {
                Nombre = cliente.Nombre,
                SapId = cliente.SapId,
                Alias = cliente.Alias,
                Comentarios = cliente.Comentarios,
                ObservacionesVentanas = cliente.ObservacionesVentanas,
                ObservacionesBalconeras = cliente.ObservacionesBalconeras,
                ObservacionesPuertas = cliente.ObservacionesPuertas,
                ObservacionesParalelas = cliente.ObservacionesParalelas,

                SoftwareList = _context.ClienteSoftwares
                    .Where(cs => cs.ClienteId == clienteId)
                    .Select(cs => cs.SoftwareId)
                    .ToList(),

                PerfilTipoList = _context.ClientePerfilTipos
                    .Where(cp => cp.ClienteId == clienteId)
                    .Select(cp => cp.PerfilTipoId)
                    .ToList(),

                ManillasList = _context.ClienteManillas
                    .Where(cp => cp.ClienteId == clienteId)
                    .Select(cp => cp.ManillaId)
                    .ToList(),

                SoporteCompasList = _context.ClienteSoporteCompases
                    .Where(cp => cp.ClienteId == clienteId)
                    .Select(cp => cp.SoporteCompasId)
                    .ToList(),

                SeguridadVentanaList = _context.ClienteSeguridadVentanas
                    .Where(cp => cp.ClienteId == clienteId)
                    .Select(cp => cp.SeguridadVentanaId)
                    .ToList(),

                SeguridadBalconeraList = _context.ClienteSeguridadBalconeras
                    .Where(cp => cp.ClienteId == clienteId)
                    .Select(cp => cp.SeguridadBalconeraId)
                    .ToList(),

                CremonaPasivaVentanaList = _context.ClienteCremonaPasivaVentanas
                    .Where(cp => cp.ClienteId == clienteId)
                    .Select(cp => cp.CremonaPasivaVentanaId)
                    .ToList(),

                CremonaPasivaVentanaPractList = _context.ClienteCremonaPasivaVentanasPract
                    .Where(cp => cp.ClienteId == clienteId)
                    .Select(cp => cp.CremonaPasivaVentanaId)
                    .ToList(),

                CremonaPasivaBalconeraList = _context.ClienteCremonaPasivaBalconeras
                    .Where(cp => cp.ClienteId == clienteId)
                    .Select(cp => cp.CremonaPasivaBalconeraId)
                    .ToList(),

                PerfilesList = _context.ClientePerfiles
                    .Where(cp => cp.ClienteId == clienteId)
                    .Select(cp => cp.PerfilId)
                    .ToList(),

                BisagrasPuertaList = _context.ClienteBisagraPuertas
                    .Where(cb => cb.ClienteId == clienteId)
                    .Select(cb => cb.BisagraPuertaId)
                    .ToList(),

                BisagrasPuertaSecList = _context.ClienteBisagraPuertasSec
                    .Where(cb => cb.ClienteId == clienteId)
                    .Select(cb => cb.BisagraPuertaId)
                    .ToList(),

                CerradurasPuertaSecList = _context.ClienteCerradurasPuertaSec
                    .Where(cb => cb.ClienteId == clienteId)
                    .Select(cb => cb.CerraduraPuertaSecId)
                    .ToList(),

                CerradurasPuertaList = _context.ClienteCerradurasPuerta
                    .Where(cb => cb.ClienteId == clienteId)
                    .Select(cb => cb.CerraduraPuertaId)
                    .ToList(),

                CilindroList = _context.ClienteCilindros
                    .Where(cb => cb.ClienteId == clienteId)
                    .Select(cb => cb.CilindroId)
                    .ToList(),

                AgujasModeloPerfilList = _context.ClienteAgujasModeloPerfil
                    .Where(cam => cam.ClienteId == clienteId)
                    .Select(cam => new AgujaModeloPerfilItem
                    {
                        AgujaModeloTipoId = cam.AgujaModeloTipoId,
                        AgujaId = cam.AgujaId,
                        PerfilId = cam.PerfilId
                    })
                    .ToList()
            };

            var clienteAgujas = _context.ClienteAgujases.FirstOrDefault(ca => ca.ClienteId == clienteId);

            model.AgujaBalconeraTipo = clienteAgujas?.AgujaBalconeraTipoId ?? 1;
            model.AgujaBalconera = clienteAgujas?.AgujaBalconeraId;

            model.AgujaPuertaSecTipo = clienteAgujas?.AgujaPuertaSecTipoId ?? 1;
            model.AgujaPuertaSec = clienteAgujas?.AgujaPuertaSecId;

            model.AgujaPuertaTipo = clienteAgujas?.AgujaPuertaTipoId ?? 1;
            model.AgujaPuerta = clienteAgujas?.AgujaPuertaId;

            var clienteConfiguracionPuertas = _context.ClienteConfiguracionPuerta.FirstOrDefault(ccp => ccp.ClienteId == clienteId);

            model.PorteroElectrico = clienteConfiguracionPuertas?.PorteroElectrico ?? false;
            model.Cilindro = clienteConfiguracionPuertas?.Cilindro ?? false;

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

        #region Creación cliente
        private void CrearCliente()
        {
            var cliente = new Cliente
            {
                Nombre = _model.Nombre,
                SapId = _model.SapId,
                Alias = _model.Alias,
                Comentarios = _model.Comentarios,
                ObservacionesVentanas = _model.ObservacionesVentanas,
                ObservacionesBalconeras = _model.ObservacionesBalconeras,
                ObservacionesPuertas = _model.ObservacionesPuertas,
                ObservacionesParalelas = _model.ObservacionesParalelas
            };

            _context.Clientes.Add(cliente);
            _context.SaveChanges();

            CrearClientePerfilTipo(cliente.Id);

            CrearClienteSoftware(cliente.Id);

            CrearClientePerfil(cliente.Id);

            CrearClienteManillas(cliente.Id);

            CrearClienteSoporteCompas(cliente.Id);

            CrearClienteSeguridadVentana(cliente.Id);

            CrearClienteCremonaPasivaVentana(cliente.Id);

            CrearClienteCremonaPasivaVentanaPract(cliente.Id);

            CrearClienteCremonaPasivaBalconera(cliente.Id);

            CrearClienteSeguridadBalconera(cliente.Id);

            CrearClienteAgujas(cliente.Id);

            CrearClienteBisagraPuerta(cliente.Id);

            CrearClienteBisagraPuertaSec(cliente.Id);

            CrearClienteCerraduraPuertaSec(cliente.Id);

            CrearClienteCerraduraPuerta(cliente.Id);

            CrearClienteConfiguacionPuerta(cliente.Id);

            CrearClienteCilindro(cliente.Id);

            _context.SaveChanges();
        }
        private void CrearClienteCilindro(int clienteId)
        {
            foreach (var cilindroId in _model.CilindroList)
            {
                _context.ClienteCilindros.Add(new ClienteCilindro
                {
                    ClienteId = clienteId,
                    CilindroId = cilindroId
                });

            }
        }
        private void CrearClienteConfiguacionPuerta(int clienteId)
        {
            _context.ClienteConfiguracionPuerta.Add(new ClienteConfiguracionPuerta
            {
                ClienteId = clienteId,
                PorteroElectrico = _model.PorteroElectrico,
                Cilindro = _model.Cilindro
            });
        }
        private void CrearClienteCerraduraPuerta(int clienteId)
        {
            foreach (var cerraduraId in _model.CerradurasPuertaList)
            {
                _context.ClienteCerradurasPuerta.Add(new ClienteCerraduraPuerta
                {
                    ClienteId = clienteId,
                    CerraduraPuertaId = cerraduraId
                });
            }
        }
        private void CrearClienteCerraduraPuertaSec(int clienteId)
        {
            foreach (var cerraduraId in _model.CerradurasPuertaSecList)
            {
                _context.ClienteCerradurasPuertaSec.Add(new ClienteCerraduraPuertaSec
                {
                    ClienteId = clienteId,
                    CerraduraPuertaSecId = cerraduraId
                });
            }
        }
        private void CrearClienteBisagraPuerta(int clienteId)
        {
            foreach (var bisagraId in _model.BisagrasPuertaList)
            {
                _context.ClienteBisagraPuertas.Add(new ClienteBisagraPuerta
                {
                    ClienteId = clienteId,
                    BisagraPuertaId = bisagraId
                });

            }
        }
        private void CrearClienteBisagraPuertaSec(int clienteId)
        {
            foreach (var bisagraId in _model.BisagrasPuertaSecList)
            {
                _context.ClienteBisagraPuertasSec.Add(new ClienteBisagraPuertaSec
                {
                    ClienteId = clienteId,
                    BisagraPuertaId = bisagraId
                });

            }
        }
        private void CrearClienteAgujas(int clienteId)
        {
            // Tabla principal
            _context.ClienteAgujases.Add(new ClienteAgujas
            {
                ClienteId = clienteId,
                AgujaBalconeraTipoId = _model.AgujaBalconeraTipo,
                AgujaBalconeraId = _model.AgujaBalconera,
                AgujaPuertaSecTipoId = _model.AgujaPuertaSecTipo,
                AgujaPuertaSecId = _model.AgujaPuertaSec,
                AgujaPuertaTipoId = _model.AgujaPuertaTipo,
                AgujaPuertaId = _model.AgujaPuerta
            });

            // Tabla por perfil
            if (_model.AgujasModeloPerfilList != null && _model.AgujasModeloPerfilList.Any())
            {
                if (_model.AgujaBalconeraTipo == (int)AgujaMode.PorPerfil)
                    CrearClienteAgujasModeloPerfil(clienteId, (int)AgujasTipoModelo.Balconera);

                if (_model.AgujaPuertaSecTipo == (int)AgujaMode.PorPerfil)
                    CrearClienteAgujasModeloPerfil(clienteId, (int)AgujasTipoModelo.PuertaSecundaria);

                if (_model.AgujaPuertaTipo == (int)AgujaMode.PorPerfil)
                    CrearClienteAgujasModeloPerfil(clienteId, (int)AgujasTipoModelo.Puerta);
            }

        }
        private void CrearClienteAgujasModeloPerfil(int clienteId, int agujaModeloTipoId)
        {
            var lista = _model.AgujasModeloPerfilList
                        .Where(t => t.AgujaModeloTipoId == agujaModeloTipoId)
                        .Select(x => new ClienteAgujasModeloPerfil
                        {
                            ClienteId = clienteId,
                            AgujaModeloTipoId = x.AgujaModeloTipoId,
                            AgujaId = x.AgujaId,
                            PerfilId = x.PerfilId
                        })
                        .ToList();

            _context.ClienteAgujasModeloPerfil.AddRange(lista);
        }
        private void CrearClienteSeguridadVentana(int clienteId)
        {
            foreach (var seguridadVentanaId in _model.SeguridadVentanaList)
            {
                _context.ClienteSeguridadVentanas.Add(new ClienteSeguridadVentana
                {
                    ClienteId = clienteId,
                    SeguridadVentanaId = seguridadVentanaId
                });

            }
        }
        private void CrearClienteSeguridadBalconera(int clienteId)
        {
            foreach (var seguridadBalconeraId in _model.SeguridadBalconeraList)
            {
                _context.ClienteSeguridadBalconeras.Add(new ClienteSeguridadBalconera
                {
                    ClienteId = clienteId,
                    SeguridadBalconeraId = seguridadBalconeraId
                });

            }
        }
        private void CrearClienteSoporteCompas(int clienteId)
        {
            foreach (var soporteCompasId in _model.SoporteCompasList)
            {
                _context.ClienteSoporteCompases.Add(new ClienteSoporteCompas
                {
                    ClienteId = clienteId,
                    SoporteCompasId = soporteCompasId
                });

            }
        }
        private void CrearClienteManillas(int clienteId)
        {
            foreach (var manillaId in _model.ManillasList)
            {
                _context.ClienteManillas.Add(new ClienteManilla
                {
                    ClienteId = clienteId,
                    ManillaId = manillaId
                });

            }
        }
        private void CrearClienteSoftware(int clienteId)
        {
            if (_model.SoftwareList.Any())
            {
                _context.ClienteSoftwares.Add(new ClienteSoftware
                {
                    ClienteId = clienteId,
                    SoftwareId = _model.SoftwareList.FirstOrDefault()
                });
            }
        }
        private void CrearClientePerfil(int clienteId)
        {
            if (_model.PerfilesList.Any())
            {
                foreach (var perfilId in _model.PerfilesList)
                {
                    _context.ClientePerfiles.Add(new ClientePerfil
                    {
                        ClienteId = clienteId,
                        PerfilId = perfilId
                    });
                }
            }
        }
        private void CrearClientePerfilTipo(int clienteId)
        {
            foreach (var perfilTipoId in _model.PerfilTipoList)
            {
                _context.ClientePerfilTipos.Add(new ClientePerfilTipo
                {
                    ClienteId = clienteId,
                    PerfilTipoId = perfilTipoId
                });

            }
        }
        private void CrearClienteCremonaPasivaVentana(int clienteId)
        {
            foreach (var cremonaPasivaVentanaTipoId in _model.CremonaPasivaVentanaList)
            {
                _context.ClienteCremonaPasivaVentanas.Add(new ClienteCremonaPasivaVentana
                {
                    ClienteId = clienteId,
                    CremonaPasivaVentanaId = cremonaPasivaVentanaTipoId
                });

            }
        }
        private void CrearClienteCremonaPasivaBalconera(int clienteId)
        {
            foreach (var cremonaPasivaBalconeraTipoId in _model.CremonaPasivaBalconeraList)
            {
                _context.ClienteCremonaPasivaBalconeras.Add(new ClienteCremonaPasivaBalconera
                {
                    ClienteId = clienteId,
                    CremonaPasivaBalconeraId = cremonaPasivaBalconeraTipoId
                });

            }
        }
        private void CrearClienteCremonaPasivaVentanaPract(int clienteId)
        {
            foreach (var cremonaPasivaVentanaTipoId in _model.CremonaPasivaVentanaPractList)
            {
                _context.ClienteCremonaPasivaVentanasPract.Add(new ClienteCremonaPasivaVentanaPract
                {
                    ClienteId = clienteId,
                    CremonaPasivaVentanaId = cremonaPasivaVentanaTipoId
                });

            }
        }
        #endregion

        #region Actualización cliente
        private void UpdateCliente()
        {
            Cliente cliente = _context.Clientes
                .Include(c => c.ClientePerfilTipos)
                .Include(c => c.ClienteSoftwares)
                .Include(c => c.ClienteManillas)
                .Include(c => c.ClienteSoporteCompases)
                .Include(c => c.ClienteSeguridadVentanas)
                .Include(c => c.ClienteSeguridadBalconeras)
                .Include(c => c.ClienteCremonaPasivaVentanas)
                .Include(c => c.ClienteCremonaPasivaBalconeras)
                .Include(c => c.ClienteCremonaPasivaVentanasPract)
                .Include(c => c.ClientePerfiles)
                .Include(c => c.ClienteAgujases)
                .Include(c => c.ClienteBisagraPuertas)
                .Include(c => c.ClienteBisagraPuertasSec)
                .Include(c => c.ClienteCerradurasPuertaSec)
                .Include(c => c.ClienteCerradurasPuerta)
                .Include(c => c.ClienteConfiguracionPuerta)
                .Include(c => c.ClienteCilindros)
                    .ThenInclude(cc => cc.Cilindro)
                        .ThenInclude(c => c.CilindroTipo)
                .First(c => c.Id == _clienteId);

            //Guardar el nombre
            cliente.Nombre = _model.Nombre;
            cliente.Alias = _model.Alias;
            cliente.SapId = _model.SapId;
            cliente.Comentarios = _model.Comentarios;
            cliente.ObservacionesVentanas = _model.ObservacionesVentanas;
            cliente.ObservacionesBalconeras = _model.ObservacionesBalconeras;
            cliente.ObservacionesPuertas = _model.ObservacionesPuertas;
            cliente.ObservacionesParalelas = _model.ObservacionesParalelas;

            UpdateClientePerfilTipo(cliente);

            UpdateSoftware(cliente);

            UpdateClientePerfil(cliente);

            UpdateManillas(cliente);

            UpdateSoporteCompas(cliente);

            UpdateSeguridadVentanas(cliente);

            UpdateCremonaPasivaVentanas(cliente);

            UpdateCremonaPasivaBalconeras(cliente);

            UpdateCremonaPasivaVentanasPract(cliente);

            UpdateSeguridadBalconeras(cliente);

            UpdateAgujas(cliente);

            UpdateBisagrasPuerta(cliente);

            UpdateBisagrasPuertaSec(cliente);

            UpdateCerraduraPuertaSec(cliente);

            UpdateCerraduraPuerta(cliente);

            UpdateConfiguracionPuerta(cliente);

            UpdateCilindros(cliente);

            _context.SaveChanges();
        }
        private void UpdateCilindros(Cliente cliente)
        {
            var itemActuales = cliente.ClienteCilindros
                .Select(cp => cp.CilindroId)
                .ToList();

            var itemSeleccionadas = _model.CilindroList;

            //1. Eliminar los que ya no están seleccionados
            var itemsAEliminar = cliente.ClienteCilindros
                .Where(cp => !itemSeleccionadas.Contains(cp.CilindroId))
                .ToList();

            foreach (var item in itemsAEliminar)
            {
                _context.Remove(item);
            }

            //2. Agregar los nuevos
            var itemsAAgregar = itemSeleccionadas
                .Where(id => !itemActuales.Contains(id))
                .ToList();

            foreach (var itemId in itemsAAgregar)
            {
                cliente.ClienteCilindros.Add(new ClienteCilindro
                {
                    ClienteId = cliente.Id,
                    CilindroId = itemId
                });
            }
        }
        private void UpdateConfiguracionPuerta(Cliente cliente)
        {
            var clienteConfiguracionPuerta = _context.ClienteConfiguracionPuerta
                .FirstOrDefault(ca => ca.ClienteId == cliente.Id);

            if (clienteConfiguracionPuerta == null)
            {
                clienteConfiguracionPuerta = new ClienteConfiguracionPuerta
                {
                    ClienteId = cliente.Id
                };

                _context.ClienteConfiguracionPuerta.Add(clienteConfiguracionPuerta);
            }

            // actualizar configuración general
            clienteConfiguracionPuerta.PorteroElectrico = _model.PorteroElectrico;
            clienteConfiguracionPuerta.Cilindro = _model.Cilindro;
        }
        private void UpdateCerraduraPuerta(Cliente cliente)
        {
            var itemActuales = cliente.ClienteCerradurasPuerta
                .Select(cp => cp.CerraduraPuertaId)
                .ToList();

            var itemSeleccionadas = _model.CerradurasPuertaList;

            //1. Eliminar los que ya no están seleccionados
            var itemsAEliminar = cliente.ClienteCerradurasPuerta
                .Where(cp => !itemSeleccionadas.Contains(cp.CerraduraPuertaId))
                .ToList();

            foreach (var item in itemsAEliminar)
            {
                _context.Remove(item);
            }

            //2. Agregar los nuevos
            var itemsAAgregar = itemSeleccionadas
                .Where(id => !itemActuales.Contains(id))
                .ToList();

            foreach (var itemId in itemsAAgregar)
            {
                cliente.ClienteCerradurasPuerta.Add(new ClienteCerraduraPuerta
                {
                    ClienteId = cliente.Id,
                    CerraduraPuertaId = itemId
                });
            }
        }
        private void UpdateCerraduraPuertaSec(Cliente cliente)
        {
            var itemActuales = cliente.ClienteCerradurasPuertaSec
                .Select(cp => cp.CerraduraPuertaSecId)
                .ToList();

            var itemSeleccionadas = _model.CerradurasPuertaSecList;

            //1. Eliminar los que ya no están seleccionados
            var itemsAEliminar = cliente.ClienteCerradurasPuertaSec
                .Where(cp => !itemSeleccionadas.Contains(cp.CerraduraPuertaSecId))
                .ToList();

            foreach (var item in itemsAEliminar)
            {
                _context.Remove(item);
            }

            //2. Agregar los nuevos
            var itemsAAgregar = itemSeleccionadas
                .Where(id => !itemActuales.Contains(id))
                .ToList();

            foreach (var itemId in itemsAAgregar)
            {
                cliente.ClienteCerradurasPuertaSec.Add(new ClienteCerraduraPuertaSec
                {
                    ClienteId = cliente.Id,
                    CerraduraPuertaSecId = itemId
                });
            }
        }
        private void UpdateBisagrasPuerta(Cliente cliente)
        {
            var itemActuales = cliente.ClienteBisagraPuertas
                .Select(cp => cp.BisagraPuertaId)
                .ToList();

            var itemSeleccionadas = _model.BisagrasPuertaList;

            //1. Eliminar los que ya no están seleccionados
            var itemsAEliminar = cliente.ClienteBisagraPuertas
                .Where(cp => !itemSeleccionadas.Contains(cp.BisagraPuertaId))
                .ToList();

            foreach (var item in itemsAEliminar)
            {
                _context.Remove(item);
            }

            //2. Agregar los nuevos
            var itemsAAgregar = itemSeleccionadas
                .Where(id => !itemActuales.Contains(id))
                .ToList();

            foreach (var itemId in itemsAAgregar)
            {
                cliente.ClienteBisagraPuertas.Add(new ClienteBisagraPuerta
                {
                    ClienteId = cliente.Id,
                    BisagraPuertaId = itemId
                });
            }
        }
        private void UpdateBisagrasPuertaSec(Cliente cliente)
        {
            var itemActuales = cliente.ClienteBisagraPuertasSec
                .Select(cp => cp.BisagraPuertaId)
                .ToList();

            var itemSeleccionadas = _model.BisagrasPuertaSecList;

            //1. Eliminar los que ya no están seleccionados
            var itemsAEliminar = cliente.ClienteBisagraPuertasSec
                .Where(cp => !itemSeleccionadas.Contains(cp.BisagraPuertaId))
                .ToList();

            foreach (var item in itemsAEliminar)
            {
                _context.Remove(item);
            }

            //2. Agregar los nuevos
            var itemsAAgregar = itemSeleccionadas
                .Where(id => !itemActuales.Contains(id))
                .ToList();

            foreach (var itemId in itemsAAgregar)
            {
                cliente.ClienteBisagraPuertasSec.Add(new ClienteBisagraPuertaSec
                {
                    ClienteId = cliente.Id,
                    BisagraPuertaId = itemId
                });
            }
        }
        private void UpdateAgujas(Cliente cliente)
        {
            var clienteAgujas = _context.ClienteAgujases
                .FirstOrDefault(ca => ca.ClienteId == cliente.Id);

            if (clienteAgujas == null)
            {
                clienteAgujas = new ClienteAgujas
                {
                    ClienteId = cliente.Id
                };

                _context.ClienteAgujases.Add(clienteAgujas);
            }

            // actualizar configuración general
            clienteAgujas.AgujaBalconeraTipoId = _model.AgujaBalconeraTipo;
            clienteAgujas.AgujaBalconeraId = _model.AgujaBalconera;

            clienteAgujas.AgujaPuertaSecTipoId = _model.AgujaPuertaSecTipo;
            clienteAgujas.AgujaPuertaSecId = _model.AgujaPuertaSec;

            clienteAgujas.AgujaPuertaTipoId = _model.AgujaPuertaTipo;
            clienteAgujas.AgujaPuertaId = _model.AgujaPuerta;

            // actualizar agujas por perfil
            UpdateAgujasModeloPerfil(cliente);
        }
        private void UpdateAgujasModeloPerfil(Cliente cliente)
        {
            var existentes = _context.ClienteAgujasModeloPerfil
                .Where(x => x.ClienteId == cliente.Id)
                .ToList();

            _context.ClienteAgujasModeloPerfil.RemoveRange(existentes);

            if (_model.AgujasModeloPerfilList == null || !_model.AgujasModeloPerfilList.Any())
                return;

            if (_model.AgujaBalconeraTipo == (int)AgujaMode.PorPerfil)
                AddAgujasModeloPerfil(cliente.Id, (int)AgujasTipoModelo.Balconera);


            if (_model.AgujaPuertaSecTipo == (int)AgujaMode.PorPerfil)
                AddAgujasModeloPerfil(cliente.Id, (int)AgujasTipoModelo.PuertaSecundaria);

            if (_model.AgujaPuertaTipo == (int)AgujaMode.PorPerfil)
                AddAgujasModeloPerfil(cliente.Id, (int)AgujasTipoModelo.Puerta);

        }
        private void AddAgujasModeloPerfil(int clienteId, int agujaModeloTipoId)
        {
            var nuevos = _model.AgujasModeloPerfilList
            .Where(t => t.AgujaModeloTipoId == agujaModeloTipoId)
            .Select(x => new ClienteAgujasModeloPerfil
            {
                ClienteId = clienteId,
                AgujaModeloTipoId = x.AgujaModeloTipoId,
                AgujaId = x.AgujaId,
                PerfilId = x.PerfilId
            });

            _context.ClienteAgujasModeloPerfil.AddRange(nuevos);
        }
        private void UpdateSeguridadVentanas(Cliente cliente)
        {
            var itemActuales = cliente.ClienteSeguridadVentanas
                .Select(cp => cp.SeguridadVentanaId)
                .ToList();

            var itemSeleccionadas = _model.SeguridadVentanaList;

            //1. Eliminar los que ya no están seleccionados
            var itemsAEliminar = cliente.ClienteSeguridadVentanas
                .Where(cp => !itemSeleccionadas.Contains(cp.SeguridadVentanaId))
                .ToList();

            foreach (var item in itemsAEliminar)
            {
                _context.Remove(item);
            }

            //2. Agregar los nuevos
            var itemsAAgregar = itemSeleccionadas
                .Where(id => !itemActuales.Contains(id))
                .ToList();

            foreach (var itemId in itemsAAgregar)
            {
                cliente.ClienteSeguridadVentanas.Add(new ClienteSeguridadVentana
                {
                    ClienteId = cliente.Id,
                    SeguridadVentanaId = itemId
                });
            }
        }
        private void UpdateSeguridadBalconeras(Cliente cliente)
        {
            var itemActuales = cliente.ClienteSeguridadBalconeras
                .Select(cp => cp.SeguridadBalconeraId)
                .ToList();

            var itemSeleccionadas = _model.SeguridadBalconeraList;

            //1. Eliminar los que ya no están seleccionados
            var itemsAEliminar = cliente.ClienteSeguridadBalconeras
                .Where(cp => !itemSeleccionadas.Contains(cp.SeguridadBalconeraId))
                .ToList();

            foreach (var item in itemsAEliminar)
            {
                _context.Remove(item);
            }

            //2. Agregar los nuevos
            var itemsAAgregar = itemSeleccionadas
                .Where(id => !itemActuales.Contains(id))
                .ToList();

            foreach (var itemId in itemsAAgregar)
            {
                cliente.ClienteSeguridadBalconeras.Add(new ClienteSeguridadBalconera
                {
                    ClienteId = cliente.Id,
                    SeguridadBalconeraId = itemId
                });
            }
        }
        private void UpdateClientePerfil(Cliente cliente)
        {
            var itemActuales = cliente.ClientePerfiles
                .Select(cp => cp.PerfilId)
                .ToList();

            var itemSeleccionadas = _model.PerfilesList;

            //1. Eliminar los que ya no están seleccionados
            var itemsAEliminar = cliente.ClientePerfiles
                .Where(cp => !itemSeleccionadas.Contains(cp.PerfilId))
                .ToList();

            foreach (var item in itemsAEliminar)
            {
                _context.Remove(item);
            }

            //2. Agregar los nuevos
            var itemsAAgregar = itemSeleccionadas
                .Where(id => !itemActuales.Contains(id))
                .ToList();

            foreach (var itemId in itemsAAgregar)
            {
                cliente.ClientePerfiles.Add(new ClientePerfil
                {
                    ClienteId = cliente.Id,
                    PerfilId = itemId
                });
            }
        }
        private void UpdateCremonaPasivaVentanas(Cliente cliente)
        {
            var itemActuales = cliente.ClienteCremonaPasivaVentanas
                .Select(cp => cp.CremonaPasivaVentanaId)
                .ToList();

            var itemSeleccionadas = _model.CremonaPasivaVentanaList;

            //1. Eliminar los que ya no están seleccionados
            var itemsAEliminar = cliente.ClienteCremonaPasivaVentanas
                .Where(cp => !itemSeleccionadas.Contains(cp.CremonaPasivaVentanaId))
                .ToList();

            foreach (var item in itemsAEliminar)
            {
                _context.Remove(item);
            }

            //2. Agregar los nuevos
            var itemsAAgregar = itemSeleccionadas
                .Where(id => !itemActuales.Contains(id))
                .ToList();

            foreach (var itemId in itemsAAgregar)
            {
                cliente.ClienteCremonaPasivaVentanas.Add(new ClienteCremonaPasivaVentana
                {
                    ClienteId = cliente.Id,
                    CremonaPasivaVentanaId = itemId
                });
            }
        }
        private void UpdateCremonaPasivaBalconeras(Cliente cliente)
        {
            var itemActuales = cliente.ClienteCremonaPasivaBalconeras
                .Select(cp => cp.CremonaPasivaBalconeraId)
                .ToList();

            var itemSeleccionadas = _model.CremonaPasivaBalconeraList;

            //1. Eliminar los que ya no están seleccionados
            var itemsAEliminar = cliente.ClienteCremonaPasivaBalconeras
                .Where(cp => !itemSeleccionadas.Contains(cp.CremonaPasivaBalconeraId))
                .ToList();

            foreach (var item in itemsAEliminar)
            {
                _context.Remove(item);
            }

            //2. Agregar los nuevos
            var itemsAAgregar = itemSeleccionadas
                .Where(id => !itemActuales.Contains(id))
                .ToList();

            foreach (var itemId in itemsAAgregar)
            {
                cliente.ClienteCremonaPasivaBalconeras.Add(new ClienteCremonaPasivaBalconera
                {
                    ClienteId = cliente.Id,
                    CremonaPasivaBalconeraId = itemId
                });
            }
        }
        private void UpdateCremonaPasivaVentanasPract(Cliente cliente)
        {
            var itemActuales = cliente.ClienteCremonaPasivaVentanasPract
                .Select(cp => cp.CremonaPasivaVentanaId)
                .ToList();

            var itemSeleccionadas = _model.CremonaPasivaVentanaPractList;

            //1. Eliminar los que ya no están seleccionados
            var itemsAEliminar = cliente.ClienteCremonaPasivaVentanasPract
                .Where(cp => !itemSeleccionadas.Contains(cp.CremonaPasivaVentanaId))
                .ToList();

            foreach (var item in itemsAEliminar)
            {
                _context.Remove(item);
            }

            //2. Agregar los nuevos
            var itemsAAgregar = itemSeleccionadas
                .Where(id => !itemActuales.Contains(id))
                .ToList();

            foreach (var itemId in itemsAAgregar)
            {
                cliente.ClienteCremonaPasivaVentanasPract.Add(new ClienteCremonaPasivaVentanaPract
                {
                    ClienteId = cliente.Id,
                    CremonaPasivaVentanaId = itemId
                });
            }
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
        private void UpdateClientePerfilTipo(Cliente cliente)
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

        #endregion


        #endregion
    }
}
