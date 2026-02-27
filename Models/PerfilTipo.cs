using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RotoGestionClientes
{
    [Table("PerfilTipo", Schema = "dbo")]
    public class PerfilTipo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = null!;

        public string NombreAbreviado { get; set; } = null!;

        public ICollection<ClientePerfilTipo> ClientePerfilTipos { get; set; } = new List<ClientePerfilTipo>();

    }
}
