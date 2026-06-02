using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class MaestroGridItem
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public bool Activa { get; set; }
    }
}
