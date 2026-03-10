using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RotoGestionClientes
{
    [Table("Manilla", Schema = "dbo")]
    public class Manilla
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = null!;

        [Required]
        public bool Activa { get; set; } = true;

        public ICollection<ClienteManilla> ClienteManillas { get; set; } = new List<ClienteManilla>();

    }
}
