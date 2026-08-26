using RotoGestionClientes;
using static RotoGestionClientes.Enums;

namespace RotoGestionClientes.UI.Services;

/// <summary>
/// Sesión de la cuenta que ha iniciado sesión en la app (CuentaUsuario), la
/// única persona operando esta instancia de escritorio mientras la ventana
/// esté abierta. Se registra como Singleton (ver Program.cs), igual que
/// VersionDatosState: MainLayout no se reinstancia al navegar ni al hacer
/// login/logout, así que necesita el mismo patrón de evento Changed para
/// enterarse y volver a pintar el AppBar/Drawer o la pantalla de Login.
///
/// No hay token ni expiración: es una app de escritorio de un único usuario
/// por proceso, así que "hay sesión" simplemente dura hasta que se cierra la
/// sesión o se cierra la ventana.
/// </summary>
public class SesionState
{
    public bool EstaAutenticado { get; private set; }
    public int CuentaUsuarioId { get; private set; }
    public string Login { get; private set; } = string.Empty;
    public string NombreMostrado { get; private set; } = string.Empty;
    public Rol Rol { get; private set; }

    // Ver CuentaUsuario.RestringirModulos para la semántica completa.
    private bool _restringirModulos;
    private HashSet<Modulo> _modulosPermitidos = new();

    public event Action? Changed;

    public void IniciarSesion(CuentaUsuario cuenta)
    {
        CuentaUsuarioId = cuenta.Id;
        Login = cuenta.Login;
        NombreMostrado = cuenta.NombreMostrado;
        Rol = Enum.TryParse<Rol>(cuenta.Rol, out var rol) ? rol : Enums.Rol.Usuario;
        _restringirModulos = cuenta.RestringirModulos;
        // cuenta.Permisos debe venir cargado (Include) por quien llame a
        // este método -- ver AuthService.VerificarCredencialesAsync /
        // CambiarPasswordAsync. TryParse descarta silenciosamente cualquier
        // valor que ya no exista en Enums.Modulo (p.ej. un módulo eliminado
        // en una versión futura de la app).
        _modulosPermitidos = cuenta.Permisos
            .Select(p => Enum.TryParse<Modulo>(p.Modulo, out var modulo) ? (Modulo?)modulo : null)
            .Where(m => m.HasValue)
            .Select(m => m!.Value)
            .ToHashSet();
        EstaAutenticado = true;

        Changed?.Invoke();
    }

    public void CerrarSesion()
    {
        EstaAutenticado = false;
        CuentaUsuarioId = 0;
        Login = string.Empty;
        NombreMostrado = string.Empty;
        // Explícito en vez de "default": el valor cero del enum Rol es
        // Administrador, y no queremos que un despiste futuro (comprobar
        // Rol sin comprobar antes EstaAutenticado) conceda privilegios de
        // más justo al cerrar sesión.
        Rol = Enums.Rol.Usuario;
        _restringirModulos = false;
        _modulosPermitidos = new();

        Changed?.Invoke();
    }

    /// <summary>
    /// ¿Puede la sesión actual acceder a este módulo? No sustituye a la
    /// visibilidad por edición (Internal/Distributor/Debug, ver
    /// Layout/MainLayout.razor): cada página combina ambas comprobaciones.
    /// Administrador siempre es true. Sin sesión, siempre false.
    /// </summary>
    public bool TieneAccesoModulo(Modulo modulo)
    {
        if (!EstaAutenticado)
            return false;

        if (Rol == Enums.Rol.Administrador)
            return true;

        if (!_restringirModulos)
            return true;

        return _modulosPermitidos.Contains(modulo);
    }
}
