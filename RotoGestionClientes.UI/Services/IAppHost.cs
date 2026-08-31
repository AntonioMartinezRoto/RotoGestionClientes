namespace RotoGestionClientes.UI.Services;

/// <summary>
/// Pequeño puente entre los componentes Blazor y la ventana WinForms que los
/// aloja, para acciones que solo tienen sentido a nivel de aplicación de
/// escritorio (cerrar la ventana, etc.). La implementación real la registra
/// el proyecto host (RotoGestionClientes.Desktop); esta librería no depende
/// de WinForms en ningún momento.
/// </summary>
public interface IAppHost
{
    /// <summary>Nombre/versión del ensamblado que se muestra en la barra de estado.</summary>
    string AppVersion { get; }

    /// <summary>Cierra la aplicación.</summary>
    void Exit();

    /// <summary>
    /// Servidor y base de datos tomados de la cadena de conexión configurada
    /// (nunca usuario/contraseña). Se muestra en la pantalla de login si
    /// falla la conexión a la BBDD, para dar contexto de qué se ha
    /// configurado sin volcar la cadena de conexión completa.
    /// </summary>
    string InfoConexion { get; }

    /// <summary>
    /// Abre el Explorador de Windows con el appsettings.json en uso ya
    /// seleccionado, para poder revisar/corregir la cadena de conexión sin
    /// tener que ir a buscar el fichero a mano.
    /// </summary>
    void AbrirCarpetaConfiguracion();
}
