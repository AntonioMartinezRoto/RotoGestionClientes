using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RotoGestionClientes
{
    // Maestro con el catálogo de tipos de usuario (Comercial, Distribuidor,
    // Técnico...). Mismo patrón que el resto de maestros de la app
    // (TipoAccion, MaquinaMantenimiento...): Id manual (no IDENTITY, se
    // asigna con NuevoIdAsync<T> en MaestroEditDialog.razor) y Activa para
    // desactivar sin borrar (no se elimina nunca, para no romper el
    // histórico de Usuario que ya lo referencia).
    //
    // EsDistribuidor marca el tipo que corresponde al catálogo de
    // distribuidores (ver Usuario.TipoUsuarioId): el resto de la app usa
    // este flag, no el Id ni el Nombre, para identificar ese papel especial
    // -- excluirlo del selector de comercial de una acción
    // (ClienteAccionEditDialog), auto-asignar
    // ConfiguracionAplicacion.DistribuidorId en la edición Distribuidor...
    // -- así sigue funcionando aunque se renombre o reordene el catálogo
    // desde Mantenimiento. En condiciones normales solo una fila del
    // catálogo debería tener este flag activo.
    [Table("TipoUsuario", Schema = "dbo")]
    public class TipoUsuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = null!;

        [Required]
        public bool EsDistribuidor { get; set; } = false;

        [Required]
        public bool Activa { get; set; } = true;

        public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
    }
}
