using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class ClienteDataExportDto
    {
        public string Nombre { get; set; } = string.Empty;

        public string? Comentarios { get; set; }

        public string? SapId { get; set; }

        public string? Alias { get; set; }
        public int? ResponsableId { get; set; }

        public string? ObservacionesVentanas { get; set; }

        public string? ObservacionesBalconeras { get; set; }

        public string? ObservacionesPuertas { get; set; }

        public string? ObservacionesParalelas { get; set; }

        public string? ObservacionesCorrederas { get; set; }

        public string? ObservacionesElevables { get; set; }

        public string? ObservacionesPlegables { get; set; }

        public string? ObservacionesMaquinas { get; set; }

        public string? ObservacionesDocumentos { get; set; }

        public List<MaestroRefDto> Softwares { get; set; } = new();

        public List<MaestroRefDto> Manillas { get; set; } = new();

        public List<MaestroRefDto> Perfiles { get; set; } = new();

        public List<MaestroRefDto> PerfilTipos { get; set; } = new();

        public List<MaestroRefDto> SoporteCompas { get; set; } = new();

        public List<MaestroRefDto> SeguridadVentanas { get; set; } = new();

        public List<MaestroRefDto> SeguridadBalconeras { get; set; } = new();

        public List<MaestroRefDto> CremonaPasivaVentanas { get; set; } = new();

        public List<MaestroRefDto> CremonaPasivaVentanasPract { get; set; } = new();

        public List<MaestroRefDto> CremonaPasivaBalconeras { get; set; } = new();

        public List<MaestroRefDto> BisagrasPuerta { get; set; } = new();

        public List<MaestroRefDto> BisagrasPuertaSec { get; set; } = new();

        public List<MaestroRefDto> CerradurasPuerta { get; set; } = new();

        public List<MaestroRefDto> CerradurasPuertaSec { get; set; } = new();

        public List<MaestroRefDto> Cilindros { get; set; } = new();

        public List<MaestroRefDto> AgujasCorredera { get; set; } = new();

        public int AgujaBalconeraTipo { get; set; }

        public int? AgujaBalconera { get; set; }

        public int AgujaPuertaSecTipo { get; set; }

        public int? AgujaPuertaSec { get; set; }

        public int AgujaPuertaTipo { get; set; }

        public int? AgujaPuerta { get; set; }

        public bool PorteroElectrico { get; set; }

        public bool Cilindro { get; set; }

        public bool CilindroCorredera { get; set; }

        public bool Elevable_Estandar { get; set; }

        public bool Elevable_Dlo { get; set; }

        public bool Plegable_Consumen { get; set; }

        public bool BisagraEnSoldadora { get; set; }

        public bool TripleTaladroCentro { get; set; }

        public int SoporteMarcoConfigId { get; set; }

        public List<AgujaModeloPerfilExportDto>
            AgujasModeloPerfil
        { get; set; } = new();

        public List<ClienteMaquinaExportDto>
            Maquinas
        { get; set; } = new();

        public List<ClienteDocumentoExportDto>
            Documentos
        { get; set; } = new();
    }
}
