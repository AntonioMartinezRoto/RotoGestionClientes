using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class ClienteAgujasModeloPerfil
    {
        public int ClienteId { get; set; }
        public int AgujaModeloTipoId { get; set; }
        public int AgujaId { get; set; }
        public int PerfilId { get; set; }

        // Navegación
        public Cliente Cliente { get; set; } = null!;
        public AgujasModelo AgujasModelo { get; set; } = null!;
        public Aguja Aguja { get; set; } = null!;
        public Perfil Perfil { get; set; } = null!;
    }
}
