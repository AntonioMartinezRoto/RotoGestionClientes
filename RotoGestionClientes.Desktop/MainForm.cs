using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using RotoGestionClientes.UI;

namespace RotoGestionClientes.Desktop;

/// <summary>
/// Ventana anfitriona: un único BlazorWebView a pantalla completa. Toda la
/// UI real (menú, y en el futuro el resto de módulos) vive en
/// RotoGestionClientes.UI como componentes Blazor normales.
///
/// A diferencia del Main.cs actual (FormBorderStyle.FixedSingle, tamaño
/// fijo), esta ventana es redimensionable: el layout de MudBlazor reacciona
/// al ancho disponible en vez de recortarse.
/// </summary>
public sealed class MainForm : Form
{
    public MainForm(IServiceCollection services)
    {
        Text = "RGC";
        MinimumSize = new Size(1024, 650);
        StartPosition = FormStartPosition.CenterScreen;
        WindowState = FormWindowState.Maximized;

        var iconPath = Path.Combine(AppContext.BaseDirectory, "Images", "RGC_Logo_JAC.ico");
        if (File.Exists(iconPath))
        {
            Icon = new Icon(iconPath);
        }

        var blazorWebView = new BlazorWebView
        {
            Dock = DockStyle.Fill,
            HostPage = "wwwroot\\index.html",
        };

        blazorWebView.RootComponents.Add<App>("#app");
        blazorWebView.Services = services.BuildServiceProvider();

        Controls.Add(blazorWebView);
    }
}
