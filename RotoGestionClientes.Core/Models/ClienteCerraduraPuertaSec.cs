using System;
using System.Collections.Generic;
using System.Text;
namespace RotoGestionClientes
{
    public class ClienteCerraduraPuertaSec
    {
        public int ClienteId { get; set; }
        public int CerraduraPuertaSecId { get; set; }

        // Navegación
        public Cliente Cliente { get; set; } = null!;
        public CerraduraPuertaSec CerraduraPuertaSec { get; set; } = null!;
    }
}
