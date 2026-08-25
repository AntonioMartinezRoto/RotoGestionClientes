using System.Reflection;
using RotoGestionClientes.UI.Services;

namespace RotoGestionClientes.Desktop;

/// <summary>
/// Implementación de <see cref="IAppHost"/> para el host WinForms: es lo
/// único que necesitan los componentes Blazor para pedir "ciérrame" sin
/// tener que conocer WinForms.
/// </summary>
internal sealed class DesktopAppHost : IAppHost
{
    public string AppVersion { get; } = ResolveVersion();

    public void Exit() => Application.Exit();

    private static string ResolveVersion()
    {
        var version = Assembly.GetExecutingAssembly().GetName().Version;
        return $"{version?.Major}.{version?.Minor}.{version?.Build}";
    }
}
