// Descarga un array de bytes (recibido en base64 desde Blazor) como un
// fichero del navegador/WebView2. Usado por el paso "Documentos" del
// wizard de clientes para descargar los documentos adjuntos guardados en
// BBDD (que llegan a JS como base64 porque no hay acceso directo a disco
// desde la Razor Class Library).
window.rgcDescargarArchivo = (nombreArchivo, contenidoBase64) => {
    const enlace = document.createElement('a');
    enlace.href = 'data:application/octet-stream;base64,' + contenidoBase64;
    enlace.download = nombreArchivo;
    document.body.appendChild(enlace);
    enlace.click();
    document.body.removeChild(enlace);
};
