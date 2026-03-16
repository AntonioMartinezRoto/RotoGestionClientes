
using RotoGestionClientes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RotoGestionClientes

{
    [Table("Cliente", Schema = "dbo")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = null!;
        public string? SapId { get; set; }
        public string? Alias { get; set; }
        public string? Comentarios { get; set; }
        public string? ObservacionesVentanas { get; set; }
        public string? ObservacionesBalconeras { get; set; }
        public string? ObservacionesPuertas { get; set; }
        public ICollection<ClienteSeguridadVentana> ClienteSeguridadVentanas { get; set; } = new List<ClienteSeguridadVentana>();
        public ICollection<ClienteSeguridadBalconera> ClienteSeguridadBalconeras { get; set; } = new List<ClienteSeguridadBalconera>();
        public ICollection<ClientePerfilTipo> ClientePerfilTipos { get; set; } = new List<ClientePerfilTipo>();
        public ICollection<ClienteSoftware> ClienteSoftwares { get; set; } = new List<ClienteSoftware>();
        public ICollection<ClienteManilla> ClienteManillas { get; set; } = new List<ClienteManilla>();
        public ICollection<ClienteSoporteCompas> ClienteSoporteCompases { get; set; } = new List<ClienteSoporteCompas>();
        public ICollection<ClienteCremonaPasivaVentana> ClienteCremonaPasivaVentanas { get; set; } = new List<ClienteCremonaPasivaVentana>();
        public ICollection<ClienteCremonaPasivaVentanaPract> ClienteCremonaPasivaVentanasPract { get; set; } = new List<ClienteCremonaPasivaVentanaPract>();
        public ICollection<ClienteCremonaPasivaBalconera> ClienteCremonaPasivaBalconeras { get; set; } = new List<ClienteCremonaPasivaBalconera>();
        public ICollection<ClientePerfil> ClientePerfiles { get; set; } = new List<ClientePerfil>();
        public ClienteAgujas? ClienteAgujases { get; set; }
        public ICollection<ClienteBisagraPuerta> ClienteBisagraPuertas { get; set; } = new List<ClienteBisagraPuerta>();
        public ICollection<ClienteBisagraPuertaSec> ClienteBisagraPuertasSec { get; set; } = new List<ClienteBisagraPuertaSec>();
        public ICollection<ClienteAgujasModeloPerfil> ClienteAgujasModelos{ get; set; } = new List<ClienteAgujasModeloPerfil>();
        public ICollection<ClienteCerraduraPuertaSec> ClienteCerradurasPuertaSec { get; set; } = new List<ClienteCerraduraPuertaSec>();
        public ICollection<ClienteCerraduraPuerta> ClienteCerradurasPuerta { get; set; } = new List<ClienteCerraduraPuerta>();
        public ClienteConfiguracionPuerta? ClienteConfiguracionPuerta { get; set; }
        public ICollection<ClienteCilindro> ClienteCilindros { get; set; } = new List<ClienteCilindro>();
    }
}
