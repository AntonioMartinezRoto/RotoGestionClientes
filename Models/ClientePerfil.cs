using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class ClientePerfilTipo
    {
        public int ClienteId { get; set; }
        public int PerfilTipoId { get; set; }

        // Navegación
        public Cliente Cliente { get; set; } = null!;
        public PerfilTipo PerfilTipo { get; set; } = null!;
    }
}
