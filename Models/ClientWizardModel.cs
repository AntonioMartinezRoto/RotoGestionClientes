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
        public string? ObservacionesPuertas { get; set; }
        public List<int> PerfilTipoList { get; set; } = new();
        public List<int> SoftwareList { get; set; } = new();
        public List<int> ManillasList { get; set; } = new();
        public List<int> SoporteCompasList { get; set; } = new();
        public List<int> SeguridadVentanaList { get; set; } = new();
        public List<int> CremonaPasivaVentanaList { get; set; } = new();
        public List<int> CremonaPasivaVentanaPractList { get; set; } = new();
        public List<int> PerfilesList { get; set; } = new();
        public int AgujaBalconeraTipo { get; set; }
        public int? AgujaBalconera { get; set; }
        public int AgujaPuertaSecTipo { get; set; }
        public int? AgujaPuertaSec { get; set; }
        public int AgujaPuertaTipo { get; set; }
        public int? AgujaPuerta { get; set; }
        public List<int> BisagrasPuertaSecList { get; set; } = new();
        public List<int> BisagrasPuertaList { get; set; } = new();
        public List<AgujaModeloPerfilItem> AgujasModeloPerfilList { get; set; } = new();
        public List<int> CerradurasPuertaSecList { get; set; } = new();
        public List<int> CerradurasPuertaList { get; set; } = new();
    }
    public class AgujaModeloPerfilItem
    {
        public int AgujaModeloTipoId { get; set; }
        public int AgujaId { get; set; }
        public int PerfilId { get; set; }
    }
}
