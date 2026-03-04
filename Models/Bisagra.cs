using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RotoGestionClientes
{
    [Table("BisagraPuerta", Schema = "dbo")]
    public class Bisagra
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = null!;
        public ICollection<ClienteBisagraPuerta> ClienteBisagraPuertas { get; set; } = new List<ClienteBisagraPuerta>();
        public ICollection<ClienteBisagraPuertaSec> ClienteBisagraPuertasSec { get; set; } = new List<ClienteBisagraPuertaSec>();
    }
}
