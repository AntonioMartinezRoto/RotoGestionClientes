using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class ClienteDocumento
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }

        public string Nombre { get; set; } = null!;

        public string NombreFicheroOriginal { get; set; } = null!;
        public string Extension { get; set; } = null!;

        public byte[] Contenido { get; set; } = null!;
        public long TamañoBytes { get; set; }

        public DateTime FechaAlta { get; set; }

        public Cliente Cliente { get; set; } = null!;
    }
}
