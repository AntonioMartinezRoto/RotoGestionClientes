using System.Diagnostics;
using System.Reflection;
using Microsoft.Data.SqlClient;
using RotoGestionClientes.UI.Services;

namespace RotoGestionClientes.Desktop;

/// <summary>
/// Implementación de <see cref="IAppHost"/> para el host WinForms: es lo
/// único que necesitan los componentes Blazor para pedir "ciérrame", saber
/// qué conexión hay configurada o abrir la carpeta de configuración, sin
/// tener que conocer WinForms.
///
/// Recibe la cadena de conexión y la ruta de appsettings.json ya resueltas
/// desde Program.cs (en vez de inyectar IConfiguration por DI) para no tener
/// que registrar IConfiguration en el contenedor solo para este uso.
/// </summary>
internal sealed class DesktopAppHost : IAppHost
{
    private readonly string _rutaConfiguracion;

    public string AppVersion { get; } = ResolveVersion();

    public string InfoConexion { get; }

    public DesktopAppHost(string connectionString, string rutaConfiguracion)
    {
        _rutaConfiguracion = rutaConfiguracion;
        InfoConexion = ResolveInfoConexion(connectionString);
    }

    public void Exit() => Application.Exit();

    public void AbrirCarpetaConfiguracion()
    {
        try
        {
            Process.Start(new ProcessStartInfo("explorer.exe", $"/select,\"{_rutaConfiguracion}\"")
            {
                UseShellExecute = true,
            });
        }
        catch
        {
            // Si por lo que sea no se puede lanzar el Explorador (permisos,
            // entorno restringido...), no dejamos que esto tumbe la app: la
            // ruta del fichero ya se le muestra a la persona en pantalla
            // para que pueda ir a buscarlo a mano.
        }
    }

    private static string ResolveVersion()
    {
        var version = Assembly.GetExecutingAssembly().GetName().Version;
        return $"{version?.Major}.{version?.Minor}.{version?.Build}";
    }

    /// <summary>
    /// Extrae solo Servidor y Base de datos de la cadena de conexión (nunca
    /// usuario/contraseña) para poder mostrarlos en la pantalla de login si
    /// falla la conexión, sin volcar la cadena de conexión completa.
    /// </summary>
    private static string ResolveInfoConexion(string connectionString)
    {
        try
        {
            var builder = new SqlConnectionStringBuilder(connectionString);
            return $"{builder.DataSource} / {builder.InitialCatalog}";
        }
        catch
        {
            return string.Empty;
        }
    }
}
