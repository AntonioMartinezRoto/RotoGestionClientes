namespace RotoGestionClientes.UI.Services;

/// <summary>
/// Estado del listado de clientes (filtro de búsqueda) que sobrevive a la
/// navegación dentro de la app. Blazor Hybrid crea una instancia nueva de
/// Clientes.razor cada vez que se navega a "/clientes" (p.ej. al volver de
/// editar un cliente), así que un campo normal del componente se perdía. Al
/// registrarse como Singleton en el único ServiceCollection de por vida de la
/// app (ver Program.cs), este servicio conserva el filtro entre navegaciones.
/// </summary>
public class ClientesListState
{
    public string Filtro { get; set; } = string.Empty;
}
