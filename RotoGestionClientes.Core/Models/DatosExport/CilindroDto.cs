using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class CilindroDto
    {
        public int Id { get; set; }

        public string Nomenclatura { get; set; } = string.Empty;

        public bool Activa { get; set; }
    }
}
