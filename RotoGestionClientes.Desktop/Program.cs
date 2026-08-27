using System.Globalization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using RotoGestionClientes;
using RotoGestionClientes.UI.Services;

namespace RotoGestionClientes.Desktop;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();

        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false)
            .Build();

        var connectionString = configuration.GetConnectionString("DefaultConnection");

        if (string.IsNullOrWhiteSpace(connectionString))
        {
            MessageBox.Show(
                "Falta la cadena de conexión 'DefaultConnection' en appsettings.json.",
                "RGC",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        AplicarIdiomaGuardado(connectionString);

        var services = new ServiceCollection();

        services.AddWindowsFormsBlazorWebView();
        services.AddMudServices();

        services.AddDbContextFactory<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString));

        services.AddSingleton<IAppHost, DesktopAppHost>();
        services.AddSingleton<ClientesListState>();
        services.AddSingleton<VersionDatosState>();
        services.AddSingleton<SesionState>();
        services.AddSingleton<AuthService>();
        services.AddSingleton<AuditoriaService>();

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        Application.Run(new MainForm(services));
    }

    /// <summary>
    /// Aplica el idioma guardado en ConfiguracionAplicacion.Idioma al hilo de
    /// la app, igual que hace LanguageService en la app WinForms actual, para
    /// que los recursos .pt.resx se resuelvan automáticamente en los
    /// distribuidores portugueses.
    /// </summary>
    private static void AplicarIdiomaGuardado(string connectionString)
    {
        try
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(connectionString)
                .Options;

            using var context = new ApplicationDbContext(options);

            var idioma = context.ConfiguracionAplicacion
                .AsNoTracking()
                .Select(x => x.Idioma)
                .FirstOrDefault() ?? "ES";

            var culture = idioma.ToUpperInvariant() switch
            {
                "PT" => new CultureInfo("pt-PT"),
                _ => new CultureInfo("es-ES"),
            };

            CultureInfo.CurrentCulture = culture;
            CultureInfo.CurrentUICulture = culture;
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
        }
        catch
        {
            // Si todavía no hay conexión a BBDD (primer arranque, cadena mal
            // configurada, servidor apagado, etc.) seguimos en español por
            // defecto; el propio menú avisará al no poder cargar datos.
        }
    }
}
