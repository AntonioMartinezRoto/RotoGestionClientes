# RGC — Fase 1: menú principal modernizado

Este documento acompaña a los 3 proyectos nuevos añadidos al repositorio:
`RotoGestionClientes.Core`, `RotoGestionClientes.UI` y
`RotoGestionClientes.Desktop`. El proyecto `RotoGestionClientes` original
**no se ha tocado** y sigue funcionando exactamente igual que antes.

## Qué se ha construido

Una réplica moderna y responsive del menú principal (`Main.cs`), usando
Blazor Hybrid (WinForms + `BlazorWebView`) y MudBlazor, tal como se acordó
en el plan. Sigue siendo un `.exe` portable local, sin servidor, con su
propio `appsettings.json`. Ver el fichero de plan para el detalle completo
de la decisión técnica.

## Importante: esto no se ha podido compilar aquí

El entorno donde he generado este código es Linux y no tiene acceso a
NuGet.org, así que **no he podido ejecutar `dotnet build` con los paquetes
reales** (EF Core, MudBlazor, `Microsoft.AspNetCore.Components.WebView.WindowsForms`).
He revisado el código a mano y he comprobado la sintaxis de los ficheros
`.cs` "planos" con el compilador de C# (sin las referencias NuGet), pero
los ficheros `.razor` y la integración final **solo se pueden verificar de
verdad compilando en tu PC**, donde sí hay acceso a NuGet e IDE.

Pasos para probarlo:

1. Requisitos en tu PC: Visual Studio 2022 (17.14+) con el workload
   ".NET desktop development", y el SDK de .NET 10.
2. Abre `RotoGestionClientes.slnx` — deberían aparecer los 4 proyectos.
3. `dotnet restore` / restaurar NuGet (VS lo hace solo al abrir).
4. Compila `RotoGestionClientes.Desktop`. Si algún paquete da error de
   versión (`NU1102`/similar), es casi seguro que es un número de versión
   mío desactualizado (los fijé por búsqueda a fecha de hoy, pero no puedo
   verificarlos con un restore real) — dejo que NuGet/VS te sugiera la
   versión disponible más reciente compatible; no debería requerir tocar
   nada de la lógica.
5. Ejecuta `RotoGestionClientes.Desktop` (F5). Debería abrir una ventana
   redimensionable con el menú (cabecera, barra lateral de navegación,
   contenido central e indicador de versión de datos), contra la BBDD de
   `appsettings.json` (ahora mismo apunta a `RFSPNB13\RGC_Test10`, la misma
   BBDD de pruebas que usa `appsettings-local.json` del proyecto actual).
6. Prueba a redimensionar la ventana — es la diferencia visible más
   importante respecto al `Main` actual (que tiene tamaño fijo).
7. Cambia el valor de `AppEdition` en la tabla `ConfiguracionAplicacion` de
   la BBDD de pruebas (Internal / Distributor / Debug) y confirma que
   "Mantenimiento", "Crear actualización de datos" y "Actualizar datos
   Roto" aparecen/desaparecen igual que en la app actual.
8. Confirma que `RotoGestionClientes` (el `.exe` legacy) sigue arrancando
   sin problemas — no debería haberse visto afectado en absoluto.

## Qué falta (fases siguientes, una por módulo)

Los botones de Clientes, Mantenimiento, Informes, "Crear actualización de
datos" y "Actualizar datos Roto" muestran un aviso de "Próximamente" — la
navegación ya está cableada (rutas Blazor listas), pero la funcionalidad
real de cada módulo se migrará en fases posteriores, tal como se acordó.

## Dónde tocar cada cosa

- **Colores/tema**: `RotoGestionClientes.UI/Theme/RgcTheme.cs` — paleta
  provisional, lista para sustituir por los colores corporativos exactos.
- **Textos ES/PT**: `RotoGestionClientes.UI/Resources/MenuTextos.resx` (ES)
  y `MenuTextos.pt.resx` (PT). Mismo patrón que `Textos.resx` en el
  proyecto actual.
- **Cadena de conexión de esta app**: `RotoGestionClientes.Desktop/appsettings.json`
  (uno por sede/distribuidor, igual que hoy).
- **Modelos/BBDD compartidos**: `RotoGestionClientes.Core/Models` — si se
  añade una columna o tabla nueva, replicar el cambio aquí y en
  `RotoGestionClientes/Models` (proyecto legacy) mientras convivan ambas
  apps.
