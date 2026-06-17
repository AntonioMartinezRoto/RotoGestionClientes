using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class ClienteMaquinaExportDto
    {
        public int MaquinaTipoId { get; set; }

        public string TipoNombre { get; set; }
            = string.Empty;

        public int? MaquinaMarcaId { get; set; }

        public string? MarcaNombre { get; set; }

        public int MaquinaMantenimientoId { get; set; }

        public string MantenimientoNombre { get; set; }
            = string.Empty;

        public string? Observaciones { get; set; }
    }
}
