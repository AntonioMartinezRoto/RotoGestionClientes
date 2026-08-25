
namespace RotoGestionClientes
{
    public class ClienteCilindro
    {
        public int ClienteId { get; set; }
        public int CilindroId { get; set; }

        // Navegación
        public Cliente Cliente { get; set; } = null!;
        public Cilindro Cilindro { get; set; } = null!;
    }
}
