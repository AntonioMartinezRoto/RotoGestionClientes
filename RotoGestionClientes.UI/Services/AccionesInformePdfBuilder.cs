using PdfSharpCore.Drawing;
using PdfSharpCore.Fonts;
using PdfSharpCore.Pdf;
using RotoGestionClientes.UI.Resources;

namespace RotoGestionClientes.UI.Services;

/// <summary>
/// Genera el PDF del botón "Exportar a PDF" de Pages/InformeAcciones.razor:
/// una cabecera con el resumen de filtros aplicados, seguida de cada gráfico
/// (capturado como PNG en el navegador por wwwroot/js/rgc-graficos.js) en su
/// propia sección, uno debajo de otro, paginando automáticamente cuando no
/// cabe más contenido. Mismo patrón "cursor + XGraphics dibujado a mano" que
/// ClienteResumenPdfBuilder, simplificado porque aquí no hace falta el listado
/// de campos etiqueta/valor -- solo un título y una imagen por gráfico.
///
/// Se usa PdfSharpCore (licencia MIT), igual que ClienteResumenPdfBuilder --
/// ver el comentario de esa clase para la justificación completa frente a
/// QuestPDF/iText.
/// </summary>
public static class AccionesInformePdfBuilder
{
    private const double MargenIzquierdo = 40;
    private const double MargenDerecho = 40;
    private const double MargenSuperior = 40;
    private const double MargenInferior = 44;

    // Misma paleta corporativa que ClienteResumenPdfBuilder (Theme/RgcTheme.cs).
    private static readonly XColor ColorPrimario = XColor.FromArgb(31, 43, 68);        // #1F2B44
    private static readonly XColor ColorSecundario = XColor.FromArgb(213, 67, 43);     // #D5432B
    private static readonly XColor ColorGris = XColor.FromArgb(110, 110, 110);

    private static readonly XBrush PincelPrimario = new XSolidBrush(ColorPrimario);
    private static readonly XBrush PincelGris = new XSolidBrush(ColorGris);
    private static readonly XPen PlumaPrimaria = new XPen(ColorPrimario, 1.4);
    private static readonly XPen PlumaSecundaria = new XPen(ColorSecundario, 1.8);

    public static byte[] Construir(IReadOnlyList<(string Titulo, byte[] Png)> graficos, string resumenFiltros)
    {
        AsegurarFontResolver();

        var document = new PdfDocument();
        var c = new Cursor(document);

        try
        {
            EscribirEncabezado(c, resumenFiltros);

            foreach (var (titulo, png) in graficos)
                EscribirGrafico(c, titulo, png);
        }
        finally
        {
            c.Gfx.Dispose();
        }

        EscribirPiePagina(document);

        using var ms = new MemoryStream();
        document.Save(ms, false);
        return ms.ToArray();
    }

    private static void EscribirEncabezado(Cursor c, string resumenFiltros)
    {
        var yInicio = c.Y;

        c.Gfx.DrawString(MenuTextos.InformeAcciones.ToUpperInvariant(), c.FuenteSubtitulo, PincelGris, new XPoint(MargenIzquierdo, yInicio + 10));
        c.Gfx.DrawString(MenuTextos.InformeAcciones, c.FuenteTitulo, PincelPrimario, new XPoint(MargenIzquierdo, yInicio + 28));
        c.Gfx.DrawString(DateTime.Now.ToString("dd/MM/yyyy HH:mm"), c.FuenteSubtitulo, PincelGris, new XPoint(MargenIzquierdo, yInicio + 44));

        c.Y = yInicio + 52;

        c.Gfx.DrawString(resumenFiltros, c.FuenteTexto, XBrushes.Black, new XPoint(MargenIzquierdo, c.Y));
        c.Y += 18;

        c.Gfx.DrawLine(PlumaPrimaria, MargenIzquierdo, c.Y, c.AnchoPagina - MargenDerecho, c.Y);
        c.Y += 18;
    }

    private static void EscribirGrafico(Cursor c, string titulo, byte[] png)
    {
        XImage imagen;
        try
        {
            imagen = XImage.FromStream(() => new MemoryStream(png));
        }
        catch
        {
            // Un gráfico que no se pudo capturar (p.ej. el navegador no
            // devolvió PNG) no debe tumbar la generación del resto del PDF.
            return;
        }

        using (imagen)
        {
            var anchoContenido = c.AnchoPagina - MargenIzquierdo - MargenDerecho;
            var altoImagen = anchoContenido * imagen.PixelHeight / (double)imagen.PixelWidth;

            // Si el título + la imagen a ancho completo no caben enteros en
            // lo que queda de página, se pasa a una nueva antes de dibujar
            // el título, para que nunca quede "huérfano" al final de una
            // página con la imagen empezando en la siguiente.
            c.AsegurarEspacio(30 + altoImagen);

            c.Gfx.DrawString(titulo, c.FuenteSeccion, PincelPrimario, new XPoint(MargenIzquierdo, c.Y + 12));
            c.Y += 20;
            c.Gfx.DrawLine(PlumaSecundaria, MargenIzquierdo, c.Y, c.AnchoPagina - MargenDerecho, c.Y);
            c.Y += 10;

            c.Gfx.DrawImage(imagen, MargenIzquierdo, c.Y, anchoContenido, altoImagen);
            c.Y += altoImagen + 20;
        }
    }

    // Pie de página con "página actual/total", dibujado en una segunda
    // pasada sobre TODAS las páginas ya generadas (hace falta conocer el
    // total, que solo se sabe una vez terminado todo el contenido).
    private static void EscribirPiePagina(PdfDocument document)
    {
        var fuente = new XFont("Arial", 8, XFontStyle.Regular);
        var total = document.Pages.Count;

        for (var i = 0; i < total; i++)
        {
            var page = document.Pages[i];
            using var gfx = XGraphics.FromPdfPage(page);

            double anchoPagina = page.Width;
            double altoPagina = page.Height;

            var yLinea = altoPagina - MargenInferior + 8;
            gfx.DrawLine(PlumaPrimaria, MargenIzquierdo, yLinea, anchoPagina - MargenDerecho, yLinea);

            var yTexto = yLinea + 14;
            gfx.DrawString(MenuTextos.InformeAcciones, fuente, PincelGris, new XPoint(MargenIzquierdo, yTexto));

            var textoPagina = $"{i + 1}/{total}";
            var anchoTexto = gfx.MeasureString(textoPagina, fuente).Width;
            gfx.DrawString(textoPagina, fuente, PincelGris, new XPoint(anchoPagina - MargenDerecho - anchoTexto, yTexto));
        }
    }

    private static void AsegurarFontResolver()
    {
        // GlobalFontSettings.FontResolver lanza si se reasigna una vez
        // usado, y es estático a nivel de proceso: se comprueba si YA está
        // configurado (por este builder o por ClienteResumenPdfBuilder, que
        // usa el mismo mecanismo) en vez de llevar un flag propio, para que
        // no importe cuál de los dos builders genera un PDF primero.
        if (GlobalFontSettings.FontResolver is not null)
            return;

        GlobalFontSettings.FontResolver = new AccionesPdfFontResolver();
    }

    /// <summary>
    /// Cursor mutable con la página/gráfico PDF actuales y la posición
    /// vertical de escritura. Añade una página nueva automáticamente en
    /// cuanto el contenido no cabe en la actual. Misma idea que el Cursor de
    /// ClienteResumenPdfBuilder, sin duplicarlo literalmente porque aquí no
    /// hace falta la fuente en negrita para etiquetas.
    /// </summary>
    private sealed class Cursor
    {
        private readonly PdfDocument _document;

        public Cursor(PdfDocument document)
        {
            _document = document;

            FuenteTitulo = new XFont("Arial", 17, XFontStyle.Bold);
            FuenteSubtitulo = new XFont("Arial", 8, XFontStyle.Regular);
            FuenteSeccion = new XFont("Arial", 12, XFontStyle.Bold);
            FuenteTexto = new XFont("Arial", 9.5, XFontStyle.Regular);

            NuevaPagina();
        }

        public XGraphics Gfx { get; private set; } = null!;
        public double Y { get; set; }
        public double AnchoPagina { get; private set; }
        public double AltoPagina { get; private set; }

        public XFont FuenteTitulo { get; }
        public XFont FuenteSubtitulo { get; }
        public XFont FuenteSeccion { get; }
        public XFont FuenteTexto { get; }

        public void AsegurarEspacio(double alturaNecesaria)
        {
            if (Y + alturaNecesaria <= AltoPagina - MargenInferior)
                return;

            Gfx.Dispose();
            NuevaPagina();
        }

        private void NuevaPagina()
        {
            var page = _document.AddPage();
            AnchoPagina = page.Width;
            AltoPagina = page.Height;
            Gfx = XGraphics.FromPdfPage(page);
            Y = MargenSuperior;
        }
    }

    /// <summary>
    /// Resuelve las fuentes leyendo directamente los .ttf de la carpeta de
    /// fuentes de Windows -- misma idea que RgcPdfFontResolver en
    /// ClienteResumenPdfBuilder.cs, duplicada aquí (en vez de compartida)
    /// porque esa clase es privada a su propio fichero.
    /// </summary>
    private sealed class AccionesPdfFontResolver : IFontResolver
    {
        public string DefaultFontName => "Arial";

        public byte[] GetFont(string faceName)
        {
            var carpetaFuentes = Environment.GetFolderPath(Environment.SpecialFolder.Fonts);
            var ruta = Path.Combine(carpetaFuentes, faceName);
            return File.ReadAllBytes(ruta);
        }

        public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
        {
            var faceName = (isBold, isItalic) switch
            {
                (true, true) => "arialbi.ttf",
                (true, false) => "arialbd.ttf",
                (false, true) => "ariali.ttf",
                _ => "arial.ttf",
            };

            return new FontResolverInfo(faceName);
        }
    }
}
