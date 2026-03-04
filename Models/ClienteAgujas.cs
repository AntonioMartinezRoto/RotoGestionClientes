using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class ClienteAgujas
    {
        public int ClienteId { get; set; }

        public int? AgujaBalconeraId { get; set; }
        public int? AgujaPuertaSecId { get; set; }
        public int? AgujaPuertaId { get; set; }

        public virtual Cliente Cliente { get; set; } = null!;

        public virtual Aguja? AgujaBalconera { get; set; }
        public virtual Aguja? AgujaPuertaSec { get; set; }
        public virtual Aguja? AgujaPuerta { get; set; }
    }
}
