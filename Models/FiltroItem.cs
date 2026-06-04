using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class FiltroItem
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public bool Selected { get; set; }
    }
}
