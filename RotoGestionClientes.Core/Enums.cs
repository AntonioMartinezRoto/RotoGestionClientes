
namespace RotoGestionClientes
{
    public static class Enums
    {
        public enum WizardMode
        {
            Create,
            Edit
        }
        public enum AgujaMode
        {
            Todos = 1,
            PorPerfil = 2
        }
        public enum AgujasTipoModelo
        {
            Balconera = 1,
            PuertaSecundaria = 2,
            Puerta = 3,
            Ventana = 4
        }
        public enum SoporteMarcoConfig
        {
            CentroMecanizado = 1,
            Plantilla = 2,
            BancoMarcos = 3
        }
        public enum MaestroTipo
        {
            Perfil,
            PerfilTipo,
            Software,
            Manilla,
            SoporteCompas,
            SeguridadVentana,
            CremonaPasivaVentana,
            BisagraPuerta,
            CilindroTipo,
            MaquinaMantenimiento,
            MaquinaMarcas,
            MaquinaTipo,
            CerraduraPuerta,
            Usuario
        }
        public enum InformeFiltroTipo
        {
            Software,
            Manilla,
            Bisagra,
            Perfil,
            Responsable,
            Maquina,
            Cerradura,
            TipoPerfil
        }
        public enum ApplicationEdition
        {
            Internal,
            Distributor,
            Debug
        }

        // Rol de una CuentaUsuario (login). Administrador puede ver la
        // auditoría y gestionar cuentas; Usuario es el comportamiento actual
        // de la app sin restricciones adicionales (a futuro se podría
        // limitar más). El nombre del enum se guarda tal cual en
        // CuentaUsuario.Rol -- es un código interno, no texto a traducir,
        // igual que ApplicationEdition en ConfiguracionAplicacion.AppEdition.
        public enum Rol
        {
            Administrador,
            Usuario
        }

        // Acción registrada en AuditoriaAccion. El nombre del enum se guarda
        // tal cual en AuditoriaAccion.Accion.
        public enum AuditoriaAccionTipo
        {
            Crear,
            Modificar,
            Eliminar
        }

        // Módulo de la app al que se le puede conceder o quitar acceso a una
        // cuenta Rol=Usuario (ver CuentaUsuario.RestringirModulos y
        // CuentaUsuarioPermiso). Administrador nunca pasa por esta lista:
        // siempre tiene acceso a todo. Auditoría y Cuentas de usuario tampoco
        // están aquí -- siguen siendo exclusivas de Administrador, no algo
        // que se pueda conceder a un Usuario. El nombre del enum se guarda
        // tal cual en CuentaUsuarioPermiso.Modulo.
        public enum Modulo
        {
            Clientes,
            Mantenimiento,
            Informes,
            CrearActualizacion,
            ActualizarDatos
        }
    }

}
