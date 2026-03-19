
namespace RotoGestionClientes
{
    public class ClienteAgujasCorredera
    {
        public int ClienteId { get; set; }
        public int AgujaCorrederaId { get; set; }

        // Navegación
        public Cliente Cliente { get; set; } = null!;
        public AgujasCorredera AgujasCorredera{ get; set; } = null!;
    }
}
