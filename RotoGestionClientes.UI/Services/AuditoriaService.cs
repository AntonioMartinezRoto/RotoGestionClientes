using static RotoGestionClientes.Enums;

namespace RotoGestionClientes.UI.Services;

/// <summary>
/// Añade filas al histórico de auditoría (dbo.AuditoriaAccion). Deliberadamente
/// NO abre ni guarda su propio ApplicationDbContext: Registrar() solo hace
/// db.AuditoriaAcciones.Add(...) sobre el contexto que le pasa el llamador,
/// para que la fila de auditoría se guarde en el MISMO SaveChangesAsync que
/// el resto de la operación (alta/edición/baja de un maestro o un cliente).
/// Así no hay ninguna ventana en la que el cambio se guarde pero la
/// auditoría no, ni al revés.
/// </summary>
public class AuditoriaService
{
    private readonly SesionState _sesion;

    public AuditoriaService(SesionState sesion)
    {
        _sesion = sesion;
    }

    /// <param name="db">El ApplicationDbContext del llamador; esta llamada no hace SaveChangesAsync por sí sola.</param>
    /// <param name="accion">Crear/Modificar/Eliminar.</param>
    /// <param name="entidad">Enums.MaestroTipo.ToString() para un maestro, o el literal "Cliente".</param>
    /// <param name="entidadId">Id de la fila afectada.</param>
    /// <param name="detalle">Resumen legible en texto libre (p.ej. el Nombre guardado); opcional.</param>
    public void Registrar(ApplicationDbContext db, AuditoriaAccionTipo accion, string entidad, int? entidadId, string? detalle = null)
    {
        db.AuditoriaAcciones.Add(new AuditoriaAccion
        {
            FechaHora = DateTime.UtcNow,
            CuentaUsuarioId = _sesion.EstaAutenticado ? _sesion.CuentaUsuarioId : null,
            UsuarioNombre = _sesion.EstaAutenticado ? _sesion.NombreMostrado : "(desconocido)",
            Entidad = entidad,
            EntidadId = entidadId,
            Accion = accion.ToString(),
            Detalle = detalle,
        });
    }
}
