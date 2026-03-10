using System;
using System.Collections.Generic;
using System.Text;
namespace RotoGestionClientes
{
    public class ClienteCerraduraPuerta
    {
        public int ClienteId { get; set; }
        public int CerraduraPuertaId { get; set; }

        // Navegación
        public Cliente Cliente { get; set; } = null!;
        public CerraduraPuerta CerraduraPuerta { get; set; } = null!;
    }
}
