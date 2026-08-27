using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RotoGestionClientes
{
    /// <summary>
    /// Un módulo (Enums.Modulo) concedido a una cuenta Rol=Usuario, aplicable
    /// solo cuando esa cuenta tiene CuentaUsuario.RestringirModulos = true
    /// (ver esa propiedad para la semántica completa: false = acceso a todo
    /// lo que ya permita la edición de la app, sin mirar esta tabla). Una
    /// cuenta Administrador nunca usa esta tabla: siempre tiene acceso a
    /// todo. Se genera con IDENTITY, igual que CuentaUsuario y
    /// AuditoriaAccion: no es un catálogo cerrado, son filas que crea el
    /// propio Administrador desde CuentaUsuarioEditDialog.
    /// </summary>
    [Table("CuentaUsuarioPermiso", Schema = "dbo")]
    public class CuentaUsuarioPermiso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int CuentaUsuarioId { get; set; }

        /// <summary>
        /// Nombre del enum Enums.Modulo tal cual -- código interno, no texto
        /// a traducir, igual que CuentaUsuario.Rol o AuditoriaAccion.Accion.
        /// </summary>
        [Required]
        public string Modulo { get; set; } = null!;

        public virtual CuentaUsuario? CuentaUsuario { get; set; }
    }
}
