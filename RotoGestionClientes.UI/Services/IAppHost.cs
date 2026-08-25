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
}
