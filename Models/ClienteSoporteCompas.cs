using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class ClienteSoporteCompas
    {
        public int ClienteId { get; set; }
        public int SoporteCompasId { get; set; }

        // Navegación
        public Cliente Cliente { get; set; } = null!;
        public SoporteCompas SoporteCompas { get; set; } = null!;
    }
}
