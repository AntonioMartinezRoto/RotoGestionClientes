using Microsoft.EntityFrameworkCore;

namespace RotoGestionClientes
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; } = null!;
        public DbSet<PerfilTipo> PerfilTipos { get; set; } = null!;
        public DbSet<SeguridadVentana> SeguridadVentanas { get; set; } = null!;
        public DbSet<CremonaPasivaVentanaTipos> CremonaPasivaVentanaTipos { get; set; } = null!;
        public DbSet<ClienteSeguridadVentana> ClienteSeguridadVentanas { get; set; } = null!;
        public DbSet<ClienteSeguridadBalconera> ClienteSeguridadBalconeras { get; set; } = null!;
        public DbSet<ClientePerfilTipo> ClientePerfilTipos { get; set; } = null!;
        public DbSet<Software> Softwares { get; set; } = null!;
        public DbSet<ClienteSoftware> ClienteSoftwares { get; set; } = null!;
        public DbSet<Manilla> Manillas { get; set; } = null!;
        public DbSet<ClienteManilla> ClienteManillas { get; set; } = null!;
        public DbSet<SoporteCompas> SoporteCompases{ get; set; } = null!;
        public DbSet<ClienteSoporteCompas> ClienteSoporteCompases { get; set; } = null!;
        public DbSet<ClienteCremonaPasivaVentana> ClienteCremonaPasivaVentanas { get; set; } = null!;
        public DbSet<ClienteCremonaPasivaBalconera> ClienteCremonaPasivaBalconeras { get; set; } = null!;
        public DbSet<ClienteCremonaPasivaVentanaPract> ClienteCremonaPasivaVentanasPract { get; set; } = null!;
        public DbSet<Perfil> Perfiles { get; set; } = null!;
        public DbSet<ClientePerfil> ClientePerfiles { get; set; } = null!;
        public DbSet<Aguja> Agujas { get; set; } = null!;
        public DbSet<AgujasCorredera> AgujasCorredera { get; set; } = null!;
        public DbSet<AgujasModelo> AgujasModelo { get; set; } = null!;
        public DbSet<ClienteAgujas> ClienteAgujases { get; set; } = null!;
        public DbSet<Bisagra> Bisagras { get; set; } = null!;
        public DbSet<ClienteBisagraPuerta> ClienteBisagraPuertas { get; set; } = null!;
        public DbSet<ClienteBisagraPuertaSec> ClienteBisagraPuertasSec { get; set; } = null!;
        public DbSet<ClienteAgujasModeloPerfil> ClienteAgujasModeloPerfil { get; set; } = null!;
        public DbSet<CerraduraPuertaSec> CerradurasPuertaSec { get; set; } = null!;
        public DbSet<ClienteCerraduraPuertaSec> ClienteCerradurasPuertaSec { get; set; } = null!;
        public DbSet<CerraduraPuerta> CerradurasPuerta { get; set; } = null!;
        public DbSet<ClienteCerraduraPuerta> ClienteCerradurasPuerta { get; set; } = null!;
        public DbSet<ClienteConfiguracionPuerta> ClienteConfiguracionPuerta { get; set; } = null!;
        public DbSet<Cilindro> Cilindros { get; set; } = null!;
        public DbSet<CilindroTipo> CilindroTipos { get; set; } = null!;
        public DbSet<ClienteCilindro> ClienteCilindros { get; set; } = null!;
        public DbSet<ClienteAgujasCorredera> ClienteAgujasCorrederas { get; set; } = null!;
        public DbSet<ClienteCilindroCorredera> ClienteCilindrosCorredera { get; set; } = null!;
        public DbSet<ClienteConfiguracionElevablePlegable> ClienteConfiguracionElevablePlegables { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración  (Fluent API)
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("Cliente", "dbo");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                      .ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                      .IsRequired();
                entity.Property(e => e.Alias);
                entity.Property(e => e.SapId);
                entity.Property(e => e.Comentarios);
                entity.Property(e => e.ObservacionesVentanas);
                entity.Property(e => e.ObservacionesBalconeras);
                entity.Property(e => e.ObservacionesPuertas);
                entity.Property(e => e.ObservacionesParalelas);
                entity.Property(e => e.ObservacionesCorrederas);
                entity.Property(e => e.ObservacionesPlegables);
                entity.Property(e => e.ObservacionesElevables);
                entity.Property(e => e.ObservacionesMaquinas);
            });
            modelBuilder.Entity<PerfilTipo>(entity =>
            {
                entity.ToTable("PerfilTipo", "dbo");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                      .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                      .IsRequired();

                entity.Property(e => e.NombreAbreviado);

                entity.Property(e => e.Activa)
                      .IsRequired();    
            });
            modelBuilder.Entity<CremonaPasivaVentanaTipos>(entity =>
            {
                entity.ToTable("CremonaPasivaVentanaTipos", "dbo");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                      .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                      .IsRequired();
            });
            modelBuilder.Entity<SeguridadVentana>(entity =>
            {
                entity.ToTable("SeguridadVentana", "dbo");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                      .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                      .IsRequired();

                entity.Property(e => e.Activa)
                        .IsRequired();

            });
            modelBuilder.Entity<ClienteSeguridadVentana>(entity =>
            {
                entity.ToTable("ClienteSeguridadVentana", "dbo");

                entity.HasKey(e => new { e.ClienteId, e.SeguridadVentanaId });

                entity.HasOne(e => e.Cliente)
                      .WithMany(c => c.ClienteSeguridadVentanas)
                      .HasForeignKey(e => e.ClienteId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.SeguridadVentana)
                      .WithMany(s => s.ClienteSeguridadVentanas)
                      .HasForeignKey(e => e.SeguridadVentanaId);
            });
            modelBuilder.Entity<ClienteSeguridadBalconera>(entity =>
            {
                entity.ToTable("ClienteSeguridadBalconera", "dbo");

                entity.HasKey(e => new { e.ClienteId, e.SeguridadBalconeraId });

                entity.HasOne(e => e.Cliente)
                      .WithMany(c => c.ClienteSeguridadBalconeras)
                      .HasForeignKey(e => e.ClienteId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.SeguridadBalconera)
                      .WithMany(s => s.ClienteSeguridadBalconeras)
                      .HasForeignKey(e => e.SeguridadBalconeraId);
            });
            modelBuilder.Entity<ClientePerfilTipo>(entity =>
            {
                entity.ToTable("ClientePerfilTipo", "dbo");

                entity.HasKey(e => new { e.ClienteId, e.PerfilTipoId });

                entity.HasOne(e => e.Cliente)
                      .WithMany(c => c.ClientePerfilTipos)
                      .HasForeignKey(e => e.ClienteId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.PerfilTipo)
                      .WithMany(s => s.ClientePerfilTipos)
                      .HasForeignKey(e => e.PerfilTipoId);
            });
            modelBuilder.Entity<Software>(entity =>
            {
                entity.ToTable("Software", "dbo");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                      .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                      .IsRequired();

                entity.Property(e => e.Activa)
                      .IsRequired();
            });
            modelBuilder.Entity<ClienteSoftware>(entity =>
            {
                entity.ToTable("ClienteSoftware", "dbo");

                entity.HasKey(e => new { e.ClienteId, e.SoftwareId });

                entity.HasOne(e => e.Cliente)
                      .WithMany(c => c.ClienteSoftwares)
                      .HasForeignKey(e => e.ClienteId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.Software)
                      .WithMany(s => s.ClienteSoftwares)
                      .HasForeignKey(e => e.SoftwareId);
            });
            modelBuilder.Entity<Manilla>(entity =>
            {
                entity.ToTable("Manilla", "dbo");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                      .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                      .IsRequired();

                entity.Property(e => e.Activa)
                    .IsRequired();
            });
            modelBuilder.Entity<ClienteManilla>(entity =>
            {
                entity.ToTable("ClienteManilla", "dbo");

                entity.HasKey(e => new { e.ClienteId, e.ManillaId });

                entity.HasOne(e => e.Cliente)
                      .WithMany(c => c.ClienteManillas)
                      .HasForeignKey(e => e.ClienteId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.Manilla)
                      .WithMany(s => s.ClienteManillas)
                      .HasForeignKey(e => e.ManillaId);
            });
            modelBuilder.Entity<SoporteCompas>(entity =>
            {
                entity.ToTable("SoporteCompas", "dbo");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                      .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                      .IsRequired();

                entity.Property(e => e.Activa)
                        .IsRequired();

                entity.HasOne(e => e.PerfilTipo)
                      .WithMany(p => p.SoporteCompases)
                      .HasForeignKey(e => e.PerfilTipoId)
                      .HasConstraintName("FK_SoporteCompas_PerfilTipo");
            });
            modelBuilder.Entity<ClienteSoporteCompas>(entity =>
            {
                entity.ToTable("ClienteSoporteCompas", "dbo");

                entity.HasKey(e => new { e.ClienteId, e.SoporteCompasId });

                entity.HasOne(e => e.Cliente)
                      .WithMany(c => c.ClienteSoporteCompases)
                      .HasForeignKey(e => e.ClienteId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.SoporteCompas)
                      .WithMany(s => s.ClienteSoporteCompases)
                      .HasForeignKey(e => e.SoporteCompasId);
            });
            modelBuilder.Entity<CremonaPasivaVentanaTipos>(entity =>
            {
                entity.ToTable("CremonaPasivaVentanaTipos", "dbo");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                      .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                      .IsRequired();

                entity.Property(e => e.Activa)
                    .IsRequired();
            });
            modelBuilder.Entity<ClienteCremonaPasivaVentana>(entity =>
            {
                entity.ToTable("ClienteCremonaPasivaVentana", "dbo");

                entity.HasKey(e => new { e.ClienteId, e.CremonaPasivaVentanaId });

                entity.HasOne(e => e.Cliente)
                      .WithMany(c => c.ClienteCremonaPasivaVentanas)
                      .HasForeignKey(e => e.ClienteId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.CremonaPasivaVentanaTipo)
                      .WithMany(s => s.ClienteCremonaPasivaVentanas)
                      .HasForeignKey(e => e.CremonaPasivaVentanaId);
            });
            modelBuilder.Entity<ClienteCremonaPasivaBalconera>(entity =>
            {
                entity.ToTable("ClienteCremonaPasivaBalconera", "dbo");

                entity.HasKey(e => new { e.ClienteId, e.CremonaPasivaBalconeraId });

                entity.HasOne(e => e.Cliente)
                      .WithMany(c => c.ClienteCremonaPasivaBalconeras)
                      .HasForeignKey(e => e.ClienteId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.CremonaPasivaBalconeraTipo)
                      .WithMany(s => s.ClienteCremonaPasivaBalconeras)
                      .HasForeignKey(e => e.CremonaPasivaBalconeraId);
            });
            modelBuilder.Entity<ClienteCremonaPasivaVentanaPract>(entity =>
            {
                entity.ToTable("ClienteCremonaPasivaVentanaPract", "dbo");

                entity.HasKey(e => new { e.ClienteId, e.CremonaPasivaVentanaId });

                entity.HasOne(e => e.Cliente)
                      .WithMany(c => c.ClienteCremonaPasivaVentanasPract)
                      .HasForeignKey(e => e.ClienteId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.CremonaPasivaVentanaTipo)
                      .WithMany(s => s.ClienteCremonaPasivaVentanasPract)
                      .HasForeignKey(e => e.CremonaPasivaVentanaId);
            });
            modelBuilder.Entity<Perfil>(entity =>
            {
                entity.ToTable("Perfil");

                entity.HasKey(e => e.Id)
                      .HasName("PK_Perfil");

                entity.Property(e => e.Nombre)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(e => e.Activa)
                        .IsRequired();

                entity.HasOne(e => e.PerfilTipo)
                      .WithMany(p => p.Perfiles)
                      .HasForeignKey(e => e.PerfilTipoId)
                      .HasConstraintName("FK_Perfil_PerfilTipo");
            });
            modelBuilder.Entity<ClientePerfil>(entity =>
            {
                entity.ToTable("ClientePerfil", "dbo");

                entity.HasKey(e => new { e.ClienteId, e.PerfilId });

                entity.HasOne(e => e.Cliente)
                      .WithMany(c => c.ClientePerfiles)
                      .HasForeignKey(e => e.ClienteId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.Perfil)
                      .WithMany(s => s.ClientePerfiles)
                      .HasForeignKey(e => e.PerfilId);
            });
            modelBuilder.Entity<Aguja>(entity =>
            {
                entity.ToTable("Agujas");

                entity.HasKey(e => e.Id)
                      .HasName("PK_Aguja");

                entity.Property(e => e.Nombre)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(e => e.Activa)
                    .IsRequired();
            });
            modelBuilder.Entity<AgujasModelo>(entity =>
            {
                entity.ToTable("AgujasModelo");

                entity.HasKey(e => e.Id)
                      .HasName("PK_AgujasModelo");

                entity.Property(e => e.Nombre)
                      .IsRequired()
                      .HasMaxLength(50);
            });
            modelBuilder.Entity<ClienteAgujasModeloPerfil>(entity =>
            {
                entity.ToTable("ClienteAgujasModeloPerfil", "dbo");

                entity.HasKey(e => new { e.ClienteId, e.AgujaModeloTipoId, e.PerfilId });

                entity.HasOne(e => e.Cliente)
                      .WithMany(c => c.ClienteAgujasModelos)
                      .HasForeignKey(e => e.ClienteId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.Aguja)
                      .WithMany(s => s.ClienteAgujasModelos)
                      .HasForeignKey(e => e.AgujaId);

                entity.HasOne(e => e.AgujasModelo)
                      .WithMany(s => s.ClienteAgujasModelos)
                      .HasForeignKey(e => e.AgujaModeloTipoId);

                entity.HasOne(e => e.Perfil)
                      .WithMany(s => s.ClienteAgujasModelos)
                      .HasForeignKey(e => e.PerfilId);
            });
            modelBuilder.Entity<ClienteAgujas>(entity =>
            {
                entity.ToTable("ClienteAgujas", "dbo");

                entity.HasKey(e => e.ClienteId);

                entity.HasOne(e => e.Cliente)
                      .WithOne(c => c.ClienteAgujases)
                      .HasForeignKey<ClienteAgujas>(e => e.ClienteId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.AgujaBalconera)
                      .WithMany()
                      .HasForeignKey(e => e.AgujaBalconeraId)
                      .IsRequired(false)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.AgujaPuertaSec)
                      .WithMany()
                      .HasForeignKey(e => e.AgujaPuertaSecId)
                      .IsRequired(false)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.AgujaPuerta)
                      .WithMany()
                      .HasForeignKey(e => e.AgujaPuertaId)
                      .IsRequired(false)
                      .OnDelete(DeleteBehavior.Restrict);
            });
            modelBuilder.Entity<Bisagra>(entity =>
            {
                entity.ToTable("BisagraPuerta");

                entity.HasKey(e => e.Id)
                      .HasName("PK_BisagraPuerta");

                entity.Property(e => e.Nombre)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(e => e.Activa)
                        .IsRequired();
            });
            modelBuilder.Entity<ClienteBisagraPuerta>(entity =>
            {
                entity.ToTable("ClienteBisagraPuerta", "dbo");

                entity.HasKey(e => new { e.ClienteId, e.BisagraPuertaId });

                entity.HasOne(e => e.Cliente)
                      .WithMany(c => c.ClienteBisagraPuertas)
                      .HasForeignKey(e => e.ClienteId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.Bisagra)
                      .WithMany(s => s.ClienteBisagraPuertas)
                      .HasForeignKey(e => e.BisagraPuertaId);
            });
            modelBuilder.Entity<ClienteBisagraPuertaSec>(entity =>
            {
                entity.ToTable("ClienteBisagraPuertaSec", "dbo");

                entity.HasKey(e => new { e.ClienteId, e.BisagraPuertaId });

                entity.HasOne(e => e.Cliente)
                      .WithMany(c => c.ClienteBisagraPuertasSec)
                      .HasForeignKey(e => e.ClienteId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.Bisagra)
                      .WithMany(s => s.ClienteBisagraPuertasSec)
                      .HasForeignKey(e => e.BisagraPuertaId);
            });
            modelBuilder.Entity<CerraduraPuertaSec>(entity =>
            {
                entity.ToTable("CerraduraPuertaSec");

                entity.HasKey(e => e.Id)
                      .HasName("PK_CerraduraPuertaSec");

                entity.Property(e => e.Nombre)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(e => e.Activa)
                        .IsRequired();
            });
            modelBuilder.Entity<ClienteCerraduraPuertaSec>(entity =>
            {
                entity.ToTable("ClienteCerraduraPuertaSec", "dbo");

                entity.HasKey(e => new { e.ClienteId, e.CerraduraPuertaSecId });

                entity.HasOne(e => e.Cliente)
                      .WithMany(c => c.ClienteCerradurasPuertaSec)
                      .HasForeignKey(e => e.ClienteId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.CerraduraPuertaSec)
                      .WithMany(s => s.ClienteCerradurasPuertaSec)
                      .HasForeignKey(e => e.CerraduraPuertaSecId);
            });
            modelBuilder.Entity<CerraduraPuerta>(entity =>
            {
                entity.ToTable("CerraduraPuerta");

                entity.HasKey(e => e.Id)
                      .HasName("PK_CerraduraPuerta");

                entity.Property(e => e.Nombre)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(e => e.Activa)
                      .IsRequired();
            });
            modelBuilder.Entity<ClienteCerraduraPuerta>(entity =>
            {
                entity.ToTable("ClienteCerraduraPuerta", "dbo");

                entity.HasKey(e => new { e.ClienteId, e.CerraduraPuertaId });

                entity.HasOne(e => e.Cliente)
                      .WithMany(c => c.ClienteCerradurasPuerta)
                      .HasForeignKey(e => e.ClienteId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.CerraduraPuerta)
                      .WithMany(s => s.ClienteCerradurasPuerta)
                      .HasForeignKey(e => e.CerraduraPuertaId);
            });
            modelBuilder.Entity<ClienteConfiguracionPuerta>(entity =>
            {
                entity.ToTable("ClienteConfiguracionPuerta", "dbo");

                entity.HasKey(e => e.ClienteId);

                entity.HasOne(e => e.Cliente)
                      .WithOne(c => c.ClienteConfiguracionPuerta)
                      .HasForeignKey<ClienteConfiguracionPuerta>(e => e.ClienteId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.Property(e => e.PorteroElectrico)
                    .IsRequired();

                entity.Property(e => e.Cilindro)
                    .IsRequired();

            });
            modelBuilder.Entity<CilindroTipo>(entity =>
            {
                entity.ToTable("CilindroTipo");

                entity.HasKey(e => e.Id)
                      .HasName("PK_CilindroTipo");

                entity.Property(e => e.Nombre)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(e => e.Activa)
                      .IsRequired();
            });
            modelBuilder.Entity<Cilindro>(entity =>
            {
                entity.ToTable("Cilindro");

                entity.HasKey(e => e.Id)
                      .HasName("PK_Cilindro");

                entity.Property(e => e.MedidaInterior)
                        .IsRequired();

                entity.Property(e => e.MedidaExterior)
                        .IsRequired();

                entity.Property(e => e.Nomenclatura)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(e => e.Activa);

                entity.HasOne(e => e.CilindroTipo)
                      .WithMany(p => p.Cilindros)
                      .HasForeignKey(e => e.CilindroTipoId)
                      .HasConstraintName("FK_Cilindro_CilindroTipo");
            });
            modelBuilder.Entity<ClienteCilindro>(entity =>
            {
                entity.ToTable("ClienteCilindro", "dbo");

                entity.HasKey(e => new { e.ClienteId, e.CilindroId });

                entity.HasOne(e => e.Cliente)
                      .WithMany(c => c.ClienteCilindros)
                      .HasForeignKey(e => e.ClienteId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.Cilindro)
                      .WithMany(s => s.ClienteCilindros)
                      .HasForeignKey(e => e.CilindroId);
            });
            modelBuilder.Entity<AgujasCorredera>(entity =>
            {
                entity.ToTable("AgujasCorredera");

                entity.HasKey(e => e.Id)
                      .HasName("PK_AgujasCorredera");

                entity.Property(e => e.Nombre)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(e => e.Activa)
                    .IsRequired();
            });
            modelBuilder.Entity<ClienteAgujasCorredera>(entity =>
            {
                entity.ToTable("ClienteAgujasCorredera", "dbo");

                entity.HasKey(e => new { e.ClienteId, e.AgujaCorrederaId });

                entity.HasOne(e => e.Cliente)
                      .WithMany(c => c.ClienteAgujasCorredera)
                      .HasForeignKey(e => e.ClienteId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.AgujasCorredera)
                      .WithMany(s => s.ClienteAgujasCorredera)
                      .HasForeignKey(e => e.AgujaCorrederaId);
            });
            modelBuilder.Entity<ClienteCilindroCorredera>(entity =>
            {
                entity.ToTable("ClienteCilindroCorredera", "dbo");

                entity.HasKey(e => new { e.ClienteId });

                entity.HasOne(e => e.Cliente)
                      .WithOne(c => c.ClienteCilindrosCorredera)
                      .HasForeignKey<ClienteCilindroCorredera>(e => e.ClienteId)
                      .OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<ClienteConfiguracionElevablePlegable>(entity =>
            {
                entity.ToTable("ClienteConfiguracionElevablePlegable", "dbo");

                entity.HasKey(e => new { e.ClienteId });

                entity.HasOne(e => e.Cliente)
                      .WithOne(c => c.ClienteConfiguracionElevablePlegable)
                      .HasForeignKey<ClienteConfiguracionElevablePlegable>(e => e.ClienteId)
                      .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
