

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RotoGestionClientes
{
    [Table("CilindroTipo", Schema = "dbo")]
    public class CilindroTipo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = null!;

        [Required]
        public bool Activa { get; set; } = true;

        public virtual ICollection<Cilindro> Cilindros { get; set; } = new List<Cilindro>();
    }
}
