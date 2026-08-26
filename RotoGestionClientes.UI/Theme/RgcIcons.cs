namespace RotoGestionClientes.UI.Theme;

/// <summary>
/// Iconos personalizados (contenido SVG interno, mismo formato que las
/// constantes de MudBlazor.Icons.Material.*) para conceptos donde el icono
/// de Material Design genérico no se parecía lo suficiente al icono que usa
/// la app legacy. Adaptados a partir de los iconos reales embebidos en
/// Mantenimiento/MantenimientoMain.resx (btn_Perfiles.Image, btn_Manillas.Image,
/// btn_Bisagras.Image): se ha rehecho el mismo concepto visual como icono de
/// líneas al estilo Material (trazo, 24x24) en vez de reutilizar los mapas de
/// bits originales (32x32/40x32), que se verían borrosos junto al resto de
/// iconos vectoriales de la aplicación.
/// Usados en Pages/Mantenimiento.razor y Pages/Informes.razor.
/// </summary>
public static class RgcIcons
{
    /// <summary>Perfil de ventana/puerta con línea de cota (adaptado del dibujo de sección con flechas de medida de btn_Perfiles.Image).</summary>
    public const string Perfiles = "<g fill=\"none\" stroke=\"currentColor\" stroke-width=\"1.6\" stroke-linecap=\"round\" stroke-linejoin=\"round\"><rect x=\"5\" y=\"10\" width=\"14\" height=\"9\" rx=\"1\"/><line x1=\"5\" y1=\"6\" x2=\"19\" y2=\"6\"/><line x1=\"5\" y1=\"4.5\" x2=\"5\" y2=\"7.5\"/><line x1=\"19\" y1=\"4.5\" x2=\"19\" y2=\"7.5\"/><line x1=\"12\" y1=\"6\" x2=\"12\" y2=\"10\"/></g>";

    /// <summary>Manilla (placa + palanca), adaptada del icono de manilla/bombín de btn_Manillas.Image.</summary>
    public const string Manillas = "<g fill=\"none\" stroke=\"currentColor\" stroke-width=\"1.6\" stroke-linecap=\"round\" stroke-linejoin=\"round\"><rect x=\"4\" y=\"5\" width=\"4\" height=\"14\" rx=\"1.5\"/><path d=\"M8 12h8c1.4 0 2.5 1.1 2.5 2.5\"/><circle cx=\"6\" cy=\"16\" r=\"0.9\" fill=\"currentColor\" stroke=\"none\"/></g>";

    /// <summary>Bisagra (dos hojas + pasador), adaptada del icono de bisagra de btn_Bisagras.Image.</summary>
    public const string Bisagras = "<g fill=\"none\" stroke=\"currentColor\" stroke-width=\"1.6\" stroke-linecap=\"round\" stroke-linejoin=\"round\"><rect x=\"4\" y=\"4\" width=\"5\" height=\"16\" rx=\"1\"/><rect x=\"15\" y=\"4\" width=\"5\" height=\"16\" rx=\"1\"/><circle cx=\"12\" cy=\"7\" r=\"1.1\" fill=\"currentColor\" stroke=\"none\"/><circle cx=\"12\" cy=\"12\" r=\"1.1\" fill=\"currentColor\" stroke=\"none\"/><circle cx=\"12\" cy=\"17\" r=\"1.1\" fill=\"currentColor\" stroke=\"none\"/></g>";
}
