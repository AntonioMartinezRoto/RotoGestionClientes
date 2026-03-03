using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class ClientePerfil
    {
        public int ClienteId { get; set; }
        public int PerfilId { get; set; }

        // Navegación
        public Cliente Cliente { get; set; } = null!;
        public Perfil Perfil { get; set; } = null!;
    }
}
