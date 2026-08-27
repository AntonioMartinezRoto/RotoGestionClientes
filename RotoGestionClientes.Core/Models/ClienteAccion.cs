using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RotoGestionClientes
{
    // Acción registrada sobre un cliente ya existente (visita comercial,
    // puesta en marcha, soporte telefónico...). A diferencia de los
    // maestros, esta es una tabla de tipo "evento" -- puede haber muchas
    // filas por cliente -- así que usa Id IDENTITY, igual que
    // ClienteMaquina/ClienteDocumento.
    //
    // Fecha es la fecha de negocio en la que ocurrió la acción (editable
    // por el usuario), y FechaFin es opcional para acciones que se
    // extienden varios días (p.ej. una puesta en marcha de 3 días). Las
    // horas invertidas se introducen siempre a mano en HorasInvertidas: no
    // se calculan a partir del rango de fechas, para que sirvan igual de
    // bien para una llamada de soporte de 30 minutos que para varios días
    // de trabajo.
    //
    // No se guarda aquí un FechaAlta/usuario-de-alta propio: la
    // trazabilidad de quién creó/modificó el registro y cuándo ya la cubre
    // el log genérico AuditoriaAccion (ver AuditoriaService.Registrar),
    // igual que en el resto de la aplicación.
    [Table("ClienteAccion", Schema = "dbo")]
    public class ClienteAccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int ClienteId { get; set; }

        [Required]
        public int TipoAccionId { get; set; }

        // Usuario "comercial" al que se atribuye la acción -- catálogo
        // Usuario (el mismo que Cliente.Responsable), no la cuenta de
        // login CuentaUsuario. Seleccionable, por defecto el responsable
        // del cliente si lo tiene.
        [Required]
        public int ComercialUsuarioId { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        public DateTime? FechaFin { get; set; }

        // Opcional: una acción de un solo día (p.ej. una visita) puede
        // registrarse solo con Fecha, sin horas ni fecha fin.
        public decimal? HorasInvertidas { get; set; }

        public string? Observaciones { get; set; }

        // Permite ocultar una acción dada de alta por error sin perder el
        // histórico ni romper las claves foráneas -- mismo espíritu que
        // Activa en los maestros, pero aquí es "desactivar este registro
        // de evento", no "desactivar esta opción del catálogo".
        [Required]
        public bool Activa { get; set; } = true;

        public virtual Cliente Cliente { get; set; } = null!;
        public virtual TipoAccion TipoAccion { get; set; } = null!;
        public virtual Usuario ComercialUsuario { get; set; } = null!;
    }
}
