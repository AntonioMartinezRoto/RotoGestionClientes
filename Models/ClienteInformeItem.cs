using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class ClienteInformeItem
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Software { get; set; } = string.Empty;

        public string Perfiles { get; set; } = string.Empty;

    }
}