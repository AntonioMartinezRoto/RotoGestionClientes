using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Required]
        public string AppEdition { get; set; } = "Internal";

        public int? DistribuidorId { get; set; }

        [Required]
        public string Idioma { get; set; } = "ES";
    }
}
