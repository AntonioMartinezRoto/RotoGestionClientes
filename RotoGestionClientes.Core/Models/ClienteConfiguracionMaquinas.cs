using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class ClienteConfiguracionMaquinas
    {
        public int ClienteId { get; set; }

        public bool BisagrasSoldadora { get; set; } = false;
        public bool TripleTaladroCentro { get; set; } = false;
        public int SoporteMarcoId { get; set; } = 1;

        public virtual Cliente Cliente { get; set; } = null!;
        public virtual SoporteMarcoConfig SoporteMarcoConfig { get; set; } = null!;
    }
}
