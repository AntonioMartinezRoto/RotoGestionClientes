using System;
using System.Collections.Generic;
using System.Text;
using static RotoGestionClientes.Enums;

namespace RotoGestionClientes
{
    public class ApplicationSettings
    {
        public ApplicationEdition Edition { get; set; }
        public int ResponsableId { get; set; }
    }
}
