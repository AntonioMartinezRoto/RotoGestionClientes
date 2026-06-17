using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RotoGestionClientes
{
    [Table("ConfiguracionAplicacion", Schema = "dbo")]
    public class ConfiguracionAplicacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string VersionMaestros { get; set; } = "1.0";
    }
}
