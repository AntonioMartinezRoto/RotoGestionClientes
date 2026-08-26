// WizardStepItem se ha retirado deliberadamente de RotoGestionClientes.Core.
//
// En el proyecto legacy, WizardStepItem.cs vive dentro de la carpeta Models/
// pero en realidad NO es un modelo de datos: es un control visual de WinForms
// (hereda de Panel y usa Label/Font/Color/Cursors...). Al copiar Models/ a
// esta librería multiplataforma (net10.0, sin WinForms) se coló por error y
// provocaba errores de compilación en cascada (Panel/Label/Color no
// encontrados), ya que esos tipos no existen fuera de WinForms.
//
// Cuando se migre el wizard de Clientes (fase futura), su equivalente será
// un componente Blazor en RotoGestionClientes.UI, no una clase aquí.
//
// Puedes borrar este fichero sin problema si prefieres no dejarlo vacío.
