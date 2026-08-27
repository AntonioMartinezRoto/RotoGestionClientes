using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RotoGestionClientes
{
    // Maestro con el catálogo de tipos de acción que se pueden registrar
    // sobre un cliente (Visita comercial, Puesta en marcha, Soporte
    // telefónico, Actualización...). Mismo patrón que el resto de maestros
    // de la app (MaquinaMantenimiento, Manilla, etc.): Id manual (no
    // IDENTITY, se asigna con NuevoIdAsync<T> en MaestroEditDialog.razor) y
    // Activa para desactivar sin borrar (no se elimina nunca, para no
    // romper el histórico de ClienteAccion que ya lo referencian).
    [Table("TipoAccion", Schema = "dbo")]
    public class TipoAccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = null!;

        [Required]
        public bool Activa { get; set; } = true;

        public virtual ICollection<ClienteAccion> ClienteAcciones { get; set; } = new List<ClienteAccion>();
    }
}
