using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RotoGestionClientes
{
    [Table("SoporteMarcoConfig", Schema = "dbo")]
    public class SoporteMarcoConfig
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = null!;

        [Required]
        public bool Activa { get; set; } = true;

        public ICollection<ClienteConfiguracionMaquinas> ClienteConfiguracionMaquinas { get; set; } = new List<ClienteConfiguracionMaquinas>();
    }
}
