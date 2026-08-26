using PdfSharpCore.Drawing;
using PdfSharpCore.Fonts;
using PdfSharpCore.Pdf;
using RotoGestionClientes.UI.Resources;
using static RotoGestionClientes.Enums;

namespace RotoGestionClientes.UI.Services;

/// <summary>
/// Genera el PDF del botón "Exportar a PDF" de Pages/ClienteResumen.razor,
/// con el mismo contenido y el mismo orden de secciones que se ve en
/// pantalla (Datos generales, Ventanas, Balconeras, Puertas, Correderas,
/// Elevables/Plegables, Máquinas, Documentos), con un aspecto corporativo:
/// logotipo de Roto en la cabecera, paleta de color de RgcTheme.cs, bloques
/// con banda de fondo + subrayado e icono representativo (las mismas
/// imágenes en miniatura que ya se ven en la pantalla de resumen), etiquetas
/// en negrita distinguidas del valor, y pie de página con número de página.
///
/// Se usa PdfSharpCore (licencia MIT, sin ningún límite ligado a los
/// ingresos de la empresa) en vez de librerías como QuestPDF (gratuita solo
/// por debajo de un umbral de ingresos anuales) o iText (AGPL o licencia de
/// pago). El documento se dibuja "a mano" con XGraphics -- un cursor
/// vertical que va escribiendo líneas de texto y añade página nueva en
/// cuanto no cabe más contenido -- en vez de con una librería de maquetación.
/// </summary>
public static class ClienteResumenPdfBuilder
{
    private const double MargenIzquierdo = 40;
    private const double MargenDerecho = 40;
    private const double MargenSuperior = 40;
    private const double MargenInferior = 44;

    private const double AltoLinea = 14;
    private const double AltoBandaSeccion = 24;
    private const double AltoIconoSeccion = 18;
    private const double AltoLogoEncabezado = 40;

    // Paleta corporativa (Theme/RgcTheme.cs): mismo azul/rojo que el resto
    // de la aplicación, para que el PDF se sienta parte de la misma
    // identidad visual en vez de un documento genérico aparte.
    private static readonly XColor ColorPrimario = XColor.FromArgb(31, 43, 68);        // #1F2B44
    private static readonly XColor ColorSecundario = XColor.FromArgb(213, 67, 43);     // #D5432B
    private static readonly XColor ColorFondoSeccion = XColor.FromArgb(244, 246, 249); // #F4F6F9
    private static readonly XColor ColorGris = XColor.FromArgb(110, 110, 110);

    private static readonly XBrush PincelPrimario = new XSolidBrush(ColorPrimario);
    private static readonly XBrush PincelGris = new XSolidBrush(ColorGris);
    private static readonly XBrush PincelFondoSeccion = new XSolidBrush(ColorFondoSeccion);
    private static readonly XPen PlumaPrimaria = new XPen(ColorPrimario, 1.4);
    private static readonly XPen PlumaSecundaria = new XPen(ColorSecundario, 1.8);

    public static byte[] Construir(ClienteResumenDto dto, bool mostrarResponsable)
    {
        AsegurarFontResolver();

        using var recursos = new RecursosGraficos();
        var document = new PdfDocument();
        var c = new Cursor(document);

        try
        {
            EscribirEncabezado(c, recursos, dto.Nombre);

            EscribirSeccion(c, MenuTextos.DatosGenerales, null, () =>
            {
                EscribirCampo(c, MenuTextos.SapId, TextoOVacio(dto.SapId));
                EscribirCampo(c, MenuTextos.Alias, TextoOVacio(dto.Alias));
                if (mostrarResponsable)
                    EscribirCampo(c, MenuTextos.Responsable, TextoOVacio(dto.ResponsableNombre));
                EscribirCampo(c, MenuTextos.Software, TextoLista(dto.Softwares));
                EscribirCampo(c, MenuTextos.TipoPerfil, TextoLista(dto.PerfilTipos));
                EscribirCampo(c, MenuTextos.Perfiles, TextoLista(dto.Perfiles));
                EscribirCampo(c, MenuTextos.Manillas, TextoLista(dto.Manillas));
                EscribirCampo(c, MenuTextos.SoporteCompas, TextoLista(dto.SoporteCompas));
                EscribirObservaciones(c, MenuTextos.Comentarios, dto.Comentarios);
                EscribirObservaciones(c, MenuTextos.ObservacionesParalelas, dto.ObservacionesParalelas);
            });

            EscribirSeccion(c, MenuTextos.Ventanas, recursos.Ventanas, () =>
            {
                EscribirCampo(c, $"{MenuTextos.Oscilobatientes} - {MenuTextos.Seguridad}", TextoLista(dto.SeguridadVentanas));
                EscribirCampo(c, $"{MenuTextos.Oscilobatientes} - {MenuTextos.HojaPasiva}", TextoLista(dto.CremonaPasivaVentanas));
                EscribirCampo(c, $"{MenuTextos.Practicables} - {MenuTextos.HojaPasiva}", TextoLista(dto.CremonaPasivaVentanasPract));
                EscribirObservaciones(c, MenuTextos.Comentarios, dto.ObservacionesVentanas);
            });

            EscribirSeccion(c, MenuTextos.Balconeras, recursos.Balconeras, () =>
            {
                EscribirCampo(c, MenuTextos.Seguridad, TextoLista(dto.SeguridadBalconeras));
                EscribirCampo(c, MenuTextos.HojaPasiva, TextoLista(dto.CremonaPasivaBalconeras));
                EscribirCampo(c, MenuTextos.Aguja, FormatearAguja(dto.AgujaBalconera));
                EscribirCampo(c, $"{MenuTextos.PuertaSecundaria} - {MenuTextos.Bisagras}", TextoLista(dto.BisagrasPuertaSec));
                EscribirCampo(c, $"{MenuTextos.PuertaSecundaria} - {MenuTextos.Cerraduras}", TextoLista(dto.CerradurasPuertaSec));
                EscribirCampo(c, $"{MenuTextos.PuertaSecundaria} - {MenuTextos.Aguja}", FormatearAguja(dto.AgujaPuertaSec));
                EscribirObservaciones(c, MenuTextos.Comentarios, dto.ObservacionesBalconeras);
            });

            EscribirSeccion(c, MenuTextos.Puertas, recursos.Puertas, () =>
            {
                EscribirCampo(c, MenuTextos.Bisagras, TextoLista(dto.BisagrasPuerta));
                EscribirCampo(c, MenuTextos.Cerraduras, TextoLista(dto.CerradurasPuerta));
                EscribirCampo(c, MenuTextos.Aguja, FormatearAguja(dto.AgujaPuerta));
                EscribirCampo(c, MenuTextos.PorteroElectrico, TextoSiNo(dto.PorteroElectrico));

                var textoCilindros = TextoSiNo(dto.Cilindro);
                if (dto.Cilindro && dto.Cilindros.Count > 0)
                    textoCilindros += $" ({TextoLista(dto.Cilindros)})";
                EscribirCampo(c, MenuTextos.Cilindros, textoCilindros);

                EscribirObservaciones(c, MenuTextos.Comentarios, dto.ObservacionesPuertas);
            });

            EscribirSeccion(c, MenuTextos.Correderas, recursos.Correderas, () =>
            {
                EscribirCampo(c, MenuTextos.Aguja, TextoLista(dto.AgujasCorredera));
                EscribirCampo(c, MenuTextos.Bombillo, TextoSiNo(dto.CilindroCorredera));
                EscribirObservaciones(c, MenuTextos.Comentarios, dto.ObservacionesCorrederas);
            });

            EscribirSeccion(c, MenuTextos.ElevablesPlegables, recursos.Elevables, () =>
            {
                if (dto.TieneConfigElevablePlegable)
                {
                    EscribirCampo(c, MenuTextos.Estandar, TextoSiNo(dto.Elevable_Estandar));
                    EscribirCampo(c, MenuTextos.Dlo, TextoSiNo(dto.Elevable_Dlo));
                    EscribirCampo(c, MenuTextos.Consumen, TextoSiNo(dto.Plegable_Consumen));
                }
                else
                {
                    EscribirCampo(c, string.Empty, MenuTextos.Ninguno);
                }

                EscribirObservaciones(c, MenuTextos.Elevables, dto.ObservacionesElevables);
                EscribirObservaciones(c, MenuTextos.Plegables, dto.ObservacionesPlegables);
            });

            EscribirSeccion(c, MenuTextos.Maquinas, recursos.Maquinas, () =>
            {
                if (dto.Maquinas.Count == 0)
                {
                    EscribirCampo(c, string.Empty, MenuTextos.SinMaquinas);
                }
                else
                {
                    foreach (var maquina in dto.Maquinas)
                    {
                        var detalle = $"{MenuTextos.Marca}: {TextoOVacio(maquina.Marca)} - {MenuTextos.Mantenimiento}: {maquina.Mantenimiento}";
                        EscribirCampo(c, maquina.Tipo, detalle);
                        if (!string.IsNullOrWhiteSpace(maquina.Observaciones))
                            EscribirCampo(c, "   " + MenuTextos.Comentarios, maquina.Observaciones);
                    }
                }

                EscribirCampo(c, MenuTextos.BisagrasSoldadora, TextoSiNo(dto.BisagraEnSoldadora));
                EscribirCampo(c, MenuTextos.TripleTaladroCentro, TextoSiNo(dto.TripleTaladroCentro));
                EscribirCampo(c, MenuTextos.SoporteMarco, NombreSoporteMarco(dto.SoporteMarcoConfigId));
                EscribirObservaciones(c, MenuTextos.Comentarios, dto.ObservacionesMaquinas);
            });

            EscribirSeccion(c, MenuTextos.Documentos, recursos.Documentos, () =>
            {
                if (dto.Documentos.Count == 0)
                {
                    EscribirCampo(c, string.Empty, MenuTextos.SinDocumentos);
                }
                else
                {
                    foreach (var documento in dto.Documentos)
                        EscribirCampo(c, documento.Nombre, documento.NombreFicheroOriginal);
                }

                EscribirObservaciones(c, MenuTextos.Comentarios, dto.ObservacionesDocumentos);
            });
        }
        finally
        {
            c.Gfx.Dispose();
        }

        EscribirPiePagina(document, dto.Nombre);

        using var ms = new MemoryStream();
        document.Save(ms, false);
        return ms.ToArray();
    }

    private static string TextoOVacio(string? valor) => string.IsNullOrWhiteSpace(valor) ? MenuTextos.Ninguno : valor;

    private static string TextoLista(List<string> valores) => valores.Count == 0 ? MenuTextos.Ninguno : string.Join(", ", valores);

    private static string TextoSiNo(bool valor) => valor ? MenuTextos.Si : MenuTextos.No;

    // Réplica en texto plano de Pages/ResumenAguja.razor (modo Todos: un
    // único nombre; modo por perfil: una línea "Perfil: Aguja" por fila de
    // la tabla que se ve en pantalla).
    private static string FormatearAguja(AgujaResumenDto data)
    {
        if (data.Tipo == (int)AgujaMode.Todos)
            return string.IsNullOrEmpty(data.NombreTodos) ? MenuTextos.Ninguno : data.NombreTodos;

        return data.PorPerfil.Count == 0
            ? MenuTextos.Ninguno
            : string.Join("; ", data.PorPerfil.Select(l => $"{l.Perfil}: {l.Aguja}"));
    }

    // Se cualifica con el namespace completo por el mismo motivo que en
    // Pages/ClienteResumen.razor: "SoporteMarcoConfig" es ambiguo entre este
    // enum y una entidad de BBDD con el mismo nombre en RotoGestionClientes.
    private static string NombreSoporteMarco(int soporteMarcoConfigId) => soporteMarcoConfigId switch
    {
        (int)RotoGestionClientes.Enums.SoporteMarcoConfig.CentroMecanizado => MenuTextos.CentroMecanizado,
        (int)RotoGestionClientes.Enums.SoporteMarcoConfig.Plantilla => MenuTextos.Plantilla,
        (int)RotoGestionClientes.Enums.SoporteMarcoConfig.BancoMarcos => MenuTextos.BancoMarcos,
        _ => MenuTextos.Ninguno,
    };

    // Cabecera corporativa: logo de Roto a la izquierda y, a su derecha,
    // "RESUMEN DEL CLIENTE" / nombre del cliente / fecha de generación,
    // cerrada con una regla azul que separa la cabecera del contenido.
    private static void EscribirEncabezado(Cursor c, RecursosGraficos recursos, string nombreCliente)
    {
        var yInicio = c.Y;
        double anchoLogo = 90;

        if (recursos.Logo is not null)
        {
            anchoLogo = AltoLogoEncabezado * recursos.Logo.PixelWidth / (double)recursos.Logo.PixelHeight;
            c.Gfx.DrawImage(recursos.Logo, MargenIzquierdo, yInicio, anchoLogo, AltoLogoEncabezado);
        }

        var xTexto = MargenIzquierdo + anchoLogo + 16;

        c.Gfx.DrawString(MenuTextos.ResumenCliente.ToUpperInvariant(), c.FuenteSubtitulo, PincelGris, new XPoint(xTexto, yInicio + 10));
        c.Gfx.DrawString(nombreCliente, c.FuenteTitulo, PincelPrimario, new XPoint(xTexto, yInicio + 28));
        c.Gfx.DrawString(DateTime.Now.ToString("dd/MM/yyyy HH:mm"), c.FuenteSubtitulo, PincelGris, new XPoint(xTexto, yInicio + 44));

        c.Y = yInicio + Math.Max(AltoLogoEncabezado, 48) + 8;

        c.Gfx.DrawLine(PlumaPrimaria, MargenIzquierdo, c.Y, c.AnchoPagina - MargenDerecho, c.Y);
        c.Y += 18;
    }

    // Bloque de sección: banda de fondo suave + icono representativo (misma
    // miniatura que en pantalla) + título en color corporativo + subrayado
    // (a petición expresa del usuario, además de la banda de fondo).
    private static void EscribirSeccion(Cursor c, string titulo, XImage? icono, Action contenido)
    {
        c.AsegurarEspacio(AltoBandaSeccion + AltoLinea + 6);
        c.Y += 10;

        var yBanda = c.Y;
        var anchoContenido = c.AnchoPagina - MargenIzquierdo - MargenDerecho;

        c.Gfx.DrawRectangle(PincelFondoSeccion, MargenIzquierdo, yBanda, anchoContenido, AltoBandaSeccion);

        var xTitulo = MargenIzquierdo + 8;
        if (icono is not null)
        {
            var anchoIcono = AltoIconoSeccion * icono.PixelWidth / (double)icono.PixelHeight;
            var yIcono = yBanda + (AltoBandaSeccion - AltoIconoSeccion) / 2;
            c.Gfx.DrawImage(icono, xTitulo, yIcono, anchoIcono, AltoIconoSeccion);
            xTitulo += anchoIcono + 8;
        }

        c.Gfx.DrawString(titulo, c.FuenteSeccion, PincelPrimario, new XPoint(xTitulo, yBanda + AltoBandaSeccion - 8));

        c.Y = yBanda + AltoBandaSeccion + 3;

        // Subrayado del bloque, tal como pidió el usuario (además de la
        // banda de fondo, para que se note claramente dónde termina).
        c.Gfx.DrawLine(PlumaSecundaria, MargenIzquierdo, c.Y, c.AnchoPagina - MargenDerecho, c.Y);
        c.Y += 12;

        contenido();
    }

    // Etiqueta en negrita distinguida del valor en texto normal (a petición
    // del usuario), en vez de una única línea de texto plano "Etiqueta: valor".
    private static void EscribirCampo(Cursor c, string etiqueta, string valor) =>
        EscribirBloqueEtiquetaValor(c, etiqueta, new[] { valor });

    private static void EscribirObservaciones(Cursor c, string etiqueta, string? texto)
    {
        if (string.IsNullOrWhiteSpace(texto))
            return;

        var parrafos = texto.Replace("\r\n", "\n").Split('\n');
        EscribirBloqueEtiquetaValor(c, etiqueta, parrafos);
    }

    private static void EscribirBloqueEtiquetaValor(Cursor c, string etiqueta, IReadOnlyList<string> parrafos)
    {
        var anchoContenido = c.AnchoPagina - MargenIzquierdo - MargenDerecho;

        if (string.IsNullOrEmpty(etiqueta))
        {
            foreach (var parrafo in parrafos)
                EscribirLineasEnMargen(c, PartirEnLineas(c.Gfx, parrafo, c.FuenteTexto, anchoContenido, anchoContenido), c.FuenteTexto);
            return;
        }

        var etiquetaTexto = $"{etiqueta}: ";
        var anchoEtiqueta = c.Gfx.MeasureString(etiquetaTexto, c.FuenteTextoNegrita).Width;

        c.AsegurarEspacio(AltoLinea);
        c.Gfx.DrawString(etiquetaTexto, c.FuenteTextoNegrita, XBrushes.Black, new XPoint(MargenIzquierdo, c.Y));

        var primerParrafo = parrafos.Count > 0 ? parrafos[0] : string.Empty;
        var anchoPrimeraLinea = Math.Max(anchoContenido - anchoEtiqueta, anchoContenido * 0.25);
        var lineasPrimerParrafo = PartirEnLineas(c.Gfx, primerParrafo, c.FuenteTexto, anchoPrimeraLinea, anchoContenido);

        if (lineasPrimerParrafo.Count == 0)
        {
            c.Y += AltoLinea;
        }
        else
        {
            c.Gfx.DrawString(lineasPrimerParrafo[0], c.FuenteTexto, XBrushes.Black, new XPoint(MargenIzquierdo + anchoEtiqueta, c.Y));
            c.Y += AltoLinea;

            for (var i = 1; i < lineasPrimerParrafo.Count; i++)
            {
                c.AsegurarEspacio(AltoLinea);
                c.Gfx.DrawString(lineasPrimerParrafo[i], c.FuenteTexto, XBrushes.Black, new XPoint(MargenIzquierdo, c.Y));
                c.Y += AltoLinea;
            }
        }

        for (var p = 1; p < parrafos.Count; p++)
            EscribirLineasEnMargen(c, PartirEnLineas(c.Gfx, parrafos[p], c.FuenteTexto, anchoContenido, anchoContenido), c.FuenteTexto);
    }

    private static void EscribirLineasEnMargen(Cursor c, List<string> lineas, XFont fuente)
    {
        if (lineas.Count == 0)
            lineas = new List<string> { string.Empty };

        foreach (var linea in lineas)
        {
            c.AsegurarEspacio(AltoLinea);
            c.Gfx.DrawString(linea, fuente, XBrushes.Black, new XPoint(MargenIzquierdo, c.Y));
            c.Y += AltoLinea;
        }
    }

    // Ajuste de línea manual palabra a palabra, midiendo el ancho real con
    // la fuente ya resuelta. anchoPrimeraLinea puede ser menor que
    // anchoResto porque la primera línea empieza justo después de una
    // etiqueta en negrita (ver EscribirBloqueEtiquetaValor).
    private static List<string> PartirEnLineas(XGraphics gfx, string texto, XFont fuente, double anchoPrimeraLinea, double anchoResto)
    {
        var lineas = new List<string>();
        if (string.IsNullOrEmpty(texto))
            return lineas;

        var lineaActual = string.Empty;
        var esPrimeraLinea = true;

        foreach (var palabra in texto.Split(' '))
        {
            var candidata = lineaActual.Length == 0 ? palabra : $"{lineaActual} {palabra}";
            var anchoMaximo = esPrimeraLinea ? anchoPrimeraLinea : anchoResto;

            if (gfx.MeasureString(candidata, fuente).Width > anchoMaximo && lineaActual.Length > 0)
            {
                lineas.Add(lineaActual);
                esPrimeraLinea = false;
                lineaActual = palabra;
            }
            else
            {
                lineaActual = candidata;
            }
        }

        if (lineaActual.Length > 0)
            lineas.Add(lineaActual);

        return lineas;
    }

    // Pie de página con el nombre del cliente y "página actual/total",
    // dibujado en una segunda pasada sobre TODAS las páginas ya generadas
    // (hace falta conocer el total, que solo se sabe una vez terminado todo
    // el contenido).
    private static void EscribirPiePagina(PdfDocument document, string nombreCliente)
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
            gfx.DrawString(nombreCliente, fuente, PincelGris, new XPoint(MargenIzquierdo, yTexto));

            var textoPagina = $"{i + 1}/{total}";
            var anchoTexto = gfx.MeasureString(textoPagina, fuente).Width;
            gfx.DrawString(textoPagina, fuente, PincelGris, new XPoint(anchoPagina - MargenDerecho - anchoTexto, yTexto));
        }
    }

    private static bool _fontResolverConfigurado;

    private static void AsegurarFontResolver()
    {
        // GlobalFontSettings.FontResolver lanza si se reasigna una vez usado,
        // así que se configura una sola vez por proceso (la app es de
        // escritorio, de un único proceso de larga duración).
        if (_fontResolverConfigurado)
            return;

        GlobalFontSettings.FontResolver = new RgcPdfFontResolver();
        _fontResolverConfigurado = true;
    }

    /// <summary>
    /// Cursor mutable con la página/gráfico PDF actuales y la posición
    /// vertical de escritura. Añade una página nueva automáticamente en
    /// cuanto el contenido no cabe en la actual, igual que iría paginando
    /// una impresión real.
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
            FuenteTextoNegrita = new XFont("Arial", 9.5, XFontStyle.Bold);
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
        public XFont FuenteTextoNegrita { get; }
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
    /// Carga el logo de Roto y los iconos representativos de cada bloque
    /// (las mismas imágenes en miniatura que ya se ven en la pantalla de
    /// resumen) desde recursos incrustados en el ensamblado -- ver los
    /// &lt;EmbeddedResource&gt; en RotoGestionClientes.UI.csproj -- en vez
    /// de leerlos de wwwroot, que no está garantizado como carpeta suelta en
    /// disco tras publicar como .exe single-file. Si algún recurso no se
    /// encuentra o falla al cargar, esa imagen concreta simplemente no se
    /// dibuja: nunca debe tumbar la generación de todo el PDF.
    /// </summary>
    private sealed class RecursosGraficos : IDisposable
    {
        public XImage? Logo { get; }
        public XImage? Ventanas { get; }
        public XImage? Balconeras { get; }
        public XImage? Puertas { get; }
        public XImage? Correderas { get; }
        public XImage? Elevables { get; }
        public XImage? Maquinas { get; }
        public XImage? Documentos { get; }

        public RecursosGraficos()
        {
            Logo = Cargar("RotoGestionClientes.UI.Pdf.logo.png");
            Ventanas = Cargar("RotoGestionClientes.UI.Pdf.ventanas.png");
            Balconeras = Cargar("RotoGestionClientes.UI.Pdf.balconeras.png");
            Puertas = Cargar("RotoGestionClientes.UI.Pdf.puertas.png");
            Correderas = Cargar("RotoGestionClientes.UI.Pdf.correderas.png");
            Elevables = Cargar("RotoGestionClientes.UI.Pdf.elevables.png");
            Maquinas = Cargar("RotoGestionClientes.UI.Pdf.maquinas.png");
            Documentos = Cargar("RotoGestionClientes.UI.Pdf.documentos.png");
        }

        private static XImage? Cargar(string logicalName)
        {
            try
            {
                var asamblea = typeof(RecursosGraficos).Assembly;
                using var stream = asamblea.GetManifestResourceStream(logicalName);
                if (stream is null)
                    return null;

                using var ms = new MemoryStream();
                stream.CopyTo(ms);
                var bytes = ms.ToArray();
                return XImage.FromStream(() => new MemoryStream(bytes));
            }
            catch
            {
                return null;
            }
        }

        public void Dispose()
        {
            Logo?.Dispose();
            Ventanas?.Dispose();
            Balconeras?.Dispose();
            Puertas?.Dispose();
            Correderas?.Dispose();
            Elevables?.Dispose();
            Maquinas?.Dispose();
            Documentos?.Dispose();
        }
    }

    /// <summary>
    /// Resuelve las fuentes leyendo directamente los .ttf de la carpeta de
    /// fuentes de Windows (la app solo se ejecuta en Windows, como WinForms
    /// host de BlazorWebView), en vez de tener que embeber ficheros de
    /// fuente propios en el proyecto.
    /// </summary>
    private sealed class RgcPdfFontResolver : IFontResolver
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
