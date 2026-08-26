using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RotoGestionClientes
{
    [Table("SoporteCompas", Schema = "dbo")]
    public class SoporteCompas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = null!;

        [Required]
        public bool Activa { get; set; } = true;

        public int PerfilTipoId { get; set; }

        public ICollection<ClienteSoporteCompas> ClienteSoporteCompases { get; set; } = new List<ClienteSoporteCompas>();
        public virtual PerfilTipo PerfilTipo { get; set; } = null!;

    }
}
