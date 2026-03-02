using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class ClientWizardModel
    {
        public string Nombre { get; set; }
        public string? Comentarios { get; set; }
        public string? Alias { get; set; }
        public string? ObservacionesVentanas { get; set; }
        public List<int> PerfilTipoList { get; set; } = new();
        public List<int> SoftwareList { get; set; } = new();
        public List<int> ManillasList { get; set; } = new();
        public List<int> SoporteCompasList { get; set; } = new();
        public List<int> SeguridadVentanaList { get; set; } = new();
        public List<int> CremonaPasivaVentanaList { get; set; } = new();
    }
}
