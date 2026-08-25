namespace RotoGestionClientes.UI.Pages;

/// <summary>
/// DTO de UI para las rejillas de selección múltiple (checkbox) del wizard de
/// Clientes: tipos de perfil, perfiles, manillas, soporte compás, etc.
/// Equivalente a la clase <c>GridItem</c> que en el proyecto legacy vivía
/// dentro de Clientes/PasoDatosGenerales.cs. No es una entidad de BBDD, así
/// que se define aquí (en la UI) en vez de en RotoGestionClientes.Core.
/// </summary>
public class SeleccionableItem
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public bool Selected { get; set; }
}
