using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class MaestrosExportDto
    {
        public string VersionMaestros { get; set; } = "1.0";
        public List<MaestroDto> Softwares { get; set; } = new();
        public List<PerfilTipoDto> PerfilTipos { get; set; } = new();
        public List<PerfilDto> Perfiles { get; set; } = new();
        public List<MaestroDto> Manillas { get; set; } = new();
        public List<MaestroDto> SoporteCompases { get; set; } = new();
        public List<MaestroDto> SeguridadVentanas { get; set; } = new();
        public List<MaestroDto> SeguridadBalconeras { get; set; } = new();
        public List<MaestroDto> CremonaPasivaVentanas { get; set; } = new();
        public List<MaestroDto> CremonaPasivaBalconeras { get; set; } = new();
        public List<MaestroDto> Bisagras { get; set; } = new();
        public List<MaestroDto> CerradurasPuerta { get; set; } = new();
        public List<MaestroDto> CerradurasPuertaSec { get; set; } = new();
        public List<CilindroDto> Cilindros { get; set; } = new();
        public List<MaestroDto> Agujas { get; set; } = new();
        public List<MaquinaTipoDto> MaquinasTipo { get; set; } = new();
        public List<MaestroDto> MaquinasMarca { get; set; } = new();
        public List<MaestroDto> MaquinasMantenimiento { get; set; } = new();
    }
}
