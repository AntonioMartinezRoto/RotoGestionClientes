using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class ClienteManilla
    {
        public int ClienteId { get; set; }
        public int ManillaId { get; set; }

        // Navegación
        public Cliente Cliente { get; set; } = null!;
        public Manilla Manilla { get; set; } = null!;
    }
}
