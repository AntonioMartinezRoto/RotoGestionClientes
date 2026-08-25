using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RotoGestionClientes
{
    [Table("Perfil", Schema = "dbo")]
    public class Perfil
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        [Required]
        public bool Activa { get; set; } = true;

        public int PerfilTipoId { get; set; }

        // Navigation property
        public virtual PerfilTipo PerfilTipo { get; set; } = null!;
        public ICollection<ClientePerfil> ClientePerfiles { get; set; } = new List<ClientePerfil>();
        public ICollection<ClienteAgujasModeloPerfil> ClienteAgujasModelos { get; set; } = new List<ClienteAgujasModeloPerfil>();
    }
}
