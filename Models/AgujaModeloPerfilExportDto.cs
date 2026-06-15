using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class AgujaModeloPerfilExportDto
    {
        public int ModeloId { get; set; }
        public string ModeloName { get; set; } = string.Empty;
        public int PerfilId { get; set; }

        public string PerfilNombre { get; set; } = string.Empty;

        public int AgujaId { get; set; }

        public string AgujaNombre { get; set; } = string.Empty;
    }
}
