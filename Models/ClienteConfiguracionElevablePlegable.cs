

namespace RotoGestionClientes
{
    public class ClienteConfiguracionElevablePlegable
    {
        public int ClienteId { get; set; }
        public bool Elevable_Dlo { get; set; }
        public bool Plegable_Consumen { get; set; }

        // Navegación
        public Cliente Cliente { get; set; } = null!;
    }
}
