using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RotoGestionClientes
{
    /// <summary>
    /// Cuenta de acceso a la aplicación (login), independiente del maestro
    /// dbo.Usuario (que es el "Responsable" que se asigna a un Cliente, sin
    /// contraseña ni rol). Se generan con IDENTITY, igual que Cliente, en vez
    /// del patrón de Id manual (NuevoIdAsync) que usan los maestros del
    /// módulo de Mantenimiento: no son un catálogo "cerrado" sembrado igual
    /// en todas las bases de datos (como PerfilTipo o MaquinaTipos), sino
    /// filas que se crean libremente desde la app en cada instalación.
    /// </summary>
    [Table("CuentaUsuario", Schema = "dbo")]
    public class CuentaUsuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Login { get; set; } = null!;

        [Required]
        public string NombreMostrado { get; set; } = null!;

        /// <summary>
        /// Hash generado con Microsoft.AspNetCore.Identity.PasswordHasher&lt;CuentaUsuario&gt;
        /// (formato V3: PBKDF2-HMACSHA256, 100.000 iteraciones, con sal por
        /// cuenta). Nunca se guarda la contraseña en claro.
        /// </summary>
        [Required]
        public string PasswordHash { get; set; } = null!;

        /// <summary>
        /// Nombre del enum Enums.Rol (Administrador/Usuario) tal cual,
        /// igual que ConfiguracionAplicacion.AppEdition ya guarda el nombre
        /// del enum ApplicationEdition: es un código interno, no un texto a
        /// traducir, así que es el mismo valor en las BBDD ES y PT.
        /// </summary>
        [Required]
        public string Rol { get; set; } = null!;

        [Required]
        public bool Activa { get; set; } = true;

        /// <summary>
        /// Fuerza el cambio de contraseña en el próximo inicio de sesión.
        /// Se activa al crear la cuenta y cada vez que un Administrador le
        /// resetea la contraseña a otra persona.
        /// </summary>
        [Required]
        public bool DebeCambiarPassword { get; set; } = true;

        [Required]
        public DateTime FechaCreacion { get; set; }

        /// <summary>
        /// false (por defecto): esta cuenta tiene acceso a todos los módulos
        /// que ya permita la edición de la app (Internal/Distributor/Debug),
        /// igual que el comportamiento de antes de existir esta columna.
        /// true: el acceso se limita exactamente a los módulos presentes en
        /// Permisos (puede ser ninguno). No se aplica a Rol=Administrador,
        /// que siempre tiene acceso a todo independientemente de este valor.
        /// </summary>
        [Required]
        public bool RestringirModulos { get; set; }

        public virtual ICollection<AuditoriaAccion> AuditoriaAcciones { get; set; } = new List<AuditoriaAccion>();

        public virtual ICollection<CuentaUsuarioPermiso> Permisos { get; set; } = new List<CuentaUsuarioPermiso>();
    }
}
