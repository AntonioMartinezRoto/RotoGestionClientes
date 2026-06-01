using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RotoGestionClientes
{
    [Table("MaquinaMarcas", Schema = "dbo")]
    public class MaquinaMarca
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = null!;

        public string? Modelo { get; set; }

        public ICollection<ClienteMaquina> ClienteMaquinas { get; set; } = new List<ClienteMaquina>();
    }
}
