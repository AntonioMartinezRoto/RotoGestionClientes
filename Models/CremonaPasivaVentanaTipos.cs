using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RotoGestionClientes
{
    [Table("CremonaPasivaVentanaTipos", Schema = "dbo")]
    public class CremonaPasivaVentanaTipos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = null!;

        public ICollection<ClienteCremonaPasivaVentana> ClienteCremonaPasivaVentanas { get; set; } = new List<ClienteCremonaPasivaVentana>();

    }
}
