
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
            MaquinaTipo
        }
    }
}
