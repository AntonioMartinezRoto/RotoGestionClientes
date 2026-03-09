using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RotoGestionClientes
{
    [Table("CerraduraPuertaSec", Schema = "dbo")]
    public class CerraduraPuertaSec
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = null!;
        public ICollection<ClienteCerraduraPuertaSec> ClienteCerradurasPuertaSec { get; set; } = new List<ClienteCerraduraPuertaSec>();
    }
}
