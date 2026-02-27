using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class ClienteSoftware
    {
        public int ClienteId { get; set; }
        public int SoftwareId { get; set; }

        // Navegación
        public Cliente Cliente { get; set; } = null!;
        public Software Software { get; set; } = null!;
    }
}
