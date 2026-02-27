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
        public DbSet<ClientePerfilTipo> ClientePerfilTipos { get; set; } = null!;
        public DbSet<Software> Softwares { get; set; } = null!;
        public DbSet<ClienteSoftware> ClienteSoftwares { get; set; } = null!;
        public DbSet<Manilla> Manillas { get; set; } = null!;
        public DbSet<ClienteManilla> ClienteManillas { get; set; } = null!;
        public DbSet<SoporteCompas> SoporteCompases{ get; set; } = null!;
        public DbSet<ClienteSoporteCompas> ClienteSoporteCompases { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración de Cliente (Fluent API)
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("Cliente", "dbo");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                      .ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                      .IsRequired();
                entity.Property(e => e.Alias);
                entity.Property(e => e.Comentarios);
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
        }
    }
}
