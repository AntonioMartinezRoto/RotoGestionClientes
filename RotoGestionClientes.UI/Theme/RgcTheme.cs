using MudBlazor;

namespace RotoGestionClientes.UI.Theme;

/// <summary>
/// Tema visual de la aplicación moderna. La paleta de aquí abajo es un punto
/// de partida "profesional" (grafito + acento cálido); en cuanto se disponga
/// de la guía de marca oficial de Roto Frank, basta con cambiar los valores
/// hexadecimales de esta clase para que se propaguen a toda la aplicación.
/// </summary>
public static class RgcTheme
{
    public static readonly MudTheme Theme = new()
    {
        PaletteLight = new PaletteLight
        {
            Primary = "#1F2B44",
            Secondary = "#D5432B",
            AppbarBackground = "#1F2B44",
            AppbarText = "#FFFFFF",
            DrawerBackground = "#FFFFFF",
            DrawerText = "#1F2B44",
            DrawerIcon = "#1F2B44",
            Background = "#F4F6F9",
            Surface = "#FFFFFF",
            Success = "#2E7D32",
            Info = "#0288D1",
            Warning = "#ED6C02",
            Error = "#C62828",
        },
        LayoutProperties = new LayoutProperties
        {
            DefaultBorderRadius = "10px",
            AppbarHeight = "64px",
            DrawerWidthLeft = "290px",
        },
        Typography = new Typography
        {
            Default = new DefaultTypography
            {
                FontFamily = ["Segoe UI", "Roboto", "Helvetica", "Arial", "sans-serif"],
            },
        },
    };
}
