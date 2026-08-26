namespace RotoGestionClientes.UI.Services;

/// <summary>
/// Estado compartido de la versión de datos maestros (ConfiguracionAplicacion.
/// VersionMaestros), mostrada en la cabecera de la app (MainLayout). Se
/// registra como Singleton en el único ServiceCollection de por vida de la
/// app (ver Program.cs) para que, al guardar un maestro en cualquier parte
/// de la app (MaestroEditDialog), la cabecera se refresque al instante sin
/// necesidad de recargar la página — MainLayout no se reinstancia al
/// navegar, así que un simple campo local no se enteraría del cambio.
/// </summary>
public class VersionDatosState
{
    public string? Version { get; private set; }

    public event Action? Changed;

    public void Establecer(string? version)
    {
        Version = version;
        Changed?.Invoke();
    }
}
