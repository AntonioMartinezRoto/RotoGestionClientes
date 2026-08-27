using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RotoGestionClientes
{
    [Table("Usuario", Schema = "dbo")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = null!;

        // Categoría del usuario -- FK al maestro TipoUsuario (Comercial,
        // Distribuidor, Técnico...). Ver TipoUsuario.EsDistribuidor para
        // cómo el resto de la app identifica el papel de "distribuidor" sin
        // depender de este Id ni del nombre del catálogo.
        [Required]
        public int TipoUsuarioId { get; set; }

        [Required]
        public bool Activa { get; set; } = true;

        public virtual TipoUsuario TipoUsuario { get; set; } = null!;

        public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    }
}
