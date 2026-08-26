using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class ClienteDocumentoExportDto
    {
        public string Nombre { get; set; } = string.Empty;

        public string NombreFicheroOriginal { get; set; }
            = string.Empty;

        public string Extension { get; set; } = string.Empty;

        public byte[] Contenido { get; set; }
            = Array.Empty<byte>();
    }
}
