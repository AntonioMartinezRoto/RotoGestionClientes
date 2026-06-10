using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes.Models
{
    public class ClienteResumenModel
    {
        public string Nombre { get; set; } = string.Empty;
        public string? SapId { get; set; }
        public string? Alias { get; set; }

        public List<string> Softwares { get; set; } = new();

        public List<string> Perfiles { get; set; } = new();

        public List<string> Manillas { get; set; } = new();

        public List<ClienteResumenMaquinaItem> Maquinas { get; set; } = new();

        public List<string> Documentos { get; set; } = new();
    }
    public class ClienteResumenMaquinaItem
    {
        public string Tipo { get; set; } = string.Empty;
        public string? Marca { get; set; }
        public string Mantenimiento { get; set; } = string.Empty;
    }
}
