using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class ClientWizardModel
    {
        public string Nombre { get; set; }
        public string? Comentarios { get; set; }
        public string? SapId { get; set; }
        public string? Alias { get; set; }
        public string? ObservacionesVentanas { get; set; }
        public string? ObservacionesBalconeras { get; set; }
        public List<int> PerfilTipoList { get; set; } = new();
        public List<int> SoftwareList { get; set; } = new();
        public List<int> ManillasList { get; set; } = new();
        public List<int> SoporteCompasList { get; set; } = new();
        public List<int> SeguridadVentanaList { get; set; } = new();
        public List<int> CremonaPasivaVentanaList { get; set; } = new();
        public List<int> CremonaPasivaVentanaPractList { get; set; } = new();
        public List<int> PerfilesList { get; set; } = new();
        public int? AgujaBalconera { get; set; }
        public int? AgujaPuertaSec { get; set; }
        public int? AgujaPuerta { get; set; }
        public List<int> BisagrasPuertaSecList { get; set; } = new();
        public List<int> BisagrasPuertaList { get; set; } = new();
    }
}
