using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class ClienteExportDto
    {
        public string Version { get; set; } = "1.0";

        public DateTime FechaExportacion { get; set; }
            = DateTime.Now;

        public ClienteDataExportDto Cliente { get; set; }
            = new();
    }
}
