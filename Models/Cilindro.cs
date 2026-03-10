
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RotoGestionClientes
{
    [Table("Cilindro", Schema = "dbo")]
    public class Cilindro
    {
        public int Id { get; set; }
        public int CilindroTipoId { get; set; }
        
        [Required]
        public int MedidaInterior { get; set; }
        
        [Required]
        public int MedidaExterior { get; set; }

        [Required]
        public string Nomenclatura { get; set; } = null!;

        [Required]
        public bool Activa { get; set; } = true;


        // Navigation property
        public virtual CilindroTipo CilindroTipo { get; set; } = null!;
        public ICollection<ClienteCilindro> ClienteCilindros { get; set; } = new List<ClienteCilindro>();
    }
}
