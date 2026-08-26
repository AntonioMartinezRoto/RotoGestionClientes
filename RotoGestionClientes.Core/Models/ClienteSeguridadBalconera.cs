using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class ClienteSeguridadBalconera
    {
        public int ClienteId { get; set; }
        public int SeguridadBalconeraId { get; set; }

        // Navegación
        public Cliente Cliente { get; set; } = null!;
        public SeguridadVentana SeguridadBalconera { get; set; } = null!;
    }
}
