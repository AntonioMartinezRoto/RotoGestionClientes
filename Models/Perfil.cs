using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class Perfil
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public int PerfilTipoId { get; set; }

        // Navigation property
        public virtual PerfilTipo PerfilTipo { get; set; } = null!;
        public ICollection<ClientePerfil> ClientePerfiles { get; set; } = new List<ClientePerfil>();
    }
}
