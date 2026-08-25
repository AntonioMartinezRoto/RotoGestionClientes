namespace RotoGestionClientes
{
    /// <summary>
    /// Copiado de Clientes/PasoMaquinas.cs (proyecto legacy), donde vive junto
    /// al formulario del wizard en vez de en Models/. Es un POCO sin ninguna
    /// dependencia de WinForms, así que se traslada tal cual aquí para que
    /// ClientWizardModel.cs (que sí está en Models/) pueda referenciarlo.
    /// </summary>
    public class ClienteMaquinaItem
    {
        public int? Id { get; set; } // null = nuevo

        public int MaquinaTipoId { get; set; }
        public string Descripcion { get; set; } = null!;

        public int? MaquinaMarcaId { get; set; }
        public string? MarcaNombre { get; set; }

        public int MaquinaMantenimientoId { get; set; }
        public string MantenimientoNombre { get; set; } = null!;

        public string? Observaciones { get; set; }
    }
}
