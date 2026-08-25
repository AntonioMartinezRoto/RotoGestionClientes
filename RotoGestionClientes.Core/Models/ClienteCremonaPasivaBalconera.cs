
namespace RotoGestionClientes
{
    public class ClienteCremonaPasivaBalconera

    {
        public int ClienteId { get; set; }
        public int CremonaPasivaBalconeraId { get; set; }

        // Navegación
        public Cliente Cliente { get; set; } = null!;
        public CremonaPasivaVentanaTipos CremonaPasivaBalconeraTipo { get; set; } = null!;
    }
}
