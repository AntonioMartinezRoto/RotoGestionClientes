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

        // Se extrae el icono directamente del propio .exe (donde ya queda
        // embebido gracias a <ApplicationIcon> en el .csproj) en vez de
        // depender del fichero .ico suelto en Images\: al publicar como
        // single-file (PublishSingleFile), ese .ico se copia como fichero
        // aparte junto al .exe, y si alguien copia/distribuye solo el .exe
        // pensando que "un solo fichero" significa literalmente eso, la
        // carpeta Images\ no viaja con él, File.Exists(iconPath) da false y
        // la ventana se queda con el icono genérico de WinForms. Extraerlo
        // del propio ejecutable no tiene esa dependencia.
        var icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        if (icon is not null)
        {
            Icon = icon;
        }
        else
        {
            // Red de seguridad por si ExtractAssociatedIcon fallara en algún
            // entorno (permisos, ejecución desde una ruta rara...): se
            // intenta igualmente con el fichero suelto, como antes.
            var iconPath = Path.Combine(AppContext.BaseDirectory, "Images", "RGC_Logo_JAC.ico");
            if (File.Exists(iconPath))
            {
                Icon = new Icon(iconPath);
            }
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
