using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class PerfilTipoDto
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string NombreAbreviado { get; set; } = string.Empty;
    }
}
