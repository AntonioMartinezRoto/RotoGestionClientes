using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class MaquinaTipoDto
    {
        public int Id { get; set; }

        public string Descripcion { get; set; } = string.Empty;

        public bool Activa { get; set; }
    }
}
