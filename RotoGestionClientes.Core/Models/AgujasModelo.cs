using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RotoGestionClientes
{
    [Table("AgujasModelo", Schema = "dbo")]
    public class AgujasModelo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = null!;

        public ICollection<ClienteAgujasModeloPerfil> ClienteAgujasModelos { get; set; } = new List<ClienteAgujasModeloPerfil>();

    }
}
