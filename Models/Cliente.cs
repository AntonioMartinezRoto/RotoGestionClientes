
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RotoGestionClientes

{
    [Table("Cliente", Schema = "dbo")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = null!;
        public string? Alias { get; set; }
        public string? Comentarios { get; set; }
        public ICollection<ClienteSeguridadVentana> ClienteSeguridadVentanas { get; set; } = new List<ClienteSeguridadVentana>();
        public ICollection<ClientePerfilTipo> ClientePerfilTipos { get; set; } = new List<ClientePerfilTipo>();
        public ICollection<ClienteSoftware> ClienteSoftwares { get; set; } = new List<ClienteSoftware>();
        public ICollection<ClienteManilla> ClienteManillas { get; set; } = new List<ClienteManilla>();
        public ICollection<ClienteSoporteCompas> ClienteSoporteCompases { get; set; } = new List<ClienteSoporteCompas>();
    }
}
