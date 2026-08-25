using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class ClienteCremonaPasivaVentanaPract
    {
        public int ClienteId { get; set; }
        public int CremonaPasivaVentanaId { get; set; }

        // Navegación
        public Cliente Cliente { get; set; } = null!;
        public CremonaPasivaVentanaTipos CremonaPasivaVentanaTipo { get; set; } = null!;
    }
}
