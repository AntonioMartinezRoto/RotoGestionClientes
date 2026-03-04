using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class ClienteBisagraPuertaSec
    {
        public int ClienteId { get; set; }
        public int BisagraPuertaId { get; set; }

        // Navegación
        public Cliente Cliente { get; set; } = null!;
        public Bisagra Bisagra { get; set; } = null!;
    }
}
