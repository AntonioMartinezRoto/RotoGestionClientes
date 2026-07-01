using RotoGestionClientes.Resources;

namespace RotoGestionClientes;

public static class Lang
{
    #region Menu principal
    public static string Guardar => Textos.Guardar;
    public static string Salir => Textos.Salir;
    public static string MenuPrincipal => Textos.Menu_principal;
    public static string Clientes => Textos.Clientes;
    public static string Mantenimiento => Textos.Mantenimiento;
    public static string Informes => Textos.Informes;
    public static string ActualizarDatos => Textos.Actualizar_datos_Roto;
    public static string CrearActualizacion => Textos.Crear_actualizacion_Roto;
    public static string VersionDatos => Textos.Version_datos;
    #endregion

    #region Clientes
    public static string NuevoCliente => Textos.NuevoCliente;
    public static string ImportarCliente => Textos.ImportarCliente;
    public static string ExportarClientes => Textos.ExportarClientes;
    public static string VolverMenu => Textos.VolverMenu;
    public static string Total => Textos.Total;
    public static string Buscar => Textos.Buscar;
    public static string SapId => Textos.SapId;
    public static string Nombre => Textos.Nombre;
    public static string Responsable => Textos.Responsable;
    public static string Comentarios => Textos.Comentarios;
    public static string VerResumen => Textos.VerResumen;
    public static string Editar => Textos.Editar;
    public static string Exportar => Textos.Exportar;
    public static string CrearConfigurador => Textos.CrearConfig;
    public static string Eliminar => Textos.Eliminar;
    public static string EliminarCliente => Textos.EliminarCliente;
    public static string ConfirmarEliminar => Textos.ConfirmarEliminarCliente;

    #endregion

    #region Exportar clientes

    public static string SeleccionarTodos => Textos.SeleccionarTodos;
    public static string Seleccionados => Textos.Seleccionados;
    public static string SeleccionarClientes => Textos.SeleccionarClientes;
    public static string SeleccioneUnCliente => Textos.SeleccioneUnCliente;
    public static string SeHanExportado => Textos.SeHanExportado;
    public static string ClientesMinuscula => Textos.ClientesMinuscula;
    public static string ClienteNoEncontrado => Textos.ClienteNoEncontrado;
    public static string ClienteExportado => Textos.ClienteExportado;
    public static string ErrorAlExportar => Textos.ErrorAlExportar;
    public static string ClienteExistente => Textos.ClienteExistente;
    public static string ArchivoNoValido => Textos.ArchivoNoValido;
    public static string ClienteImportado => Textos.ClienteImportado;
    public static string ErrorAlImportar => Textos.ErrorAlImportar;
    #endregion

    #region ClienteWizard

    public static string CompletarDatosCliente => Textos.CompletaDatosCliente;
    public static string EditandoCliente => Textos.EditandoCliente;
    public static string DatosGenerales => Textos.DatosGenerales;
    public static string Ventanas => Textos.Ventanas;
    public static string Puertas => Textos.Puertas;
    public static string Inline => Textos.Inline;
    public static string ElevablesPlegables => Textos.ElevablesPlegables;
    public static string Maquinas => Textos.Maquinas;
    public static string Documentos => Textos.Documentos;
    public static string Cancelar => Textos.Cancelar;
    public static string Atras => Textos.Atras;
    public static string Finalizar => Textos.Finalizar;
    public static string Siguiente => Textos.Siguiente;
    public static string DatosCorruptos => Textos.DatosCorruptos;
    public static string Validacion => Textos.Validación;
    #endregion

    #region PasoDatosGenerales

    public static string Alias => Textos.Alias;
    public static string Software => Textos.Software;
    public static string TipoPerfil => Textos.TipoPerfil;
    public static string SoporteCompas => Textos.SoporteCompas;
    public static string Manillas => Textos.Manillas;
    public static string Perfil => Textos.Perfil;

    #endregion

    #region PasoVentanas

    public static string Oscilobatientes => Textos.Oscilobatientes;
    public static string HojaPasiva => Textos.HojaPasiva;
    public static string Seguridad => Textos.Seguridad;
    public static string Practicables => Textos.Practicables;

    #endregion

    #region PasoBalconeras

    public static string Balconeras => Textos.Balconeras;
    public static string Aguja => Textos.Aguja;
    public static string Todos => Textos.Todos;
    public static string PorPerfil => Textos.PorPerfil;
    public static string PuertaSecundaria => Textos.PuertaSecundaria;
    public static string Bisagras => Textos.Bisagras;
    public static string Cerraduras => Textos.Cerraduras;
    public static string DefinirAgujasPerfil => Textos.DeinifirAgujasPerfil;

    #endregion

    #region PasoPuertas

    public static string Si => Textos.Si;
    public static string Cilindros => Textos.Cilindros;
    public static string SeleccionarCilindros => Textos.SeleccionarCilindros;
    public static string Tipo => Textos.Tipo;
    public static string Interior => Textos.Interior;
    public static string Exterior => Textos.Exterior;
    public static string Nomenclatura => Textos.Nomenclatura;


    #endregion
    #region Correderas

    public static string Correderas => Textos.Correderas;
    public static string Bombillo => Textos.Bombillo;
    public static string No => Textos.No;

    #endregion
    #region ElevablesPlegables

    public static string Elevables => Textos.Elevables;
    public static string Plegables => Textos.Plegables;
    public static string Estandar => Textos.Estandar;
    public static string Dlo => Textos.Dlo;
    public static string Consumen => Textos.Consumen;

    #endregion
    #region Maquinas

    public static string Marca => Textos.Marca;
    public static string BisagrasSoldadora => Textos.BisagrasSoldadora;
    public static string TripleTaladroCentro => Textos.TripleTaladroCentro;
    public static string SoporteMarco => Textos.SoporteMarco;
    public static string CentroMecanizado => Textos.CentroMecanizado;
    public static string Plantilla => Textos.Plantilla;
    public static string BancoMarcos => Textos.BancoMarcos;

    #endregion
    #region Documentos

    public static string Documento => Textos.Documento;
    public static string Fichero => Textos.Fichero;
    public static string NombreDocumento => Textos.NombreDocumento;
    public static string SeleccionarDocumento => Textos.SeleccionarDocumento;
    public static string NingunFichero => Textos.NingunFichero;
    public static string IndicarNombreDoc => Textos.IndicarNombreDoc;
    public static string DocumentoObligatorio => Textos.DocumentoObligatorio;

    #endregion
    #region Resumen

    public static string General => Textos.General;
    public static string Perfiles => Textos.Perfiles;
    public static string SeguridadVentana => Textos.SeguridadVentana;
    public static string PasivaOscilo => Textos.PasivaOscilo;
    public static string PasivaPracticables => Textos.PasivaPracticables;
    public static string AgujaBalconera => Textos.AgujaBalconera;
    public static string SeguridadBalconera => Textos.SeguridadBalconera;
    public static string PasivaBalconera => Textos.PasivaBalconera;
    public static string AgujaPuerta => Textos.AgujaPuerta;
    public static string ElevablesEstandar => Textos.ElevablesEstandar;
    public static string NoUsaElevablesEstandar => Textos.NoUsaElevablesEstandar;
    public static string UsaElevablesDlo => Textos.UsaElevablesDlo;
    public static string NoUsaElevablesDlo => Textos.NoUsaElevablesDlo;
    public static string NoConsumenPlegables => Textos.NoConsumenPlegables;
    public static string ConsumenPlegables => Textos.ConsumenPlegables;
    public static string Desconocido => Textos.Desconocido;
    #endregion
    #region Mantenimiento

    public static string Usuarios => Textos.Usuarios;
    public static string Pasivas => Textos.Pasivas;
    public static string TipoMaquinas => Textos.TipoMaquinas;
    public static string MarcasMaquinas => Textos.MarcasMaquinas;
    public static string MantenimientoMaquinas => Textos.MantenimientoMaquina;
    public static string Activo => Textos.Activo;
    public static string EsDistribuidor => Textos.EsDistribuidor;
    #endregion
}
