// Exporta un gráfico MudChart (dibujado como <svg> por MudBlazor, con su
// leyenda como HTML normal justo al lado) como una imagen PNG, sin depender
// de ninguna librería externa ni CDN -- la app es un ejecutable portable
// offline, así que todo lo que necesita JS tiene que venir con ella. Se usa
// en Pages/ClienteResumen.razor y Pages/InformeAcciones.razor tanto para la
// descarga individual de un gráfico como, en InformeAcciones, para componer
// el PDF del informe (Services/AccionesInformePdfBuilder.cs).
//
// Técnica: en vez de serializar solo el <svg> del gráfico, se serializa el
// contenedor COMPLETO (gráfico + leyenda) envuelto en un <foreignObject>
// dentro de un <svg> nuevo -- MudChart dibuja la leyenda como HTML normal al
// lado del <svg> del gráfico, no dentro de él, así que capturar solo el
// <svg> se dejaba la leyenda fuera del PNG/PDF exportado aunque se viera
// bien en pantalla. Como ese <foreignObject> se rasteriza de forma aislada
// (sin las hojas de estilo de la página), se copian todas las reglas CSS ya
// cargadas en un <style> dentro de él para que la leyenda conserve colores,
// tipografía y disposición. Una vez tenemos ese <svg> como texto, se carga
// como imagen (data URL image/svg+xml) y se dibuja sobre un <canvas> oculto;
// canvas.toDataURL('image/png') da el PNG resultante. Se devuelve solo la
// parte base64 (sin el prefijo "data:image/png;base64,"), igual que espera
// window.rgcDescargarArchivo.
//
// Calidad: un <svg> es vectorial (no tiene "resolución" propia), así que la
// nitidez del PNG depende únicamente del tamaño en píxeles al que se le pide
// al navegador que lo rasterice al cargarlo como imagen. Pedirle el mismo
// tamaño que ocupa en pantalla (los ~600x260 px CSS de la tarjeta) da un PNG
// que se ve borroso en cuanto se amplía en una diapositiva o un documento.
// Por eso se escala ESCALA_EXPORTACION veces el ancho/alto del contenedor
// (el viewBox del <svg> nuevo reescala todo el contenido como vector, sin
// pixelar nada) antes de rasterizarlo, y el <canvas> de destino usa ese
// mismo tamaño ampliado.
const ESCALA_EXPORTACION = 3;

// Concatena el texto de todas las reglas CSS ya cargadas en la página
// (MudBlazor.min.css + wwwroot/css/app.css, ambas locales -- no hay hojas de
// estilo de terceros en esta app portable). Si alguna hoja no se puede leer
// (por ejemplo, todavía cargando) simplemente se ignora en vez de romper la
// exportación: en el peor caso la leyenda sale con el estilo por defecto del
// navegador en vez del de MudBlazor, pero se sigue viendo el texto.
function estilosPaginaComoTexto() {
    let css = '';
    for (const hoja of document.styleSheets) {
        try {
            for (const regla of hoja.cssRules) {
                css += regla.cssText + '\n';
            }
        } catch {
            // Hoja no accesible (cross-origin, todavía cargando...) -- se omite.
        }
    }
    return css;
}

window.rgcExportarGraficoPng = (elementId) => {
    return new Promise((resolve) => {
        const contenedor = document.getElementById(elementId);
        if (!contenedor || !contenedor.querySelector('svg')) {
            resolve(null);
            return;
        }

        // Ancho/alto reales en pantalla del contenedor completo (gráfico +
        // leyenda), para que el PNG no salga recortado ni a tamaño 0.
        const rect = contenedor.getBoundingClientRect();
        const ancho = Math.max(1, Math.round(rect.width)) || 600;
        const alto = Math.max(1, Math.round(rect.height)) || 300;
        const anchoExportado = ancho * ESCALA_EXPORTACION;
        const altoExportado = alto * ESCALA_EXPORTACION;

        const svgNS = 'http://www.w3.org/2000/svg';
        const xhtmlNS = 'http://www.w3.org/1999/xhtml';

        const clon = contenedor.cloneNode(true);
        clon.setAttribute('xmlns', xhtmlNS);
        clon.style.width = ancho + 'px';
        clon.style.height = alto + 'px';
        clon.style.margin = '0';
        clon.style.backgroundColor = '#ffffff';

        const estilo = document.createElementNS(xhtmlNS, 'style');
        estilo.textContent = estilosPaginaComoTexto();

        const svgExportacion = document.createElementNS(svgNS, 'svg');
        svgExportacion.setAttribute('xmlns', svgNS);
        // Importante: el viewBox queda al tamaño real en pantalla y solo el
        // width/height final se amplía -- es lo que hace que, al rasterizar
        // a un tamaño mayor, el navegador reescale todo el contenido
        // (trazos, texto, leyenda...) en vez de recortarlo o pixelarlo.
        svgExportacion.setAttribute('viewBox', `0 0 ${ancho} ${alto}`);
        svgExportacion.setAttribute('width', anchoExportado);
        svgExportacion.setAttribute('height', altoExportado);

        const foreignObject = document.createElementNS(svgNS, 'foreignObject');
        foreignObject.setAttribute('width', ancho);
        foreignObject.setAttribute('height', alto);
        foreignObject.appendChild(estilo);
        foreignObject.appendChild(clon);
        svgExportacion.appendChild(foreignObject);

        const svgTexto = new XMLSerializer().serializeToString(svgExportacion);
        const svgDataUrl = 'data:image/svg+xml;charset=utf-8,' + encodeURIComponent(svgTexto);

        const img = new Image();
        img.onload = () => {
            const canvas = document.createElement('canvas');
            canvas.width = anchoExportado;
            canvas.height = altoExportado;
            const ctx = canvas.getContext('2d');
            // Fondo blanco explícito: el contenedor es transparente por
            // defecto, y un PNG transparente se ve mal pegado en una
            // diapositiva o documento.
            ctx.fillStyle = '#ffffff';
            ctx.fillRect(0, 0, anchoExportado, altoExportado);
            ctx.drawImage(img, 0, 0, anchoExportado, altoExportado);

            try {
                const pngDataUrl = canvas.toDataURL('image/png');
                resolve(pngDataUrl.replace(/^data:image\/png;base64,/, ''));
            } catch {
                resolve(null);
            }
        };
        img.onerror = () => resolve(null);
        img.src = svgDataUrl;
    });
};
