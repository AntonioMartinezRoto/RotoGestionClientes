using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RotoGestionClientes
{
    [Table("MaquinaTipos", Schema = "dbo")]
    public class MaquinaTipo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string Descripcion { get; set; } = null!;

        public short Mecaniza { get; set; }
        public short Automatica { get; set; }
        public bool Activa { get; set; }

        public ICollection<ClienteMaquina> ClienteMaquinas { get; set; } = new List<ClienteMaquina>();
    }
}
