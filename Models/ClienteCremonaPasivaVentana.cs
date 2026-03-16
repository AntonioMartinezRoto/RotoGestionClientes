
namespace RotoGestionClientes
{
    public class ClienteCremonaPasivaVentana
    {
        public int ClienteId { get; set; }
        public int CremonaPasivaVentanaId { get; set; }

        // Navegación
        public Cliente Cliente { get; set; } = null!;
        public CremonaPasivaVentanaTipos CremonaPasivaVentanaTipo { get; set; } = null!;
    }
}
