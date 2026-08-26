using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RotoGestionClientes
{
    /// <summary>
    /// Histórico de acciones sobre las tablas maestras (módulo de
    /// Mantenimiento) y sobre Cliente (alta, modificación, baja). Se rellena
    /// desde RotoGestionClientes.UI.Services.AuditoriaService, nunca a mano.
    ///
    /// CuentaUsuarioId es nullable y sin cascada de borrado: si más adelante
    /// se elimina una cuenta, su histórico de auditoría no debe desaparecer
    /// ni bloquear el borrado. Por eso UsuarioNombre se guarda también como
    /// texto plano en el momento de la acción (no solo el Id): el registro
    /// tiene que seguir siendo legible aunque la cuenta cambie de nombre o
    /// se borre después.
    ///
    /// Entidad es texto libre (no un enum en BBDD) a propósito, siguiendo el
    /// mismo patrón que ConfiguracionAplicacion.AppEdition: en código se
    /// rellena con Enums.MaestroTipo.ToString() para los maestros o con el
    /// literal "Cliente", pero mantenerlo como NVARCHAR evita tener que
    /// tocar el esquema si en el futuro se audita alguna entidad más.
    /// </summary>
    [Table("AuditoriaAccion", Schema = "dbo")]
    public class AuditoriaAccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime FechaHora { get; set; }

        public int? CuentaUsuarioId { get; set; }

        [Required]
        public string UsuarioNombre { get; set; } = null!;

        [Required]
        public string Entidad { get; set; } = null!;

        public int? EntidadId { get; set; }

        /// <summary>Nombre del enum Enums.AuditoriaAccionTipo (Crear/Modificar/Eliminar).</summary>
        [Required]
        public string Accion { get; set; } = null!;

        public string? Detalle { get; set; }

        public virtual CuentaUsuario? CuentaUsuario { get; set; }
    }
}
