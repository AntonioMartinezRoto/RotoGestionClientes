using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class ClienteDocumentoItem
    {
        public int? Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string NombreFicheroOriginal { get; set; } = null!;

        public string Extension { get; set; } = null!;

        public byte[] Contenido { get; set; } = null!;

        public long TamañoBytes { get; set; }
    }
}
