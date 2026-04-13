

namespace RotoGestionClientes
{
    public class ClienteCilindroCorredera
    {
        public int ClienteId { get; set; }
        public bool Cilindro { get; set; }

        // Navegación
        public Cliente Cliente { get; set; } = null!;
    }
}

