using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RotoGestionClientes
{
    [Table("ClienteMaquina", Schema = "dbo")]
    public class ClienteMaquina
    {
        [Key]
        public int Id { get; set; }

        public int ClienteId { get; set; }
        public int MaquinaTipoId { get; set; }
        public int? MaquinaMarcaId { get; set; }
        public int MaquinaMantenimientoId { get; set; }

        public string? Observaciones { get; set; }

        // Navegación
        public Cliente Cliente { get; set; } = null!;
        public MaquinaTipo MaquinaTipo { get; set; } = null!;
        public MaquinaMarca? MaquinaMarca { get; set; }
        public MaquinaMantenimiento MaquinaMantenimiento { get; set; } = null!;
    }
}
