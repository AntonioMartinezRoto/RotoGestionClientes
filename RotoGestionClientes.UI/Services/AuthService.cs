using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RotoGestionClientes;

namespace RotoGestionClientes.UI.Services;

/// <summary>Resultado de comprobar un usuario/contraseña, sin tocar SesionState todavía.</summary>
public sealed record ResultadoVerificacion(bool Exito, bool RequiereCambioPassword, CuentaUsuario? Cuenta);

/// <summary>
/// Verifica credenciales contra dbo.CuentaUsuario y gestiona el cambio de
/// contraseña. Deliberadamente NO establece la sesión (SesionState) por sí
/// solo al verificar: si la cuenta tiene DebeCambiarPassword, Login.razor
/// mantiene a la persona en la pantalla de login hasta que fija una
/// contraseña nueva, y solo entonces se llama a EstablecerSesion. Así nunca
/// hay una ventana en la que se conceda acceso a la app con una contraseña
/// pendiente de cambiar.
///
/// Usa Microsoft.AspNetCore.Identity.PasswordHasher&lt;CuentaUsuario&gt;
/// (PBKDF2-HMACSHA256 con sal por cuenta) en vez de comparar texto plano o
/// un hash simple sin sal.
/// </summary>
public class AuthService
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbFactory;
    private readonly SesionState _sesion;
    private readonly PasswordHasher<CuentaUsuario> _hasher = new();

    public AuthService(IDbContextFactory<ApplicationDbContext> dbFactory, SesionState sesion)
    {
        _dbFactory = dbFactory;
        _sesion = sesion;
    }

    public async Task<ResultadoVerificacion> VerificarCredencialesAsync(string login, string password)
    {
        await using var db = await _dbFactory.CreateDbContextAsync();

        // Include(Permisos): SesionState.IniciarSesion necesita los módulos
        // concedidos para poder resolver el acceso sin volver a la BBDD.
        var cuenta = await db.CuentasUsuario.Include(x => x.Permisos).FirstOrDefaultAsync(x => x.Login == login);
        if (cuenta is null || !cuenta.Activa)
            return new ResultadoVerificacion(false, false, null);

        var verificacion = _hasher.VerifyHashedPassword(cuenta, cuenta.PasswordHash, password);
        if (verificacion == PasswordVerificationResult.Failed)
            return new ResultadoVerificacion(false, false, null);

        if (verificacion == PasswordVerificationResult.SuccessRehashNeeded)
        {
            // PasswordHasher puede pedir "rehash" si cambia el formato/coste
            // por defecto entre versiones del paquete; se regenera con los
            // parámetros actuales sin molestar a la persona que ha iniciado
            // sesión.
            cuenta.PasswordHash = _hasher.HashPassword(cuenta, password);
            await db.SaveChangesAsync();
        }

        return new ResultadoVerificacion(true, cuenta.DebeCambiarPassword, cuenta);
    }

    /// <summary>Fija una contraseña nueva y limpia DebeCambiarPassword. Devuelve la cuenta actualizada.</summary>
    public async Task<CuentaUsuario?> CambiarPasswordAsync(int cuentaUsuarioId, string nuevaPassword)
    {
        await using var db = await _dbFactory.CreateDbContextAsync();

        // Include(Permisos): igual que en VerificarCredencialesAsync, hace
        // falta para que SesionState.IniciarSesion pueda resolver el acceso.
        var cuenta = await db.CuentasUsuario.Include(x => x.Permisos).FirstOrDefaultAsync(x => x.Id == cuentaUsuarioId);
        if (cuenta is null)
            return null;

        cuenta.PasswordHash = _hasher.HashPassword(cuenta, nuevaPassword);
        cuenta.DebeCambiarPassword = false;
        await db.SaveChangesAsync();

        return cuenta;
    }

    /// <summary>Concede acceso: a partir de aquí SesionState.EstaAutenticado pasa a true.</summary>
    public void EstablecerSesion(CuentaUsuario cuenta) => _sesion.IniciarSesion(cuenta);

    public void CerrarSesion() => _sesion.CerrarSesion();
}
