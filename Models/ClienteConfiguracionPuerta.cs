using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class ClienteConfiguracionPuerta
    {
        public int ClienteId { get; set; }

        public bool PorteroElectrico { get; set; } = true;
        public bool Cilindro { get; set; } = true;
        public virtual Cliente Cliente { get; set; } = null!;
    }
}
