using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class ClienteSeguridadVentana
    {
        public int ClienteId { get; set; }
        public int SeguridadVentanaId { get; set; }

        // Navegación
        public Cliente Cliente { get; set; } = null!;
        public SeguridadVentana SeguridadVentana { get; set; } = null!;
    }
}
